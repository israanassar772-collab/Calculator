using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1;
            float num2;
            if (txt_b1.Text == "" || txt_b2.Text == "")
            {
                MessageBox.Show("Enter The Number");
            }
            else
            {
                num1 = float.Parse(txt_b1.Text);
                num2 = float.Parse(txt_b2.Text);
                float result = num1 + num2;
                lab_res.Text = result + "";

            }
           

            }

        }
    }

