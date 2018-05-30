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



        IEnumerable<Movies> GetMoviesType(int id);
       
    }
}
