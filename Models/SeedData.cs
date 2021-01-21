using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HRM.Data;
using System;
using System.Linq;

namespace HRM.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HRMContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<HRMContext>>()))
            {
                // Look for any movies.
                if (context.Employee.Any())
                {
                    return;   // DB has been seeded
                }

                context.Employee.AddRange(
                    new Employee
                    {
                        EmployeeID = 1,
                        LastName = "Rio",
                        FirstName = "Ferdinand",
                        Birth_Date = DateTime.Parse("1987-3-13"),
                        Salary = 300M,
                        Department = Department.IT,
                        Position = Position.Officer,
                        Type = Type.FullTime
                    },

                    new Employee
                    {
                        EmployeeID = 2,
                        LastName = "Paul",
                        FirstName = "Scholes",
                        Birth_Date = DateTime.Parse("1986-3-13"),
                        Salary = 400M,
                        Department = Department.SSC,
                        Position = Position.CEO,
                        Type = Type.FullTime
                    },

                    new Employee
                    {
                        EmployeeID = 3,
                        LastName = "Ryan",
                        FirstName = "Giggs",
                        Birth_Date = DateTime.Parse("1982-3-13"),
                        Salary = 400M,
                        Department = Department.MKT,
                        Position = Position.Manager,
                        Type = Type.PartTime
                    },

                    new Employee
                    {
                        EmployeeID = 4,
                        LastName = "Wayne",
                        FirstName = "Rooney",
                        Birth_Date = DateTime.Parse("1986-3-13"),
                        Salary = 400M,
                        Department = Department.MKT,
                        Position = Position.CEO,
                        Type = Type.PartTime
                    },

                    new Employee
                    {
                        EmployeeID = 5,
                        LastName = "Cristiano",
                        FirstName = "Ronaldo",
                        Birth_Date = DateTime.Parse("1986-3-13"),
                        Salary = 500M,
                        Department = Department.IT,
                        Position = Position.Director,
                        Type = Type.FullTime
                    }
                );
                context.SaveChanges();
            }
        }
    }
}