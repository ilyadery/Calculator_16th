using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_16th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Calculator1_16th()
        {
            int first = Int32.Parse(textBox3.Text, System.Globalization.NumberStyles.HexNumber);
           

            if (first < 0xFF)
            {
                first++;
                textBox3.Text = string.Format("{0:X2}", first);
            }
            else
            {
                first = 00;
                textBox3.Text = string.Format("{0:X2}", first);
            }

         
        }

        public void Calculator2_16th()
        {
            int first = Int32.Parse(textBox3.Text, System.Globalization.NumberStyles.HexNumber);


            if (first < 0xFF)
            {
                first--;
                textBox3.Text = string.Format("{0:X2}", first);
            }
            else
            {
                first = 00;
                textBox3.Text = string.Format("{0:X2}", first);
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator1_16th();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculator2_16th();
        
        }
    }
}
