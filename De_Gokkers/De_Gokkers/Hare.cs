using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace De_Gokkers
{
    class Hare : Main
    {
        public int StartingPosition = 931;
        public int RaceTrackLength = 91;
        public string Name;
        public int Location = 0;
        public int distance;
        public string winner;
        public PictureBox MyPictureBox = null;

        public Hare(PictureBox pictureBox, int raceTrackLength, string name)
        {
            MyPictureBox = pictureBox;
            RaceTrackLength = raceTrackLength;
            Name = name;
        }
        public string GetWinner()
        {
            return winner;
        }
        public bool Run()
        {
            //Random iets = new Random();
            //int distance = iets.Next(5, 10);
            Random rand = new Random();
            int MaxRandom = 961;
            int intRandomNumber = rand.Next(1, MaxRandom); // Grotere getallen range om het meer accurate te laten verlopen. 
            //  De loop telt tot 5
            for (int i = 0; i < 5; i++)
            {
                if (intRandomNumber > ((MaxRandom / 5) * i)) // De if checkt of random number groter is dan een (nummer/5)
                {
                    distance = i; // Pakt het getal van hoevaak het geloopt is aka 1 tm 5
                    if (Location > 50)
                    {
                        winner = Name;
                        MessageBox.Show(winner);
                    }
                }
            }



            if (MyPictureBox.Location.X > RaceTrackLength)
            {
                return true;
            }
            else
            {
                //  Point NewPos = new Point(MyPictureBox.Location.X - distance, MyPictureBox.Location.Y);
                Point NewPos = new Point(MyPictureBox.Location.X - distance, MyPictureBox.Location.Y);
                MyPictureBox.Location = NewPos;
                MyPictureBox.Refresh();
                return false;
            }
        }

        public void TakeStartingPosition(int Y)
        {
            Point StartPos = new Point(931, Y);
            MyPictureBox.Location = StartPos;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetLoc()
        {
            return MyPictureBox.Location.X;
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
            this.lbl_Player1Cash.Size = new System.Drawing.Size(50, 26);
            this.lbl_Player1Cash.Text = "€ 10";
            // 
            // lbl_Player3Cash
            // 
            this.lbl_Player3Cash.Size = new System.Drawing.Size(50, 26);
            this.lbl_Player3Cash.Text = "€ 10";
            // 
            // lbl_Player2Cash
            // 
            this.lbl_Player2Cash.Size = new System.Drawing.Size(50, 26);
            this.lbl_Player2Cash.Text = "€ 10";
            // 
            // Hare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1002, 617);
            this.Name = "Hare";
            this.Load += new System.EventHandler(this.Hare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Hare2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Hare3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Hare4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Hare1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_AmountMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Hare_Load(object sender, EventArgs e)
        {

        }
    }
}
