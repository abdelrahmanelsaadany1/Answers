using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers.Data.Models
{
    internal class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public decimal Salary { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        public decimal HourRateBonus { get; set; }
        public int Dept_ID { get; set; }
    }
}
