using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PKU.Dabao
{
	static class DragDropHandler
	{
		public static App getApp(this DragEventArgs e)
		{
			string fileName = getFileName(e);
			if (fileName == null)
				return null;
			return analyseFile(fileName);
		}

		static string getFileName(DragEventArgs e)
		{
			var data = e.Data.GetData("FileDrop") as Array;
			if (data != null && data.Length > 0 && data.GetValue(0) is string)
			{
				return data.GetValue(0) as string;
			}
			return null;
		}

		static App analyseFile(string fileName)
		{
			if (fileName == null)
				return null;
				
			App app = new App();
			app.name = Path.GetFileNameWithoutExtension(fileName);
			app.cmd = fileName;
			return app;
#if false
			if (Directory.Exists(fileName))
			{
				app.name = Path.GetFileName(fileName);
				app.cmd = "explorer " + fileName;
				return app;
			}
			if (!File.Exists(fileName))
			{
				return null;
			}

			string ext,name;
			do
			{
				ext = Path.GetExtension(fileName);
				name = Path.GetFileNameWithoutExtension(fileName);
				if(ext!=".lnk")
					break;
				var shell = new IWshRuntimeLibrary.WshShell();
				IWshRuntimeLibrary.IWshShortcut link=shell.CreateShortcut(fileName) as IWshRuntimeLibrary.IWshShortcut;
				fileName = link.TargetPath;
			}while (true);
			app.name = name;

			switch (ext)
			{
				case ".exe":
					app.cmd = fileName;
					break;
			}

			return app;
#endif
		}
	}
}
