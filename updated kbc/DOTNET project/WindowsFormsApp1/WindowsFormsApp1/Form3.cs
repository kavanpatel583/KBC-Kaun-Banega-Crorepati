using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        public object Me { get; private set; }

        private void Form3_Load(object sender, EventArgs e)
        {
            Chart1.Series["VOTES"].Points.AddXY("A", QUIZ.v1);
            Chart1.Series["VOTES"].Points.AddXY("B", QUIZ.v2);
            Chart1.Series["VOTES"].Points.AddXY("C", QUIZ.v3);
            Chart1.Series["VOTES"].Points.AddXY("D", QUIZ.v4);
        }

     
    }
}
