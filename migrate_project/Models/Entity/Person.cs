using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace migrate_project.Models.Entity
{ 
    public class Person
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }  
        public string email { get; set; }
    }
}