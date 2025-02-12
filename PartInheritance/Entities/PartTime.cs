using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartInheritance.Entities
{
    internal class PartTime : Employee
    {
        public int CountOfHours { get; set; } 
        public int HourRate { get; set; }
    }
}
