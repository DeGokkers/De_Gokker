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

        public Guy()
        {
        }

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
            //Plaats een nieuwe weddenschap en sla het op in de variable MyBet.
            //Retourneer een true als de gokker genoeg geld heeft om te wedden
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

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.img_Hare2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Hare3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Hare4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Hare1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_AmountMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Player1Cash
            // 
            this.lbl_Player1Cash.Location = new System.Drawing.Point(72, 14);
            this.lbl_Player1Cash.Size = new System.Drawing.Size(50, 26);
            this.lbl_Player1Cash.Text = "€ 10";
            // 
            // lbl_Player3Cash
            // 
            this.lbl_Player3Cash.Location = new System.Drawing.Point(72, 63);
            this.lbl_Player3Cash.Size = new System.Drawing.Size(50, 26);
            this.lbl_Player3Cash.Text = "€ 10";
            // 
            // lbl_Player2Cash
            // 
            this.lbl_Player2Cash.Location = new System.Drawing.Point(72, 39);
            this.lbl_Player2Cash.Size = new System.Drawing.Size(50, 26);
            this.lbl_Player2Cash.Text = "€ 10";
            // 
            // Guy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1002, 617);
            this.Name = "Guy";
            this.Load += new System.EventHandler(this.Guy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Hare2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Hare3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Hare4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Hare1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_AmountMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Guy_Load(object sender, EventArgs e)
        {

        }
    }
}
