using EliteMart.AppCode;
using EliteMart.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliteMart
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private AppDB db = new AppDB();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var loginQuery = db.TaiKhoans.Where(x => x.TenDangNhap == txtUsername.Text && x.MatKhau == txtPassword.Text);
            if (loginQuery.Count() > 0)
            {
                this.Hide();
                TaiKhoan loginAccount = loginQuery.First();
                Session.LoginAccount = loginAccount;
                Manager f = new Manager();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác. Vui lòng kiểm tra lại!!!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
