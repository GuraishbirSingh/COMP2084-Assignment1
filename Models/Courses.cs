using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment1.Models
{
    public partial class Courses
    {
        public Courses()
        {
            Students = new HashSet<Students>();
        }

        [Key]
        public int CourseId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string DelieveryMode { get; set; }
        [Required]
        [StringLength(50)]
        public string Coordinator { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Fees { get; set; }

        [InverseProperty("Course")]
        public virtual ICollection<Students> Students { get; set; }
    }
}
