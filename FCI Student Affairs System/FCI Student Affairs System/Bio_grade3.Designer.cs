
namespace SOFTWARE_GUI
{
    partial class Bio_grade3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bio_grade3));
            this.Sections = new System.Windows.Forms.Button();
            this.StudentsGrades = new System.Windows.Forms.Button();
            this.StudentsNames = new System.Windows.Forms.Button();
            this.GoToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sections
            // 
            this.Sections.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sections.Location = new System.Drawing.Point(305, 321);
            this.Sections.Margin = new System.Windows.Forms.Padding(5);
            this.Sections.Name = "Sections";
            this.Sections.Size = new System.Drawing.Size(299, 85);
            this.Sections.TabIndex = 38;
            this.Sections.Text = "عرض السكاشن";
            this.Sections.UseVisualStyleBackColor = true;
            this.Sections.Click += new System.EventHandler(this.Sections_Click_1);
            // 
            // StudentsGrades
            // 
            this.StudentsGrades.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StudentsGrades.Location = new System.Drawing.Point(305, 231);
            this.StudentsGrades.Margin = new System.Windows.Forms.Padding(5);
            this.StudentsGrades.Name = "StudentsGrades";
            this.StudentsGrades.Size = new System.Drawing.Size(299, 85);
            this.StudentsGrades.TabIndex = 37;
            this.StudentsGrades.Text = "عرض الطلاب وبياناتهم";
            this.StudentsGrades.UseVisualStyleBackColor = true;
            this.StudentsGrades.Click += new System.EventHandler(this.StudentsGrades_Click);
            // 
            // StudentsNames
            // 
            this.StudentsNames.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StudentsNames.Location = new System.Drawing.Point(305, 140);
            this.StudentsNames.Margin = new System.Windows.Forms.Padding(5);
            this.StudentsNames.Name = "StudentsNames";
            this.StudentsNames.Size = new System.Drawing.Size(299, 85);
            this.StudentsNames.TabIndex = 36;
            this.StudentsNames.Text = "عرض لائحة الفرقة الثالثة نظم معلومات حيوية";
            this.StudentsNames.UseVisualStyleBackColor = true;
            // 
            // GoToMain
            // 
            this.GoToMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GoToMain.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GoToMain.Location = new System.Drawing.Point(375, 434);
            this.GoToMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GoToMain.Name = "GoToMain";
            this.GoToMain.Size = new System.Drawing.Size(168, 60);
            this.GoToMain.TabIndex = 42;
            this.GoToMain.Text = "الصفحة الرئيسية";
            this.GoToMain.UseVisualStyleBackColor = false;
            this.GoToMain.Click += new System.EventHandler(this.GoToMain_Click_1);
            // 
            // Bio_grade3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.GoToMain);
            this.Controls.Add(this.Sections);
            this.Controls.Add(this.StudentsGrades);
            this.Controls.Add(this.StudentsNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bio_grade3";
            this.Text = "نظم حيوية_ المستوى الثالث";
            this.Load += new System.EventHandler(this.Bio_grade3_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Sections;
        private System.Windows.Forms.Button StudentsGrades;
        private System.Windows.Forms.Button StudentsNames;
        private System.Windows.Forms.Button GoToMain;
    }
}