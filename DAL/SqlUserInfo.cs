using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace DAL
{
     public class SqlUserInfo:IUserInfo
    {
         GYEntities db = DbContextFactory.CreateDbContext();
         public void AddUserInfo(UserInfo userInfo)
         {
             db.UserInfo.Add(userInfo);
             db.SaveChanges();
         }
         public void UpdateUserInfo(UserInfo userInfo)
         {
             db.Entry(userInfo).State = EntityState.Modified;
             db.SaveChanges();
         }
         public UserInfo Login(string UserName, string Password)
         {
             var userInfo = db.UserInfo.Where(u => u.UserName == UserName)
                 .Where(u => u.Password == Password).FirstOrDefault();
             return userInfo;
         }
         public UserInfo GetUserName(string UserName)
         {
             UserInfo userInfo = db.UserInfo.Find(UserName);
             return userInfo;
         }
         public IEnumerable<UserInfo> IEGetUserName(string UserName)
         {
             var userInfo = db.UserInfo.Where(c => c.UserName == UserName);
             return userInfo;
         }
    }
}
