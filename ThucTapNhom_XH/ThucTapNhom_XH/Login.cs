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
    public partial class Login : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if ( txt_password.Text.ToString().Equals("") || txx_username.Text.ToString().Equals(""))
            {
                MessageBox.Show("Nhập đầy đủ thông tin đăng nhập", "Thông báo!!!");
            }
            else
            {
                var login = db.TaiKhoans.Select(a => a).Where(s => s.Username == txx_username.Text && s.Password == txt_password.Text).FirstOrDefault();
                if ( login != null)
                {
                    Form1 form1 = new Form1();                  
                    form1.ShowDialog();
                    Close();

                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo!");
                }
            }
        }
    }
}
