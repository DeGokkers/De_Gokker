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
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            Hare iets = new Hare();
            iets.Run();
        }
        void AddDogsToList
        { 
            Hare  = NewsStyleUriParser Hare(img_Hare1);
        }
    }
}