using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using Model;
using IDAL;

namespace DALFactory
{
    public class DataAccess
    {
        private static string AssemblyName = ConfigurationManager.AppSettings["Path"].ToString();
        private static string db = ConfigurationManager.AppSettings["DB"].ToString();
        public static IUserInfo CreateUserInfo()
        {
            string className = AssemblyName + "." + db + "UserInfo";
            return (IUserInfo)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IMovies CreateMovies()
        {
            string className = AssemblyName + "." + db + "Movies";
            return (IMovies)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IFestive CreateFestive()
        {
            string className = AssemblyName + "." + db + "Festive";
            return (IFestive)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IMessage CreateMessage()
        {
            string className = AssemblyName + "." + db + "Message";
            return (IMessage)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IReMessage CreateReMessage()
        {
            string className = AssemblyName + "." + db + "ReMessage";
            return (IReMessage)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static INews CreateNews()
        {
            string className = AssemblyName + "." + db + "News";
            return (INews)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IAdminInfo CreateAdminInfo()
        {
            string className = AssemblyName + "." + db + "AdminInfo";
            return (IAdminInfo)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static ITheme CreateTheme()
        {
            string className = AssemblyName + "." + db + "Theme";
            return (ITheme)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IReComment CreateReComment()
        {
            string className = AssemblyName + "." + db + "ReComment";
            return (IReComment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IComments CreateComments()
        {
            string className = AssemblyName + "." + db + "Comments";
            return (IComments)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IImages CreateImages()
        {
            string className = AssemblyName + "." + db + "Images";
            return (IImages)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static ICollect CreateCollect()
        {
            string className = AssemblyName + "." + db + "Collect";
            return (ICollect)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IMoviesType CreateMoviesType()
        {
            string className = AssemblyName + "." + db + "MoviesType";
            return (IMoviesType)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IActive CreateActive()
        {
            string className = AssemblyName + "." + db + "Active";
            return (IActive)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
