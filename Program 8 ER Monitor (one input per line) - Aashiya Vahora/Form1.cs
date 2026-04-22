using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_8_ER_Monitor__one_input_per_line____Aashiya_Vahora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//variable declaration
        int[] SysPressure = new int[5];
        int[] DiaPressure = new int[5];
        string[] DocIDN = new string[] { "D.Abrams MD", "D.Jarvic MD", "T.Panos MD" };
        int DocID = 0;
        string PatientName = "", DocName = "", Status = "", inline = "";
        double SysAvg, DiaAvg;
        private void button1_Click(object sender, EventArgs e)
        {
            ReadFile();
        }
        private void ReadFile()
        {
            StreamReader inputFile;
            inputFile = File.OpenText("MorePatients.txt");
            while (!inputFile.EndOfStream)
            {
                inline = inputFile.ReadLine();
                string[] data = inline.Split(',');
                PatientName = data[0];

                int count = 1;
                for (int i = 0; i < 5; i++)
                {
                    SysPressure[i] = int.Parse(data[count]);
                    DiaPressure[i] = int.Parse(data[count + 1]);
                    count += 2;
                }

                DocID = int.Parse(data[11]);

                PressureAvg();
                PatientStatus();
                DoctorN();
                ShowInfo();
            }
        }
        private void PressureAvg()
        {
            SysAvg = SysPressure.Average();
            DiaAvg = DiaPressure.Average();
        }
        private void PatientStatus()
        {
            if (SysAvg <= 90 || SysAvg >= 160 || DiaAvg <= 60 || DiaAvg >= 90)
                Status = "Warning";
            else
                Status = "Normal";
        }
        private void DoctorN()
        {
            DocName = DocIDN[DocID];
        }
        private void ShowInfo()
        {
            listBox1.Items.Add(PatientName + "\t" + "\t" + SysAvg + "\t" + "\t" + DiaAvg + "\t" + "\t" + Status + "\t" + "\t" + DocName);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
