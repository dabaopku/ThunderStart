using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PKU.Dabao
{
	public partial class FormMain : Form
	{
		readonly Hotkey hotKey;
		public FormMain()
		{
			InitializeComponent();
			hotKey = new Hotkey(Handle);
			hotKey.RegisterHotkey(Keys.R, Hotkey.KeyFlags.MOD_CONTROL);
			hotKey.OnHotkey+=new Hotkey.HotkeyEventHandler(hotKey_OnHotkey);
		}

		private void hotKey_OnHotkey()
		{
			Show();
		}

		#region 窗体事件

		private void txtCmd_TextChanged(object sender, EventArgs e)
		{
			if (txtCmd.Text != "")
			{
				lstCmd.Items.Clear();
				var res=DataBaseManager.search(txtCmd.Text);
				foreach (var a in res)
				{
					lstCmd.Items.Add(a);
				}
				lstCmd.DroppedDown = true;
			}
			else
			{
				lstCmd.DroppedDown = false;
			}
		}

		//捕捉用户按键
		private void txtCmd_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				//如果是上下键,实现候选项选择
				case Keys.Down:
					e.Handled = true;
					lstCmd.DroppedDown = true;
					if (lstCmd.Items.Count==0)
					{
						break;
					}
					if (lstCmd.SelectedIndex<lstCmd.Items.Count-1)
					{
						lstCmd.SelectedIndex++;
					}
					else
					{
						lstCmd.SelectedIndex = 0;
					}
					break;
				case Keys.Up:
					e.Handled = true;
					lstCmd.DroppedDown = true;
					if (lstCmd.Items.Count == 0)
					{
						break;
					}
					if (lstCmd.SelectedIndex > 0)
					{
						lstCmd.SelectedIndex--;
					}
					else
					{
						lstCmd.SelectedIndex = lstCmd.Items.Count - 1;
					}
					break;
				//回车键执行命令
				case Keys.Enter:
					if (lstCmd.Items.Count==0)
					{
						break;
					}
					if (lstCmd.SelectedItem==null)
					{
						lstCmd.SelectedIndex = 0;
					}
					System.Diagnostics.Process.Start((lstCmd.SelectedItem as App).cmd);
					break;
				case Keys.Escape:
					if (lstCmd.DroppedDown)
					{
						lstCmd.DroppedDown = false;
					}
					else
					{
						hideWindow();
					}
					break;
				default:
					break;
			}
		}

		private void FormMain_DragDrop(object sender, DragEventArgs e)
		{
			App file = e.getApp();
			FormAdd form = new FormAdd();
			form.load(file);
			form.ShowDialog();
		}

		private void FormMain_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			hideWindow();
		}

		private void hideWindow()
		{
			Hide();
			notifyIcon.ShowBalloonTip(1000, "雷暴启动", "你可以单击这里打开主窗口", ToolTipIcon.Info);
		}
		private void FormMain_Deactivate(object sender, EventArgs e)
		{
			hideWindow();
		}

		#endregion

		#region 托盘图标

		private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Show();
			}
		}

		private void menuOpen_Click(object sender, EventArgs e)
		{
			Show();
		}

		private void menuQuit_Click(object sender, EventArgs e)
		{
			quit();
		}

		private void quit()
		{
			hotKey.UnregisterHotkeys();
			Application.ExitThread();
		}

		#endregion

		private void menuManage_Click(object sender, EventArgs e)
		{
			var frm = new FormManage();
			frm.ShowDialog();
		}

		private void menuAdd_Click(object sender, EventArgs e)
		{
			var frm = new FormAdd();
			frm.ShowDialog();
		}



	}
}
