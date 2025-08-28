using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_.Models
{
    internal class Instructor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [Column(TypeName = "VarChar(20)")]
        public string Name { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Bouns { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Salary { get; set; }
        [Required]
        [MaxLength(100)]
        [Column(TypeName = "NVarChar(100)")]
        public string Address { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal HourRate { get; set; }

        [ForeignKey(nameof(Department))]
        public int? DepID { get; set; }
        public Department? Department { get; set; }

        public ICollection<Course_Inst> course_Insts { get; set; }
        public ICollection<Department> ManagedDepartments { get; set; }

    }
}
