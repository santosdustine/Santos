using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApp
{
    public partial class StuFrmReg : Form
    {
        public StuFrmReg()
        {
            InitializeComponent();
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            for (int day = 1; day <= 31; day++)
            {
                cmbDay.Items.Add(day);
            }

            for (int month = 1; month <= 12; month++)
            {
                cmbMonth.Items.Add(month);
            }

            for (int year = 1900; year <= DateTime.Now.Year; year++)
            {
                cmbYear.Items.Add(year);
            }
            string[] courses = { 
                "Bachelor of Science in Information Technology ",
                "Bachelor of Science in Tourism Management",
                "Bachelor of Science in Psychology",
                "Bachelor of Science in Business Administration",
                "Bachelor of Science in Hospitality Management ", 
            };
            {
                
                for (int i = 0; i < courses.Length; i++)
                {
                    cmbPrograms.Items.Add(courses[i]);
                }
                    
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string middleName = txtMiddleName.Text.Trim();

            foreach (char c in lastName + firstName)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("Invalid input! Names should not contain numbers.",
                        "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please enter your Last Name.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(middleName))
            {
                MessageBox.Show("Please enter your Middle Name.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMiddleName.Focus(); return;
            }
            else if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Please enter your First Name.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus(); return;
            }

            else if (!radMale.Checked && !radFemale.Checked)
            {
                MessageBox.Show("Please select a Gender.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cmbDay.SelectedItem == null)
            {
                MessageBox.Show("Please select a Day.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbMonth.SelectedItem == null)
            {
                MessageBox.Show("Please select a Month.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbYear.SelectedItem == null)
            {
                MessageBox.Show("Please select a Year.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbPrograms.SelectedItem == null)
            {
                MessageBox.Show("Please select a Program.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int day = cmbDay.SelectedIndex + 1;
                int month = cmbMonth.SelectedIndex + 1;
                int year = int.Parse(cmbYear.SelectedItem.ToString());
                DateTime testDate = new DateTime(year, month, day);
            }
            catch
            {
                MessageBox.Show("Invalid date! Please check the Day, Month, and Year.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studGender = radMale.Checked ? "Male" : "Female";
            string studCourse = cmbPrograms.SelectedItem.ToString();

            string dobDay = cmbDay.SelectedItem.ToString();
            string dobMonth = cmbMonth.SelectedItem.ToString();
            string dobYear = cmbYear.SelectedItem.ToString();
            string dob = dobDay + "/" + dobMonth + "/" + dobYear;

            string fullName = firstName + " " + " " + lastName;

            DisplayStudentInfo(fullName, studGender, dob, studCourse);
            DisplayStudentInfo(fullName, studCourse);
            DisplayStudentInfo(firstName, lastName, studCourse);
        }

        private void DisplayStudentInfo(string firstName, string lastName, string program)
        {
            string message = "Student name: " + firstName + " " + lastName + "\n" +
                             "Program: " + program;
            MessageBox.Show(message, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayStudentInfo(string fullName, string program)
        {
            string message = "Student name: " + fullName + "\n" +
                            "Program: " + program;
            MessageBox.Show(message, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayStudentInfo(string fullName, string gender, string dob, string program)
        {
            string message = "Student name: " + fullName + "\n" +
                             "Gender: " + gender + "\n" +
                             "Date of birth: " + dob + "\n" +
                             "Program: " + program;
            MessageBox.Show(message, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void cmbPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         private void TB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.Title = "Select a Photo";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStud.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void pictureBoxStud_Click(object sender, EventArgs e)
        {

        }
    }
}