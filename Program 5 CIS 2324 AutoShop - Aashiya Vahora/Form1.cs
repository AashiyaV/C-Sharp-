using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_5_CIS_2324_AutoShop___Aashiya_Vahora
{
    public partial class Form1 : Form
    {//Coded By Aashiya Vahora
        public Form1()
        {
            InitializeComponent();
        }// Variable Declaration
        double PartTax = 0, PartsCost = 0, LaborCost = 0, OilandLubeCost, MiscCost, CarWashCost = 0, FlushesCost = 0, TotalSandLCosts = 0, TotalCharges = 0;       
        private void button1_Click(object sender, EventArgs e)
        {
            OilandLubeCharge();
            MiscCharge();
            CarWashCharge();
            FlushesCharge();
            PartsandLaborCharge();
            CalculateCharges();
            DisplayCharges();
        }
        private void OilandLubeCharge()
        {
            if (checkBox1.Checked)
                OilandLubeCost = 26;
            if (radioButton2.Checked)
                OilandLubeCost = OilandLubeCost + 10;
            else if (radioButton3.Checked)
                OilandLubeCost = OilandLubeCost + 20;
            if (checkBox2.Checked)
                OilandLubeCost = OilandLubeCost + 18;
        }
        private void MiscCharge()
        {
            if (checkBox3.Checked)
                MiscCost = MiscCost + 15;
            if (checkBox4.Checked)
                MiscCost = MiscCost + 100;
            if (checkBox5.Checked)
                MiscCost = MiscCost + + 20;
        }
        private void CarWashCharge()
        {
            if (radioButton6.Checked)
                CarWashCost = 6;
            if (radioButton7.Checked)
                CarWashCost = 9;
        }
        private void FlushesCharge()
        {
            if (checkBox6.Checked)
                FlushesCost = FlushesCost + 30;
            else if (checkBox7.Checked)
                FlushesCost = FlushesCost + 80;
        }
        private void PartsandLaborCharge()
        {
            PartsCost = double.Parse(textBox1.Text);
            LaborCost = double.Parse(textBox2.Text);
        }
        private void CalculateCharges()
        {
            PartTax = (PartsCost * .06);
            TotalSandLCosts = (OilandLubeCost + MiscCost + CarWashCost + FlushesCost) + (LaborCost * 20);
            TotalCharges = TotalSandLCosts + PartsCost + PartTax;
        }
        private void DisplayCharges()
        {
            label8.Text = TotalSandLCosts.ToString("C");
            label9.Text = PartsCost.ToString("C");
            label10.Text = PartTax.ToString("C");
            label11.Text = TotalCharges.ToString("C");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;

            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;

            textBox1.Text = "";
            textBox2.Text = "";

            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About to terminate app");
            Application.Exit();
        }

    }
}
