using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string First_Name = FirstName.Text;
            string Last_Name = LastName.Text;
            string Middle_Name = MiddleName.Text;
            string gender = null;
            string course = Course.Text;
            string day = Day.Text;
            string month = Month.Text;
            string year = Year.Text;

            if (Male.Checked == true)
            {
                gender = "Male";
            }
            else if (Female.Checked == true)
            {
                gender = " Female ";

            }   
            if (Month.Text.Equals("-Month-") && Day.Text.Equals("-Day-") && Year.Text.Equals("-Year-"))
            {
                if(Male.Checked && !Female.Checked)
                {
                    FirstMess(First_Name,Middle_Name,Last_Name, course);
                }
                else if (Male.Checked && !Female.Checked)
                {
                    FirstMess(First_Name, Middle_Name, Last_Name, course, gender);
                }

            }
            else
            {
                FirstMess(First_Name, Middle_Name, Last_Name, course, gender, day, month, year  );
            }

        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 31; i++)
            {

                Day.Items.Add(i);
            }
            string[] MonthName = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            for (int i = 0; i < 12; i++)
            {

                Month.Items.Add(MonthName[i]);
            }

            for (int i = 1900; i <= 2024; i++)
            {

                Year.Items.Add(i);
            }


           ArrayList course = new ArrayList();
            course.Add("Bachelor of Science in Computer Science");
            course.Add("Bachelor of Science in Information Technology");
            course.Add("Bachelor of Science in Information Systems");
            course.Add("Bachelor of Science in Computer Engineering");

            for (int i = 0; i < 4; i++)
            {
                Course.Items.Add(course[i]);

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            OpenFileDialog Openpic = new OpenFileDialog();
            Openpic.ShowDialog(this);
            if(Openpic.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Bitmap.FromFile(Openpic.FileName);
            }

        }

        public void FirstMess(string First_Name, string Middle_Name, string Last_Name, string Program)
        {
            MessageBox.Show("Student Name: " + First_Name + " " + Middle_Name + " " + Last_Name
                 + "\nProgram: " + Program);

        }

        public void FirstMess(string First_Name, string Last_Name, string Program)
        {
            MessageBox.Show("Student Name: " + First_Name + " " + Last_Name
                 + "\nProgram: " + Program);
        }

        public void FirstMess(string First_Name, string Middle_Name, string Last_Name, string Program, string Gender)
        {
            MessageBox.Show("Student Name: " + First_Name + " " + Middle_Name + " " + Last_Name
            + "\nGender: " + Gender
            + "\nProgram: " + Program);
        }

        public void FirstMess(string First_Name, string Middle_Name, string Last_Name, string Program, string Gender, string Day, string Month, string Year)
        {
            MessageBox.Show("Student Name: " + First_Name + " " + Middle_Name + " " + Last_Name
           + "\nGender: " + Gender
           + "\nBirth of day: " + Day + " " + Month + " " + Year
           + "\nProgram: " + Program);

        }

    }
}

