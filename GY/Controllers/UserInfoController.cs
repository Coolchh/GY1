using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Protocols;
using BLL;
using Model;

namespace GY.Controllers
{
    public class UserInfoController : Controller
    {
        UserInfoManager userinfomanager = new UserInfoManager();
        //PostManager postManager = new PostManager();
        // GET: UserInfo
        public ActionResult Index()
        {
            return View();
        }
        #region 登录
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public string Login([Bind(Include = "UserName,Password")]string UserName, string Password)
        {
            try
            {
                var users = userinfomanager.Login(UserName, Password);
                if (users != null)
                {
                    //保存到Session HttpContext.
                    Session["UserName"] = UserName;
                    //Session["UserImage"] = userinfomanager.GetUserName(UserName).UserImage;
                    string data = "登录成功";
                    return data;
                }
                else
                {
                    string data = "登录失败";
                    return data;
                }
            }
            catch (Exception ex)
            {
                string data = "错误";
                return data;
            }
        }
        #endregion
        #region 注册
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register([Bind(Include = "UserName,Password,Email")] UserInfo userInfo)
        {
            if (ModelState.IsValid)
            {               
                userinfomanager.AddUserInfo(userInfo);
                return Content("<script>;alert('注册成功!');window.history.go(-2); window.location.reload(); </script>");
            }
            else
            {
                return Content("<script>;alert('注册失败！');history.go(-1)</script>");
            }
        }       
        #endregion
        #region 注销
        [HttpPost]
        public string Zhuxiao()
        {
            //保存到Session HttpContext.
            Session["UserName"] = null;
            string A = "a";
            return A;
        }
        #endregion
    }
}