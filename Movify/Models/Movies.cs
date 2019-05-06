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
        [Required(ErrorMessage = "Name Required")]
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name = "Release Date")]
        public string ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        [Range(1,20,ErrorMessage = "No should be from 1-20")]
        public byte NoInStock { get; set; }
        [Display(Name = "Genre")]
        public Genres Genre { get; set; }
        [Required]
        public byte GenresId { get; set; }
    }
}