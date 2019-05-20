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

        private int time;

        private bool Trangthai = true;
        private int currentLevel = 0;

        //PictureBox[] picBoxes = null;
        //    Image[] images =null;
        PictureBox[] picBoxes = new PictureBox[100];
        Image[] images = new Image[100];
        private const int Level1_number = 9;
        private const int Level2_number = 16;
        private const int Level3_number = 25;



        private void CatAnh(Image image, Image[] images, int index, int numRow, int numCol, int x, int y)
        {
            images[index] = new Bitmap(x, y);
            Graphics objGraphics = Graphics.FromImage(images[index]);
            objGraphics = Graphics.FromImage(images[index]);
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
                MessageBox.Show("Hoan thanh ");
            }
        }

        OpenFileDialog openFileDialog = null;
        Image image;
        PictureBox pbWhole = null;
        private void buttonImageBrowse_Click_1(object sender, EventArgs e)
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
        private Bitmap CreateBitmapImage(Image image)
        {
            Bitmap objImage = new Bitmap(pbPuzzle.Width, pbPuzzle.Height);
            Graphics objGraphics = Graphics.FromImage(objImage);
            objGraphics.Clear(Color.White);
            objGraphics.DrawImage(image, new Rectangle(0, 0, pbPuzzle.Width, pbPuzzle.Height));
            objGraphics.Flush();
            return objImage;
        }


    
        private void Startgame()
        {
            if (pbWhole != null)
            {
                pbPuzzle.Controls.Remove(pbWhole);
                pbWhole.Dispose();
                pbWhole = null;
            }


            if (picBoxes == null)
            {
                picBoxes = new PictureBox[currentLevel];
                images = new Image[currentLevel];

            }

            int numRow = (int)Math.Sqrt(currentLevel);
            int numCol = numRow;
            int x = pbPuzzle.Width / numRow;
            int y = pbPuzzle.Height / numCol;
            int[] indice = new int[currentLevel];

            for (int i = 0; i < currentLevel; i++)
            {
                indice[i] = i;
                if (picBoxes[i] == null)
                {
                    picBoxes[i] = new MyPB();
                    picBoxes[i].Click += new EventHandler(xephinhClick);

                    picBoxes[i].BorderStyle = BorderStyle.Fixed3D;
                }
                picBoxes[i].Width = x;
                picBoxes[i].Height = y;

                ((MyPB)picBoxes[i]).Index = i;


                CatAnh(image, images, i, numRow, numCol, x, y);
                picBoxes[i].Location = new Point(x * (i % numCol), y * (i / numCol));

                if (!pbPuzzle.Controls.Contains(picBoxes[i]))
                {
                    pbPuzzle.Controls.Add(picBoxes[i]);

                }
            }
            TronAnh(ref indice);

            for (int i = 0; i < currentLevel; i++)
            {
                picBoxes[i].Image = images[indice[i]];
                ((MyPB)picBoxes[i]).ImageIndex = indice[i];
            }


        }
        private bool isTrue()
        {
            for (int i = 0; i < currentLevel; i++)
            {
                if (((MyPB)picBoxes[i]).ImageIndex != ((MyPB)picBoxes[i]).Index)

                    return false;
            }
            return true;

        }
        private void level1_Click(object sender, EventArgs e)
        {
            // time = 0;

            currentLevel = Level1_number;
            time = 120;
            Startgame();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //time = 0;

            currentLevel = Level2_number;
            time = 180;
            Startgame();
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  time = 0;
            time = 300;
            currentLevel = Level3_number;

            Startgame();
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Record f2 = new Record();
            f2.Show();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Trangthai == true)
            {
                timer1.Stop();
                Trangthai = false;
                button1.Text = "Play";
            }
            else
            {
                Trangthai = true;
                timer1.Start();

                button1.Text = "Pause";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            lbTime.Text = (time / 60).ToString() + " m : " + (time % 60).ToString() + " s";
            time--;
            if (time == 0)
            {
                timer1.Stop();
                MessageBox.Show("Het thoi gian ");

                Record r1 = new Record();
                r1.Show();
            }
        }
    }
}
