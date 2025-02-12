using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers.Data.Models
{
    public class CourseInstructor
    {
        public int Inst_ID { get; set; }
        public Instructor Instructor { get; set; }

        public int Course_ID { get; set; }
        public Course Course { get; set; }

        public string Evaluate { get; set; }
    }
}
