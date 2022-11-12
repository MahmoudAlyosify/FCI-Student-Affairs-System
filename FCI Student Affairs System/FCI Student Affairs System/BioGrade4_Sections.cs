using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SOFTWARE_GUI
{
    public partial class BioGrade4_Sections : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source = DESKTOP-LPP5L8J\SQLEXPRESS;
            Initial Catalog = Student_Affairs_System;
            Integrated Security = true;"
            );
        SqlCommand cmd;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();

        public BioGrade4_Sections()
        {
            InitializeComponent();
            clearData();
        }
        void clearData()
        {
            Dt.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }
        private void GoToMain_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearData();
            Da = new SqlDataAdapter("select StudentName as Section1 from Student where Section = 1 and Grade = 4", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearData();
            Da = new SqlDataAdapter("select StudentName as Section2 from Student where Section = 2 and Grade = 4", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearData();
            Da = new SqlDataAdapter("select StudentName as Section3 from Student where Section = 3 and Grade = 4", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearData();
            Da = new SqlDataAdapter("select StudentName as Section4 from Student where Section = 4 and Grade = 4", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearData();
            Da = new SqlDataAdapter("select StudentName as Section5 from Student where Section = 5 and Grade = 4", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clearData();
            Da = new SqlDataAdapter("select StudentName as Section6 from Student where Section = 6 and Grade = 4", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clearData();
            Da = new SqlDataAdapter("select StudentName as Section7 from Student where Section = 7 and Grade = 4", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clearData();
            Da = new SqlDataAdapter("select StudentName as Section8 from Student where Section = 8 and Grade = 4", con);
            Da.Fill(Dt);
            this.dataGridView1.DataSource = Dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clearData();
            Da = new SqlDataAdapter("select StudentName as Section9 from Student where Section = 9 and Grade = 4", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clearData();
            cmd = new SqlCommand("select StudentName as Section10 from Student where Section = 10 and Grade = 4", con);
            Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            this.dataGridView1.DataSource = Dt;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bio_grade4 f = new Bio_grade4();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
