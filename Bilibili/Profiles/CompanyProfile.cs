using AutoMapper;
using Bilibili.Entities;
using Bilibili.Models;

namespace Bilibili.Profiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDto>().ForMember(
                dest => dest.CompanyName,
                opt => opt.MapFrom(src => src.Name)
            );
            CreateMap<CompanyAddDto, Company>();
        }
    }
}