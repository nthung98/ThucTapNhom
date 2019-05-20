using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ThucTapNhom_XH
{
    public partial class Record : Form
    {
        // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I5PP1IK;Initial Catalog=XepHinhClick;Integrated Security=True ");
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I5PP1IK;Initial Catalog=XepHinhClick;Integrated Security=True");

        private void Load_Sql()
        {

            con.Open();
            string sql = "select * from Diem";
            SqlCommand commandsql = new SqlCommand(sql, con);//Thuc thi cac chuc nang cau lenh trong sql
            SqlDataAdapter com = new SqlDataAdapter(commandsql);//Van chuyen du lieu
            DataTable table = new DataTable();//tao bang ao
            com.Fill(table);//dua du lieu voa bnag
            dataGridView1.DataSource = table;
            con.Close();


        }
        public void Hienthi()
        {
            ////SqlConnection con = new SqlConnection(@"      Data Source = DESKTOP - I5PP1IK; Initial Catalog = XepHinhClick; Integrated Security = True ");
            //con.Open();
            string sqlSelect = "Select * from Diem";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            //con.Close();
        }
        public Record()
        {
            InitializeComponent();
        }

        private void Them_Click(object sender, EventArgs e)
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

        private void Sua_Click(object sender, EventArgs e)
        {
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

        private void Xoa_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Nhan pham cua ban se bi suy giam neu lam tiep qua trinh nay ");
            con.Open();
            string sqlDelete = @"Delete from Diem where MaDiem = @MaDiem";
            SqlCommand cmd = new SqlCommand(sqlDelete, con);
            cmd.Parameters.AddWithValue("MaDiem", txt_MaDiem.Text);

            cmd.ExecuteNonQuery();
            Hienthi();
            con.Close();
        }

        private void Record_Load(object sender, EventArgs e)
        {
            Load_Sql();
        }
    }
    }

