using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_.Models
{
    internal class Course_Inst
    {
        [Key]
        public int inst_ID { get; set; }
        [Key]
        public int Course_ID { get; set; }

        public int evaluate { get; set; }
    }
}
