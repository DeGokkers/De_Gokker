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
        public int RaceTrackLength = 91;
        public int Location;
        public PictureBox MyPictureBox = null;
        public Random Randomizer;

        public bool Run()
        {
            int MoveSpaces = Randomizer.Next(1, 4);

            MyPictureBox.Left = StartingPosition + Location;

            
            if (Location >= RaceTrackLength)
            {
                return true;
            }
            else
            {
                Location += MoveSpaces;
                return false;
            }
        }

        public void TakeStartingPosition()
        {

        }
    }
}
