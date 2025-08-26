using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_.Models
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
       
        public string Name { get; set; } = null!;

        public int ins_id { get; set; }
        
        public DateTime HiringDate { get; set; }

}   }
