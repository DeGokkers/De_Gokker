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
        public PictureBox MyPictureBox = null;
        
        public Hare()
        {
            MyPictureBox = null;
            RaceTrackLength = 1031;
        }
        public Hare(PictureBox pictureBox, int raceTrackLength, string name)
        {
            MyPictureBox = pictureBox;
            RaceTrackLength = raceTrackLength;
            Name = name;
        }
        public bool Run()
        {
            Random iets = new Random();
            int distance = iets.Next(5, 10);

            if (MyPictureBox.Location.X > RaceTrackLength)
            {
                MessageBox.Show("Swag");
                return true;
            }
            else
            {
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
    }
}
