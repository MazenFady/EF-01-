using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public int ins_id { get; set; }

        public DateTime HiringDate { get; set; }

}   }
