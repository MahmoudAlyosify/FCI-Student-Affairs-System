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
    public partial class Bio_grade4 : Form
    {


        public Bio_grade4()
        {
            InitializeComponent();
        }

        private void GoToMain_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.ShowDialog();
            this.Close();
        }

        private void Sections_Click(object sender, EventArgs e)
        {
            BioGrade4_Sections f = new BioGrade4_Sections();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void AddNewStudent_Click(object sender, EventArgs e)
        {
            
        }

        private void Bio_grade4_Load(object sender, EventArgs e)
        {

        }

        private void GoToMain_Click_1(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.ShowDialog();
            this.Close();
        }

        private void StudentsNames_Click(object sender, EventArgs e)
        {
            BioGrade4_StudentInfo f = new BioGrade4_StudentInfo();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
