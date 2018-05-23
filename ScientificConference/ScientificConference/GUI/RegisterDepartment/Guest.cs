using ScientificConference.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificConference.GUI.RegisterDepartment
{
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
            dtpBirthDay.Format = DateTimePickerFormat.Custom;
            dtpBirthDay.CustomFormat = "MM-dd-yyyy";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Register next = new Register();
            this.Hide();
            next.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            DateTime birthday = dtpBirthDay.Value;
            string address = txbAddress.Text;
            string phone = txbPhone.Text;
            string email = txbEmail.Text;
            string topic = txbTopic.Text;
            string country = txbCountry.Text;
            int check;
            if (cbCheck.Checked == true)
            {
                check = 1;
            }
            else check = 0;
            GuestDAO _guest = new GuestDAO();
            if(_guest.CheckExist(name,phone))
            {
                MessageBox.Show("Người này đã tồn tại", "Thông Báo");
            }
            else{
                _guest.AddGuest(name, birthday, address, phone, topic, email, check, country);
                Register next = new Register();
                this.Hide();
                next.Show();
            }
        }
    }
}
