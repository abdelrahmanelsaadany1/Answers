using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers.Data.Models
{
    internal class StudCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Stud_ID { get; set; }
        public int Course_ID { get; set; }
        public decimal Grade { get; set; }
    }
}
