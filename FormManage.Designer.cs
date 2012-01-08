namespace PKU.Dabao
{
	partial class FormManage
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManage));
			this.dgApp = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.appBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgApp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.appBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgApp
			// 
			this.dgApp.AllowUserToAddRows = false;
			this.dgApp.AutoGenerateColumns = false;
			this.dgApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.shortNameDataGridViewTextBoxColumn,
            this.cmdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
			this.dgApp.DataSource = this.appBindingSource;
			this.dgApp.Location = new System.Drawing.Point(25, 23);
			this.dgApp.Name = "dgApp";
			this.dgApp.RowHeadersVisible = false;
			this.dgApp.RowTemplate.Height = 23;
			this.dgApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgApp.Size = new System.Drawing.Size(668, 341);
			this.dgApp.TabIndex = 0;
			this.dgApp.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgApp_CellEndEdit);
			this.dgApp.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgApp_RowsRemoved);
			this.dgApp.Validating += new System.ComponentModel.CancelEventHandler(this.dgApp_Validating);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "名称";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// shortNameDataGridViewTextBoxColumn
			// 
			this.shortNameDataGridViewTextBoxColumn.DataPropertyName = "shortName";
			this.shortNameDataGridViewTextBoxColumn.HeaderText = "缩写";
			this.shortNameDataGridViewTextBoxColumn.Name = "shortNameDataGridViewTextBoxColumn";
			// 
			// cmdDataGridViewTextBoxColumn
			// 
			this.cmdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cmdDataGridViewTextBoxColumn.DataPropertyName = "cmd";
			this.cmdDataGridViewTextBoxColumn.HeaderText = "命令";
			this.cmdDataGridViewTextBoxColumn.Name = "cmdDataGridViewTextBoxColumn";
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "描述";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			// 
			// appBindingSource
			// 
			this.appBindingSource.DataSource = typeof(PKU.Dabao.App);
			// 
			// FormManage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(720, 387);
			this.Controls.Add(this.dgApp);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormManage";
			this.Text = "快捷方式管理";
			this.Load += new System.EventHandler(this.FormManage_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgApp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.appBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgApp;
		private System.Windows.Forms.BindingSource appBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shortNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cmdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
	}
}