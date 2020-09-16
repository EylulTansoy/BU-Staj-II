using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TripTravel.Models.Classes
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
    }
}