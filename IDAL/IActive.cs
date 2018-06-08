using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IActive
    {
        IEnumerable<Active> GetNewActive();
        IEnumerable<Active> GetTypeActive(int id);
        IEnumerable<Active> GetActive();
    }
}
