using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreLIB
{
    public class imageViewer
    {
        public int imageID { set; get; }
        public String imageName { set; get; }

        public Boolean imgSeeker(int ISBN)
        {
            var dbImg = new DALimageViewer();
            imageID = dbImg.getImage(ISBN);
            if (imageID > 0)
            {
                imageName = dbImg.imageName;
                return true;
            }
            else
            {
                imageName = "notAvailable";
                return false;
            }
                
        }
    }
}
