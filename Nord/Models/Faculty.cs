using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Nord.Models
{
   
    public class Faculty
    {
       
        public int FacultyId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int DateOfCreation { get; set; }
    }
}