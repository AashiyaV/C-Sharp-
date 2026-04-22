using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1_CIS2324___Aashiya_Vahora
{//Coded by Aashiya Vahora
    public partial class Form1 : Form
    {
        // Variable declaration 
        double MealPrice = 0, TipPercentage = 0, TipAmount = 0, Total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// Codebehind the PROCESS BUTTON
            IntputData(); 
            ProcessData();
            OutputData();
        }
        private void IntputData()
        {
            MealPrice = double.Parse(textBox1.Text);
            TipPercentage = double.Parse(textBox2.Text)/100;
        }
        private void ProcessData()
        {
            TipAmount = MealPrice * TipPercentage;
            Total = MealPrice + TipAmount;
        }
        private void OutputData()
        {
            label3.Text = TipAmount.ToString("C");
            label6.Text = Total.ToString("C");
        }
        private void button2_Click(object sender, EventArgs e)
        {// Codebehind the CLEAR BUTTON
            ClearAll();
        }
       private void ClearAll()
        {
            textBox1.Text = "";
            label3.Text = "";
            textBox2.Text = "";
            label6.Text = "";
            MealPrice = 0;
            TipPercentage = 0;
        }
        private void button3_Click(object sender, EventArgs e)
        {// Codebehind the EXIT BUTTON
            MessageBox.Show("About to Exit the App");
            Application.Exit();
        }
    }
}
