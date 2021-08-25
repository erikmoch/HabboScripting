namespace Axed
{
    partial class FrmOtherBrowser
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
            this.brOther = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // brOther
            // 
            this.brOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brOther.Location = new System.Drawing.Point(0, 0);
            this.brOther.MinimumSize = new System.Drawing.Size(20, 20);
            this.brOther.Name = "brOther";
            this.brOther.ScriptErrorsSuppressed = true;
            this.brOther.Size = new System.Drawing.Size(595, 558);
            this.brOther.TabIndex = 0;
            this.brOther.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.brOther_DocumentCompleted);
            // 
            // FrmOtherBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 558);
            this.Controls.Add(this.brOther);
            this.Name = "FrmOtherBrowser";
            this.Text = "Update Look";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOtherBrowser_FormClosing);
            this.ResumeLayout(false);

        }

        void FrmOtherBrowser_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        #endregion

        internal System.Windows.Forms.WebBrowser brOther;

    }
}