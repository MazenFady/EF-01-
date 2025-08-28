using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_.Models
{
   
    internal class Student
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        [Required]
        [Column(TypeName = "VarChar(20)")]
        public string FName { get; set; }

        [MaxLength(20)]
        [Required]
        [Column(TypeName = "VarChar(20)")]
        public string LName { get; set; }
        
        [MaxLength(100)]
        [Column(TypeName = "NVarChar(100)")]
        [Required]
        public string Address { get; set; } 

        public int? Age { get; set; }

        [ForeignKey(nameof(Department))]
        public int? DepId { get; set; }
        public Department? Department { get; set; }
        public ICollection<Stud_Course> Stud_Courses { get; set; }

     
    }
}
