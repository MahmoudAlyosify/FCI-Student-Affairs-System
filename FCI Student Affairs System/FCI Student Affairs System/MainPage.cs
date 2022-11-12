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
    
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void GeneralGrade4_Click(object sender, EventArgs e)
        {

        }

        private void ResetPassword_Click(object sender, EventArgs e)
        {
            this.Hide();//Hide the Main form 
            ResetPassword resetPassword=new ResetPassword();
            resetPassword.ShowDialog();//to show the reset Password page form
            this.Close();//Form Exit

        }

        private void Help_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/17lEtiUfc4mNEiS4pb7aBYm9mz-oMJKNf/view?usp=sharing");
        }

        private void GeneralGrade1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://life.aun.edu.eg/fci/ar/department/Computer/science");
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://life.aun.edu.eg/fci/ar/department/BioInformatics");
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://life.aun.edu.eg/fci/ar/department/Software/Engineering");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://life.aun.edu.eg/fci/ar/department/Information/Systems");
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://life.aun.edu.eg/fci/ar/department/Information/Technology");
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://life.aun.edu.eg/fci/ar/department/Multimedia");
        }

        private void GeneralGrade3_CS_Click(object sender, EventArgs e)
        {
            this.Hide();
            General_grade3_cs general_Grade3_Cs=new General_grade3_cs();
            general_Grade3_Cs.ShowDialog();
            this.Close();
        }

        private void GeneralGrade3_IS_Click(object sender, EventArgs e)
        {
            this.Hide();
            General_grade3_IS general_Grade3_IS=new General_grade3_IS();
            general_Grade3_IS.ShowDialog();
            this.Close();
        }

        private void GeneralGrade3_IT_Click(object sender, EventArgs e)
        {
            this.Hide();
            General_grade3_IT general_Grade3_IT=new General_grade3_IT();
            general_Grade3_IT.ShowDialog();
            this.Close();
        }

        private void GeneralGrade3_MM_Click(object sender, EventArgs e)
        {
            this.Hide();
            General_grade3_MM general_Grade3_MM=new General_grade3_MM();
            general_Grade3_MM.ShowDialog();
            this.Close();
        }

        private void GeneralGrade4_IS_Click(object sender, EventArgs e)
        {
            this.Hide();
            General_grade4_IS general_Grade4_IS=new General_grade4_IS();
            general_Grade4_IS.ShowDialog();
            this.Close();
        }

        private void GeneralGrade4_CS_Click(object sender, EventArgs e)
        {
            this.Hide();
            general_grade4_cs general_Grade4_Cs =new general_grade4_cs();
            general_Grade4_Cs.ShowDialog();
            this.Close();
        }

        private void GeneralGrade4_IT_Click(object sender, EventArgs e)
        {
            this.Hide();
            General_grade4_IT general_Grade4_IT=new General_grade4_IT();
            general_Grade4_IT.ShowDialog();
            this.Close();
        }

        private void GeneralGrade4_MM_Click(object sender, EventArgs e)
        {
            this.Hide();
            General_grade4_MM general_Grade4_MM=new General_grade4_MM();
            general_Grade4_MM.ShowDialog();
            this.Close();
        }

        private void BioGrade1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bio_grade1 bio_Grade1 = new Bio_grade1();
            bio_Grade1.ShowDialog();
            this.Close();
        }

        private void BioGrade2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bio_grade2 bio_Grade2 = new Bio_grade2();
            bio_Grade2.ShowDialog();
            this.Close();
        }

        private void BioGrade3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bio_grade3 bio_Grade3 = new Bio_grade3();
            bio_Grade3.ShowDialog();
            this.Close();
        }

        private void BioGrade4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bio_grade4 bio_Grade4 = new Bio_grade4();
            bio_Grade4.ShowDialog();
            this.Close();
        }

        private void SW_Grade1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SW_grade1 sW_Grade1 =new SW_grade1();
            sW_Grade1.ShowDialog();
            this.Close();
        }

        private void SW_Grade2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SW_grade2 sW_Grade2 = new SW_grade2();
            sW_Grade2.ShowDialog();
            this.Close();
        }

        private void SW_Grade3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SW_grade3 sW_Grade3 = new SW_grade3();
            sW_Grade3.ShowDialog();
            this.Close();
        }

        private void SW_Grade4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SW_grade4 sW_Grade4 = new SW_grade4();
            sW_Grade4.ShowDialog();
            this.Close();
        }

        private void SystemAdministrator_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrators_Options administrators_Options = new Administrators_Options();
            administrators_Options.ShowDialog();
            this.Close();
        }

        private void GeneralGrade2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseBioGrade chooseBioGrade = new ChooseBioGrade();
            chooseBioGrade.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseSWGradecs chooseSWGradecs = new ChooseSWGradecs();
            chooseSWGradecs.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddingNewStudent addingNewStudent = new AddingNewStudent();
            addingNewStudent.ShowDialog();
            this.Close();
        }
    }
}
