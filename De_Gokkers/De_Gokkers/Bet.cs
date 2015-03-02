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

        public string Hare;
        public string hare;
        public Guy Bettor;

        public int Add_Substract = 0;
        public int AmountOfBettors = 3;
        public int[] PlacedBets;
        public string Name;

        public Bet(string name, int amount, string hare)
        {
            Name = name;
            Amount = amount;
            Hare = hare;
        }

        public string[] OnHare;
        public string GetDescription()
        {
            //Retourneer een string die aangeeft wie de weddenschap heeft gedaan,
            //voor welk bedrag er is gewed en op welke hond er is gewed.
            //Bijv. “Sietse wedt 8 euro op hond 4”.
            //Als het bedrag 0 is, is er geen weddenschap geplaatst.
            //De string die dan geretourneerd wordt is bijv.
            //“Sietse heeft geen weddenschap geplaatst.”)

            if (Amount >= 5 & Amount <= 15)
            {
                string line = Bettor.Name + "Heeft €" + Amount + "gewed op haas: " + hare;
                switch (Bettor.Name)
                {
                    case "Fer":
                        PlaceBet(1, Hare, Amount);
                        break;
                    case "Lidy":
                        PlaceBet(2, Hare, Amount);
                        break;
                    case "Sietse":
                        PlaceBet(3, Hare, Amount);
                        break;
                }
                return line;
            }
            else
            {
                string line = Name + " heeft geen geldig bedrag ingevoerd, het bedrag moet tussen 5 en 15 euro liggen";
                MessageBox.Show(line);
                return line;
            }
        }
        public int PayOut(int Winner)
        {
            PlacedBets[Winner] = PlacedBets[Winner] * 2; ;
            return Winner;
        }
        // PlaceBet(1 , "Speedy", 15)
        public void PlaceBet(int Bettor, string strngHare, int amount)
        {
            PlacedBets = new int[AmountOfBettors];
            PlacedBets[Bettor] = Amount;
            OnHare[Bettor] = strngHare;


        }

    }
}
