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
    public class MoviesManager
    {
        IMovies imovies = DataAccess.CreateMovies();
        public IEnumerable<Movies> GetVideo()
        {
            var videos = imovies.GetVideo();
            return videos;
        }

        public IEnumerable<Movies> Search(string search)
        {
            var videos = imovies.Search(search);
            return videos;
        }
        public IEnumerable<Movies> GetVideoById(int? id)
        {
            var video = imovies.GetVideoById(id);
            return video;
        }
        public IEnumerable<Movies> GetVideoByVideoKId(int? id)
        {
            var video = imovies.GetVideoByVideoKId(id);
            return video;
        }

        public IQueryable<Message> GetVideoCommentByVideoId(int? id)
        {
            var Message = imovies.GetVideoCommentByVideoId(id);
            return Message;
        }

        public void RemoveVideo(Movies shi)
        {
            imovies.RemoveVideo(shi);

        }
        public void AddVideo(Movies shi)
        {
            imovies.AddVideo(shi);

        }
        public void EditVideo(Movies shi)
        {
            imovies.EditVideo(shi);

        }
        public void RemoveRangeVideoComment(IQueryable<Message> Message)
        {
            imovies.RemoveRangeVideoComment(Message);
        }

        public IEnumerable<Movies> GetNewVideo()
        {
            var getnewvideo = imovies.GetNewVideo();
            return getnewvideo;
        }

        //public IEnumerable<Video> GetRecommend()
        //{
        //    var recommend = imovies.GetRecommend();
        //    return recommend;
        //}
        //public IEnumerable<Movies> GetMovies()
        //{
        //    var movies = imovies.GetMovies();
        //    return movies;
        //}

        //public IEnumerable<Movies> Search(string search)
        //{
        //    var movies = imovies.Search(search);
        //    return movies;
        //}
        //public IEnumerable<Movies> GetMoviesById(int? id)
        //{
        //    var movies = imovies.GetMoviesById(id);
        //    return movies;
        //}
        //public IEnumerable<Movies> GetMoviesByMoviesId(int? id)
        //{
        //    var movies = imovies.GetMoviesByMoviesId(id);
        //    return movies;
        //}

        //public IQueryable<Message> GetMessageByMoviesId(int? id)
        //{
        //    var Message = imovies.GetMessageByMoviesId(id);
        //    return Message;
        //}

        //public void RemoveMovies(Movies shi)
        //{
        //    imovies.RemoveMovies(shi);

        //}
        //public void AddMovies(Movies shi)
        //{
        //    imovies.AddMovies(shi);

        //}
        //public void EditMovies(Movies shi)
        //{
        //    imovies.EditMovies(shi);

        //}
        //public void RemoveRangeMessage(IQueryable<Message> Message)
        //{
        //    imovies.RemoveRangeMessage(Message);
        //}

        //public IEnumerable<Movies> GetNewMovies()
        //{
        //    var getnewmovies = imovies.GetNewMovies();
        //    return getnewmovies;
        //}

        //public IEnumerable<Video> GetRecommend()
        //{
        //    var recommend = imovies.GetRecommend();
        //    return recommend;
        //}
    }
}
