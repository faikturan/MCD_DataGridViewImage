using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_DataGridViewImage
{
    public class urun
    {
        public int Id { get; set; }
        public string UrunTanim { get; set; }
        public string ResimYol { get; set; }
        public Image UrunResim
        {
            get
            {
                if (!string.IsNullOrEmpty(ResimYol))
                    return Image.FromFile(ResimYol);
                else
                    return Image.FromFile(@"C:\Users\PC\Desktop\kitapResim\noImage.jpg");
            }
        }
    }
}
