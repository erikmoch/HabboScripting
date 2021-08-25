namespace Axed
{
    partial class FrmTuts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTuts));
            this.TxtStuff = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtStuff
            // 
            this.TxtStuff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtStuff.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtStuff.Location = new System.Drawing.Point(0, 0);
            this.TxtStuff.Multiline = true;
            this.TxtStuff.Name = "TxtStuff";
            this.TxtStuff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtStuff.Size = new System.Drawing.Size(386, 341);
            this.TxtStuff.TabIndex = 0;
            this.TxtStuff.Text = resources.GetString("TxtStuff.Text");
            // 
            // FrmTuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 341);
            this.Controls.Add(this.TxtStuff);
            this.Name = "FrmTuts";
            this.Text = "Tutorials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void FrmTuts_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        #endregion

        private System.Windows.Forms.TextBox TxtStuff;
    }
}