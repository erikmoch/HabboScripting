namespace Axed
{
    partial class FrmBrowser
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
            this.brHabbo = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // brHabbo
            // 
            this.brHabbo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brHabbo.Location = new System.Drawing.Point(0, 0);
            this.brHabbo.MinimumSize = new System.Drawing.Size(20, 20);
            this.brHabbo.Name = "brHabbo";
            this.brHabbo.ScriptErrorsSuppressed = true;
            this.brHabbo.ScrollBarsEnabled = false;
            this.brHabbo.Size = new System.Drawing.Size(774, 595);
            this.brHabbo.TabIndex = 0;
            this.brHabbo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.brHabbo_PreviewKeyDown);
            this.brHabbo.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.brHabbo_DocumentCompleted);
            // 
            // FrmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 595);
            this.Controls.Add(this.brHabbo);
            this.Name = "FrmBrowser";
            this.Text = "Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBrowser_FrmUnload);
            this.Load += new System.EventHandler(this.FrmBrowser_Load);
            this.ResumeLayout(false);

        }

        void brHabbo_PreviewKeyDown(object sender, System.Windows.Forms.PreviewKeyDownEventArgs e)
        {
            if (e.Shift == false)
            {
                if (e.KeyCode == System.Windows.Forms.Keys.Down)
                    ConnectionManager.GReference(0).MoveDown();
                if (e.KeyCode == System.Windows.Forms.Keys.Up)
                    ConnectionManager.GReference(0).MoveUp();
                if (e.KeyCode == System.Windows.Forms.Keys.Left)
                    ConnectionManager.GReference(0).MoveLeft();
                if (e.KeyCode == System.Windows.Forms.Keys.Right)
                    ConnectionManager.GReference(0).MoveRight();
                return;
            }
            if (e.KeyCode == System.Windows.Forms.Keys.Down)
                ConnectionManager.GReference(0).LookDown();
            if (e.KeyCode == System.Windows.Forms.Keys.Up)
                ConnectionManager.GReference(0).LookUp();
            if (e.KeyCode == System.Windows.Forms.Keys.Left)
                ConnectionManager.GReference(0).LookLeft();
            if (e.KeyCode == System.Windows.Forms.Keys.Right)
                ConnectionManager.GReference(0).LookRight();

        }

        #endregion

        internal System.Windows.Forms.WebBrowser brHabbo;

    }
}