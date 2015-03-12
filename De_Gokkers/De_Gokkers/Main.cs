using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace De_Gokkers
{
    public partial class Main : Form
    {
        protected string select = "Klik hier om een haas te selecteren";
        
        Hare[] Hares = new Hare[4];
        Guy[] Players = new Guy[3];
        string winner;
        string[] playerHare = new string[3];
        int[] playerBet = new int[3];
        bool runLock = false;
        System.Media.SoundPlayer Player = new System.Media.SoundPlayer();
        Label[] lbl_PlayerCash = new Label[3];
        


        Image[] Flip1 = new Image[13] { Properties.Resources.Hare1_1, Properties.Resources.Hare1_2, Properties.Resources.Hare1_3, Properties.Resources.Hare1_4, Properties.Resources.Hare1_5, Properties.Resources.Hare1_6, Properties.Resources.Hare1_7, Properties.Resources.Hare1_8, Properties.Resources.Hare1_9, Properties.Resources.Hare1_10, Properties.Resources.Hare1_11, Properties.Resources.Hare1_12, Properties.Resources.Hare1_13};
        Image[] Flip2 = new Image[13] { Properties.Resources.Hare2_1, Properties.Resources.Hare2_2, Properties.Resources.Hare2_3, Properties.Resources.Hare2_4, Properties.Resources.Hare2_5, Properties.Resources.Hare2_6, Properties.Resources.Hare2_7, Properties.Resources.Hare2_8, Properties.Resources.Hare2_9, Properties.Resources.Hare2_10, Properties.Resources.Hare2_11, Properties.Resources.Hare2_12, Properties.Resources.Hare2_13, };
        Image[] Flip3 = new Image[13] { Properties.Resources.Hare3_1, Properties.Resources.Hare3_2, Properties.Resources.Hare3_3, Properties.Resources.Hare3_4, Properties.Resources.Hare3_5, Properties.Resources.Hare3_6, Properties.Resources.Hare3_7, Properties.Resources.Hare3_8, Properties.Resources.Hare3_9, Properties.Resources.Hare3_10, Properties.Resources.Hare3_11, Properties.Resources.Hare3_12, Properties.Resources.Hare3_13, };
        Image[] Flip4 = new Image[13] { Properties.Resources.Hare4_1, Properties.Resources.Hare4_2, Properties.Resources.Hare4_3, Properties.Resources.Hare4_4, Properties.Resources.Hare4_5, Properties.Resources.Hare4_6, Properties.Resources.Hare4_7, Properties.Resources.Hare4_8, Properties.Resources.Hare4_9, Properties.Resources.Hare4_10, Properties.Resources.Hare4_11, Properties.Resources.Hare4_12, Properties.Resources.Hare4_13, };


        int playerCash;
        private void UpdateWinner()
        {
            lbl_Winner.Text = winner + " heeft deze ronde \ngewonnen!";
        }

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
            
            Player.Stream = Properties.Resources.Benny_Hill_Theme;
            Player.Play();

            btn_Bet.Text = "Reset!";
            Lock(true);
            AddHares();
            foreach (Hare hare in Hares)
            {
                for (int i = 2; (0 < Hares[0].GetLoc() && 0 < Hares[1].GetLoc() && 0 < Hares[2].GetLoc() && 0 < Hares[3].GetLoc()); )
                {
                    if (-1 < Hares[0].GetLoc() && -1 < Hares[1].GetLoc() && -1 < Hares[2].GetLoc() && -1 < Hares[3].GetLoc())
                    {
                        Hares[0].Run();
                        Hares[1].Run();
                        Hares[2].Run();
                        Hares[3].Run();
                    }
                }
                btn_Bet.Enabled = true;
            }

            if (Hares[0].MyPictureBox.Location.X <= 0)
            {
                winner = "Speedy (Zwart)";
                lbl_Winner.Text = winner + ": Heeft deze ronde \ngewonnen!";

                for (int i = 0; i < Flip1.Length; i++)
                {
                    img_Hare1.Image = Flip1[i];
                    img_Hare1.Refresh();
                    Thread.Sleep(100);
                }

                img_Hare1.Image = Properties.Resources.Hare_1;
            }
            if (Hares[1].MyPictureBox.Location.X <= 0)
            {
                winner = "Slowy (Rood)";
                lbl_Winner.Text = winner + ": Heeft deze ronde \ngewonnen!";

                for (int i = 0; i < Flip2.Length; i++)
                {
                    img_Hare2.Image = Flip2[i];
                    img_Hare2.Refresh();
                    Thread.Sleep(100);
                }

                img_Hare2.Image = Properties.Resources.Hare_2; 
            }
            if (Hares[2].MyPictureBox.Location.X <= 0)
            {
                winner = "Turtle (Blauw)";
                lbl_Winner.Text = winner + ": Heeft deze ronde \ngewonnen!";

                for (int i = 0; i < Flip3.Length; i++)
                {
                    img_Hare3.Image = Flip3[i];
                    img_Hare3.Refresh();
                    Thread.Sleep(100);
                }

                img_Hare3.Image = Properties.Resources.Hare_3;
            }
            if (Hares[3].MyPictureBox.Location.X <= 0)
            {
                winner = "Flying (Groen)";
                lbl_Winner.Text = winner + ": Heeft deze ronde \ngewonnen!";

                for (int i = 0; i < Flip4.Length; i++)
                {
                    img_Hare4.Image = Flip4[i];
                    img_Hare4.Refresh();
                    Thread.Sleep(100);
                }

                img_Hare4.Image = Properties.Resources.Hare_4;
            }

            for (int i = 0; i < playerHare.Length; i++)
            {
                AddLabelCash();
                if (playerHare[i] == winner)
                {
                    Players[i].Collect(playerBet[i]);
                    lbl_PlayerCash[i].Text = Players[i].UpdateLabels();
                    Player.Dispose();

                    playerHare[0] = null;
                    playerHare[1] = null;
                    playerHare[2] = null;
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
            Players[0] = new Guy("Fer", 10);
            Players[1] = new Guy("Lidy", 10);
            Players[2] = new Guy("Sietse", 10);
        }

        void AddLabelCash()
        {
            lbl_PlayerCash[0] = lbl_Player1Cash;
            lbl_PlayerCash[1] = lbl_Player2Cash;
            lbl_PlayerCash[2] = lbl_Player3Cash;
        }

        private void btn_Bet_Click(object sender, EventArgs e)
        {
            int betAmount = Convert.ToInt32(num_AmountMoney.Value);
            if (btn_Bet.Text == "Reset!")
            {
                Lock(false);
                btn_Bet.Text = "Wed!";
                lbl_Winner.Text = winner + ": Heeft de vorige ronde \ngewonnen!";
                Hares[0].TakeStartingPosition(91);
                img_Hare1.Image = Properties.Resources.Hare_1;
                Hares[1].TakeStartingPosition(176);
                img_Hare2.Image = Properties.Resources.Hare_2;
                Hares[2].TakeStartingPosition(261);
                img_Hare3.Image = Properties.Resources.Hare_3;
                Hares[3].TakeStartingPosition(346);
                img_Hare4.Image = Properties.Resources.Hare_4;
                list_Announce.Items.Clear();
                slct_Hare.Enabled = false;
                btn_Run.Enabled = false;
                btn_Bet.Enabled = false;
                num_AmountMoney.Enabled = false;
                list_Announce.Enabled = false;
                rdio_Player1.Checked = false;
                rdio_Player2.Checked = false;
                rdio_Player3.Checked = false;
                Player.Stop();

                if (Players[0].GetCash() < 5 && Players[1].GetCash() < 5 && Players[2].GetCash() < 5)
                {
                    string message = "Geen één speler heeft nog genoeg geld om te spelen, wil je het spel resetten?";
                    string caption = "Einde spel";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                }
            }
            else
            {
                if (rdio_Player1.Checked == true)
                {
                    playerCash = Players[0].GetCash();

                    if (slct_Hare.Text == select)
                    {
                        NoHareSelected();
                    }
                    else if (playerCash >= betAmount)
                    {
                        Bet Bet = new Bet(rdio_Player1.Text, Convert.ToInt32(num_AmountMoney.Value), slct_Hare.SelectedItem.ToString());
                        playerHare[0] = slct_Hare.SelectedItem.ToString();
                        playerBet[0] = Convert.ToInt32(num_AmountMoney.Value);
                        list_Announce.Items.Add(Bet.GetDescription());
                        btn_Run.Enabled = true;
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
                        NoHareSelected();
                    }
                    else if (playerCash >= betAmount)
                    {
                        Bet Bet = new Bet(rdio_Player2.Text, Convert.ToInt32(num_AmountMoney.Value), slct_Hare.SelectedItem.ToString());
                        playerHare[1] = slct_Hare.SelectedItem.ToString();
                        playerBet[1] = Convert.ToInt32(num_AmountMoney.Value);
                        list_Announce.Items.Add(Bet.GetDescription());

                        rdio_Player2.Enabled = false;
                        rdio_Player2.Checked = false;
                        btn_Bet.Enabled = false;
                        btn_Run.Enabled = true;
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
                        NoHareSelected();
                    }
                    else if (playerCash >= betAmount)
                    {
                        Bet Bet = new Bet(rdio_Player3.Text, Convert.ToInt32(num_AmountMoney.Value), slct_Hare.Text);
                        playerHare[2] = slct_Hare.SelectedItem.ToString();
                        playerBet[2] = Convert.ToInt32(num_AmountMoney.Value);
                        list_Announce.Items.Add(Bet.GetDescription());

                        rdio_Player3.Enabled = false;
                        rdio_Player3.Checked = false;
                        btn_Bet.Enabled = false;
                        btn_Run.Enabled = true;
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

            //if (Players[0].PlaceBet(Convert.ToInt32(num_AmountMoney.Value)) && Players[1].PlaceBet(Convert.ToInt32(num_AmountMoney.Value)) && Players[2].PlaceBet(Convert.ToInt32(num_AmountMoney.Value)))
            //{
            //    btn_Run.Enabled = true;
            //}
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
                if (Players[0].GetCash() == 0)
                    rdio_Player1.Enabled = false;
                else
                    rdio_Player1.Enabled = true;
                if (Players[1].GetCash() == 0)
                    rdio_Player2.Enabled = false;
                else
                    rdio_Player2.Enabled = true;
                if (Players[2].GetCash() == 0)
                    rdio_Player3.Enabled = false;
                else
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
        private void NoHareSelected()
        {
            for (int i = list_Announce.Items.Count - 1; i >= 0; i--)
            {
                string item = (string)list_Announce.Items[i];
                if (item.StartsWith("Selecteer een Haas!"))
                    list_Announce.Items.RemoveAt(i);
            }
            list_Announce.Items.Add("Selecteer een Haas!");
        }
    }
}