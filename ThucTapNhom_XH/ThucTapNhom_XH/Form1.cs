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
        public void xephinhClick(object sender, EventArgs e)
        {
            ((MyPB)sender).BorderStyle = BorderStyle.FixedSingle;
            if (firstBox == null)
            {
                firstBox = (MyPB)sender;
                firstBox.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (secondBox == null)
            {
                secondBox = (MyPB)sender;
                firstBox.BorderStyle = BorderStyle.Fixed3D;
                secondBox.BorderStyle = BorderStyle.FixedSingle;
                Switch(firstBox, secondBox);
                firstBox = null;
                secondBox = null;
            }
            if (isTrue())
            {
                timer1.Stop();
                MessageBox.Show("Hoan thanh ");
                Record f2 = new Record();
                f2.Show();
            }
        }
        OpenFileDialog openFileDialog = null;
        Image image;
        PictureBox pbWhole = null;
        private void buttonImageBrowse_Click(object sender, EventArgs e)
        {

            if (openFileDialog == null)
            {
                openFileDialog = new OpenFileDialog();
            }
            openFileDialog.Filter = "Image|*.png; *.jpg; *.jpeg; *.psd";    //Gioigan dinh dang
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = CreateBitmapImage(Image.FromFile(openFileDialog.FileName));
                if (pbWhole == null)
                {
                    pbWhole = new PictureBox();
                    pbWhole.Height = pbPuzzle.Height;
                    pbWhole.Width = pbPuzzle.Width;
                    pbPuzzle.Controls.Add(pbWhole);
                }
                pbWhole.Image = image;
                pbMain.Image = image;

            }


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
