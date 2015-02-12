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
            Guy Sietse = new Guy("Sietse", 1337);
            Guy Fer = new Guy("Fer", 123);
            Guy Lidy = new Guy("Lidy", 9001);
            Guy Peter = new Guy("Peter", 4321);
            lbl_Player1Cash.Text = Sietse.UpdateLabels();
            lbl_Player2Cash.Text = Fer.UpdateLabels();
            lbl_Player3Cash.Text = Lidy.UpdateLabels();
            lbl_Player4Cash.Text = Peter.UpdateLabels();

        }
    }
}