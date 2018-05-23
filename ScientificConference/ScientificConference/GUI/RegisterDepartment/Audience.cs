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
    public partial class Audience : Form
    {
        public Audience()
        {
            InitializeComponent();
            dtpBirthDay.Format = DateTimePickerFormat.Custom;
            dtpBirthDay.CustomFormat = "MM-dd-yyyy";
        }

        private void Audience_Load(object sender, EventArgs e)
        {

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
            int fee;
            if(txbFee.Text == "")
            {
                fee = 0;
            }
            else
            {
                fee = Convert.ToInt32(txbFee.Text);
            }
            int check;
            if (cbCheck.Checked == true)
            {
                check = 1;
            }
            else check = 0;
            AudienceDAO _audience = new AudienceDAO();
            if (_audience.CheckExist(name, phone))
            {
                MessageBox.Show("Người này đã tồn tại", "Thông Báo");
            }
            else
            {
                _audience.AddAudience(name, birthday, address, phone, topic, email, check, country, fee);
                Register next = new Register();
                this.Hide();
                next.Show();
            }
        }
    }
}
