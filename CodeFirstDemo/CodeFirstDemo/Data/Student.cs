using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstDemo.Data
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255, MinimumLength = 1)]
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }


        public int? ReferenceId { get; set; }
    }
}
