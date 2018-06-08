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
        public IEnumerable<Active> GetTypeActive { get; set; }
    }
}