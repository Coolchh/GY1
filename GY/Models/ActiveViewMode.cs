using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;

namespace GY.Models
{
    public class ActiveViewMode
    {
        public IEnumerable<Active> GetNewActive { get; set; }
        public IEnumerable<Active> GetActive { get; set; }
        public IEnumerable<Active> GetTypeActive1 { get; set; }
        public IEnumerable<Active> GetTypeActive2 { get; set; }
        public IEnumerable<Active> GetTypeActive3 { get; set; }
        

    }
}