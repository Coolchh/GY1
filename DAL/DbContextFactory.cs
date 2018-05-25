using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class DbContextFactory
    {
        public static GYEntities CreateDbContext()
        {
            GYEntities dbContext = (GYEntities)CallContext.GetData("dbContext");
            if (dbContext == null)
            {
                dbContext = new GYEntities();
                CallContext.SetData("dbContext", dbContext);
            }
            return dbContext;
        }

    }
}
