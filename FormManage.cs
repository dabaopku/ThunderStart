using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PKU.Dabao
{
	public partial class FormManage : Form
	{
		ModelContainer db;
		readonly List<string> hideColumn = new List<string> { "count", "pinyin", "id" };

		Dictionary<string, string> columnHead = new Dictionary<string, string>
			{ 
				{"name","名称"},
				{"shortName","缩写"},
				{"cmd","命令"},
				{"description","描述"}
			};
		public FormManage()
		{
			InitializeComponent();
		}

		private void FormManage_Load(object sender, EventArgs e)
		{
			db = new ModelContainer();
			dgApp.DataSource = db.App;
		}

		private void dgApp_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			save2Database();
		}

		private void dgApp_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			save2Database();
		}

		private void dgApp_Validating(object sender, CancelEventArgs e)
		{
			save2Database();
		}

		private void save2Database()
		{
			try
			{
				db.SaveChanges();
			}
			catch(Exception)
			{

			}
		}
	}
}
