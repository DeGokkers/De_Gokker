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
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadiobutton;
        public Label MyLabel;
        public TextBox textbox;

        public void UpdateLabels()
        {
            //Verander mijn label in de omschrijving van mijn weddenschap.
            //Verander de label op mijn radioknop zodat deze mijn saldo laat zien.
            //(Bijv. "Lidy heeft 43 euro".)
            MyLabel = lbl_Player1Stats;
            string update = (Name + ": €" + Cash);
            MyLabel.Text = update;
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
