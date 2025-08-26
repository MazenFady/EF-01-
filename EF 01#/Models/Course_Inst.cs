using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_.Models
{
    [PrimaryKey(nameof(inst_ID), nameof(Course_ID))]
    internal class Course_Inst
    {
        
        public int inst_ID { get; set; }
      
        public int Course_ID { get; set; }

        public int evaluate { get; set; }
    }
}
