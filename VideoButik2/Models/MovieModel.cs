using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoButik2.Models
{
    public class MovieModel
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public string Genre { get; set; }

    }
}