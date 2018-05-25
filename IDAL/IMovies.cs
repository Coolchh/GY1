using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IMovies
    {
        IEnumerable<Movies> GetVideo();
        IEnumerable<Movies> GetVideoById(int? id);
        IQueryable<Message> GetVideoCommentByVideoId(int? id);
        void RemoveVideo(Movies video);
        void AddVideo(Movies video);
        void EditVideo(Movies video);
        void RemoveRangeVideoComment(IQueryable<Message> Message);
        IEnumerable<Movies> GetNewVideo();
        //IEnumerable<Movies> GetRecommend();
        IEnumerable<Movies> GetVideoByVideoKId(int? id);
        IEnumerable<Movies> Search(string search);
        //IEnumerable<Movies> GetMovies();
        //IEnumerable<Movies> GetMoviesById(int? id);
        //IQueryable<Movies> GetMessageByMoviesId(int? id);
        //void RemoveMovies(Movies movies);
        //void AddMovies(Movies movies);
        //void EditMovies(Movies movies);
        //void RemoveRangeMessage(IQueryable<Message> Message);
        //IEnumerable<Movies> GetNewMovies();
        ////IEnumerable<Movies> GetRecommend();
        //IEnumerable<Movies> GetMoviesByMoviesId(int? id);
        //IEnumerable<Movies> Search(string search);
    }
}
