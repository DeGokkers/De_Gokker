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
            _Main = this;
        }
        public static Main _Main;

        public void update(string message)
        {
            txt_Announce.Text = message;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Guy sample = new Guy();
        }

        public decimal amount()
        {
            return num_AmountMoney.Value;
        }
    }
}
