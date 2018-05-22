using ScientificConferenc.GUI.RegisterDepartment;
using ScientificConference.DAO;
using ScientificConference.GUI.RegisterDepartment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificConference
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            Load += new EventHandler(Register_Load);
        }
        #region method

        public int flag = 1;
        public void ShowDataInstructor()
        {
            string query = "select Name, BirthDay, Address, PhoneNumber, Email, Topic, Country, RegistrationDate, Fee, status, Point from Instructor, CheckJoin where Instructor.checkk = CheckJoin.val";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            dgvData.DataSource = data;
        }

        public  void ShowData()
        {
            string query;
            if (flag == 1)
            {
                query = "select Name, BirthDay, Address, PhoneNumber, Email, Topic, Country, RegistrationDate, Fee, status, Point from Instructor, CheckJoin where Instructor.checkk = CheckJoin.val";
            }
            else if (flag == 2)
            {
                query = "select * from Guest";
            }
            else
            {
                query = "select * from Audience";
            }
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            dgvData.DataSource = data;
        }

        #endregion

        #region event
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string find = txbFind.text;
            string query;
            if(flag == 1)
            {
                query = "select Name, BirthDay, Address, PhoneNumber, Email, Topic, Country, RegistrationDate, Fee, status, Point from Instructor, CheckJoin where Instructor.checkk = CheckJoin.val and Name='" + find + "'";
            }
            else if(flag == 2)
            {
                query = "select * from Guest where Name='" + find + "'";
            }
            else
            {
                query = "select * from Audience where Name='" + find + "'";
            }
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            dgvData.DataSource = data;
        }

        private void loaddata_(object sender, EventArgs e)
        {
            btnFind_Click(sender, e);
        }



        private void btnInstructor_Click(object sender, EventArgs e)
        {
            flag = 1;
            ShowData();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ShowDataInstructor();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            flag = 2;
            ShowData();
        }

        private void btnAudience_Click(object sender, EventArgs e)
        {
            flag = 3;
            ShowData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(flag == 1)
            {
                Instructor next = new Instructor();    
                this.Hide();
                next.Show();
            }
            else if(flag == 2)
            {
                Guest next = new Guest();
                this.Hide();
                next.Show();
            }
            else
            {
                Audience next = new Audience();
                this.Hide();
                next.Show();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            ShowDataInstructor();
        }
        #endregion

    }
}
