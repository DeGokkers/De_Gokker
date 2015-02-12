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
            Guy Sietse = new Guy("Sietse", 50);
            Guy Fer = new Guy("Fer", 50);
            Guy Peter = new Guy("Peter", 50);
            Guy Lidy = new Guy("Lidy", 1002);
            lbl_Player1Stats.Text = Sietse.UpdateLabels();
            lbl_Player2Stats.Text = Fer.UpdateLabels();
            lbl_Player3Stats.Text = Peter.UpdateLabels();
            lbl_Player4Stats.Text = Lidy.UpdateLabels();
        }
    }
}