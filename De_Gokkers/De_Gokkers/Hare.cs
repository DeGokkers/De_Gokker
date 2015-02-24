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
        public int StartingPosition;
        public int RaceTrackLength = 91;
        public int Location;
        public PictureBox MyPictureBox = null;
        public Random Randomizer;

        public bool Run()
        {
            MyPictureBox = img_Hare1;

            MyPictureBox.Left = StartingPosition + Location;

            
            if (Location >= RaceTrackLength)
            {
                return true;
            }
            else
            {
                Location += 5;
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            
        }
    }
}
