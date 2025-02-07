using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers.Data.Models
{
    internal class CourseInstructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string Evaluate { get; set; }
    }
}
