using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static void SendEmail(string email,string name,string prize,string word)
        {
            MailMessage mailMessage = new MailMessage("teamkbc07@gmail.com", email);
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "<br/>"+"<br/>"+
                
                "-----CONGRATULATION------ " + name +"<br/>"+ "<br/>" + "<br/>"+

                "<table border=" + 1 + " cellpadding=" + 0 + " cellspacing=" + 0 + ">" +
                "<tr bgcolor='#1a53ff'>" +
               "<th text-align='center' colspan='7'><h1>Winning Amount</h1></th>" +
               "</tr>" +

              "<tr bgcolor='#668cff'>" +
               "<th><h2>In Rs</h2></th>" +
               "<th><h2>In Words</h2></td>" +
               "</tr>" +

               "<tr bgcolor='#688cfc'>" +
               "<th><h3>" + prize + "</h3></th>" +
               "<th><h3>" + word + "</h3></th>" +
               "</tr>" +

             "</table>";
            mailMessage.Subject = "Winner Prize";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "teamkbc07@gmail.com",
                Password = "%TGB6yhn^YHN5tgb"
            };
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            string email = Form1.mail;
            label1.Text = Form1.NAME;
            label3.Text = QUIZ.k;
            
            if(label3.Text == "5000")
            {
                label2.Text = "FIVE THOUSAND ONLY";
            }
            else if (label3.Text == "10,000")
            {
                label2.Text = "TEN THOUSAND ONLY";
            }
            if (label3.Text == "20,000")
            {
                label2.Text = "TWENTY THOUSAND ONLY";
            }
            if (label3.Text == "40,000")
            {
                label2.Text = "FORTY THOUSAND ONLY";
            }
            if (label3.Text == "80,000")
            {
                label2.Text = "EIGHTY THOUSAND ONLY";
            }
            if (label3.Text == "1,60,000")
            {
                label2.Text = "ONE LAKH SIXTY THOUSAND ONLY";
            }
            if (label3.Text == "3,20,000")
            {
                label2.Text = "THREE LAKH TWENTY THOUSAND ONLY";
            }
            if (label3.Text == "6,40,000")
            {
                label2.Text = "SIX LAKH FORTY THOUSAND ONLY";
            }
            if (label3.Text == "12,50,000")
            {
                label2.Text = "TWELVE LAKH FIFTY THOUSAND ONLY";
            }
            if (label3.Text == "25,00,000")
            {
                label2.Text = "TWENTY LAKH ONLY";
            }
            if (label3.Text == "50,00,000")
            {
                label2.Text = "FIFTY LAKH ONLY";
            }
            if (label3.Text == "1 Crore")
            {
                label2.Text = " 1  CRORE ONLY ";
            }
            string name = label1.Text;
            string prize = label3.Text;
            string word = label2.Text;
            SendEmail(email,name, prize,word);

        }
    }
}
