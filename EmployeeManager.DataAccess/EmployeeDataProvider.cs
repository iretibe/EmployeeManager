using EmployeeManager.Common.DataProvider;
using EmployeeManager.Common.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EmployeeManager.DataAccess
{
    public class EmployeeDataProvider : IEmployeeDataProvider
    {
        public IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
              {
                new Employee
                {
                    Id = 1,
                    FirstName = "Daniel",
                    EntryDate = new DateTime(2019, 10, 1),
                    IsCoffeeDrinker = true,
                    JobRoleId = 3
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Theophilus",
                    EntryDate = new DateTime(2015, 9, 23),
                    IsCoffeeDrinker = true,
                    JobRoleId = 1
                },
                new Employee
                {
                    Id = 3,
                    FirstName = "Paul",
                    EntryDate = new DateTime(2020, 1, 1),
                    IsCoffeeDrinker = false,
                    JobRoleId = 2
                },
                new Employee
                {
                    Id = 4,
                    FirstName = "Abigail",
                    EntryDate = new DateTime(2013, 5, 15),
                    IsCoffeeDrinker = false,
                    JobRoleId = 4
                },
                new Employee
                {
                    Id = 5,
                    FirstName = "John",
                    EntryDate = new DateTime(2014, 11, 17),
                    IsCoffeeDrinker = true,
                    JobRoleId = 1
                }
              };
        }

        public IEnumerable<JobRole> LoadJobRoles()
        {
            return new List<JobRole>
            {
                new JobRole{ Id = 1, RoleName = "Software developer" },
                new JobRole{ Id = 2, RoleName = "Administrator" },
                new JobRole{ Id = 3, RoleName = "Marketing specialist" },
                new JobRole{ Id = 4, RoleName = "CEO" },
            };
        }

        public void SaveEmployee(Employee employee)
        {
            Debug.WriteLine($"Employee saved: {employee.FirstName}");
        }
    }
}
