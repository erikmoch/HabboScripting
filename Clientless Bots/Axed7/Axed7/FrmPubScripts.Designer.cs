namespace Axed
{
    partial class FrmPubScripts
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
            this.txtWarpCords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdLidoWarp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdGetDrink = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDrinkName = new System.Windows.Forms.TextBox();
            this.cmdLidoSeatDrop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWarpCords
            // 
            this.txtWarpCords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWarpCords.Location = new System.Drawing.Point(6, 20);
            this.txtWarpCords.Name = "txtWarpCords";
            this.txtWarpCords.Size = new System.Drawing.Size(181, 21);
            this.txtWarpCords.TabIndex = 0;
            this.txtWarpCords.Text = "9,-9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lido Warp -";
            // 
            // cmdLidoWarp
            // 
            this.cmdLidoWarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLidoWarp.Location = new System.Drawing.Point(193, 20);
            this.cmdLidoWarp.Name = "cmdLidoWarp";
            this.cmdLidoWarp.Size = new System.Drawing.Size(34, 21);
            this.cmdLidoWarp.TabIndex = 2;
            this.cmdLidoWarp.Text = "&Go";
            this.cmdLidoWarp.UseVisualStyleBackColor = true;
            this.cmdLidoWarp.Click += new System.EventHandler(this.cmdLidoWarp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "(Be on diving board then hit Warp)";
            // 
            // cmdGetDrink
            // 
            this.cmdGetDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGetDrink.Location = new System.Drawing.Point(193, 88);
            this.cmdGetDrink.Name = "cmdGetDrink";
            this.cmdGetDrink.Size = new System.Drawing.Size(34, 21);
            this.cmdGetDrink.TabIndex = 6;
            this.cmdGetDrink.Text = "&Go";
            this.cmdGetDrink.UseVisualStyleBackColor = true;
            this.cmdGetDrink.Click += new System.EventHandler(this.cmdGetDrink_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Custom Drink -";
            // 
            // txtDrinkName
            // 
            this.txtDrinkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrinkName.Location = new System.Drawing.Point(6, 90);
            this.txtDrinkName.Name = "txtDrinkName";
            this.txtDrinkName.Size = new System.Drawing.Size(181, 21);
            this.txtDrinkName.TabIndex = 4;
            this.txtDrinkName.Text = "Cup\'O\'Soup";
            // 
            // cmdLidoSeatDrop
            // 
            this.cmdLidoSeatDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLidoSeatDrop.Location = new System.Drawing.Point(6, 146);
            this.cmdLidoSeatDrop.Name = "cmdLidoSeatDrop";
            this.cmdLidoSeatDrop.Size = new System.Drawing.Size(221, 21);
            this.cmdLidoSeatDrop.TabIndex = 9;
            this.cmdLidoSeatDrop.Text = "&Go";
            this.cmdLidoSeatDrop.UseVisualStyleBackColor = true;
            this.cmdLidoSeatDrop.Click += new System.EventHandler(this.cmdLidoSeatDrop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lido Seat Drop -";
            // 
            // FrmPubScripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 179);
            this.Controls.Add(this.cmdLidoSeatDrop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdGetDrink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDrinkName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdLidoWarp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWarpCords);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPubScripts";
            this.Text = "Public Room Scripts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPubScripts_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void FrmPubScripts_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        #endregion

        private System.Windows.Forms.TextBox txtWarpCords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdLidoWarp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdGetDrink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDrinkName;
        private System.Windows.Forms.Button cmdLidoSeatDrop;
        private System.Windows.Forms.Label label4;

    }
}