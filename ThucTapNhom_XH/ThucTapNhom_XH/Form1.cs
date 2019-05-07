using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom_XH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CatAnh(Image image, Image[] images, int index, int numRow, int numCol, int x, int y)
        {
            images[index] = new Bitmap(x, y);
            Graphics objGraphics = Graphics.FromImage(images[index]);
            // objGraphics = Graphics.FromImage(images[index]);
            objGraphics.Clear(Color.White);
            objGraphics.DrawImage(image, new Rectangle(0, 0, x, y),
                                        new Rectangle(x * (index % numCol), y * (index / numCol), x, y),
                                        GraphicsUnit.Pixel);

            objGraphics.Flush();
        }
        private void buttonImageBrowse_Click(object sender, EventArgs e)
        {

        }

        private void level1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
