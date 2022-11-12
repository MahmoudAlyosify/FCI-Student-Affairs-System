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
using System.IO;

namespace SOFTWARE_GUI
{
    public partial class AddingNewStudent : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source = DESKTOP-LPP5L8J\SQLEXPRESS;
            Initial Catalog = Student_Affairs_System;
            Integrated Security = true;"
            );
        SqlCommand cmd;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();

        public AddingNewStudent()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select Your Image";
                openFileDialog.Filter = "Image File (*.jpg; *.jpeg; *.png;*.bmp;)|*.jpg; *.jpeg; *.png;*.bmp;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap image = new Bitmap(openFileDialog.FileName);
                    pictureBox1.Image = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            /*
                cmd = new SqlCommand("InsertIntoStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] param = new SqlParameter[17];

                param[0] = new SqlParameter("@StudentName", SqlDbType.VarChar, 50);
                param[0].Value = textBox1.Text;

                param[1] = new SqlParameter("@national_ID", SqlDbType.Char, 14);
                param[1].Value = textBox2.Text;
            
                param[2] = new SqlParameter("@DateOfBirth", SqlDbType.Date);
                param[2].Value = dateTimePicker1.Value;
                
                param[3] = new SqlParameter("@City", SqlDbType.NVarChar, 20);
                param[3].Value = comboBox1.Text;

                param[4] = new SqlParameter("@Center", SqlDbType.NVarChar, 20);
                param[4].Value = textBox3.Text;

                param[5] = new SqlParameter("@stud_Address", SqlDbType.NVarChar, 150);
                param[5].Value = textBox4.Text;

                param[6] = new SqlParameter("@Religio", SqlDbType.NVarChar, 10);
                param[6].Value = comboBox2.Text;

                param[7] = new SqlParameter("@Gender", SqlDbType.NVarChar, 10);
                param[7].Value = comboBox3.Text;

                param[8] = new SqlParameter("@phone", SqlDbType.Char, 11);
                param[8].Value = textBox5.Text;

                param[9] = new SqlParameter("@degree", SqlDbType.Decimal);
                param[9].Value = textBox6.Text;

                param[10] = new SqlParameter("@Batch", SqlDbType.Char, 4);
                param[10].Value = textBox9.Text;

                param[11] = new SqlParameter("@SittingNum", SqlDbType.NVarChar, 20);
                param[11].Value = textBox10.Text;

                param[12] = new SqlParameter("@department", SqlDbType.NVarChar, 40);
                param[12].Value = listBox1.Text;

                param[13] = new SqlParameter("@FatherName", SqlDbType.NVarChar, 50);
                param[13].Value = textBox8.Text;

                param[14] = new SqlParameter("@FatherID", SqlDbType.NVarChar, 14);
                param[14].Value = textBox11.Text;

                param[15] = new SqlParameter("@FatherJob", SqlDbType.NVarChar, 50);
                param[15].Value = textBox13.Text;

                param[16] = new SqlParameter("@FatherPhone", SqlDbType.NVarChar, 11);
                param[16].Value = textBox7.Text;
            /*
            param[17] = new SqlParameter("@Payment", SqlDbType.int);
            param[17].Value = checkBox1.Checked;
            /*
            cmd.Parameters.AddRange(param);
            */
            string payment = "";
            cmd = new SqlCommand("Insert Into Student(StudentName, national_ID, DataOfBirth,City, Center, stud_Address, Religion, Gender,phone, degree, Batch, SittingNum, department,FatherName, FatherID, FatherJob, FatherPhone, Payment) values ('" + textBox1.Text +"', '"+ textBox2.Text +"', '"+ dateTimePicker1.Value +"', '"+ comboBox1.Text +"', '"+ textBox3.Text +"', '"+ textBox4.Text +"', '"+ comboBox2.Text +"', '"+ comboBox3.Text +"', '"+ textBox5.Text +"', "+ textBox6.Text +", '"+ textBox9.Text +"', '"+ textBox10.Text +"', '"+listBox1.Text+"', '"+ textBox8.Text +"', '"+ textBox11.Text +"', '"+ textBox13.Text +"', '"+ textBox7.Text +"', '"+ checkBox1.Text +"' )", con);

            con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
                con.Close();
            
            
           
            /////////////////////////////////////////////////////////////////////////////////
            string message = "هل تريد أن تطبع أستمارة التسجيل ؟";
            string title = "طباعة أستمارة التسجيل";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                // Do something  
            }
            else
            {
                // Do something  
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                button1.Enabled = true;
            else if(!checkBox1.Checked)
                button1.Enabled = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddingNewStudent_Load(object sender, EventArgs e)
        {
           
        }

        private void GoToMain_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection conn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Student_Affairs_System;Data Source=localhost\MAHMOUDALYOSIFY");
            try { conn.Open(); } catch { MessageBox.Show("problem with the connection"); }

            string data = "50";

            SqlDataAdapter ad = new SqlDataAdapter("select top 1 image from [dbo].[testtable] where id = 50", conn);
            DataSet ds = new DataSet();

            ad.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                byte[] blob = new byte [0];
                blob = (Byte[])(ds.Tables[0].Rows[0]["image"]);

                pictureBox1.Image = Image.FromStream(new MemoryStream(blob));
                
            }
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
