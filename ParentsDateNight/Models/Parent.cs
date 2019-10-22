﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParentsDateNight.Models
{
    public class Parent
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Street")]
        public int StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
    }
}