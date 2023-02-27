// Token: 0x0200003D RID: 61
public partial class Packetlogger : global::System.Windows.Forms.Form
{
	// Token: 0x060001D4 RID: 468 RVA: 0x0000336E File Offset: 0x0000156E
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x00014E50 File Offset: 0x00013050
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
		this.logOptionsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.stopTheServerLogToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.stopTheClientLogToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.clearLogToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.saveHabboswfToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.saveLogToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.txtSearch = new global::System.Windows.Forms.TextBox();
		this.txtInject = new global::System.Windows.Forms.TextBox();
		this.fontDialog_0 = new global::System.Windows.Forms.FontDialog();
		this.fontStyleToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.backgroundColorToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.fontColorsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.clientToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.serverToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.fontFamilyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.colorDialog_0 = new global::System.Windows.Forms.ColorDialog();
		this.menuStrip1.SuspendLayout();
		base.SuspendLayout();
		this.richTextBox1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.richTextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.richTextBox1.ForeColor = global::System.Drawing.Color.PaleGreen;
		this.richTextBox1.Location = new global::System.Drawing.Point(0, 33);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.Size = new global::System.Drawing.Size(909, 526);
		this.richTextBox1.TabIndex = 0;
		this.richTextBox1.Text = "";
		this.richTextBox1.SizeChanged += new global::System.EventHandler(this.richTextBox1_SizeChanged);
		this.richTextBox1.TextChanged += new global::System.EventHandler(this.richTextBox1_TextChanged);
		this.richTextBox1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.Packetlogger_KeyDown);
		this.richTextBox1.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.Packetlogger_KeyPress);
		this.timer_0.Enabled = true;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		this.menuStrip1.Font = new global::System.Drawing.Font("Segoe UI", 14f);
		this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.logOptionsToolStripMenuItem,
			this.toolsToolStripMenuItem
		});
		this.menuStrip1.Location = new global::System.Drawing.Point(0, 0);
		this.menuStrip1.Name = "menuStrip1";
		this.menuStrip1.Size = new global::System.Drawing.Size(909, 33);
		this.menuStrip1.TabIndex = 2;
		this.menuStrip1.Text = "menuStrip1";
		this.logOptionsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.fontStyleToolStripMenuItem,
			this.stopTheServerLogToolStripMenuItem,
			this.stopTheClientLogToolStripMenuItem,
			this.clearLogToolStripMenuItem
		});
		this.logOptionsToolStripMenuItem.Name = "logOptionsToolStripMenuItem";
		this.logOptionsToolStripMenuItem.Size = new global::System.Drawing.Size(126, 29);
		this.logOptionsToolStripMenuItem.Text = "Log Options";
		this.stopTheServerLogToolStripMenuItem.Name = "stopTheServerLogToolStripMenuItem";
		this.stopTheServerLogToolStripMenuItem.Size = new global::System.Drawing.Size(242, 30);
		this.stopTheServerLogToolStripMenuItem.Text = "Stop the server log";
		this.stopTheServerLogToolStripMenuItem.Click += new global::System.EventHandler(this.stopTheServerLogToolStripMenuItem_Click);
		this.stopTheClientLogToolStripMenuItem.Name = "stopTheClientLogToolStripMenuItem";
		this.stopTheClientLogToolStripMenuItem.Size = new global::System.Drawing.Size(242, 30);
		this.stopTheClientLogToolStripMenuItem.Text = "Stop the client log";
		this.stopTheClientLogToolStripMenuItem.Click += new global::System.EventHandler(this.stopTheClientLogToolStripMenuItem_Click);
		this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
		this.clearLogToolStripMenuItem.Size = new global::System.Drawing.Size(242, 30);
		this.clearLogToolStripMenuItem.Text = "Clear log";
		this.clearLogToolStripMenuItem.Click += new global::System.EventHandler(this.clearLogToolStripMenuItem_Click);
		this.toolsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.saveHabboswfToolStripMenuItem,
			this.saveLogToolStripMenuItem
		});
		this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
		this.toolsToolStripMenuItem.Size = new global::System.Drawing.Size(69, 29);
		this.toolsToolStripMenuItem.Text = "Tools";
		this.saveHabboswfToolStripMenuItem.Name = "saveHabboswfToolStripMenuItem";
		this.saveHabboswfToolStripMenuItem.Size = new global::System.Drawing.Size(216, 30);
		this.saveHabboswfToolStripMenuItem.Text = "Save Habbo.swf";
		this.saveHabboswfToolStripMenuItem.Click += new global::System.EventHandler(this.saveHabboswfToolStripMenuItem_Click);
		this.saveLogToolStripMenuItem.Name = "saveLogToolStripMenuItem";
		this.saveLogToolStripMenuItem.Size = new global::System.Drawing.Size(216, 30);
		this.saveLogToolStripMenuItem.Text = "Save log";
		this.saveLogToolStripMenuItem.Click += new global::System.EventHandler(this.saveLogToolStripMenuItem_Click);
		this.txtSearch.BackColor = global::System.Drawing.Color.Silver;
		this.txtSearch.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtSearch.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.txtSearch.Location = new global::System.Drawing.Point(0, 516);
		this.txtSearch.Name = "txtSearch";
		this.txtSearch.Size = new global::System.Drawing.Size(909, 43);
		this.txtSearch.TabIndex = 3;
		this.txtSearch.Visible = false;
		this.txtSearch.TextChanged += new global::System.EventHandler(this.txtSearch_TextChanged);
		this.txtSearch.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.Packetlogger_KeyDown);
		this.txtInject.BackColor = global::System.Drawing.Color.Silver;
		this.txtInject.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtInject.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.txtInject.Location = new global::System.Drawing.Point(0, 473);
		this.txtInject.Name = "txtInject";
		this.txtInject.Size = new global::System.Drawing.Size(909, 43);
		this.txtInject.TabIndex = 4;
		this.txtInject.Visible = false;
		this.txtInject.TextChanged += new global::System.EventHandler(this.txtInject_TextChanged);
		this.txtInject.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtInject_KeyDown);
		this.fontDialog_0.Color = global::System.Drawing.SystemColors.ControlText;
		this.fontDialog_0.Apply += new global::System.EventHandler(this.fontDialog_0_Apply);
		this.fontStyleToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.backgroundColorToolStripMenuItem,
			this.fontColorsToolStripMenuItem,
			this.fontFamilyToolStripMenuItem
		});
		this.fontStyleToolStripMenuItem.Name = "fontStyleToolStripMenuItem";
		this.fontStyleToolStripMenuItem.Size = new global::System.Drawing.Size(242, 30);
		this.fontStyleToolStripMenuItem.Text = "Font Style";
		this.fontStyleToolStripMenuItem.Click += new global::System.EventHandler(this.fontStyleToolStripMenuItem_Click);
		this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
		this.backgroundColorToolStripMenuItem.Size = new global::System.Drawing.Size(233, 30);
		this.backgroundColorToolStripMenuItem.Text = "Background color";
		this.backgroundColorToolStripMenuItem.Click += new global::System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
		this.fontColorsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.clientToolStripMenuItem,
			this.serverToolStripMenuItem
		});
		this.fontColorsToolStripMenuItem.Name = "fontColorsToolStripMenuItem";
		this.fontColorsToolStripMenuItem.Size = new global::System.Drawing.Size(233, 30);
		this.fontColorsToolStripMenuItem.Text = "Font colors";
		this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
		this.clientToolStripMenuItem.Size = new global::System.Drawing.Size(152, 30);
		this.clientToolStripMenuItem.Text = "Client";
		this.clientToolStripMenuItem.Click += new global::System.EventHandler(this.clientToolStripMenuItem_Click);
		this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
		this.serverToolStripMenuItem.Size = new global::System.Drawing.Size(152, 30);
		this.serverToolStripMenuItem.Text = "Server";
		this.serverToolStripMenuItem.Click += new global::System.EventHandler(this.serverToolStripMenuItem_Click);
		this.fontFamilyToolStripMenuItem.Name = "fontFamilyToolStripMenuItem";
		this.fontFamilyToolStripMenuItem.Size = new global::System.Drawing.Size(233, 30);
		this.fontFamilyToolStripMenuItem.Text = "Font Family";
		this.fontFamilyToolStripMenuItem.Click += new global::System.EventHandler(this.fontFamilyToolStripMenuItem_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(909, 559);
		base.Controls.Add(this.txtInject);
		base.Controls.Add(this.txtSearch);
		base.Controls.Add(this.richTextBox1);
		base.Controls.Add(this.menuStrip1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		this.ForeColor = global::System.Drawing.Color.LimeGreen;
		base.MainMenuStrip = this.menuStrip1;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "Packetlogger";
		this.Text = "Packetlogger";
		base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Packetlogger_FormClosed);
		base.Load += new global::System.EventHandler(this.Packetlogger_Load);
		base.SizeChanged += new global::System.EventHandler(this.Packetlogger_SizeChanged);
		base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.Packetlogger_KeyDown);
		base.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.Packetlogger_KeyPress);
		base.Resize += new global::System.EventHandler(this.Packetlogger_Resize);
		this.menuStrip1.ResumeLayout(false);
		this.menuStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000140 RID: 320
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000141 RID: 321
	private global::System.Windows.Forms.RichTextBox richTextBox1;

	// Token: 0x04000142 RID: 322
	private global::System.Windows.Forms.Timer timer_0;

	// Token: 0x04000143 RID: 323
	private global::System.Windows.Forms.MenuStrip menuStrip1;

	// Token: 0x04000144 RID: 324
	private global::System.Windows.Forms.ToolStripMenuItem logOptionsToolStripMenuItem;

	// Token: 0x04000145 RID: 325
	private global::System.Windows.Forms.ToolStripMenuItem stopTheServerLogToolStripMenuItem;

	// Token: 0x04000146 RID: 326
	private global::System.Windows.Forms.ToolStripMenuItem stopTheClientLogToolStripMenuItem;

	// Token: 0x04000147 RID: 327
	private global::System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;

	// Token: 0x04000148 RID: 328
	private global::System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;

	// Token: 0x04000149 RID: 329
	private global::System.Windows.Forms.TextBox txtSearch;

	// Token: 0x0400014A RID: 330
	private global::System.Windows.Forms.TextBox txtInject;

	// Token: 0x0400014B RID: 331
	private global::System.Windows.Forms.ToolStripMenuItem saveHabboswfToolStripMenuItem;

	// Token: 0x0400014C RID: 332
	private global::System.Windows.Forms.ToolStripMenuItem saveLogToolStripMenuItem;

	// Token: 0x0400014D RID: 333
	private global::System.Windows.Forms.FontDialog fontDialog_0;

	// Token: 0x0400014E RID: 334
	private global::System.Windows.Forms.ToolStripMenuItem fontStyleToolStripMenuItem;

	// Token: 0x0400014F RID: 335
	private global::System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;

	// Token: 0x04000150 RID: 336
	private global::System.Windows.Forms.ToolStripMenuItem fontColorsToolStripMenuItem;

	// Token: 0x04000151 RID: 337
	private global::System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;

	// Token: 0x04000152 RID: 338
	private global::System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;

	// Token: 0x04000153 RID: 339
	private global::System.Windows.Forms.ToolStripMenuItem fontFamilyToolStripMenuItem;

	// Token: 0x04000154 RID: 340
	private global::System.Windows.Forms.ColorDialog colorDialog_0;
}
