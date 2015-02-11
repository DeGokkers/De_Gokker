using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace De_Gokkers
{
    class Greyhound
    {
        public int RaceTrackLength;
   //     static Form1 test = new Form1();
        public PictureBox MyPictureBox = test.pictureBox1;
        public Random Randomizer;

        public void Run()
        {
            int distance = Randomizer.Next(1, 4);
            MyPictureBox.Location = new Point(MyPictureBox.Location.X + distance, MyPictureBox.Location.Y);
        }

        public void TakeStartingPosition()
        {

        }
    }
}
