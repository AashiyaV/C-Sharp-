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

namespace Program_7_IO_Token___Aashiya_Vahora
{
    public partial class Form1 : Form
    {//coded by Aashiya Vahora
        public Form1()
        {
            InitializeComponent();
        }//variable declaration
        StreamReader inputFile; StreamWriter outputFile;
        string letterGrade = "";
        double avg = 0;
        int seqNumber = 1;
        string LastName = "", FirstName = "";
        string[] InputRecord = new string[7];
        int[] testScores = new int[7];
        int[] scoresUsed = new int[5];

        private void button1_Click(object sender, EventArgs e)
        {
            InputGradeFiles();
        }
        private void InputGradeFiles()
        {
            outputFile = File.CreateText("StudentGradesStatistics.txt");
            outputFile.WriteLine("Sequence#,LastName,FirstName,SC#1,SC#2,SC#3,SC#4,SC#5,MeanScore,LowestScore,LetterGrade");

            if
                (openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);
                while (!inputFile.EndOfStream)
                {
                    InputDataIntoInputRecordArray();
                    InputTestScoresIntoTestScores();
                    DropHighestandLowestGrade();
                    FindLetterGrade();
                    ListboxOutputDisplay();
                    OutputRecordToSaveFile();
                    seqNumber++;
                }
                inputFile.Close();
                outputFile.Close();

            }
        }
        private void InputDataIntoInputRecordArray()
        {
            InputRecord = inputFile.ReadLine().Split(',');
            LastName = InputRecord[0].ToString();
            FirstName = InputRecord[1].ToString();
        }
        private void InputTestScoresIntoTestScores()
        {
            for (int j = 0; j < 7; j++)
            {
                testScores[j] = int.Parse(InputRecord[j + 2]);
            }
        }
        private void DropHighestandLowestGrade()
        {
            Array.Sort(testScores);
            for (int j = 0; j < 5; j++)
            {
                scoresUsed[j] = testScores[j + 1];
            }
        }
        private void FindLetterGrade()
        {
            avg = scoresUsed.Average();
            if (avg >= 90)
                letterGrade = "A";
            else if (avg >= 80)
                letterGrade = "B";
            else if (avg >= 70)
                letterGrade = "C";
            else if (avg >= 60)
                letterGrade = "D";
            else if (avg <= 60)
                letterGrade = "F";
        }
        private string ListboxOutput()
        {
            string line = (seqNumber + "\t" + LastName + "\t" + FirstName + "\t" +
                scoresUsed[0].ToString() + "\t" +
                scoresUsed[1].ToString() + "\t" +
                scoresUsed[2].ToString() + "\t" +
                scoresUsed[3].ToString() + "\t" +
                scoresUsed[4].ToString() + "\t" +
                avg.ToString() + "\t" +
                scoresUsed.Min() + "\t" +
                scoresUsed.Max() + "\t" +
                letterGrade);
            return line;
        }
        private void ListboxOutputDisplay()
        {
            listBox1.Items.Add(ListboxOutput());
        }
        private string OutputRecord()
        {
            string outputLine = (seqNumber + "\t" + LastName + "\t" + FirstName + "\t" +
                scoresUsed[0].ToString() + "\t" +
                scoresUsed[1].ToString() + "\t" +
                scoresUsed[2].ToString() + "\t" +
                scoresUsed[3].ToString() + "\t" +
                scoresUsed[4].ToString() + "\t" +
                avg.ToString() + "\t" +
                scoresUsed.Min() + "\t" +
                scoresUsed.Max() + "\t" +
                letterGrade);

            return outputLine;
        }
        private void OutputRecordToSaveFile()
        {
            outputFile.WriteLine(OutputRecord());
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
