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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I5PP1IK;Initial Catalog=XepHinhClick;Integrated Security=True ");
            //TimeSpan time = TimeSpan.Parse(txt_ThoiGian.Text);

            string sqlInsert = @"INSERT INTO Diem (MaDiem, ThoiGian, Level, MaNC) VALUES        (@MaDiem,@ThoiGian,@Level,@MaNC)";
            SqlCommand cmd = new SqlCommand(sqlInsert, con);
            cmd.Parameters.AddWithValue("MaDiem", txt_MaDiem.Text);
            cmd.Parameters.AddWithValue("Thoigian", txt_ThoiGian.Text);
            cmd.Parameters.AddWithValue("Level", txt_Level.Text);
            cmd.Parameters.AddWithValue("MaNC", txt_MaNC.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            Hienthi();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I5PP1IK;Initial Catalog=XepHinhClick;Integrated Security=True ");

            MessageBox.Show("Nhan pham cua ban se bi suy giam neu lam tiep qua trinh nay ");

            con.Open();
            string sqlEdit = @"Update Diem Set ThoiGian= @ThoiGian,Level =@Level,MaNC = @MaNC where MaDiem = @MaDiem";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("MaDiem", txt_MaDiem.Text);
            cmd.Parameters.AddWithValue("Thoigian", txt_ThoiGian.Text);
            cmd.Parameters.AddWithValue("Level", txt_Level.Text);
            cmd.Parameters.AddWithValue("MaNC", txt_MaNC.Text);


            cmd.ExecuteNonQuery();
            Hienthi();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I5PP1IK;Initial Catalog=XepHinhClick;Integrated Security=True ");

            MessageBox.Show("Nhan pham cua ban se bi suy giam neu lam tiep qua trinh nay ");
            con.Open();
            string sqlDelete = @"Delete from Diem where MaDiem = @MaDiem";
            SqlCommand cmd = new SqlCommand(sqlDelete, con);
            cmd.Parameters.AddWithValue("MaDiem", txt_MaDiem.Text);

            cmd.ExecuteNonQuery();
            Hienthi();
            con.Close();
        }
    }
}
