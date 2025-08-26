using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_.Models
{
    internal class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Required]
        public int Duration { get; set; }
        [MaxLength(20)]
        [Required]
        [Column(TypeName = "VarChar(20)")]
        public string Name { get; set; } 
        [MaxLength(100)]
        [Column(TypeName = "NVarChar(100)")]

        public string Description { get; set; }
        
        public int Top_ID { get; set; }
    }
}
