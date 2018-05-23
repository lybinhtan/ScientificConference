using ScientificConference;
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

namespace ScientificConferenc.GUI.RegisterDepartment
{
    public partial class Instructor : Form
    {
        public Instructor()
        {
            InitializeComponent();
            dtpBirthDay.Format = DateTimePickerFormat.Custom;
            dtpBirthDay.CustomFormat = "MM-dd-yyyy";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "MM-dd-yyyy";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Register next = new Register();
            this.Hide();
            next.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name = txbName.Text;
            DateTime BirthDay = dtpBirthDay.Value;
            string Address = txbAddress.Text;
            string PhoneNumber = txbPhone.Text;
            string Email = txbEmail.Text;
            string Topic = txbTopic.Text;
            string Country = txbCountry.Text;
            DateTime RegistrationDate = dtpDate.Value;
            int Fee;
            if(txbFee.Text == "")
            {
                Fee = 0;
            }
            else
            {
                 Fee = Convert.ToInt32(txbFee.Text);
            }
            int Check;
            if (cbCheck.Checked == true)Check = 1;
            else Check = 0;
            InstructorDAO _instructor = new InstructorDAO();
            if (_instructor.CheckExist(Name, PhoneNumber))
            {
                MessageBox.Show("Người này đã tồn tại", "Thông Báo");
            }
            else
            {
                _instructor.AddInstructor(Name, BirthDay, Address, PhoneNumber, Email, Topic, Country, RegistrationDate, Fee, Check);
                Register next = new Register();
                this.Hide();
                next.Show();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
