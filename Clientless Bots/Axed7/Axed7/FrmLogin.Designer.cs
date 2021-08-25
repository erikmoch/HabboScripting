namespace Axed
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJSESSIONID = new System.Windows.Forms.TextBox();
            this.chkSaveDetails = new System.Windows.Forms.CheckBox();
            this.chkVista = new System.Windows.Forms.CheckBox();
            this.chkNoEnc = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Form :: Place to put your login information";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(12, 47);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(243, 21);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(12, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(243, 21);
            this.txtPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Or....";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "JSESSIONID (Leave Others Blank)";
            // 
            // txtJSESSIONID
            // 
            this.txtJSESSIONID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJSESSIONID.Location = new System.Drawing.Point(12, 149);
            this.txtJSESSIONID.Name = "txtJSESSIONID";
            this.txtJSESSIONID.Size = new System.Drawing.Size(243, 21);
            this.txtJSESSIONID.TabIndex = 7;
            // 
            // chkSaveDetails
            // 
            this.chkSaveDetails.AutoSize = true;
            this.chkSaveDetails.BackColor = System.Drawing.Color.Transparent;
            this.chkSaveDetails.Location = new System.Drawing.Point(170, 176);
            this.chkSaveDetails.Name = "chkSaveDetails";
            this.chkSaveDetails.Size = new System.Drawing.Size(85, 17);
            this.chkSaveDetails.TabIndex = 8;
            this.chkSaveDetails.Text = "Save Details";
            this.chkSaveDetails.UseVisualStyleBackColor = false;
            // 
            // chkVista
            // 
            this.chkVista.AutoSize = true;
            this.chkVista.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVista.Location = new System.Drawing.Point(12, 176);
            this.chkVista.Name = "chkVista";
            this.chkVista.Size = new System.Drawing.Size(165, 17);
            this.chkVista.TabIndex = 9;
            this.chkVista.Text = "I\'m a nub who uses Vista";
            this.chkVista.UseVisualStyleBackColor = true;
            // 
            // chkNoEnc
            // 
            this.chkNoEnc.AutoSize = true;
            this.chkNoEnc.BackColor = System.Drawing.Color.Transparent;
            this.chkNoEnc.Location = new System.Drawing.Point(86, 199);
            this.chkNoEnc.Name = "chkNoEnc";
            this.chkNoEnc.Size = new System.Drawing.Size(93, 17);
            this.chkNoEnc.TabIndex = 10;
            this.chkNoEnc.Text = "No Encryption";
            this.chkNoEnc.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 228);
            this.Controls.Add(this.chkNoEnc);
            this.Controls.Add(this.chkVista);
            this.Controls.Add(this.chkSaveDetails);
            this.Controls.Add(this.txtJSESSIONID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void FrmLogin_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtJSESSIONID;
        internal System.Windows.Forms.CheckBox chkSaveDetails;
        internal System.Windows.Forms.CheckBox chkVista;
        internal System.Windows.Forms.CheckBox chkNoEnc;
    }
}