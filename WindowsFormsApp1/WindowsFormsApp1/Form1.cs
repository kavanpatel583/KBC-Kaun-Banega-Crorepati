using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        public static string NAME;
        public static string mail;

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer kbc = new SoundPlayer(@"F:\DOTNET project\WindowsFormsApp1\WindowsFormsApp1\Resources\kbc.wav");
            kbc.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                linkLabel1.Text = "please Enter the Name and email First";
            }

            else
            {
                mail = textBox2.Text;
                NAME = textBox1.Text;
                this.Hide();
                QUIZ q = new QUIZ();
                q.Show();
            }
            

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
