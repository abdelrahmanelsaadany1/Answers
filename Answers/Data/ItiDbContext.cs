using Answers.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Answers.Data
{
    internal class ItiDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ItiDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfiguration());
            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }
        public DbSet<Course> Employees { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<StudCourse> StudCourses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
