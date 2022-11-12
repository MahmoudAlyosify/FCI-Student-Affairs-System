using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFTWARE_GUI
{
    public partial class Bio_grade1 : Form
    {
        public Bio_grade1()
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
            Sections_Grade3_BIO section = new Sections_Grade3_BIO();
            this.Hide();
            section.ShowDialog();
            this.Close();

        }

        private void AddNewStudent_Click(object sender, EventArgs e)
        {

            this.Hide();//this to hide Student option form
            StudentInformation studentInformation = new StudentInformation();//creat object of Student option form 
            studentInformation.ShowDialog();//show the student Information form
            this.Close();//close student Information form
        }

        private void Bio_grade1_Load(object sender, EventArgs e)
        {

        }
        private void AddNewStudent_Click_1(object sender, EventArgs e)
        {
            AddingNewStudent addingNewStudent = new AddingNewStudent();
            this.Hide();
            addingNewStudent.ShowDialog();
            this.Close();
        }

        private void GoToMain_Click_1(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.ShowDialog();
            this.Close();
        }

        private void Sections_Click_1(object sender, EventArgs e)
        {
            Sections_Grade3_BIO section = new Sections_Grade3_BIO();
            this.Hide();
            section.ShowDialog();
            this.Close();
        }

        private void StudentsGrades_Click(object sender, EventArgs e)
        {
            StudentInformation studentInformation = new StudentInformation();
            this.Hide();
            studentInformation.ShowDialog();
            this.Close();
        }

        private void AddNewStudent_Click_2(object sender, EventArgs e)
        {
            AddingNewStudent add = new AddingNewStudent();
            this.Hide();
            add.ShowDialog();
            this.Close();
        }

        private void GoToMain_Click_2(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.ShowDialog();
            this.Close();
        }

        private void StudentsNames_Click(object sender, EventArgs e)
        {
            BioGrade1_studentInfo f = new BioGrade1_studentInfo();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void StudentsGrades_Click_1(object sender, EventArgs e)
        {

        }

        private void Sections_Click_2(object sender, EventArgs e)
        {
            BioGrade1_Sections f = new BioGrade1_Sections();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
