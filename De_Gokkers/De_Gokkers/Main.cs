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
        public static Main _Main;

        private void Main_Load(object sender, EventArgs e)
        {
        }

        public void update(string text)
        { 
            
        }

        public decimal amount()
        {
            return num_AmountMoney.Value;
        }

        private void PlaceBet_MouseClick(object sender, MouseEventArgs e)
        {
            Guy test = new Guy();
            txt_Announce.Text = test.UpdateLabels();
        } 
    }
}