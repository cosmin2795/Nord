using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Nord.Models
{

    public class Cours
    {
        
        public int CoursId { get; set; }
        [Required]
        [Display(Name = "Materia")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Nota")]
        public int Note { get; set; }
        [Required]
        public int StudentId { get; set; }

    }
}