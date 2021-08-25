using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Axed
{
    public partial class FrmPubScripts : Form
    {
        public FrmPubScripts()
        {
            InitializeComponent();
        }

        private void cmdLidoWarp_Click(object sender, EventArgs e)
        {
            ConnectionManager.GReference(0).SendToServerAddHeaders("Ag");
            ConnectionManager.GReference(0).SendToServerAddHeaders("Aj0ada0da0dada0da0da00da000 000ss%050%11z0%28z");
            System.Threading.Thread.Sleep(600);
            ConnectionManager.GReference(0).SendToServerAddHeaders("Ak" + txtWarpCords.Text);
        }

        private void cmdGetDrink_Click(object sender, EventArgs e)
        {
            ConnectionManager.GReference(0).SendToServerAddHeaders("AP" + txtDrinkName.Text);
        }

        private void cmdLidoSeatDrop_Click(object sender, EventArgs e)
        {
            ConnectionManager.GReference(0).SendToServerAddHeaders("AXSit");
        }
    }
}