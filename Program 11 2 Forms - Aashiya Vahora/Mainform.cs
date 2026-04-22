using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_11_2_Forms___Aashiya_Vahora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 mealplans = new Form2();
        int DRIndex, DRAmount, TotalAmount;
        private void button1_Click(object sender, EventArgs e)
        {
            GetDRCost();
            DisplayDRCost();
            
        }
        private void GetDRCost()
        {
            DRIndex = listBox1.SelectedIndex;
            if (DRIndex == 0)
                DRAmount = 1500;
            else if (DRIndex == 1)
                DRAmount = 1600;
            else if (DRIndex == 2)
                DRAmount = 1200;
            else if (DRIndex == 3)
                DRAmount = 1800;
        }
        private void DisplayDRCost()
        {
            DormitoryLabel.Text = DRAmount.ToString("c");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GetMealPlan();
            DisplayMealPlan();
            Totals();
        }
        private void GetMealPlan()
        {
            Form2 mealplans = new Form2();
            mealplans.ShowDialog();
        }
        private void DisplayMealPlan()
        {
           MealPlanLabel.Text = Form2.MealPlanAmount.ToString("c");
        }
        private void Totals()
        {
            TotalAmount = Form2.MealPlanAmount + DRAmount;
            TotalLabel.Text = TotalAmount.ToString("c");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItem = "";
            listBox1.SelectedIndex = -1;
            mealplans.listBox1.SelectedIndex = -1;
            mealplans.listBox1.SelectedItem = "";
            DormitoryLabel.Text = "";
            MealPlanLabel.Text = "";
            TotalLabel.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
