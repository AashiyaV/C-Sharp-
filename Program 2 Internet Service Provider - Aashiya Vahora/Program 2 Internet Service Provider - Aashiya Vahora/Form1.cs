using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2_Internet_Service_Provider___Aashiya_Vahora
{//Coded by Aashiya Vahora
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variable Declaration
        double HrsUsed = 0, Price = 0;

        private void button1_Click(object sender, EventArgs e)
        {//Code behine calculate button
            HrsUsed = double.Parse(textBox1.Text);
            if (HrsUsed > 744)
                MessageBox.Show("error: number of hours cannot exceed 744");

            if (radioButton1.Checked)
             {
                if(HrsUsed <= 10.0)
                    Price = 9.95;
                else 
                    Price = 9.95 + (2 * (HrsUsed - 10));
            }
           else if (radioButton2.Checked)
            {
                if (HrsUsed <= 20.0)
                    Price = 14.95;
                else
                    Price = 14.95 + (1*(HrsUsed - 20));
            }
           else if (radioButton3.Checked)
            {
                if (HrsUsed > 20.0)
                    Price = 19.95;
            }
            if (checkBox1.Checked)
            {
                Price = Price * 0.80;
            }
            label4.Text = Price.ToString("C");
        }
        private void button2_Click(object sender, EventArgs e)
        {//Code behind clear button
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
            textBox1.Text = "";
            label4.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {//Code behind exit button
            MessageBox.Show("About to exit application");
            Application.Exit();
        }
    }
}
