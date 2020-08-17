using Microsoft.AspNetCore.Mvc.Rendering;
using MVCMovie.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Category> Categories { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
    }
}