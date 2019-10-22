using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParentsDateNight.Models
{
    public class Sitters
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name Initial")]
        public string LastNameInitial { get; set; }

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        public string Details { get; set; }
    }
}