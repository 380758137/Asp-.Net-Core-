using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bilibili.Entities;
using Bilibili.Helpers;
using Bilibili.Models;
using Bilibili.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bilibili.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyCollectionsController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyCollectionsController(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository ?? throw new ArgumentNullException(nameof(companyRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("({ids})", Name = nameof(GetCompanyCollection))]
        public async Task<IActionResult> GetCompanyCollection(
            [ModelBinder(BinderType=typeof(ArrayModelBinder))]
            [FromRoute]
            IEnumerable<Guid> ids)
        {
            if (ids == null)
            {
                return BadRequest();
            }
            var entities = await _companyRepository.GetCompaniesAsync(ids);
            if (ids.Count() != entities.Count())
            {
                return NotFound();
            }
            var dtoToReturn = _mapper.Map<IEnumerable<CompanyDto>>(entities);
            return Ok(dtoToReturn);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<CompanyDto>>> CreateCompanyCollections(IEnumerable<CompanyAddDto> companyCollection)
        {
            var companyEntities = _mapper.Map<IEnumerable<Company>>(companyCollection);
            foreach (var company in companyEntities)
            {
                _companyRepository.AddCompany(company);
            }
            await _companyRepository.SaveAsync();
            var dtosToReturn = _mapper.Map<IEnumerable<CompanyDto>>(companyEntities);
            var idsStr = string.Join(",", dtosToReturn.Select(x => x.Id));
            return CreatedAtRoute(nameof(GetCompanyCollection), new { ids = idsStr }, dtosToReturn);
        }
    }
}