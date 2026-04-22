using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_6._01_Matrix_Transposition___Aashiya_Vahora
{//Coded by Aashiya Vahora
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] arr2d = new int[6, 6] { {3, 25, 62, 13, 9, 8},
                                     {99, 75, 2, 25, 32, 21},
                                     {88, 92, 5, 18, 17 ,33},
                                     {77, 91, 60, 55, 47, 36},
                                     {31, 26, 73, 38, 35, 99},
                                     {5, 97, 83, 76, 58, 22} };
        private void button1_Click(object sender, EventArgs e)
        {
            InputMatrix();
            TransposeMatrix();
            DisplayTransposition();
        }
        private void InputMatrix()
        {
            listBox1.Items.Add(arr2d[0,0] + "\t" + arr2d[0,1] + "\t" + arr2d[0,2] + "\t" + arr2d[0,3] + "\t" + arr2d[0,4] + "\t" + arr2d[0,5]);
            listBox1.Items.Add(arr2d[1,0] + "\t" + arr2d[1,1] + "\t" + arr2d[1,2] + "\t" + arr2d[1,3] + "\t" + arr2d[1,4] + "\t" + arr2d[1,5]);
            listBox1.Items.Add(arr2d[2,0] + "\t" + arr2d[2,1] + "\t" + arr2d[2,2] + "\t" + arr2d[2,3] + "\t" + arr2d[2,4] + "\t" + arr2d[2,5]);
            listBox1.Items.Add(arr2d[3,0] + "\t" + arr2d[3,1] + "\t" + arr2d[3,2] + "\t" + arr2d[3,3] + "\t" + arr2d[3,4] + "\t" + arr2d[3,5]);
            listBox1.Items.Add(arr2d[4,0] + "\t" + arr2d[4,1] + "\t" + arr2d[4,2] + "\t" + arr2d[4,3] + "\t" + arr2d[4,4] + "\t" + arr2d[4,5]);
            listBox1.Items.Add(arr2d[5,0] + "\t" + arr2d[5,1] + "\t" + arr2d[5,2] + "\t" + arr2d[5,3] + "\t" + arr2d[5,4] + "\t" + arr2d[5,5]);
        }
        private void TransposeMatrix()
        {
           
        }
        private void DisplayTransposition()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {//code behind clear button
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {//code behind exit button
            MessageBox.Show("About to terminate app");
            Application.Exit();

        }
    }
}
