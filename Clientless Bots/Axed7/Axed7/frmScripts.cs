using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Axed
{
    public partial class frmScripts : Form
    {
        private ContextMenu UserMenu = new ContextMenu();
        private ContextMenu FurnitureMenu = new ContextMenu();
        private bool NukeTelesOn = false;
        private bool RndPosters = false;
        public frmScripts()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            TakeStage(pnlFurnitureFloor);
        }

        private void pnlFurnitureFloor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void frmScripts_Load(object sender, EventArgs e)
        {

        }
        #region Node Adding (Adding To Listviews)
        #region Delegates
        internal delegate void _NewNode(string N, int I);
        internal delegate void _AddToNode(string N, int U, int I);
        internal delegate void _RemNode(int I);
        internal delegate void _RunVoidMethod();
        #endregion
        #region Floor Item Nodes
        internal void NewFurniture(string NodeText, int ItemID)
        {
            try
            {
                if (this.InvokeRequired)
                { this.Invoke(new _NewNode(NewFurniture), NodeText, ItemID); }
                else
                {
                    if (LVFurniture.Items.ContainsKey(ItemID.ToString()) == false)
                        LVFurniture.Items.Add(ItemID.ToString(), ItemID.ToString(), 0).SubItems.Add(NodeText);
                    for (int x = 2; x < 10; x++)
                    {
                        LVFurniture.Items[ItemID.ToString()].SubItems.Add("");
                    }
                    //if (
                    //
                    //ConnectionManager.GReference(0).SendToServerAddHeaders("AJ" + Jeax.Habbo.Encoding.B64.encode(ItemID.ToString()) + ItemID + Jeax.Habbo.Encoding.B64.encode("iJeax.com - Jeax Is God [Axed 7.0]") + "iJeax.com - Jeax Is God [Axed 7.0]");
                    //System.Threading.Thread.Sleep(30);
                }

            }
            catch
            {
            }
        }
        internal void AddToFurniNode(string NodeText, int UserID, int Index)
        {
            try
            {
                if (this.InvokeRequired)
                { this.Invoke(new _AddToNode(AddToFurniNode), NodeText, UserID, Index); }
                else
                {
                    if (LVFurniture.Items.ContainsKey(UserID.ToString()) == true)
                        LVFurniture.Items[UserID.ToString()].SubItems[Index].Text = NodeText;
                }

            }
            catch
            {
            }
        }

        internal void RemoveItem(int UserID)
        {
            try
            {
                if (this.InvokeRequired)
                { this.Invoke(new _RemNode(RemoveItem), UserID); }
                else
                {
                    if (LVFurniture.Items.ContainsKey(UserID.ToString()) == true)
                        LVFurniture.Items[UserID.ToString()].Remove();
                }

            }
            catch
            {
            }
        }
        internal void RemoveAllItems()
        {
            try
            {
                if (this.InvokeRequired)
                { this.Invoke(new _RunVoidMethod(RemoveAllItems)); }
                else
                {
                   LVFurniture.Items.Clear();
                   LVPosters.Items.Clear();
                }

            }
            catch
            {
            }
        }
        internal void AddToFurniNode2(string NodeText, int UserID, int Index)
        {
            try
            {
                if (this.InvokeRequired)
                { this.Invoke(new _AddToNode(AddToFurniNode2), NodeText, UserID, Index); }
                else
                {
                    if (LVFurniture.Items.ContainsKey(UserID.ToString()) == true)
                    {
                        string BeforeSign = Jeax.Habbo.Encoding.VL64.encode(Jeax.Habbo.Encoding.VL64.decode(LVFurniture.Items[UserID.ToString()].SubItems[Index].Text));
                        LVFurniture.Items[UserID.ToString()].SubItems[Index].Text = BeforeSign + NodeText;
                    }
                }

            }
            catch
            {
            }
        }
        #endregion
        #region Wall Item Nodes
        internal void NewWallItem(string NodeText, int ItemID)
        {
            try
            {
                if (this.InvokeRequired)
                { this.Invoke(new _NewNode(NewWallItem), NodeText, ItemID); }
                else
                {
                    if (LVPosters.Items.ContainsKey(ItemID.ToString()) == false)
                        LVPosters.Items.Add(ItemID.ToString(), ItemID.ToString(), 0).SubItems.Add(NodeText);
                    for (int x = 2; x < 6; x++)
                    {
                        LVPosters.Items[ItemID.ToString()].SubItems.Add("");
                    }
                }

            }
            catch
            {
            }
        }
        internal void AddToWallItemNode(string NodeText, int UserID, int Index)
        {
            try
            {
                if (this.InvokeRequired)
                { this.Invoke(new _AddToNode(AddToWallItemNode), NodeText, UserID, Index); }
                else
                {
                    if (LVPosters.Items.ContainsKey(UserID.ToString()) == true)
                        LVPosters.Items[UserID.ToString()].SubItems[Index].Text = NodeText;
                }

            }
            catch
            {
            }
        }
        internal void RemovePoster(int UserID)
        {
            try
            {
                if (this.InvokeRequired)
                { this.Invoke(new _RemNode(RemovePoster), UserID); }
                else
                {
                    if (LVPosters.Items.ContainsKey(UserID.ToString()) == true)
                        LVPosters.Items[UserID.ToString()].Remove();
                }

            }
            catch
            {
            }
        }

        #endregion
        #region User Nodes
        internal void NewNode(string NodeText, int UserID)
        {
            try
            {
                if (this.InvokeRequired)
                { this.Invoke(new _NewNode(NewNode), NodeText, UserID); }
                else
                {
                    if (LVUsers.Items.ContainsKey(UserID.ToString()) == false)
                        LVUsers.Items.Add(UserID.ToString(), UserID.ToString(), 0).SubItems.Add(NodeText);
                    for (int x = 2; x < 9; x++)
                    {
                        LVUsers.Items[UserID.ToString()].SubItems.Add("");
                    }
                    LVUsers.Items[UserID.ToString()].SubItems.Add("False");
                }

            }
            catch
            {
            }
        }
        internal void AddToNode(string NodeText, int UserID, int Index)
        {
            try
            {
                if (this.InvokeRequired)
                { this.Invoke(new _AddToNode(AddToNode), NodeText, UserID, Index); }
                else
                {
                    if (LVUsers.Items.ContainsKey(UserID.ToString()) == true)
                        LVUsers.Items[UserID.ToString()].SubItems[Index].Text = NodeText;
                }

            }
            catch
            {
            }
        }
        internal void RemoveNode(int UserID)
        {
            try
            {
                if (this.InvokeRequired)
                { this.Invoke(new _RemNode(RemoveNode), UserID); }
                else
                {
                    if (LVUsers.Items.ContainsKey(UserID.ToString()) == true)
                        LVUsers.Items[UserID.ToString()].Remove();
                }

            }
            catch
            {
            }
        }
        internal void RemoveAllUsers()
        {
            try
            {
                if (this.InvokeRequired)
                { this.Invoke(new _RunVoidMethod(RemoveAllUsers)); }
                else
                {
                    LVUsers.Items.Clear();
                }

            }
            catch
            {
            }
        }
        #endregion

        #endregion
        #region Menu Commands
        private void wallItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeStage(pnlWallItems);
        }
        private void floorItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeStage(pnlFurnitureFloor);
        }
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeStage(pnlUsers);
        }
        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            TakeStage(pnlPubScripts);
        }
        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {
            TakeStage(pnlPreferences);
        }
        private void TakeStage(Panel PanelName)
        {
            if (PanelName.Dock != DockStyle.Fill) // If its not already Taking the Stage
            {
                RemoveAllPanels();
                this.Height = PanelName.Height + 60;
                this.Width = PanelName.Width + 8;
                PanelName.Dock = DockStyle.Fill;
            }
        }
        private void RemoveAllPanels()
        {
            pnlFurnitureFloor.Dock = DockStyle.None;
            pnlFurnitureFloor.Left = 9999;
            pnlWallItems.Dock = DockStyle.None;
            pnlWallItems.Left = 9999;
            pnlUsers.Dock = DockStyle.None;
            pnlUsers.Left = 9999;
            pnlPubScripts.Dock = DockStyle.None;
            pnlPubScripts.Left = 9999;
            pnlPreferences.Dock = DockStyle.None;
            pnlPreferences.Left = 9999;
        }
        #endregion
        #region pnlFloorFurniture
        private void cmdPickup_Click(object sender, EventArgs e)
        {
            int TmpItemID = int.Parse(LVFurniture.SelectedItems[0].SubItems[0].Text);
            ConnectionManager.GReference(0).SendToServerAddHeaders("ACnew stuff " + TmpItemID);
        }

        private void cmdJumpTo_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionHandler B = ConnectionManager.GReference(0);
                int ItemX;
                int ItemY;
                ItemX = int.Parse(LVFurniture.SelectedItems[0].SubItems[2].Text);
                ItemY = int.Parse(LVFurniture.SelectedItems[0].SubItems[3].Text);
                B.SendToServerAddHeaders("@v" + B._RoomID + "/" + LVFurniture.SelectedItems[0].SubItems[0].Text);
            }
            catch { }
        }
        private void cmdSign_Click(object sender, EventArgs e)
        {
            try
            {
                int TmpItemID = int.Parse(LVFurniture.SelectedItems[0].SubItems[0].Text);
                ConnectionManager.GReference(0).SendToServerAddHeaders("AJ" + Jeax.Habbo.Encoding.B64.encode(TmpItemID.ToString()) + TmpItemID + Jeax.Habbo.Encoding.B64.encode(txtSigning.Text) + txtSigning.Text);
            }
            catch { }
        }

        private void cmdPickupSelectedSprite_Click(object sender, EventArgs e)
        {
            cmdSignAll.Enabled = false;
            cmdSignSprite.Enabled = false;
            cmdPickupAll.Enabled = false;
            cmdPickupSelectedSprite.Enabled = false;
            cmdNukeTeles.Enabled = false;
            _RunVoidMethod delRP2 = new _RunVoidMethod(PickupAllSelectedSprite);
            IAsyncResult tag2 = delRP2.BeginInvoke(null, null);
        }
        private void PickupAllSelectedSprite()
        {
            ListView LVTmp = new ListView();
            for (int x = 0; x < LVFurniture.Items.Count; x++)
            {
                LVTmp.Items.Add(LVFurniture.Items[x].Text);
            }
            try
            {
                string SelectedSprite = LVFurniture.SelectedItems[0].SubItems[1].Text;
                for (int x = 0; x < LVTmp.Items.Count; x++)
                {
                    if (LVFurniture.Items[x].SubItems[1].Text == SelectedSprite)
                    {
                        int TmpItemID = int.Parse(LVFurniture.Items[x].SubItems[0].Text);
                        ConnectionManager.GReference(0).SendToServerAddHeaders("ACnew stuff " + TmpItemID);
                        System.Threading.Thread.Sleep(300);
                    }
                }
            }
            finally
            {
                cmdSignAll.Enabled = true;
                cmdSignSprite.Enabled = true;
                cmdPickupAll.Enabled = true;
                cmdPickupSelectedSprite.Enabled = true;
                cmdNukeTeles.Enabled = true;
            }
        }

        private void cmdSignSprite_Click(object sender, EventArgs e)
        {
            cmdSignAll.Enabled = false;
            cmdSignSprite.Enabled = false;
            cmdPickupAll.Enabled = false;
            cmdPickupSelectedSprite.Enabled = false;
            cmdNukeTeles.Enabled = false;
            _RunVoidMethod delRP2 = new _RunVoidMethod(SignAllSelectedSprite);
            IAsyncResult tag2 = delRP2.BeginInvoke( null, null);
        }
        private void SignAllSelectedSprite()
        {
            ListView LVTmp = new ListView();
            for (int x = 0; x < LVFurniture.Items.Count; x++)
            {
                LVTmp.Items.Add(LVFurniture.Items[x].Text);
            }
            try
            {
                string SelectedSprite = LVTmp.SelectedItems[0].SubItems[1].Text;
                for (int x = 0; x < LVTmp.Items.Count; x++)
                {
                    if (LVTmp.Items[x].SubItems[1].Text == SelectedSprite)
                    {

                        int TmpItemID = int.Parse(LVTmp.Items[x].SubItems[0].Text);
                        ConnectionManager.GReference(0).SendToServerAddHeaders("AJ" + Jeax.Habbo.Encoding.B64.encode(TmpItemID.ToString()) + TmpItemID + Jeax.Habbo.Encoding.B64.encode(txtSigning.Text) + txtSigning.Text);
                        System.Threading.Thread.Sleep(300);
                    }
                }
            }
            finally
            {
                cmdSignAll.Enabled = true;
                cmdSignSprite.Enabled = true;
                cmdPickupAll.Enabled = true;
                cmdPickupSelectedSprite.Enabled = true;
                cmdNukeTeles.Enabled = true;
            }
        }

        private void cmdSignAll_Click(object sender, EventArgs e)
        {
            cmdSignAll.Enabled = false;
            cmdSignSprite.Enabled = false;
            cmdPickupAll.Enabled = false;
            cmdPickupSelectedSprite.Enabled = false;
            cmdNukeTeles.Enabled = false;
            _RunVoidMethod delRP2 = new _RunVoidMethod(SignAll);
            IAsyncResult tag2 = delRP2.BeginInvoke(null, null);
        }
        private void SignAll()
        {
            ListView LVTmp = new ListView();
            for (int x = 0; x < LVFurniture.Items.Count; x++)
            {
                LVTmp.Items.Add(LVFurniture.Items[x].Text);
            }
            try
            {
                for (int x = 0; x < LVTmp.Items.Count; x++)
                {
                    
                    int TmpItemID = int.Parse(LVTmp.Items[x].SubItems[0].Text);
                    ConnectionManager.GReference(0).SendToServerAddHeaders("AJ" + Jeax.Habbo.Encoding.B64.encode(TmpItemID.ToString()) + TmpItemID + Jeax.Habbo.Encoding.B64.encode(txtSigning.Text) + txtSigning.Text);
                    System.Threading.Thread.Sleep(50);
                }
            }
            finally
            {
                cmdSignAll.Enabled = true;
                cmdSignSprite.Enabled = true;
                cmdPickupAll.Enabled = true;
                cmdPickupSelectedSprite.Enabled = true;
                cmdNukeTeles.Enabled = true;
            }
        }

        private void cmdPickupAll_Click(object sender, EventArgs e)
        {
            cmdSignAll.Enabled = false;
            cmdSignSprite.Enabled = false;
            cmdPickupAll.Enabled = false;
            cmdPickupSelectedSprite.Enabled = false;
            cmdNukeTeles.Enabled = false;
            _RunVoidMethod delRP2 = new _RunVoidMethod(PickupAll);
            IAsyncResult tag2 = delRP2.BeginInvoke(null, null);
        }
        private void PickupAll()
        {
            ListView LVTmp = new ListView();
            for (int x = 0; x < LVFurniture.Items.Count; x++)
            {
                LVTmp.Items.Add(LVFurniture.Items[x].Text);
            }
            try
            {
                for (int x = 0; x < LVTmp.Items.Count; x++)
                {
                    int TmpItemID = int.Parse(LVTmp.Items[x].SubItems[0].Text);
                    ConnectionManager.GReference(0).SendToServerAddHeaders("ACnew stuff " + TmpItemID);
                    System.Threading.Thread.Sleep(400);
                }
            }
            finally
            {
                cmdSignAll.Enabled = true;
                cmdSignSprite.Enabled = true;
                cmdPickupAll.Enabled = true;
                cmdPickupSelectedSprite.Enabled = true;
                cmdNukeTeles.Enabled = true;
            }
        }

        private void cmdNukeTeles_Click(object sender, EventArgs e)
        {
            if (cmdNukeTeles.Text == "Nuke Teleporters")
            {
                cmdNukeTeles.Text = "Stop Nuking";
                cmdSignAll.Enabled = false;
                cmdSignSprite.Enabled = false;
                cmdPickupAll.Enabled = false;
                cmdPickupSelectedSprite.Enabled = false;
                NukeTelesOn = true;
                //cmdNukeTeles.Enabled = false;
                _RunVoidMethod delRP2 = new _RunVoidMethod(NukeTeleporters);
                IAsyncResult tag2 = delRP2.BeginInvoke(null, null);
            }
            else
            {
                cmdNukeTeles.Text = "Nuke Teleporters";
                NukeTelesOn = false;
            }
        }
        private void NukeTeleporters()
        {
            try
            {
                ListView LVTmp = new ListView();
                for (int x = 0; x < LVFurniture.Items.Count; x++)
                {
                    if (LVFurniture.Items[x].SubItems[1].Text == "door" || LVFurniture.Items[x].SubItems[1].Text == "doorB" || LVFurniture.Items[x].SubItems[1].Text == "doorC" || LVFurniture.Items[x].SubItems[1].Text == "doorD")
                    {
                        LVTmp.Items.Add(LVFurniture.Items[x].Text);
                        LVTmp.Items[LVTmp.Items.Count - 1].SubItems.Add(LVFurniture.Items[x].SubItems[1].Text);
                    }
                }
                while (NukeTelesOn == true)
                {
                    for (int x = 0; x < LVTmp.Items.Count; x++)
                    {
                        if (LVTmp.Items[x].SubItems[1].Text == "door" || LVTmp.Items[x].SubItems[1].Text == "doorB" || LVTmp.Items[x].SubItems[1].Text == "doorC" || LVTmp.Items[x].SubItems[1].Text == "doorD")
                        {
    
                            int TmpItemID = int.Parse(LVTmp.Items[x].SubItems[0].Text);
                            ConnectionManager.GReference(0).SendToServerAddHeaders("AJ" + Jeax.Habbo.Encoding.B64.encode(TmpItemID.ToString()) + TmpItemID + Jeax.Habbo.Encoding.B64.encode("TRUE") + "TRUE");
                            System.Threading.Thread.Sleep(40);
                        }
                    }
                }
            }
            catch
            {

            }
            finally
            {
                cmdSignAll.Enabled = true;
                cmdSignSprite.Enabled = true;
                cmdPickupAll.Enabled = true;
                cmdPickupSelectedSprite.Enabled = true;
                cmdNukeTeles.Enabled = true;
                cmdNukeTeles.Text = "Nuke Teleporters";
                NukeTelesOn = false;
            }
        }


        private void LVFurniture_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtSigning.Text = LVFurniture.SelectedItems[0].SubItems[9].Text;
            }
            catch { }
        }


        #endregion
        #region pnlWallItems
        private void cmdMovePoster_Click(object sender, EventArgs e)
        {
            ConnectionManager.GReference(0).SendToServerAddHeaders("ACnew item " + txtPosterID.Text);
            ConnectionManager.GReference(0).SendToServerAddHeaders("AZ" + txtPosterID.Text + " :w=" + txtW.Text + " l=" + TxtL.Text + " " + txtRotation.Text);
        }

        private void LVPosters_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtPosterID.Text = LVPosters.SelectedItems[0].Text;
                txtW.Text = LVPosters.SelectedItems[0].SubItems[2].Text;
                TxtL.Text = LVPosters.SelectedItems[0].SubItems[3].Text;
                txtRotation.Text = LVPosters.SelectedItems[0].SubItems[4].Text;
            }
            catch { }
        }

        private void cmdPickupAllPosters_Click(object sender, EventArgs e)
        {
            cmdPickupAllPosters.Enabled = false;
            _RunVoidMethod delRP2 = new _RunVoidMethod(PickupAllPosters);
            IAsyncResult tag2 = delRP2.BeginInvoke(null, null);
        }
        private void PickupAllPosters()
        {
            try
            {
                ListView LVTmp = new ListView();
                for (int x = 0; x < LVPosters.Items.Count; x++)
                {
                    LVTmp.Items.Add(LVPosters.Items[x].Text);
                }
                for (int x = 0; x < LVTmp.Items.Count; x++)
                {

                    ConnectionManager.GReference(0).SendToServerAddHeaders("ACnew item " + LVTmp.Items[x].Text);
                    System.Threading.Thread.Sleep(300);
                }
            }
            finally
            {
                cmdPickupAllPosters.Enabled = true;
            }

        }


        private void cmdRandomPosters_Click(object sender, EventArgs e)
        {
            if (cmdRandomPosters.Text == "Fun Posters")
            {
                RndPosters = true;
                cmdRandomPosters.Text = "No Fun :(";
                _RunVoidMethod delRP2 = new _RunVoidMethod(RandomisedPostersLoop);
                IAsyncResult tag2 = delRP2.BeginInvoke(null, null);
            }
            else
            {
                cmdRandomPosters.Text = "Fun Posters";
                RndPosters = false;
            }
        }
        private void RandomisedPostersLoop()
        {
            ListView LVTmp = new ListView();
            for (int x = 0; x < LVPosters.Items.Count; x++)
            {
                LVTmp.Items.Add(LVPosters.Items[x].Text);
            }
            while (RndPosters == true)
            {
                Random Randomiser = new Random();
                string TmpRotation = "";
                if (new Random().Next(0, 2) == 0)
                    TmpRotation = "l";
                else
                    TmpRotation = "r";
                string RandomLPart2 = "";
                if (TmpRotation == "l")
                    RandomLPart2 = Randomiser.Next(-150, 300).ToString();
                else
                    RandomLPart2 = Randomiser.Next(20, 450).ToString();

                for (int x = 0; x < LVTmp.Items.Count; x++)
                {
                    //Randomiser = new Random((new Random().Next(-2147483648, 2147483647)));
                    if (RndPosters == false)
                        break;
                    ConnectionManager.GReference(0).SendToServerAddHeaders("ACnew item " + LVTmp.Items[x].Text);
                    string RandomW = "";
                    if (TmpRotation == "l")
                        RandomW = "3,12";
                    else
                        RandomW = "4,0";
                    string RandomL = "";
                    if (TmpRotation == "l")
                        RandomL = Randomiser.Next(-20, 600).ToString() + "," + RandomLPart2;
                    else
                        RandomL = Randomiser.Next(-400, 250).ToString() + "," + RandomLPart2;
                    ConnectionManager.GReference(0).SendToServerAddHeaders("AZ" + LVTmp.Items[x].Text + " :w=" + RandomW + " l=" + RandomL + " " + TmpRotation);
                    if (Randomiser.Next(0, 2) == 0)
                        TmpRotation = "l";
                    else
                        TmpRotation = "r";

                    if (TmpRotation == "l")
                        RandomLPart2 = Randomiser.Next(-150, 300).ToString();
                    else
                        RandomLPart2 = Randomiser.Next(20, 450).ToString();

                    System.Threading.Thread.Sleep(1200);
                }
            }
            RndPosters = false;
            cmdRandomPosters.Text = "Fun Posters";
        }
        #endregion
        #region pnlUsers
        private void cmdKickUser_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionManager.GReference(0).SendToServerAddHeaders("A_" + LVUsers.SelectedItems[0].SubItems[1].Text);
            }
            catch { }
        }

        private void cmdStealLook_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionManager.GReference(0).UpdateHabbo(LVUsers.SelectedItems[0].SubItems[2].Text, LVUsers.SelectedItems[0].SubItems[4].Text, LVUsers.SelectedItems[0].SubItems[3].Text);
            }
            catch
            {
            }
        }

        private void opWelcomeUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (opWelcomeUsers.Checked == true)
                ConnectionManager.GReference(0).WelcomeUsers = true;
            else
                ConnectionManager.GReference(0).WelcomeUsers = false;
        }
        #endregion

        #region Public Room Scripts
        private void cmdLidoWarp_Click(object sender, EventArgs e)
        {
            ConnectionManager.GReference(0).SendToServerAddHeaders("Ag");
            ConnectionManager.GReference(0).SendToServerAddHeaders("Aj" + txtDive.Text);
            System.Threading.Thread.Sleep(600);
            ConnectionManager.GReference(0).SendToServerAddHeaders("Ak" + txtWarpCords.Text);
        }
        #endregion

        private void pnlPreferences_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkRandomShockwaveID_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pnlUsers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdMassKick_Click(object sender, EventArgs e)
        {

        }



    }
}