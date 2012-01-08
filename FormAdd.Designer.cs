namespace PKU.Dabao
{
	partial class FormAdd
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtShortName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.btOk = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.txtCmd = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 12F);
			this.label1.Location = new System.Drawing.Point(25, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "名称";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 12F);
			this.label2.Location = new System.Drawing.Point(27, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "缩写";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("宋体", 12F);
			this.txtName.Location = new System.Drawing.Point(88, 25);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(268, 26);
			this.txtName.TabIndex = 1;
			// 
			// txtShortName
			// 
			this.txtShortName.Font = new System.Drawing.Font("宋体", 12F);
			this.txtShortName.Location = new System.Drawing.Point(88, 57);
			this.txtShortName.Name = "txtShortName";
			this.txtShortName.Size = new System.Drawing.Size(262, 26);
			this.txtShortName.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 12F);
			this.label3.Location = new System.Drawing.Point(25, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "描述";
			// 
			// txtDesc
			// 
			this.txtDesc.Font = new System.Drawing.Font("宋体", 12F);
			this.txtDesc.Location = new System.Drawing.Point(30, 162);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(218, 130);
			this.txtDesc.TabIndex = 4;
			// 
			// btOk
			// 
			this.btOk.Font = new System.Drawing.Font("宋体", 12F);
			this.btOk.Location = new System.Drawing.Point(275, 196);
			this.btOk.Name = "btOk";
			this.btOk.Size = new System.Drawing.Size(75, 30);
			this.btOk.TabIndex = 6;
			this.btOk.Text = "确定";
			this.btOk.UseVisualStyleBackColor = true;
			this.btOk.Click += new System.EventHandler(this.btOk_Click);
			// 
			// btCancel
			// 
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.Font = new System.Drawing.Font("宋体", 12F);
			this.btCancel.Location = new System.Drawing.Point(275, 246);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(75, 28);
			this.btCancel.TabIndex = 7;
			this.btCancel.Text = "取消";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// txtCmd
			// 
			this.txtCmd.Font = new System.Drawing.Font("宋体", 12F);
			this.txtCmd.Location = new System.Drawing.Point(88, 97);
			this.txtCmd.Name = "txtCmd";
			this.txtCmd.Size = new System.Drawing.Size(262, 26);
			this.txtCmd.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 12F);
			this.label4.Location = new System.Drawing.Point(27, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "命令";
			// 
			// FormAdd
			// 
			this.AcceptButton = this.btOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btCancel;
			this.ClientSize = new System.Drawing.Size(384, 304);
			this.Controls.Add(this.txtCmd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btOk);
			this.Controls.Add(this.txtDesc);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtShortName);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormAdd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "新建快捷方式";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtShortName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDesc;
		private System.Windows.Forms.Button btOk;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.TextBox txtCmd;
		private System.Windows.Forms.Label label4;
	}
}