﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace seminarska.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Id { get; set; }
        [Display(Name = "Priimek in ime")]
        [Required(ErrorMessage = "Ime je obvezen podatek")]
        public string Ime { get; set; }
        [Range(5, 50)]
        public int Starost { get; set; }

    }
}