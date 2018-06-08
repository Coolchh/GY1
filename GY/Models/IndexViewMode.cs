using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using Model;

namespace GY.Models
{
    public class IndexViewMode
    {
        public IEnumerable<Movies> Moviestop9 { get; set; }
        public IEnumerable<News> Newstop6 { get; set; }
        public IEnumerable<Active> Active5 { get; set; }
        public IEnumerable<Movies> GetNewMovies { get; set; }
        public IEnumerable<Images> GetImages { get; set; }

        public IEnumerable<Active> GetActive { get; set; }
    }
}