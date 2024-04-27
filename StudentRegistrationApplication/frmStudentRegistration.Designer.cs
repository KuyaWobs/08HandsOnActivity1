namespace StudentRegistrationApplication
{
    partial class frmStudentRegistration
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
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Year = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.ComboBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Register_Student = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LastName.Location = new System.Drawing.Point(24, 91);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(351, 26);
            this.LastName.TabIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FirstName.Location = new System.Drawing.Point(24, 143);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(351, 26);
            this.FirstName.TabIndex = 1;
            // 
            // MiddleName
            // 
            this.MiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MiddleName.Location = new System.Drawing.Point(24, 195);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(351, 26);
            this.MiddleName.TabIndex = 2;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.BackColor = System.Drawing.Color.Transparent;
            this.Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Male.Location = new System.Drawing.Point(122, 239);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(61, 24);
            this.Male.TabIndex = 3;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = false;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.BackColor = System.Drawing.Color.Transparent;
            this.Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Female.Location = new System.Drawing.Point(189, 239);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(80, 24);
            this.Female.TabIndex = 4;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = false;
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Year.FormattingEnabled = true;
            this.Year.Location = new System.Drawing.Point(224, 299);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(86, 28);
            this.Year.TabIndex = 5;
            this.Year.Text = "-Year-";
            // 
            // Day
            // 
            this.Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Day.FormattingEnabled = true;
            this.Day.Location = new System.Drawing.Point(41, 299);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(64, 28);
            this.Day.TabIndex = 6;
            this.Day.Text = "-Day-";
            // 
            // Month
            // 
            this.Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Month.FormattingEnabled = true;
            this.Month.Location = new System.Drawing.Point(111, 299);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(107, 28);
            this.Month.TabIndex = 7;
            this.Month.Text = "-Month-";
            // 
            // Register_Student
            // 
            this.Register_Student.BackColor = System.Drawing.Color.Crimson;
            this.Register_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Register_Student.ForeColor = System.Drawing.Color.White;
            this.Register_Student.Location = new System.Drawing.Point(62, 406);
            this.Register_Student.Name = "Register_Student";
            this.Register_Student.Size = new System.Drawing.Size(169, 32);
            this.Register_Student.TabIndex = 8;
            this.Register_Student.Text = "Register Student";
            this.Register_Student.UseVisualStyleBackColor = false;
            this.Register_Student.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Name *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "First Name *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Middle Name *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date of birth *";
            // 
            // Course
            // 
            this.Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Course.FormattingEnabled = true;
            this.Course.Location = new System.Drawing.Point(24, 363);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(351, 28);
            this.Course.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Program to apply *";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(404, 91);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(247, 194);
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::StudentRegistrationApplication.Properties.Resources._73293e357cc318bb485a843ba825bcf6;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register_Student);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmStudentRegistration";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmStudentRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.Button Register_Student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Course;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

