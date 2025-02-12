﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers.Data.Models
{
    public class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; }

        public decimal HourRate { get; set; }

        public decimal Bouns { get; set; }

        public Department Department { get; set; }

        public ICollection<CourseInstructor> CourseInstructors { get; set; } = new List<CourseInstructor>();
    }
}
