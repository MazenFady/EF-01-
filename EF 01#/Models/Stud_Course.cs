using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_.Models
{
    [PrimaryKey(nameof(stud_ID), nameof(Course_ID))]
    internal class Stud_Course
    {
        
        public int stud_ID { get; set; }
   
        public  int Course_ID { get; set; }

        public Student? student { get; set; }

        public Course? course { get; set; }

        public int Grade { get; set; } 
    }
}
