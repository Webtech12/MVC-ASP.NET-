using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movify.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public string DateAdded { get; set; }
        public byte NoInStock { get; set; }
        public Genres Genre { get; set; }
        public byte GenresId { get; set; }
    }
}