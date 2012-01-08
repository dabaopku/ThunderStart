namespace PKU.Dabao
{
	partial class FormMain
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.txtCmd = new System.Windows.Forms.TextBox();
			this.lstCmd = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.menuManage = new System.Windows.Forms.ToolStripMenuItem();
			this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtCmd
			// 
			this.txtCmd.Font = new System.Drawing.Font("宋体", 12F);
			this.txtCmd.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtCmd.Location = new System.Drawing.Point(90, 20);
			this.txtCmd.Name = "txtCmd";
			this.txtCmd.Size = new System.Drawing.Size(300, 26);
			this.txtCmd.TabIndex = 0;
			this.txtCmd.TextChanged += new System.EventHandler(this.txtCmd_TextChanged);
			this.txtCmd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCmd_KeyDown);
			// 
			// lstCmd
			// 
			this.lstCmd.Font = new System.Drawing.Font("宋体", 12F);
			this.lstCmd.FormattingEnabled = true;
			this.lstCmd.Location = new System.Drawing.Point(90, 20);
			this.lstCmd.Name = "lstCmd";
			this.lstCmd.Size = new System.Drawing.Size(300, 24);
			this.lstCmd.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "雷暴启动";
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.notifyMenu;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "雷暴启动";
			this.notifyIcon.Visible = true;
			this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
			// 
			// notifyMenu
			// 
			this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.menuAdd,
            this.menuManage,
            this.menuQuit});
			this.notifyMenu.Name = "notifyMenu";
			this.notifyMenu.Size = new System.Drawing.Size(169, 114);
			// 
			// menuOpen
			// 
			this.menuOpen.Name = "menuOpen";
			this.menuOpen.Size = new System.Drawing.Size(168, 22);
			this.menuOpen.Text = "打开(&O)";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			// 
			// menuManage
			// 
			this.menuManage.Name = "menuManage";
			this.menuManage.Size = new System.Drawing.Size(168, 22);
			this.menuManage.Text = "管理快捷方式(&M)";
			this.menuManage.Click += new System.EventHandler(this.menuManage_Click);
			// 
			// menuQuit
			// 
			this.menuQuit.Name = "menuQuit";
			this.menuQuit.Size = new System.Drawing.Size(168, 22);
			this.menuQuit.Text = "退出(&Q)";
			this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
			// 
			// menuAdd
			// 
			this.menuAdd.Name = "menuAdd";
			this.menuAdd.Size = new System.Drawing.Size(168, 22);
			this.menuAdd.Text = "添加快捷方式(&N)";
			this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
			// 
			// FormMain
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumBlue;
			this.ClientSize = new System.Drawing.Size(434, 62);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCmd);
			this.Controls.Add(this.lstCmd);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "雷暴启动";
			this.TopMost = true;
			this.Deactivate += new System.EventHandler(this.FormMain_Deactivate);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
			this.notifyMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtCmd;
		private System.Windows.Forms.ComboBox lstCmd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip notifyMenu;
		private System.Windows.Forms.ToolStripMenuItem menuOpen;
		private System.Windows.Forms.ToolStripMenuItem menuQuit;
		private System.Windows.Forms.ToolStripMenuItem menuManage;
		private System.Windows.Forms.ToolStripMenuItem menuAdd;

	}
}

