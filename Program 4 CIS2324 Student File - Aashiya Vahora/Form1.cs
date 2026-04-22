using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Program_4_CIS2324_Student_File___Aashiya_Vahora
{
    public partial class Form1 : Form
    {
        //Variable Declaration
        string StudentName = "", Average = "";
        int Score1 = 0, Score2 = 0, Score3 = 0;
        double total = 0;
        public Form1()
        {//Coded By Aashiya Vahora
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {//Code behind process button
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader inputfile;
                inputfile = File.OpenText(openFileDialog1.FileName);
                while (!inputfile.EndOfStream)
                {
                    StudentName = inputfile.ReadLine();
                    Score1 = int.Parse(inputfile.ReadLine());
                    Score2 = int.Parse(inputfile.ReadLine());
                    Score3 = int.Parse(inputfile.ReadLine());
                    ComputeLetterGrade();
                    ListRecord();
                }
            }
        }
        private void ComputeLetterGrade()
        {
            total = (Score1 + Score2 + Score3) / 3;
            if (total >= 90)
                Average = "A";
            else if (total >= 80)
                Average = "B";
            else if (total >= 70)
                Average = "C";
            else if (total >= 60)
                Average = "D";
            else Average = "F";
        }
        private void ListRecord()
        {
            listBox1.Items.Add(StudentName + "\t" +
                                  "   " + total.ToString("N2") + "\t" +
                                  "   " + Average);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About to terminate app");
            Application.Exit();
        }
    }
}
