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

        }
    }
}
