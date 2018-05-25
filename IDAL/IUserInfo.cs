using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IUserInfo
    {
        void AddUserInfo(UserInfo userInfo);      
        UserInfo Login(string UserName, string Password);
        UserInfo GetUserName(string UsersName);
        void UpdateUserInfo(UserInfo userInfo);
        IEnumerable<UserInfo> IEGetUserName(string UsersName);
        //IEnumerable<UserInfo> Jifenpaihang10();
        //IEnumerable<UserInfo> Search(string search);
    }
}
