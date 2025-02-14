using demo.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace demo.Data.DataSeeding
{
    public class CompanyDbContextSeed
    {
        
        
        #region Department
        
        public static void Seed(CompanyDbContext dbContext) {
            if (!dbContext.Departments.Any())
            {
                var DepartmentsData = File.ReadAllText("C:\\Users\\aelsa\\source\\repos\\ranaHatem\\assignments\\assignment18\\demo\\Data\\DataSeeding\\departments.json");
                var Departments = JsonSerializer.Deserialize<List<Department>>(DepartmentsData);
                if (Departments?.Count > 0)
                {
                    foreach (var Department in Departments)
                    {
                        dbContext.Departments.Add(Department);

                    }
                    dbContext.SaveChanges();

                }
            }





        }

        #endregion
        #region Employee
        public static void SeedEmployee(CompanyDbContext dbContext)
        {
            if (!dbContext.Departments.Any())
            {
                var EmployeesData = File.ReadAllText("C:\\Users\\aelsa\\source\\repos\\ranaHatem\\assignments\\assignment18\\demo\\Data\\DataSeeding\\employees.json");
                var Employees = JsonSerializer.Deserialize<List<Employee>>(EmployeesData);
                if (Employees?.Count > 0)
                {
                    foreach (var employee in Employees)
                    {
                        dbContext.Employees.Add(employee);

                    }
                    dbContext.SaveChanges();

                }
            }

        }

        #endregion

      
    }
    
}
