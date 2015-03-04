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
        protected string select = "Klik hier om een haas te selecteren";
        Hare[] Hares = new Hare[4];
        Guy[] Players = new Guy[3];
        string winner;
        string player1Hare;
        string player2Hare;
        string player3Hare;

        int player1Bet;
        int player2Bet;
        int player3Bet;

        int playerCash;

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
            slct_Hare.Enabled = false;
            btn_Run.Enabled = false;
            btn_Bet.Enabled = false;
            num_AmountMoney.Enabled = false;
            list_Announce.Enabled = false;

            AddHares();
            for (int i = 0; i < 4; i++)
            {
                slct_Hare.Items.Add(Hares[i].Name);
            }

        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            btn_Bet.Text = "Reset!";
            Lock(true);
            AddHares();
            foreach (Hare hare in Hares)
            {
                for (int i = 2; (0 < Hares[0].GetLoc() && 0 < Hares[1].GetLoc() && 0 < Hares[2].GetLoc() && 0 < Hares[3].GetLoc()); )
                {
                    if (0 < Hares[0].GetLoc() && 0 < Hares[1].GetLoc() && 0 < Hares[2].GetLoc() && 0 < Hares[3].GetLoc())
                    {
                        Hares[0].Run();
                        Hares[1].Run();
                        Hares[2].Run();
                        Hares[3].Run();
                        xHare1.Text = Hares[0].MyPictureBox.Location.X.ToString();
                        xHare2.Text = Hares[1].MyPictureBox.Location.X.ToString();
                        xHare3.Text = Hares[2].MyPictureBox.Location.X.ToString();
                        xHare4.Text = Hares[3].MyPictureBox.Location.X.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Test");
                    }
                }
                btn_Bet.Enabled = true;
            }
            if (Hares[0].MyPictureBox.Location.X <= 0)
            {
                winner = "Speedy (Zwart)";
                MessageBox.Show("1 is de winnaar");
            }
            if (Hares[1].MyPictureBox.Location.X <= 0)
            {
                winner = "Slowy (Rood)";
                MessageBox.Show("2 is de winnaar");
            }
            if (Hares[2].MyPictureBox.Location.X <= 0)
            {
                winner = "Turtle (Blauw)";
                MessageBox.Show("3 is de winnaar");
            }
            if (Hares[3].MyPictureBox.Location.X <= 0)
            {
                winner = "Flying (Groen)";
                MessageBox.Show("4 is de winnaar");
            }

            if (player1Hare == winner)
            {
                Players[0].Collect(player1Bet);
                lbl_Player1Cash.Text = Players[0].UpdateLabels();
            }
            if (player2Hare == winner)
            {
                Players[1].Collect(player2Bet);
                lbl_Player2Cash.Text = Players[1].UpdateLabels();
            }
            if (player3Hare == winner)
            {
                Players[2].Collect(player3Bet);
                lbl_Player3Cash.Text = Players[2].UpdateLabels();
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
            Players[0] = new Guy("Fer", 10);
            Players[1] = new Guy("Lidy", 10);
            Players[2] = new Guy("Sietse", 10); 
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
                slct_Hare.Enabled = false;
                btn_Run.Enabled = false;
                btn_Bet.Enabled = false;
                num_AmountMoney.Enabled = false;
                list_Announce.Enabled = false;
                rdio_Player1.Checked = false;
                rdio_Player2.Checked = false;
                rdio_Player3.Checked = false;
            }
            else
            {
                AddPlayers();

                if (rdio_Player1.Checked == true)
                {
                    playerCash = Players[0].GetCash();

                    if (slct_Hare.Text == select)
                    {
                        list_Announce.Items.Add("Selecteer een Haas!");
                    }
                    else if (playerCash >= betAmount)
                    {
                        Bet Bet = new Bet(rdio_Player1.Text, Convert.ToInt32(num_AmountMoney.Value), slct_Hare.SelectedItem.ToString());
                        player1Hare = slct_Hare.SelectedItem.ToString();
                        player1Bet = Convert.ToInt32(num_AmountMoney.Value);
                        list_Announce.Items.Add(Bet.GetDescription());
                       
                        rdio_Player1.Enabled = false;
                        rdio_Player1.Checked = false;
                        btn_Bet.Enabled = false;
                        num_AmountMoney.Enabled = false;
                        slct_Hare.Enabled = false;

                        Players[0].PlaceBet(Convert.ToInt32(num_AmountMoney.Value));
                        lbl_Player1Cash.Text = Players[0].UpdateLabels();
                    }
                    else
                    {
                        list_Announce.Items.Add(rdio_Player1.Text + " heeft niet genoeg geld om dit bedrag in te zetten.");
                    }
                }

                if (rdio_Player2.Checked == true)
                {
                    playerCash = Players[1].GetCash();

                    if (slct_Hare.Text == select)
                    {
                        list_Announce.Items.Add("Selecteer een Haas!");
                    }
                    else if (playerCash >= betAmount)
                    {
                        Bet Bet = new Bet(rdio_Player2.Text, Convert.ToInt32(num_AmountMoney.Value), slct_Hare.SelectedItem.ToString());
                        player2Hare = slct_Hare.SelectedItem.ToString();
                        player2Bet = Convert.ToInt32(num_AmountMoney.Value);
                        list_Announce.Items.Add(Bet.GetDescription());
                        
                        rdio_Player2.Enabled = false;
                        rdio_Player2.Checked = false;
                        btn_Bet.Enabled = false;
                        num_AmountMoney.Enabled = false;
                        slct_Hare.Enabled = false;

                        Players[1].PlaceBet(Convert.ToInt32(num_AmountMoney.Value));
                        lbl_Player2Cash.Text = Players[1].UpdateLabels();
                    }
                    else
                    {
                        list_Announce.Items.Add(rdio_Player2.Text + " heeft niet genoeg geld om dit bedrag in te zetten.");
                    }
                }

                if (rdio_Player3.Checked == true)
                {
                    playerCash = Players[2].GetCash();

                    if (slct_Hare.Text == select)
                    {
                        list_Announce.Items.Add("Selecteer een Haas!");
                    }
                    else if (playerCash >= betAmount)
                    {
                        Bet Bet = new Bet(rdio_Player3.Text, Convert.ToInt32(num_AmountMoney.Value), slct_Hare.Text);
                        player3Hare = slct_Hare.SelectedItem.ToString();
                        player3Bet = Convert.ToInt32(num_AmountMoney.Value);
                        list_Announce.Items.Add(Bet.GetDescription());
                        
                        rdio_Player3.Enabled = false;
                        rdio_Player3.Checked = false;
                        btn_Bet.Enabled = false;
                        num_AmountMoney.Enabled = false;
                        slct_Hare.Enabled = false;

                        Players[2].PlaceBet(Convert.ToInt32(num_AmountMoney.Value));
                        lbl_Player3Cash.Text = Players[2].UpdateLabels();
                    }
                    else
                    {
                        list_Announce.Items.Add(rdio_Player3.Text + " heeft niet genoeg geld om dit bedrag in te zetten.");
                    }
                }
                slct_Hare.Text = select;
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

        private void rdio_Player1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdio_Player1.Checked == true)
            {
                slct_Hare.Text = select;
                slct_Hare.Enabled = true;
                btn_Run.Enabled = true;
                btn_Bet.Enabled = true;
                num_AmountMoney.Enabled = true;
                list_Announce.Enabled = true;
            }
        }

        private void rdio_Player2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdio_Player2.Checked == true)
            {
                slct_Hare.Text = select;
                slct_Hare.Enabled = true;
                btn_Run.Enabled = true;
                btn_Bet.Enabled = true;
                num_AmountMoney.Enabled = true;
                list_Announce.Enabled = true;
            }
        }

        private void rdio_Player3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdio_Player3.Checked == true)
            {
                slct_Hare.Text = select;
                slct_Hare.Enabled = true;
                btn_Run.Enabled = true;
                btn_Bet.Enabled = true;
                num_AmountMoney.Enabled = true;
                list_Announce.Enabled = true;
            }
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetAllesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}