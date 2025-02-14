using demo.Data;
using demo.Data.DataSeeding;
using Microsoft.EntityFrameworkCore;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext companyDbContext = new CompanyDbContext();
            CompanyDbContextSeed.Seed(companyDbContext);
            #region Navigational Properties
            //var Employee = from e in companyDbContext.Employees
            //               where e.Code == 1
            //               select e;
            //foreach (var e in Employee)
            //{
            //    Console.WriteLine($"Employee Name: {e.Name}, Age: {e.Age}, Department: {e.Department.Name}");
            //}

            //var department = from d in companyDbContext.Departments
            //                 where d.DeptId == 1
            //                 select d;


            #endregion

            #region Explicit
            //var Employee = from e in companyDbContext.Employees
            //               where e.Code == 1
            //               select e;
            //if (Employee is not null)
            //{
            //    foreach (var e in Employee)
            //    {
            //        companyDbContext.Entry(e).Reference(x => x.Department).Load();
            //        Console.WriteLine($"Employee Name: {e.Name}, Age: {e.Age}, Department: {e.Department.Name}");
            //    }


            //}

            #endregion
            #region Inner Join

            //var Employee = from e in companyDbContext.Employees
            //               join d in companyDbContext.Departments
            //               on e.DepartmentDeptId equals d.DeptId
            //               select new
            //               {
            //                   e.Name,
            //                   e.Age,
            //                   DepartmentName = d.Name
            //               };

            //foreach (var e in Employee)

            //{
            //    Console.WriteLine($"Employee Name: {e.Name}, Age: {e.Age}, Department: {e.DepartmentName}");
            //}




            #endregion
            #region Left Outer Join


            //var Employee = from e in companyDbContext.Employees
            //               join d in companyDbContext.Departments
            //               on e.DepartmentDeptId equals d.DeptId into empDept
            //               from ed in empDept.DefaultIfEmpty()
            //               select new
            //               {
            //                   e.Name,
            //                   e.Age,
            //                   DepartmentName = ed.Name
            //               };

            //foreach (var e in Employee)

            //{
            //    Console.WriteLine($"Employee Name: {e.Name}, Age: {e.Age}, Department: {e.DepartmentName}");
            //}

            #endregion
            #region Cross Join

            //var Employee = from e in companyDbContext.Employees
            //               from d in companyDbContext.Departments
            //               select new
            //               {
            //                   e.Name,
            //                   e.Age,
            //                   DepartmentName = d.Name
            //               };

            //foreach (var e in Employee)

            //{
            //    Console.WriteLine($"Employee Name: {e.Name}, Age: {e.Age}, Department: {e.DepartmentName}");
            //}




            #endregion

        }
    }
}
