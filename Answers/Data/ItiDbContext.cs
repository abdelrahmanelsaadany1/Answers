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
    public class ItiDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ItiDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
      .HasOne(d => d.Instructor)
      .WithOne(i => i.Department)
      .HasForeignKey<Department>(d => d.Ins_ID);

            // Configure many-to-many relationships
            modelBuilder.Entity<StudCourse>()
                .HasKey(sc => new { sc.Stud_ID, sc.Course_ID });

            modelBuilder.Entity<StudCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudCourses)
                .HasForeignKey(sc => sc.Stud_ID);

            modelBuilder.Entity<StudCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudCourses)
                .HasForeignKey(sc => sc.Course_ID);

            modelBuilder.Entity<CourseInstructor>()
                .HasKey(ci => new { ci.Inst_ID, ci.Course_ID });

            modelBuilder.Entity<CourseInstructor>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.CourseInstructors)
                .HasForeignKey(ci => ci.Inst_ID);

            modelBuilder.Entity<CourseInstructor>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.CourseInstructors)
                .HasForeignKey(ci => ci.Course_ID);

           
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudCourse> StudCourses { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
    }
}
