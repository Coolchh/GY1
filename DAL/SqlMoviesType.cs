using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAL;
using System.Data.Entity;

namespace DAL
{
     public  class SqlMoviesType:IMoviesType
    {
         GYEntities db = DbContextFactory.CreateDbContext();
         public IEnumerable<MoviesType> GetMoviesType()
         {
             var moviestype = db.MoviesType.ToList();
             return moviestype;
         }
      
    }
}
