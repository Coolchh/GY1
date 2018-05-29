using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAL;
using System.Data.Entity;
using Model;
using IDAL;
using System.Data.Entity;

namespace DAL
{
    public class SqlImages:IImages
    {
        GYEntities db = DbContextFactory.CreateDbContext();
        public IEnumerable<Images>GetImages()
        {
            var getimages = db.Images.ToList();
            return getimages;

        }
    }
}
