using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers.Data.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        
        public int Top_ID { get; set; }
        public Topic Topic { get; set; }


        public ICollection<StudCourse> StudCourses { get; set; } = new List<StudCourse>();

        public ICollection<CourseInstructor> CourseInstructors { get; set; } = new List<CourseInstructor>();
    }
}
