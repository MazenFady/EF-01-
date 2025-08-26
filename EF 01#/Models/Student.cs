using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_.Models
{
   
    internal class Student
    {
       
        public int Id { get; set; }

        public string FName { get; set; } = null!;
       
        public string LName { get; set; } = null!;

        public string Address { get; set; } = null!;

        public int Age { get; set; }

        public int Dep_Id { get; set; }
    }
}
