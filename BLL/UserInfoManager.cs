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
    public class UserInfoManager
    {
        IUserInfo iuserinfo = DataAccess.CreateUserInfo();
        public void AddUserInfo(UserInfo userInfo)
        {
            iuserinfo.AddUserInfo(userInfo);
        }
        //public IEnumerable<UserInfo> Search(string search)
        //{
        //    var userInfo = iuserinfo.Search(search);
        //    return userInfo;
        //}
        public IEnumerable<UserInfo> IEGetUserName(string UserName)
        {
            var userInfo = iuserinfo.IEGetUserName(UserName);
            return userInfo;
        }
        public UserInfo Login(string UserName, string Password)
        {
            var userInfo = iuserinfo.Login(UserName, Password);
            return userInfo;
        }

        public UserInfo GetUserName(string UserName)
        {
            var userInfo = iuserinfo.GetUserName(UserName);
            return userInfo;
        }

    }
}
