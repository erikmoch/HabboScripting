namespace Axed
{
    partial class FrmSandR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSandR));
            this.lstSearchAndReplace = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmboReplyType = new System.Windows.Forms.ToolStripComboBox();
            this.cmboType = new System.Windows.Forms.ToolStripComboBox();
            this.txtReplace = new System.Windows.Forms.ToolStripTextBox();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cmdAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSearchAndReplace
            // 
            this.lstSearchAndReplace.CheckBoxes = true;
            this.lstSearchAndReplace.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstSearchAndReplace.FullRowSelect = true;
            this.lstSearchAndReplace.GridLines = true;
            this.lstSearchAndReplace.LabelEdit = true;
            this.lstSearchAndReplace.Location = new System.Drawing.Point(1, -2);
            this.lstSearchAndReplace.MultiSelect = false;
            this.lstSearchAndReplace.Name = "lstSearchAndReplace";
            this.lstSearchAndReplace.Size = new System.Drawing.Size(519, 218);
            this.lstSearchAndReplace.TabIndex = 0;
            this.lstSearchAndReplace.UseCompatibleStateImageBehavior = false;
            this.lstSearchAndReplace.View = System.Windows.Forms.View.Details;
            this.lstSearchAndReplace.SelectedIndexChanged += new System.EventHandler(this.lstSearchAndReplace_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Search";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Replace";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Reply Type";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.cmdAdd,
            this.toolStripSeparator1,
            this.cmboReplyType,
            this.cmboType,
            this.txtReplace,
            this.txtSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 217);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(521, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cmboReplyType
            // 
            this.cmboReplyType.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmboReplyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboReplyType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmboReplyType.Items.AddRange(new object[] {
            "Server",
            "Client"});
            this.cmboReplyType.Name = "cmboReplyType";
            this.cmboReplyType.Size = new System.Drawing.Size(121, 25);
            // 
            // cmboType
            // 
            this.cmboType.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmboType.Items.AddRange(new object[] {
            "Server",
            "Client"});
            this.cmboType.Name = "cmboType";
            this.cmboType.Size = new System.Drawing.Size(121, 25);
            this.cmboType.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // txtReplace
            // 
            this.txtReplace.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReplace.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(100, 25);
            // 
            // txtSearch
            // 
            this.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "-";
            this.toolStripButton1.ToolTipText = "Delete";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdAdd.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdd.Image")));
            this.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(23, 22);
            this.cmdAdd.Text = "+";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // FrmSandR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 242);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lstSearchAndReplace);
            this.Name = "FrmSandR";
            this.Text = "Packet Editor";
            this.Resize += new System.EventHandler(this.FrmSandR_Resize);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSandR_FormClosing);
            this.Load += new System.EventHandler(this.FrmSandR_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void FrmSandR_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        void FrmSandR_Resize(object sender, System.EventArgs e)
        {          
            lstSearchAndReplace.Height = this.Height- 53;
            lstSearchAndReplace.Width = this.Width - 7;
            lstSearchAndReplace.Columns[0].Width = lstSearchAndReplace.Width / 4 - 2;
            lstSearchAndReplace.Columns[1].Width = lstSearchAndReplace.Width / 4 - 2;
            lstSearchAndReplace.Columns[2].Width = lstSearchAndReplace.Width / 4 - 2;
            lstSearchAndReplace.Columns[3].Width = lstSearchAndReplace.Width / 4 - 2;
        }

        #endregion

        private System.Windows.Forms.ListView lstSearchAndReplace;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripTextBox txtReplace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdAdd;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripComboBox cmboType;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripComboBox cmboReplyType;
    }
}