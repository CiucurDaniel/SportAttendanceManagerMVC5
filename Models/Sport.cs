﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SportAttendanceManager.Models
{
    public class Sport
    {
        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSport { get; set; }

        [Required]
        public int Hour { get; set; }

        [Required]
        public int Minute { get; set; }

        [Required]
        public string Description { get; set; }

        // add the teacher who has this sport
        public int idUser { get; set; }
        public virtual User User { get; set; }

        // add one to many Students that the sport has
        public List<Student> Students { get; set; }
    }
}