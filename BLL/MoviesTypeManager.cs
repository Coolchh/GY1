using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAL;
using DALFactory;

namespace BLL
{
      public class MoviesTypeManager
    {
          IMoviesType imoviestype = DataAccess.CreateMoviesType();
          public IEnumerable<MoviesType> GetMoviesType()
          {
              var moviestype = imoviestype.GetMoviesType();
              return moviestype;
          }
    }
}
