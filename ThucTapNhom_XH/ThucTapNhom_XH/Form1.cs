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
        private void TronAnh(ref int[] arr)
        {
            Random rng = new Random();
            int n = arr.Length;
            while (n > 1)
            {
                int k = rng.Next(n);
                n--;
                int temp = arr[n];
                arr[n] = arr[k];
                arr[k] = temp;
            }
        }
        MyPB firstBox = null;
        MyPB secondBox = null;
        private void Switch(MyPB box1, MyPB box2)
        {
            int tmp = box2.ImageIndex;
            box2.Image = images[box1.ImageIndex];
            box2.ImageIndex = box1.ImageIndex;
            box1.Image = images[tmp];
            box1.ImageIndex = tmp;
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
