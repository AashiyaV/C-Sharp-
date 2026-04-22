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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int MealPlanIndex;
        public static int MealPlanAmount;
        private void button1_Click(object sender, EventArgs e)
        {
            GetMPAmount();
        }
        private void GetMPAmount()
        {
            MealPlanIndex = listBox1.SelectedIndex;
            if (MealPlanIndex == 0)
                MealPlanAmount = 560;
            else if (MealPlanIndex == 1)
                MealPlanAmount = 1095;
            else if (MealPlanIndex == 2)
                MealPlanAmount = 1500;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
