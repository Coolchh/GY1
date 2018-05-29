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
    public class ImagesManager
    {
        IImages iimages = DataAccess.CreateImages();
        public IEnumerable<Images>GetImages()
        {
            var getimages = iimages.GetImages();
            return getimages;
                 
        }
    }
}
