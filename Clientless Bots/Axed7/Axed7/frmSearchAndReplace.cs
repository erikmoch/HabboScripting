using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Axed
{
    public partial class FrmSandR : Form
    {
        public FrmSandR()
        {
            InitializeComponent();
        }
        
        private void FrmSandR_Load(object sender, EventArgs e)
        {
            cmboType.SelectedIndex = 1;
            cmboReplyType.SelectedIndex = 1;
            lstSearchAndReplace.Columns[0].Width = lstSearchAndReplace.Width / 4 - 2;
            lstSearchAndReplace.Columns[1].Width = lstSearchAndReplace.Width / 4 - 2;
            lstSearchAndReplace.Columns[2].Width = lstSearchAndReplace.Width / 4 - 2;
            lstSearchAndReplace.Columns[3].Width = lstSearchAndReplace.Width / 4 - 2;
        }
        private delegate void RepDelegate(string ThePacket, string Type, int ID);
        internal void ReplaceThis(string ThePacket, string Type, int ID)
        {
            string TmpOutput;
            TmpOutput = ThePacket;
            if (InvokeRequired == true)
            {
               this.Invoke(new RepDelegate(ReplaceThis), ThePacket, Type, ID);
            }
            else
            {
                for (int x = 0; x < lstSearchAndReplace.Items.Count; x++)
                {
                    if (lstSearchAndReplace.Items[x].Checked == false)
                        continue;
                    if (lstSearchAndReplace.Items[x].SubItems[2].Text != Type)
                        continue;
                    if (lstSearchAndReplace.Items[x].SubItems[3].Text != Type)
                    {
                        if (TmpOutput.IndexOf(lstSearchAndReplace.Items[x].Text) != -1)
                        {
                            if (lstSearchAndReplace.Items[x].SubItems[3].Text == "Server")
                                ConnectionManager.GReference(0).SendToServerAddHeaders(lstSearchAndReplace.Items[x].SubItems[1].Text);
                            if (lstSearchAndReplace.Items[x].SubItems[3].Text == "Client")
                                ConnectionManager.GReference(0).SendToClient(lstSearchAndReplace.Items[x].SubItems[1].Text);
                        }
                        continue;
                    }
                    TmpOutput = TmpOutput.Replace(lstSearchAndReplace.Items[x].Text, lstSearchAndReplace.Items[x].SubItems[1].Text);
                }
                ConnectionManager.GReference(0).SandRPacket[ID] = TmpOutput;
            }
        }

        private void lstSearchAndReplace_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            lstSearchAndReplace.Items.Add(txtSearch.Text).SubItems.Add(txtReplace.Text);
            lstSearchAndReplace.Items[lstSearchAndReplace.Items.Count - 1].SubItems.Add(cmboType.Text);
            lstSearchAndReplace.Items[lstSearchAndReplace.Items.Count - 1].SubItems.Add(cmboReplyType.Text);
            txtSearch.Clear();
            txtReplace.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                lstSearchAndReplace.Items.Remove(lstSearchAndReplace.SelectedItems[0]);
            }
            catch
            {
                MessageBox.Show("Nothing Selected");
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}