using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PKU.Dabao
{
	partial class App
	{
		public override string ToString()
		{
			return string.Format("{0}({1})",name,cmd);
		}
	}
}
