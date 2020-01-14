using System.Collections.Generic;
using Bilibili.DtoParameters;

namespace Bilibili.Models
{
    public class CompanyAddDto
    {
        public string Name { get; set; }
        public string Introduction { get; set; }
        public ICollection<EmployeeAddDto> Employees { get; set; } = new List<EmployeeAddDto>();
    }
}