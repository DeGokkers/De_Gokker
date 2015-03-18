using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

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

            Random rand = new Random();
            int MaxRandom = 961;
            int intRandomNumber = rand.Next(1, MaxRandom); // Grotere getallen range om het meer accurate te laten verlopen. 
            //  De loop telt tot 5
            for (int i = 0; i < 5; i++)
            {
                if (intRandomNumber > ((MaxRandom / 5) * i)) // De if checkt of random number groter is dan een (nummer/5)
                {
                    distance = i; // Pakt het getal van hoevaak het geloopt is aka 1 tm 5
                }
            }

            if (MyPictureBox.Location.X > RaceTrackLength)
            {
                return true;
            }

            else
            {
                MyPictureBox.Left -= distance;
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
    }
}
