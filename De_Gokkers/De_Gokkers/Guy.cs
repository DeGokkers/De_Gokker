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
            string update = (name + ": €" + cash);
            return update;
        }

        public bool PlaceBet(decimal amount, int dog)
        {
            //Plaats een nieuwe weddenschap en sla het op in de variable MyBet.
            //Retourneer een true als de gokker genoeg geld heeft om te wedden
            MyBet.GetDescription();
            return true;
        }

        public void ClearBet()
        { 
            //Maak de weddenschap leeg
            
        }

        public void Collect(int Winner)
        { 
            //Betaal mijn weddenschap uit.
            //Maak mijn weddenschap leeg.
            //Werk mijn labels bij.

        }
    }
}
