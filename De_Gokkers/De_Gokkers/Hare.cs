using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace De_Gokkers
{
    class Hare
    {
        public int StartingPosition;
        public int RaceTrackLength = ;
        public PictureBox MyPictureBox = null;
        public int Location = 931;
        public Random Randomizer;

        public bool Run()
        {
            int moveSpaces = Randomizer.Next(1, 4);

            MyPictureBox.Left = StartingPosition + Location;

            
            if (Location >= RaceTrackLength)
            {
                return true;
            }
            else
            {
                Location += moveSpaces;
                return false;
            }
        }

        public void TakeStartingPosition()
        {

        }
    }
}
