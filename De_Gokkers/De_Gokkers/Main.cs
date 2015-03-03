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
            btn_Bet.Text = "Reset!";
            Lock(true);
            AddHares();
            foreach (Hare hare in Hares)
            {
                for (int i = 2; (3 < Hares[0].GetLoc() && 1 < Hares[1].GetLoc() && 0 < Hares[2].GetLoc() && -1 < Hares[3].GetLoc()); )
                {
                    Hares[0].Run();
                    Hares[1].Run();
                    Hares[2].Run();
                    Hares[3].Run();
                }
            }
        }
        void AddHares()
        {
            Hares[0] = new Hare(img_Hare1, 1031, "Speedy (Zwart)");
            Hares[1] = new Hare(img_Hare2, 1031, "Slowy (Rood)");
            Hares[2] = new Hare(img_Hare3, 1031, "Turtle (Blauw)");
            Hares[3] = new Hare(img_Hare4, 1031, "Flying (Groen)");
        }

        void AddPlayers()
        {
            Players[0] = new Guy("Sietse", 10);
            Players[1] = new Guy("Fer", 10);
            Players[2] = new Guy("Lidy", 10); 
        }

        private void btn_Bet_Click(object sender, EventArgs e)
        {
            int betAmount = Convert.ToInt32(num_AmountMoney.Value);
            if (btn_Bet.Text == "Reset!")
            {
                Lock(false);
                btn_Bet.Text = "Wed!";
                Hares[0].TakeStartingPosition(91);
                Hares[1].TakeStartingPosition(176);
                Hares[2].TakeStartingPosition(261);
                Hares[3].TakeStartingPosition(346);
                list_Announce.Items.Clear();
                rdio_Player1.Enabled = true;
                rdio_Player1.Enabled = true;
                rdio_Player1.Enabled = true;
            }
            else
            {
                AddPlayers();
                if (rdio_Player1.Checked == true)
                {
                    int playerCash = Players[0].GetCash();
                    if (playerCash >= betAmount)
                    {
                        Bet Bet = new Bet(rdio_Player1.Text, Convert.ToInt32(num_AmountMoney.Value), slct_Hare.Text);
                        list_Announce.Items.Add(Bet.GetDescription());
                        rdio_Player1.Enabled = false;
                        rdio_Player1.Checked = false;
                        Players[0].PlaceBet(Convert.ToInt32(num_AmountMoney.Value));
                        lbl_Player1Cash.Text = Players[0].UpdateLabels();
                    }
                    else
                    {
                        MessageBox.Show("{0} heeft niet genoeg geld om dit bedrag in te zetten.", rdio_Player1.Text);
                    }
                }
                if (rdio_Player2.Checked == true)
                {
                    int playerCash = Players[1].GetCash();
                    if (playerCash >= betAmount)
                    {
                        Bet Bet = new Bet(rdio_Player2.Text, Convert.ToInt32(num_AmountMoney.Value), slct_Hare.Text);
                        list_Announce.Items.Add(Bet.GetDescription());
                        rdio_Player2.Enabled = false;
                        rdio_Player2.Checked = false;
                        Players[1].PlaceBet(Convert.ToInt32(num_AmountMoney.Value));
                        lbl_Player1Cash.Text = Players[1].UpdateLabels();
                    }
                    else
                    {
                        MessageBox.Show("{0} heeft niet genoeg geld om dit bedrag in te zetten.", rdio_Player2.Text);
                    }
                }
                if (rdio_Player3.Checked == true)
                {
                    int playerCash = Players[2].GetCash();
                    if (playerCash >= betAmount)
                    {
                        Bet Bet = new Bet(rdio_Player3.Text, Convert.ToInt32(num_AmountMoney.Value), slct_Hare.Text);
                        list_Announce.Items.Add(Bet.GetDescription());
                        rdio_Player1.Enabled = false;
                        rdio_Player1.Checked = false;
                        Players[2].PlaceBet(Convert.ToInt32(num_AmountMoney.Value));
                        lbl_Player3Cash.Text = Players[2].UpdateLabels();
                    }
                    else
                    {
                        MessageBox.Show("{0} heeft niet genoeg geld om dit bedrag in te zetten.", rdio_Player3.Text);
                    }
                }
            }
            
        }

        private void Lock(bool Locked)
        {
            if (Locked == true)
            {
                num_AmountMoney.Enabled = false;
                slct_Hare.Enabled = false;
                rdio_Player1.Enabled = false;
                rdio_Player2.Enabled = false;
                rdio_Player3.Enabled = false;
                btn_Run.Enabled = false;
            }
            if (Locked == false)
            {
                num_AmountMoney.Enabled = true;
                slct_Hare.Enabled = true;
                rdio_Player1.Enabled = true;
                rdio_Player2.Enabled = true;
                rdio_Player3.Enabled = true;
                btn_Run.Enabled = true;
            }
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}