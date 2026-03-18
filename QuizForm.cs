using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class QuizApp : Form
    {
        public QuizApp()
        {
            InitializeComponent();
            panel1DArray.Visible = false;
            panel2DArray.Visible = false;
            panelContains.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
              
            string[] listNames = { "Philip ", "Carl ", "Karl ", "Rod ", "Dustine" };

            foreach (string name in listNames)
            {
                textBox2DArray.AppendText(name);
            }
        }

        private void Btn1DArray_Click(object sender, EventArgs e)
        {
            panel1DArray.Visible = true;
            panel2DArray.Visible = false;
            panelContains.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            char[,] letters = new char[2, 3]
            {
                { 'A', 'B','C'},
                { 'D','E','F'}
            };

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    textBox2DArray.AppendText(letters[i, j] + " ");
                }
                textBox2DArray.AppendText("\r\n");
            }
        }

        private void btn2DArray_Click(object sender, EventArgs e)
        {
            panel2DArray.Visible = true;
            panel1DArray.Visible = false;
            panelContains.Visible = false;
        }

        private void btnContains_Click(object sender, EventArgs e)
        { 
            panelContains.Visible = true;
            panel1DArray.Visible = false;
            panel2DArray.Visible = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            string message = txtCheck.Text;


            if (message.Contains("Hello"))
            {
                MessageBox.Show("The message contains 'Hello'");
            }

            else
            {
                MessageBox.Show("The message NOT contains 'Hello'");

            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void lblContains_Click(object sender, EventArgs e)
        {

        }
    }
}