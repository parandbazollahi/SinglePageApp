using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SinglePageApp.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Family { get; set; }

        [Required]
        public int Age { get; set; }
    }
}