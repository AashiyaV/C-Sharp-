using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_10_Lottery_Ticket_Object___Aashiya_Vahora
{
    public partial class Form1 : Form
    {//Coded by Aashiya Vahora
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GetMyTicket();
        }
        private void GetMyTicket()
        {
            Lottery_Ticket myTicket = new Lottery_Ticket();
            int[] lotteryNumbers = new int[5];

            for (int i = 0; i < lotteryNumbers.Length; i++)
            {
                myTicket.Pick();
                lotteryNumbers[i] = myTicket.GetNum();
            }
            Array.Sort(lotteryNumbers);
            label1.Text = lotteryNumbers[0].ToString();
            label2.Text = lotteryNumbers[1].ToString();
            label3.Text = lotteryNumbers[2].ToString();
            label4.Text = lotteryNumbers[3].ToString();
            label5.Text = lotteryNumbers[4].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetWinningNumbers();
        }
        private void GetWinningNumbers()
        {
            Lottery_Ticket winningTicket = new Lottery_Ticket();
            int[] lotteryNumbers = new int[5];
            for (int i = 0;  i < lotteryNumbers.Length; i++)
            {
                winningTicket.Pick();
                lotteryNumbers[i] = winningTicket.GetNum();
            }
            Array.Sort(lotteryNumbers);
            label6.Text = lotteryNumbers[0].ToString();
            label7.Text = lotteryNumbers[1].ToString();
            label8.Text = lotteryNumbers[2].ToString();
            label9.Text = lotteryNumbers[3].ToString();
            label10.Text = lotteryNumbers[4].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
