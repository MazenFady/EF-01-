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

        [ForeignKey(nameof(Manager))]
        public int? ins_id { get; set; }
        public Instructor? Manager { get; set; }

        public DateTime HiringDate { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Instructor> Instructors { get; set; }
    }
}
