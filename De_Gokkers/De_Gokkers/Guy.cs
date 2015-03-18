using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_Gokkers
{
    class Guy : Main
    {
        protected string name;
        protected int cash;
        public Bet MyBet;
        public RadioButton MyRadiobutton;
        public Label MyLabel;

        public Guy(string name, int cash)
        {
            this.name = name;
            this.cash = cash;
        }

        public string UpdateLabels()
        {
            //Verander mijn label in de omschrijving van mijn weddenschap.
            //Verander de label op mijn radioknop zodat deze mijn saldo laat zien.
            //(Bijv. "Lidy heeft 43 euro".)
            string update = ("€ " + cash);
            return update;
        }

        public bool PlaceBet(int amount)
        {
            if (amount <= cash)
            {
                this.cash -= amount;
                return true;
            }
            else
                return false;
        }
            
        public void ClearBet()
        { 
            //Maak de weddenschap leeg
            MyBet.Amount = 0;
            MyBet.Hare = null;
        }

        public void Collect(int amount)
        {
            cash += (amount * 2);
        }

        public int GetCash()
        {
            return cash;
        }

        public void SetCash(int amount)
        {
            this.cash = -amount;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
