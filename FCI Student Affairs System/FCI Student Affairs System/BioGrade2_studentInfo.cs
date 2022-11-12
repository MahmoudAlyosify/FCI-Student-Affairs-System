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
    public partial class BioGrade2_studentInfo : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source = DESKTOP-LPP5L8J\SQLEXPRESS;
            Initial Catalog = Student_Affairs_System;
            Integrated Security = true;"
            );
        SqlCommand cmd;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();

        public BioGrade2_studentInfo()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select StudentName, national_ID, DataOfBirth, City, Center, stud_Address, Religion, Gender, phone, degree, Batch, SittingNum, FatherName, FatherID, FatherJob, FatherPhone, Payment from Student where Grade = 2", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void GoToMain_Click(object sender, EventArgs e)
        {
            Bio_grade2 f = new Bio_grade2();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
