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

        public bool PlaceBet(int amount, int hare)
        {
            //Plaats een nieuwe weddenschap en sla het op in de variable MyBet.
            //Retourneer een true als de gokker genoeg geld heeft om te wedden
            if (amount <= cash)
            {
                cash -= amount;
                MyBet.Amount = amount;
                MyBet.hare = hare;
                return true;
            }
            else
                return false;
        }

        public void ClearBet()
        { 
            //Maak de weddenschap leeg
            MyBet.Amount = 0;
            MyBet.hare = 0;
        }

        public void Collect(int Winner)
        {
            cash *= 2;
        }

        public int GetCash()
        {
            return cash;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // lbl_Player1Cash
            // 
            this.lbl_Player1Cash.Location = new System.Drawing.Point(72, 14);
            this.lbl_Player1Cash.Size = new System.Drawing.Size(67, 26);
            this.lbl_Player1Cash.Text = "€1337";
            // 
            // lbl_Player4Cash
            // 
            this.lbl_Player4Cash.Location = new System.Drawing.Point(72, 87);
            this.lbl_Player4Cash.Size = new System.Drawing.Size(67, 26);
            this.lbl_Player4Cash.Text = "€4321";
            // 
            // lbl_Player3Cash
            // 
            this.lbl_Player3Cash.Location = new System.Drawing.Point(72, 63);
            this.lbl_Player3Cash.Size = new System.Drawing.Size(67, 26);
            this.lbl_Player3Cash.Text = "€9001";
            // 
            // lbl_Player2Cash
            // 
            this.lbl_Player2Cash.Location = new System.Drawing.Point(72, 39);
            this.lbl_Player2Cash.Size = new System.Drawing.Size(56, 26);
            this.lbl_Player2Cash.Text = "€123";
            // 
            // Guy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1002, 617);
            this.Name = "Guy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
