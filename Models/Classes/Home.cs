﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TripTravel.Models.Classes
{
    public class Home
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
    }
}