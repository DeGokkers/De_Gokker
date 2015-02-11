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

        public void UpdateLabels()
        {

            Main._Main.update("Text test");
        }

        public bool PlaceBet(decimal amount, int dog)
        {
            amount = Main._Main.amount();
            return true;
        }

        public void ClearBet()
        { 
            
        }

        public void Collect(int Winner)
        { 
        
        }
    }
}
