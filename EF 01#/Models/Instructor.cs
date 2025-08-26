using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }

        public string Address { get; set; } = null!;
        
        public decimal HourRate { get; set; }

        public int Dept_ID { get; set; }
    }
}
