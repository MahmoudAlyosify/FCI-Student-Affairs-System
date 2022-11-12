using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCI_Student_Affairs_System
{
    public partial class choose_your_login_type : Form
    {
        public choose_your_login_type()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin admin = new AdminLogin();
            admin.ShowDialog();
            this.Close();
        }

        private void choose_your_login_type_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpLogin emp = new EmpLogin();
            emp.ShowDialog();
            this.Close();
        }
    }
}
