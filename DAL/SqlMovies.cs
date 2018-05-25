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
    public class SqlMovies:IMovies
    {

        GYEntities db = DbContextFactory.CreateDbContext();
        public IEnumerable<Movies> GetVideo()
        {
            var videos = db.Movies.ToList();
            return videos;
        }
        public IEnumerable<Movies> Search(string search)
        {
            var videos = db.Movies.Where(c => c.MoviesName.Contains(search)).ToList();
            return videos;
        }
        public IEnumerable<Movies> GetVideoById(int? id)
        {
            var video = from vi in db.Movies
                        where vi.MoviesID == id
                        select vi;
            return video;
        }
        public IEnumerable<Movies> GetVideoByVideoKId(int? id)
        {
            var video = from vi in db.Movies
                        where vi.TypeID == id
                        select vi;
            return video;
        }
        public IQueryable<Message> GetVideoCommentByVideoId(int? id)
        {
            var Message = db.Message.Include("Movies").Where(c => c.MoviesID == id);
            return Message;
        }

        public void RemoveVideo(Movies video)
        {
            //db.Shi.Add(goods);
            db.Movies.Remove(video);
            db.SaveChanges();
        }
        public void AddVideo(Movies video)
        {
            db.Movies.Add(video);
            db.SaveChanges();
        }
        public void EditVideo(Movies video)
        {
            db.Entry(video).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void RemoveRangeVideoComment(IQueryable<Message> VideoComment)
        {
            db.Message.RemoveRange(VideoComment);
        }
        public IEnumerable<Movies> GetNewVideo() //获取最新的视频
        {
            var newvideo = from po in db.Movies
                           orderby po.Time descending
                           select po;
            return newvideo;
        }
        //public IEnumerable<Movies> GetRecommend() //获取推荐的视频
        //{
        //    var recommend = from po in db.Movies
        //                    where po.Video_recommend == 1
        //                    orderby po.AddTime descending
        //                    select po;
        //    return recommend;
        //}
        // public IEnumerable<Movies> GetMovies() 
        //{
        //    var Movies = db.Movies.ToList();
        //    return Movies;
        //}
        //public IEnumerable<Movies> Search(string search)
        //{
        //    var movies = db.Movies.Where(c => c.MoviesName.Contains(search)).ToList();
        //    return movies;
        //}
        //public IEnumerable<Movies> GetMoviesById(int? id)
        //{
        //    var movies = from vi in db.Movies
        //                where vi.MoviesID == id
        //                select vi;
        //    return movies;
        //}
        //public IEnumerable<Movies> GetMoviesIDByMoviesId(int? id)
        //{
        //    var movies = from vi in db.Movies
        //                where vi.MoviesID == id
        //                select vi;
        //    return movies;
        //}
        //public IQueryable<Message> GetMessageByMoviesId(int? id)
        //{
        //    var Message = db.Message.Include("Movies").Where(c => c.MoviesID == id);
        //    return Message;
        //}

        //public void RemoveVideo(Movies movies)
        //{
        //    //db.Shi.Add(goods);
        //    db.Movies.Remove(movies);
        //    db.SaveChanges();
        //}
        //public void AddMovies(Movies movies)
        //{
        //    db.Movies.Add(movies);
        //    db.SaveChanges();
        //}
        //public void EditMovies(Movies movies)
        //{
        //    db.Entry(movies).State = EntityState.Modified;
        //    db.SaveChanges();
        //}

        //public void RemoveRangeMovies(IQueryable<Message> Message)
        //{
        //    db.Message.RemoveRange(Message);
        //}
        //public IEnumerable<Movies> GetNewMovies() //获取最新的视频
        //{
        //    var newmovies = from po in db.Movies
        //                       orderby po.Time descending
        //                       select po;
        //    return newmovies;
        //}
        //public IEnumerable<Movies> GetRemessage() //获取推荐的视频
        //{
        //    var ReMessage = from po in db.Movies
        //                   where po.Video_recommend == 1
        //                   orderby po.Time descending
        //                   select po;
        //    return ReMessage;
        //}
    }
    
}
