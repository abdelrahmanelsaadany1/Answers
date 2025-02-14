using PartInheritance.Contexts;
using PartInheritance.Entities;

namespace PartInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session3
            //using RouteDbContext context = new RouteDbContext();
            //FullTimeEmployee employee = new FullTimeEmployee();
            //{
            //    employee.Name = "John";
            //    employee.Age = 30;
            //    employee.Address = "1234 Main St";
            //    employee.Salary = 50000;
            //    employee.StartDate = new System.DateTime(2010, 1, 1);
            //}
            //PartTime partTime = new PartTime();
            //{
            //    partTime.Name = "Jason";
            //    partTime.Age = 25;
            //    partTime.Address = "1234 Main St";
            //    partTime.CountOfHours = 40;
            //    partTime.HourRate = 30;

            //}
            //context.FullTimeEmployees.Add(employee);
            //context.PartTimes.Add(partTime);
            //context.SaveChanges();
            //var FullTimeEmployees = from e in context.FullTimeEmployees
            //                        select e;
            //var PartTimeEmployee = from e in context.PartTimes
            //                       select e;
            //foreach (var e in FullTimeEmployees)
            //{
            //    System.Console.WriteLine($"Employee Name: {e.Name}, Age: {e.Age}, Address: {e.Address}, Salary: {e.Salary}, Start Date: {e.StartDate}");
            //}
            //foreach (var e in PartTimeEmployee)
            //{
            //    System.Console.WriteLine($"Employee Name: {e.Name}, Age: {e.Age}, Address: {e.Address}, Count of Hours: {e.CountOfHours}, Hour Rate: {e.HourRate}");
            //}
            #endregion
            #region Session4
            //using RouteDbContext context = new RouteDbContext();
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Name = "John",
            //    Age = 30,
            //    Address = "1234 Main St",
            //    Salary = 50000,
            //    StartDate = new System.DateTime(2010, 1, 1)
            //};

            //PartTime partTime = new PartTime()
            //{
            //    Name = "Jason",
            //    Age = 25,
            //    Address = "1234 Main St",
            //    CountOfHours = 40,
            //    HourRate = 30
            //};
            ////context.Add(fullTimeEmployee);
            ////context.Add(partTime);
            //context.SaveChanges();
            //var Employee = from e in context.Employees
            //                        select e;
            //foreach (var e in Employee.OfType<FullTimeEmployee>())
            //{
            //    System.Console.WriteLine($"Employee Name: {e.Name}, Age: {e.Age}, Address: {e.Address}");
            //}

            //var PartTimeEmployee = from e in context.Employees
            //                       select e;
            //foreach (var e in PartTimeEmployee.OfType<PartTime>())
            //{
            //    System.Console.WriteLine($"Employee Name: {e.Name}, Age: {e.Age}, Address: {e.Address}");
            //}

            #endregion
           

        }
    }
}
