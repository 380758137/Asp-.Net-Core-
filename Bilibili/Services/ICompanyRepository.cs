using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bilibili.DtoParameters;
using Bilibili.Entities;

namespace Bilibili.Services
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync(Guid companyId, string genderDisplay,string q);
        Task<Employee> GetEmployeeAsync(Guid companyId, Guid employeeId);
        void AddEmployee(Guid companyId, Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        Task<IEnumerable<Company>> GetCompaniesAsync(CompanyDtoParameters parameters);
        Task<Company> GetCompanyAsync(Guid companyId);
        Task<IEnumerable<Company>> GetCompaniesAsync(IEnumerable<Guid> companyIds);
        void AddCompany(Company company);
        void DeleteCompany(Company company);
        void UpdateCompany(Company company);
        Task<bool> CompanyExistsAsync(Guid companyId);
        Task<bool> SaveAsync();
    }
}