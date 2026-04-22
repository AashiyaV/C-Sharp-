using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_10_Lottery_Ticket_Object___Aashiya_Vahora
{
    class Lottery_Ticket
    {
        private int pickedNum;
        Random rand = new Random();
        public Lottery_Ticket()
        {
            pickedNum = 0;
        }
        public void Pick()
        {
            pickedNum = rand.Next(100);
        }
        public int GetNum()
        {
            return pickedNum;
        }
    }
}
