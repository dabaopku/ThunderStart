using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PKU.Dabao
{
	public partial class FormAdd : Form
	{
		public FormAdd()
		{
			InitializeComponent();
			app = new App();
		}
		App app = null;
		public void load(App _app)
		{
			var newApp = _app.findInDataBase();
			if (newApp!=null)
			{
				Text = "编辑快捷方式";
				_app.description = newApp.description;
				_app.shortName = newApp.shortName;
				_app.cmd = newApp.cmd;
			}
			txtName.Text = _app.name;
			txtShortName.Text = _app.shortName;
			txtDesc.Text = _app.description;
			txtCmd.Text = _app.cmd;
			app = _app;
		}

		void save()
		{
			app.name = txtName.Text;
			app.shortName = txtShortName.Text;
			app.description = txtDesc.Text;
			app.cmd = txtCmd.Text;
		}

		private void btOk_Click(object sender, EventArgs e)
		{
			if (app != null)
			{
				save();
				app.saveToDataBase();
			}
			Close();
		}

		private void btCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
