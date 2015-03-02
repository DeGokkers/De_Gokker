using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_Gokkers
{
    public partial class Main : Form 
    {

        Hare[] Hares = new Hare[4];
        Guy[] Players = new Guy[4];

        int racetracklength = 100;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            AddPlayers();
            lbl_Player1Cash.Text = Players[0].UpdateLabels();
            lbl_Player2Cash.Text = Players[1].UpdateLabels();
            lbl_Player3Cash.Text = Players[2].UpdateLabels();

            AddHares();
            for (int i = 0; i < 4; i++)
            {
                slct_Hare.Items.Add(Hares[i].GetName());
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            AddHares();
            foreach (Hare hare in Hares)
            {
                for (int i = 0; i < Hares[0].GetLoc(); i++)
                {
                    Hares[0].Run();
                    Hares[1].Run();
                    Hares[2].Run();
                    Hares[3].Run();  
                }
            }
            foreach (Hare hare in Hares)
            {
                for (int e = 0; e < Hares; i++)
                {


                    for (int i = 0; i < 4; i++)
                    {
                        if (i < Hares[i].GetLoc())
                        {
                            Hares[i].Run();

                        }

                    }
                }
            }
            
        }
        void AddHares()
        {
            Hares[0] = new Hare(img_Hare1, 1031, "Speedy");
            Hares[1] = new Hare(img_Hare2, 1031, "Slowy");
            Hares[2] = new Hare(img_Hare3, 1031, "Turtle");
            Hares[3] = new Hare(img_Hare4, 1031, "Flying");
        }

        void AddPlayers()
        {
            Players[0] = new Guy("Sietse", 10);
            Players[1] = new Guy("Fer", 10);
            Players[2] = new Guy("Lidy", 10); 
        }

        private void resetSpelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hares[0].TakeStartingPosition(91);
            Hares[1].TakeStartingPosition(176);
            Hares[2].TakeStartingPosition(261);
            Hares[3].TakeStartingPosition(346);
        }
    }
}