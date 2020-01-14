using System;
using Bilibili.Entities;

namespace Bilibili.DtoParameters
{
    public class EmployeeAddDto
    {

        public string EmployeeNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}