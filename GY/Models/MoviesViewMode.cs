using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using Model;

namespace GY.Models
{
    public class MoviesViewMode
    {
        public IEnumerable<Movies> GetNewMovies { get; set; }
        public IEnumerable<Movies> Movies1 { get; set; }
        public IEnumerable<Message> AllMessage { get; set; }
        public IEnumerable<Movies> MoviesTop5 { get; set; }
        public IEnumerable<Movies> Get1MoviesType { get; set; }
        public IEnumerable<Movies> Get2MoviesType { get; set; }
        public IEnumerable<Movies> Get3MoviesType { get; set; }
        public IEnumerable<Movies> Get4MoviesType { get; set; }
        public IEnumerable<MoviesType> GetMoviesTpye { get; set; }
    }
}