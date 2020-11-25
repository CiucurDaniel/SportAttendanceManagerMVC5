﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SportAttendanceManager.Models
{
    public class User
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idUser { get; set; }

        [Required(ErrorMessage = "Minimum length for name is 3")]
        [StringLength(50, MinimumLength = 3)]

        public string FirstName { get; set; }


        [Required(ErrorMessage = "Minimum length for name is 3")]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }


        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]
        public string Password { get; set; }


        [NotMapped]
        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        public string ConfirmPassword { get; set; }


        //add one to many Sport that the teacher has
        public List<Sport> Sports { get; set; }


        public string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;*/
