using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Data.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(50,MinimumLength =10)]
        public string? Name { get; set; }
        [Column(TypeName = "decimal(12,2)")]

        public double Salary { get; set; }
        [Range(20,60)]
        [AllowedValues(18,19,20,21)]
        [DeniedValues(10,15)]

        public int? Age { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Phone]
        public string? PhoneNumber { get; set; }
        [DataType(DataType.Password)]
        public string? Password { get; set; }

    }
}
