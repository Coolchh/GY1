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
    public class ActiveManager
    {
        IActive iactive = DataAccess.CreateActive();
        public IEnumerable<Active> GetActive()
        {
            var active = iactive.GetActive();
            return active;
        }
        public IEnumerable<Active> GetNewActive()
        {
            var newactive = iactive.GetNewActive();
            return newactive;
        }
        public IEnumerable<Active> GetTypeActive(int id)
        {
            var activetype= iactive.GetTypeActive(id);
            return activetype;
        }
    }
}
