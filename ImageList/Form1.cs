using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageList
{
    public partial class Form1 : Form
    {
        public int indice = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (indice == ImgLFotos.Images.Count)
            {
                indice = 0;
            }

            lblIMAGENES.ImageIndex = indice;
            indice++;
        }

        private void addImageList(object sender, EventArgs e)
        {

            ImgLFotos.ColorDepth = ColorDepth.Depth32Bit;
            ImgLFotos.ImageSize = new Size(255, 255);

            ImgLFotos.Images.Add(Image.FromFile(@"C:\2Q==-2.jpg"));
            ImgLFotos.Images.Add(Image.FromFile(@"C:\2Q==-3.jpg"));

        }

        private void deleteImage(object sender, EventArgs e)
        {

            ImgLFotos.Images.RemoveAt(indice-1);
            lblIMAGENES.ImageIndex = 1;
            indice = 1;
        }       
    }
}
