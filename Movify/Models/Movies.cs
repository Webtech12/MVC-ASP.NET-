using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movify.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Release Date")]
        public string ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        public byte NoInStock { get; set; }
        [Display(Name = "Genre")]
        public Genres Genre { get; set; }
        [Required]
        public byte GenresId { get; set; }
    }
}