using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class QUIZ : Form
    {
        Boolean ff = false, ad = false;
        int second = 31;
        public static string k ;
        int[] x = new int[15];
        public static int p = 0;
        public static int v1;
        public static int v2;
        public static int v3;
        public static int v4;
        string ansfromdb, ansselect, correctop, correct;
        int score = 0, qid;
        Form3 f1 = new Form3();
        gameover g1 = new gameover();
        public string connstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";
        SoundPlayer tic = new SoundPlayer(@"F:\DOTNET project\WindowsFormsApp1\WindowsFormsApp1\Resources\tic.wav");
        SoundPlayer right = new SoundPlayer(@"F:\DOTNET project\WindowsFormsApp1\WindowsFormsApp1\Resources\right.wav");
        SoundPlayer wrong = new SoundPlayer(@"F:\DOTNET project\WindowsFormsApp1\WindowsFormsApp1\Resources\wrong.wav");
        private object q;
        
        public QUIZ()
        {
            InitializeComponent();
        }

        private void QUIZ_Load(object sender, EventArgs e)
        {
            if (ff == true)
            {
                pictureBox1.Enabled = false;

            }
            if (ad == true)
            {
                pictureBox2.Enabled = false;

            }
            timer1.Interval = 1000;
            timer1.Start();
            QUIZ q = new QUIZ();
            Random r = new Random();
            qid = r.Next(1, 16);

            x[p] = qid;


            displayquestion(qid);
            colorchange(p);
        }


        public void colorchange(int p)
        {
            if (p == 0)
            {
                label6.BackColor = Color.Orange;
                label6.ForeColor = Color.Purple;
            }
            if (p == 1)
            {
                label6.BackColor = Color.Black;
                label6.ForeColor = Color.White;
                label7.BackColor = Color.Orange;
                label7.ForeColor = Color.Purple;
            }
            if (p == 2)
            {
                label7.BackColor = Color.Black;
                label7.ForeColor = Color.White;
                label8.BackColor = Color.Orange;
                label8.ForeColor = Color.Purple;
            }
            if (p == 3)
            {
                label8.BackColor = Color.Black;
                label8.ForeColor = Color.White;
                label9.BackColor = Color.Orange;
                label9.ForeColor = Color.Purple;
            }
            if (p == 4)
            {
                label9.BackColor = Color.Black;
                label9.ForeColor = Color.White;
                label10.BackColor = Color.Orange;
                label10.ForeColor = Color.Purple;
            }
            if (p == 5)
            {
                label10.BackColor = Color.Black;
                label10.ForeColor = Color.White;
                label11.BackColor = Color.Orange;
                label11.ForeColor = Color.Purple;
            }
            if (p == 6)
            {
                label11.BackColor = Color.Black;
                label11.ForeColor = Color.White;
                label12.BackColor = Color.Orange;
                label12.ForeColor = Color.Purple;
            }
            if (p == 7)
            {
                label12.BackColor = Color.Black;
                label12.ForeColor = Color.White;
                label13.BackColor = Color.Orange;
                label13.ForeColor = Color.Purple;
            }
            if (p == 8)
            {
                label13.BackColor = Color.Black;
                label13.ForeColor = Color.White;
                label14.BackColor = Color.Orange;
                label14.ForeColor = Color.Purple;
            }
            if (p == 9)
            {
                label14.BackColor = Color.Black;
                label14.ForeColor = Color.White;
                label15.BackColor = Color.Orange;
                label15.ForeColor = Color.Purple;
            }
            if (p == 10)
            {
                label15.BackColor = Color.Black;
                label15.ForeColor = Color.White;
                label16.BackColor = Color.Orange;
                label16.ForeColor = Color.Purple;
            }
            if (p == 11)
            {
                label16.BackColor = Color.Black;
                label16.ForeColor = Color.White;
                label17.BackColor = Color.Orange;
                label17.ForeColor = Color.Purple;
            }

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Orange;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }
        private void label3_MouseEnter_1(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Orange;
        }

        private void label3_MouseLeave_1(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label4_MouseEnter_1(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Orange;
        }

        private void label4_MouseLeave_1(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }
        private void label5_MouseEnter_1(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Orange;
        }

        private void label5_MouseLeave_1(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
            second = 32;
            if (p == 11)
            {

                this.Hide();
                numberfind();
                g1.Show();
            }
            ansselect = label2.Text;
            if (ansselect.Equals(ansfromdb))
            {
                f1.Close();
                tic.Stop();
                right.Play();
                Thread.Sleep(5000);
                qid++;
                displayquestion(qid);
                l1:
                Random r = new Random();
                int s = r.Next(1, 17);

                bool c = search(x, s);

                if (c == true)
                {
                    goto l1;
                }
                else
                {

                    p++;
                    qid = s;
                    x[p] = qid;
                    displayquestion(qid);
                    colorchange(p);
                }
            }
            else
            {
                tic.Stop();
                wrong.Play();
                Thread.Sleep(5000);
                if (p>5)
                {
                    
                    p = 5;
                }
                numberfind();
                this.Hide();
                g1.Show();
              

            }
            displaylabel();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
            second = 32;
            if (p == 11)
            {
                this.Hide();
                numberfind();
                g1.Show();

            }
            ansselect = label3.Text;
            if (ansselect.Equals(ansfromdb))
            {
                f1.Close();
                tic.Stop();
                right.Play();
                Thread.Sleep(5000);
                qid++;
                displayquestion(qid);
                l1:
                Random r = new Random();
                int s = r.Next(1, 17);

                bool c = search(x, s);

                if (c == true)
                {
                    goto l1;
                }
                else
                {

                    p++;
                    qid = s;
                    x[p] = qid;
                    displayquestion(qid);
                    colorchange(p);
                }
            }

            else
            {
                tic.Stop();
                wrong.Play();
                Thread.Sleep(5000);
                if (p > 5)
                {
                  
                    p = 5;
                }
                numberfind();
                this.Hide();
                g1.Show();
                
            }
            displaylabel();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
            second = 32;
            if (p == 11)
            {
                this.Hide();
                numberfind();
                g1.Show();
            }
            ansselect = label4.Text;
            if (ansselect.Equals(ansfromdb))
            {
                f1.Close();
                tic.Stop();
                right.Play();
                Thread.Sleep(5000);
                qid++;
                displayquestion(qid);
                l1:
                Random r = new Random();
                int s = r.Next(1, 17);

                bool c = search(x, s);

                if (c == true)
                {
                    goto l1;
                }
                else
                {
                    label5.ForeColor = Color.Green;
                    p++;
                    qid = s;
                    x[p] = qid;
                    displayquestion(qid);
                    colorchange(p);
                }
            }

            else
            {
                tic.Stop();
                wrong.Play();
                Thread.Sleep(5000);
                if (p > 5)
                {
                   
                    p = 5;
                }
                numberfind();
                this.Hide();
                g1.Show();
       


            }
            displaylabel();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
            second = 32;
            if (p == 11)
            {
                this.Hide();
                numberfind();
                g1.Show();
            }
            ansselect = label5.Text;
            if (ansselect.Equals(ansfromdb))
            {
                f1.Close();
                tic.Stop();
                right.Play();
                Thread.Sleep(5000);
                qid++;
                displayquestion(qid);
                l1:
                Random r = new Random();
                int s = r.Next(1, 17);

                bool c = search(x, s);

                if (c == true)
                {
                    goto l1;
                }
                else
                {

                    p++;
                    qid = s;
                    x[p] = qid;
                    displayquestion(qid);
                    colorchange(p);
               
                }

            }

            else
            {
                tic.Stop();
                wrong.Play();
                Thread.Sleep(5000);
                if (p > 5)
                {
                   
                    p = 5;
                }
                numberfind();
                this.Hide();
                g1.Show();
            }
            displaylabel();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)

        {
        }


        private void label14_Click(object sender, EventArgs e)
        {
        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)

        {

            {
                second = second - 1;
                label18.Text = second.ToString();
                if (second <= 0)
                {
                    timer1.Stop();
                    if(p>=1)
                    {
                        p = 0;
                        numberfind();
                    }
                    g1.Show();
                    this.Hide();
                }
            }
            if(p > 5)
            {
                tic.Stop();
                timer1.Stop();
                label18.Visible = false;
            }
        }
      

         void numberfind()
        {
            if( p == 0 )
            {
                k = label6.Text;
            }
            else if(p == 1)
            {
                k = label7.Text;
            }
            else if (p == 2)
            {
                k = label8.Text;
            }
            else if (p == 3)
            {
                k = label9.Text;
            }
            else if (p == 4)
            {
                k = label10.Text;
            }
            else if (p == 5)
            {
                k = label11.Text;
            }
            else if (p == 6)
            {
                k = label12.Text;
            }
            else if (p == 7)
            {
                k = label13.Text;
            }
            else if (p == 8)
            {
                k = label14.Text;
            }
            else if (p == 9)
            {
                k = label15.Text;
            }
            else if (p == 10)
            {
                k = label16.Text;
            }
            else if (p == 11)
            {
                k = label17.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberfind();
            g1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ff == true)
            { return; }
            else
            {
                ff = true;
                pictureBox1.Image = Image.FromFile(@"F:\DOTNET project\WindowsFormsApp1\WindowsFormsApp1\Resources\122.png");
                SqlConnection con = new SqlConnection(connstring);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select q_opcORRECT from questions where q_id ='" + qid + "'", con);
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    correctop = reader["q_opcORRECT"].ToString();
                }
                if (label2.Text.Equals(correctop))
                {
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = true;
                }
                if (label3.Text.Equals(correctop))
                {
                    label2.Visible = false;
                    label5.Visible = false;
                    label4.Visible = true;
                }
                if (label4.Text.Equals(correctop))
                {
                    label2.Visible = false;
                    label5.Visible = false;
                    label3.Visible = true;
                }
                if (label5.Text.Equals(correctop))
                {
                    label2.Visible = false;
                    label4.Visible = false;
                    label3.Visible = true;
                }
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (ad == true)
            { return; }
            else
            {
                ad = true;
                pictureBox2.Image = Image.FromFile(@"F:\DOTNET project\WindowsFormsApp1\WindowsFormsApp1\Resources\123.png");
                SqlConnection con = new SqlConnection(connstring);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select q_opcORRECT from questions where q_id ='" + qid + "'", con);
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    correct = reader["q_opcORRECT"].ToString();
                }
                int[] a = new int[3];
                int c;

                Random r1 = new Random();
                if (label2.Text.Equals(correct))
                {

                    for (int i = 0; i <= 2; i++)
                    {
                        c = r1.Next(1, 25);
                        a[i] = c;
                    }
                    v1 = 100 - a[0] - a[1] - a[2];
                    v2 = a[0];
                    v3 = a[1];
                    v4 = a[2];
                    Form3 f1 = new Form3();
                    f1.Show();

                }
                if (label3.Text.Equals(correct))
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        c = r1.Next(1, 25);
                        a[i] = c;
                    }
                    v1 = a[0];
                    v2 = 100 - a[0] - a[1] - a[2];
                    v3 = a[1];
                    v4 = a[2];
                    Form3 f1 = new Form3();
                    f1.Show();
                }
                if (label4.Text.Equals(correct))
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        c = r1.Next(1, 25);
                        a[i] = c;
                    }
                    v1 = a[1];
                    v2 = a[0];
                    v3 = 100 - a[0] - a[1] - a[2];
                    v4 = a[2];
                    Form3 f1 = new Form3();
                    f1.Show();
                }
                if (label5.Text.Equals(correct))
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        c = r1.Next(1, 25);
                        a[i] = c;
                    }
                    v1 = a[2];
                    v2 = a[0];
                    v3 = a[1];
                    v4 = 100 - a[0] - a[1] - a[2];
                    Form3 f1 = new Form3();
                    f1.Show();
                }

            }
        }

        public void displaylabel()
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
        }
        public void displayquestion(int q_id)

        {
            int s = q_id;
            SqlConnection connection = new SqlConnection(connstring);
             connection.Open();
            SqlCommand cmd = new SqlCommand("select * from questions where q_id='" + s + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                label1.Text = reader["q_question"].ToString(); //question
                label2.Text = reader["q_opA"].ToString(); //opa
                label3.Text = reader["q_opB"].ToString();//opb
                label4.Text = reader["q_opC"].ToString();//opc
                label5.Text = reader["q_opD"].ToString();//opd
                ansfromdb = reader["q_opcORRECT"].ToString();//correct option.........
            }
            connection.Close();
            tic.Play();
        }
        public static bool search(int[] x, int s)
        {
            bool c = false;
            for (int i = 0; i < x.Length; i++)
            {
                if (s == x[i])
                {
                    c = true;
                    break;
                }
            }
            return c;
        }
    }
}
