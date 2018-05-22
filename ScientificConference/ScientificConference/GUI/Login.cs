using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScientificConference
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            int check = DAO.StaffDAO.Instance.GetStaff(userName, passWord);
            if(check == 0)
            {
                MessageBox.Show("Bạn nhập sai yêu cầu nhập lại", "Thông báo");
            }
            else
            {
                Register Register = new Register();
                this.Hide();
                Register.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
