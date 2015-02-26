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
        public int Location = 0;
        public PictureBox MyPictureBox = null;
        public Random Randomizer;
        
        public Hare()
        {
            MyPictureBox = null;
            RaceTrackLength = 100;
        }
        public Hare(PictureBox pictureBox, int raceTrackLength)
        {
            MyPictureBox = pictureBox;
            RaceTrackLength = raceTrackLength;
        }
        public bool Run()
        {
            if (Location == 0)
            {
                MyPictureBox.Left = StartingPosition + Location;
            }
            else if(Location != 0)
            {
                MyPictureBox.Left = MyPictureBox.Left + Location;
            }
            else
            {
                MessageBox.Show("Huh");
            }
            System.Threading.Thread.Sleep(10);
            Location = MyPictureBox.Left;

            if (Location >= RaceTrackLength)
            {
                return true;
            }
            else
            {
                Point NewPos = new Point(MyPictureBox.Location.X + 5, MyPictureBox.Location.Y);
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
    }
}
