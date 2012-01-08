using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PKU.Dabao
{
	/// <summary>
	/// 参考资料:http://www.cnblogs.com/dabaopku/archive/2010/02/21/1670793.html
	/// </summary>
	public class Hotkey : System.Windows.Forms.IMessageFilter
	{
		private const int WM_HotKey = 0x312;
		//存储所有使用的热键
		private UInt32 keyID;
		private readonly IntPtr hWnd;

		public delegate void HotkeyEventHandler();

		public event HotkeyEventHandler OnHotkey;

		public enum KeyFlags
		{
			MOD_ALT = 0x1,
			MOD_CONTROL = 0x2,
			MOD_SHIFT = 0x4,
			MOD_WIN = 0x8
		}

		#region API

		[DllImport("user32.dll")]
		public static extern UInt32 RegisterHotKey(IntPtr hWnd, UInt32 id, UInt32 fsModifiers, UInt32 vk);

		[DllImport("user32.dll")]
		public static extern UInt32 UnregisterHotKey(IntPtr hWnd, UInt32 id);

		[DllImport("kernel32.dll")]
		public static extern UInt32 GlobalAddAtom(String lpString);

		[DllImport("kernel32.dll")]
		public static extern UInt32 GlobalDeleteAtom(UInt32 nAtom);

		#endregion

		public Hotkey(IntPtr hWnd)
		{
			this.hWnd = hWnd;
			Application.AddMessageFilter(this);
		}

		//注册新的热键
		public void RegisterHotkey(Keys Key, KeyFlags keyflags)
		{
			//为热键生成一个全局唯一标识符
			keyID = GlobalAddAtom(System.Guid.NewGuid().ToString());
			RegisterHotKey((IntPtr) hWnd, keyID, (UInt32) keyflags, (UInt32) Key);
		}

		//解除注册热键
		public void UnregisterHotkeys()
		{
			Application.RemoveMessageFilter(this);
			UnregisterHotKey(hWnd, keyID);
			GlobalDeleteAtom(keyID);
		}

		//过滤系统消息
		public bool PreFilterMessage(ref System.Windows.Forms.Message m)
		{
			if (m.Msg == WM_HotKey && (UInt32) m.WParam == keyID)
			{
				if (OnHotkey != null)
				{
					OnHotkey();
					return true;
				}
			}
			return false;
		}
	}
}