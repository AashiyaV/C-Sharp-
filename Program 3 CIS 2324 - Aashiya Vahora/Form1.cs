using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3_CIS_2324___Aashiya_Vahora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variable Decleration
        string Seminar = " ", LocationSelected = " ", DisplayData = " ";
        double SeminarCost = 0, LocationCost = 0, NumDays = 0, TotalCost = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            ProcessSeminar();
            ProcessLocation();
            CalculateTotal();
            DisplayOutput();
        }
        private void ProcessSeminar()
        {
            Seminar = listBox1.SelectedItem.ToString();
            if (Seminar == ("Handling Stress"))
            {
                SeminarCost = 1000;
                NumDays = 3;
            }
            else if (Seminar == "Time Mangement")
            {
                SeminarCost = 800;
                NumDays = 3;
            }
            else if (Seminar == "Supervision Skills")
            {
                SeminarCost = 1500;
                NumDays = 3;
            }
            else if (Seminar == "Negotiation")
            {
                SeminarCost = 1300;
                NumDays = 5;
            }
            else if (Seminar == "How to Interview")
            {
                SeminarCost = 500;
                NumDays = 1;
            }
        }
        private void ProcessLocation()
        {
            LocationSelected = listBox2.SelectedItem.ToString();
            if (LocationSelected == "Austin")
            { LocationCost = 150; }
            else if (LocationSelected == "Chicago")
            { LocationCost = 225; }
            else if (LocationSelected == "Dallas")
            { LocationCost = 175; }
            else if (LocationSelected == "Orlando")
            { LocationCost = 300; }
            else if (LocationSelected == "Phoenix")
            { LocationCost = 175; }
            else if (LocationSelected == "Raleigh")
            { LocationCost = 150; }
        }
        private void CalculateTotal()
        {
            TotalCost = (SeminarCost + (LocationCost * NumDays));
        }
        private void DisplayOutput()
        {
            label4.Text = TotalCost.ToString("C");
            DisplayData = (listBox1.SelectedItem.ToString() + "                       " + listBox2.SelectedItem.ToString() +
                "                       " + TotalCost.ToString("C"));
            listBox3.Items.Add(DisplayData);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItem = "";
            listBox1.SelectedIndex = -1;
            listBox2.SelectedItem = "";
            listBox2.SelectedIndex = -1;
            listBox3.SelectedItem = "";
            listBox3.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItem = "";
            listBox1.SelectedIndex = -1;
            listBox2.SelectedItem = "";
            listBox2.SelectedIndex = -1;
            listBox3.SelectedItem = "";
            listBox3.Items.Clear();
            label4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About to terminate app");
            Application.Exit();
        }
    }
}