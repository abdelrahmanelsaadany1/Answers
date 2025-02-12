using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers.Data.Models
{
    public class Student
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string FName { get; set; }

        [Required, MaxLength(100)]
        public string LName { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }

        public int Dep_Id { get; set; }
        public Department Department { get; set; }

        public ICollection<StudCourse> StudCourses { get; set; } = new List<StudCourse>();
    }
}
