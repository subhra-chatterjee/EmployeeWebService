using EmployeeManagementModel;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace EmployeeWebService.Components.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        // List of employees
        protected List<EmployeeInformation> Employees { get; set; }

        protected override void OnInitialized()
        {
            // Initialize employee data (replace with a service call in a real app)
            Employees = new List<EmployeeInformation>
            {
                new EmployeeInformation
                {
                    EmployeeID = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    PhoneNumber = "123-456-7890",
                    Department = "HR",
                    Position = "Manager",
                    Salary = 60000,
                    DateOfJoining = new DateTime(2020, 5, 1),
                    IsActive = true
                },
                new EmployeeInformation
                {
                    EmployeeID = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    PhoneNumber = "987-654-3210",
                    Department = "IT",
                    Position = "Developer",
                    Salary = 80000,
                    DateOfJoining = new DateTime(2021, 6, 15),
                    IsActive = true
                }
            };
        }
    }
}