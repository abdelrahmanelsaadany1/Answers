using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Data.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string Name { get; set; }
        public DateOnly CreationDate { get; set; }
        [InverseProperty(nameof(Models.Employee.Department))]
      public ICollection<Employee> Employees { get; set; }=new HashSet<Employee>();
        #region Manage
        [ForeignKey("Manager")]
        public int? ManagerId { get; set; }
        [InverseProperty(nameof(Models.Employee.ManageDepartment))]
        
        public Employee Manager { get; set; }=null!;
        #endregion

    }
}
