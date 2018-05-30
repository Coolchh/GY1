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
        public IEnumerable<Movies> GetMoviesType(int id)
        {
            var moviestype1 = imovies.GetMoviesType(id);
            return moviestype1;
        }
      
    }
}
