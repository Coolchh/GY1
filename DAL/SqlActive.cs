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
    public class SqlActive:IActive
    {
        GYEntities db = DbContextFactory.CreateDbContext();
        public IEnumerable<Active> GetActive()
        {
            var active = db.Active.ToList();
            return active;
        }
        public IEnumerable<Active> GetNewActive()
        {
            var newactive = from po in db.Active
                            orderby po.ActiveTime descending
                            select po;
            return newactive;
        }
        public IEnumerable<Active> GetTypeActive(int id)
        {
            var activetype = from po in db.Active
                             where po.FestiveID == id
                             select po;
            return activetype;
        }
    }
}
