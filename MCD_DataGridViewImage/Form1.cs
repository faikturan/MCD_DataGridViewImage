using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_DataGridViewImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<urun> urunlerim = new List<urun>();
            urunlerim.Add(new urun()
            {
                Id = 1,
                UrunTanim = "Tablet 1",
                ResimYol = @"C:\Users\PC\Desktop\kitapResim\tablet1.jpg"
            });

            urunlerim.Add(new urun()
            {
                Id = 2,
                UrunTanim = "Tablet 2",
                ResimYol = @"C:\Users\PC\Desktop\kitapResim\tablet2.jpg"
            });

            urunlerim.Add(new urun()
            {
                Id = 3,
                UrunTanim = "Tablet 3",
                ResimYol = @"C:\Users\PC\Desktop\kitapResim\tablet3.jpg"
            });

            urunlerim.Add(new urun()
            {
                Id = 4,
                UrunTanim = "Tablet 4",
                ResimYol = string.Empty
            });

            grdUrunler.DataSource = urunlerim;
        }
    }
}
