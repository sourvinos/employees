using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Employees.Models;
using Microsoft.AspNetCore.Components;

namespace Employees.Web.Pages {

    public class EmployeeListBase : ComponentBase {

        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync() {
            await Task.Run(LoadEmployees);
        }

        public void LoadEmployees() {

            System.Threading.Thread.Sleep(3000);

            Employee e1 = new Employee {
                EmployeeId = 1,
                LastName = "Doe",
                FirstName = "John",
                Email = "john@gmail.com",
                DoB = new DateTime(1980, 01, 01),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Payroll" },
                PhotoPath = "images/john.svg"
            };
            Employee e2 = new Employee {
                EmployeeId = 2,
                LastName = "Brown",
                FirstName = "Sara",
                Email = "sara@hotmail.com",
                DoB = new DateTime(1970, 11, 01),
                Gender = Gender.Female,
                Department = new Department { DepartmentId = 1, DepartmentName = "HR" },
                PhotoPath = "images/sara.svg"
            };
            Employee e3 = new Employee {
                EmployeeId = 3,
                LastName = "White",
                FirstName = "Mike",
                Email = "mike@hotmail.com",
                DoB = new DateTime(1971, 05, 12),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/mike.svg"
            };
            Employee e4 = new Employee {
                EmployeeId = 4,
                LastName = "Red",
                FirstName = "Jane",
                Email = "jane@gmail.com",
                DoB = new DateTime(1975, 11, 10),
                Gender = Gender.Female,
                Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/jane.svg"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };

        }

    }

}