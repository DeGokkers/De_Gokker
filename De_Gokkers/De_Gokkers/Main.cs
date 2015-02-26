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

        int racetracklength = 100;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Guy[] Bettor = new Guy[4];
            Bettor[0] = new Guy("Sietse", 10);
            Bettor[1] = new Guy("Fer", 10);
            Bettor[2] = new Guy("Lidy", 10);
            Bettor[3] = new Guy("Peter", 10);


            lbl_Player1Cash.Text = Bettor[0].UpdateLabels();
            lbl_Player2Cash.Text = Bettor[1].UpdateLabels();
            lbl_Player3Cash.Text = Bettor[2].UpdateLabels();
            lbl_Player4Cash.Text = Bettor[3].UpdateLabels();

            AddHareToList();
            for (int i = 0; i < 4; i++)
            {
                slct_Hare.Items.Add(Hares[i].GetName());
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            AddHareToList();
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
            
        }
        void AddHareToList()
        {
            Hares[0] = new Hare(img_Hare1, 1031, "Speedy");
            Hares[1] = new Hare(img_Hare2, 1031, "Slowy");
            Hares[2] = new Hare(img_Hare3, 1031, "Turtle");
            Hares[3] = new Hare(img_Hare4, 1031, "Flying");
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