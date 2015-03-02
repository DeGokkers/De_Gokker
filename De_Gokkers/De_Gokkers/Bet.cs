using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_Gokkers
{
    class Bet
    {
        public int Amount;
        public int hare;
        public int Add_Substract = 0;
        public int AmountOfBettors = 3;
        public int[] PlacedBets;
        public string Name;

        public Bet(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }


        public string GetDescription()
        {
            //Retourneer een string die aangeeft wie de weddenschap heeft gedaan,
            //voor welk bedrag er is gewed en op welke hond er is gewed.
            //Bijv. “Sietse wedt 8 euro op hond 4”.
            //Als het bedrag 0 is, is er geen weddenschap geplaatst.
            //De string die dan geretourneerd wordt is bijv.
            //“Sietse heeft geen weddenschap geplaatst.”)

            if (Amount > 5 & Amount < 15)
            {
                string line = Name + "heeft " + Amount + "gewed op haas: " + hare;
                switch (Name)
                {
                    case "Fer":
                        PlaceBet(1);
                        break;
                    case "Lidy":
                        PlaceBet(2);
                        break;
                    case "Sietse":
                        PlaceBet(3);
                        break;
                }
                return line;
            }
            else
            {
                string line = Name + "heeft geen geldig bedrag ingevoerd, het bedrag moet tussen 5 en 15 euro liggen";
                MessageBox.Show(line);
                return line;
            }
        }
        public int PayOut(int Winner)
        {
            PlacedBets[Winner] = PlacedBets[Winner] * 2;
            return Winner;
        }
        public void PlaceBet(int Bettor)
        {   
            PlacedBets = new int[AmountOfBettors];
            PlacedBets[Bettor] = Amount;
        }

    }
}
