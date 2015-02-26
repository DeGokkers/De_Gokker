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
      //      Bettor[3] = new Guy("Peter", 10);


            lbl_Player1Cash.Text = Bettor[0].UpdateLabels();
            lbl_Player2Cash.Text = Bettor[1].UpdateLabels();
            lbl_Player3Cash.Text = Bettor[2].UpdateLabels();
     //       lbl_Player4Cash.Text = Bettor[3].UpdateLabels();
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            Lock(true);
            AddHareToList();
            foreach (Hare hare in Hares)
            {
                Hares[0].Run();
                Hares[1].Run();
                Hares[2].Run();
                Hares[3].Run();
            }
            Lock(false);
        }
        void AddHareToList()
        { 
            Hares[0] = new Hare(img_Hare1, racetracklength);
            Hares[1] = new Hare(img_Hare2, racetracklength);
            Hares[2] = new Hare(img_Hare3, racetracklength);
            Hares[3] = new Hare(img_Hare4, racetracklength);
        }

        private void resetSpelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hares[0].TakeStartingPosition(91);
            Hares[1].TakeStartingPosition(176);
            Hares[2].TakeStartingPosition(261);
            Hares[3].TakeStartingPosition(346);
        }
        private void Lock(bool Locked)
        {
            if (Locked = true)
            {
                num_AmountMoney.Enabled = false;
                slct_Hare.Enabled = false;
                rdio_Player1.Enabled = false;
                rdio_Player2.Enabled = false;
                rdio_Player3.Enabled = false;
    //            rdio_Player4.Enabled = false;
                btn_Run.Enabled = false;    
            }
            if (Locked = false)
            {
                num_AmountMoney.Enabled = true;
                slct_Hare.Enabled = true;
                rdio_Player1.Enabled = true;
                rdio_Player2.Enabled = true;
                rdio_Player3.Enabled = true;
             //   rdio_Player4.Enabled = true;
                btn_Run.Enabled = true;    
            }
        }

        private void btn_Bet_Click(object sender, EventArgs e)
        {
         
        }
    }
}