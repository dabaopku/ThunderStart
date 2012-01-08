using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PKU.Dabao
{
	static class DataBaseManager
	{
		public static void saveToDataBase(this App app)
		{
			string py = CH2PY.Convert(app.name, "", true);
			Regex re = new Regex(@"[^A-Z]");
			string py2=re.Replace(py, "");
			app.pinyin = string.Format("{0}\n{1}", py, py2);
			using (var db = new ModelContainer())
			{
				var oldApp = db.App.FirstOrDefault(a => a.name == app.name);
				if (oldApp != null)
				{
					oldApp.shortName = app.shortName;
					oldApp.pinyin = app.pinyin;
					oldApp.description = app.description;
					oldApp.cmd = app.cmd;
				}
				else
				{
					if (db.App.Count() == 0)
					{
						app.id = 0;
					}
					else
					{
						int maxId = db.App.Max(a => a.id);
						app.id = maxId + 1;
					}
					db.AddToApp(app);
				}
				db.SaveChanges();
			}
		}

		public static List<App> search(string key)
		{
			using (var db = new ModelContainer())
			{
				return db.App.Where(a => a.name.Contains(key) || a.pinyin.Contains(key) || a.shortName.Contains(key) || a.description.Contains(key)).ToList();
			}
		}

		public static App findInDataBase(this App app)
		{
			using (var db = new ModelContainer())
			{
				return db.App.FirstOrDefault(a => a.name == app.name);
			}
		}
	}
}
