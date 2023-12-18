using WindowsAssistant.ResourcesData.Source.Root;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System;
using Microsoft.Win32;

namespace WindowsAssistant.ResourcesData.Forms
{
	public partial class TemporaryPaths : Form
	{
		private readonly string _TypedPaths = Path.Combine("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\TypedPaths");
		private readonly string _Applications = Path.Combine("C:\\ProgramData\\Microsoft\\Windows\\Start Menu");

		public readonly Dictionary<string, string> Dictionary_Paths = new Dictionary<string, string>();
		private bool Bool_TemporaryPaths = false;


		public TemporaryPaths()
		{ InitializeComponent(); }

		private void Paths_Refresh()
		{
			Dictionary_Paths.Clear();
			ListBox_Paths.Items.Clear();

			using (RegistryKey RegistryKey_Paths = Registry.CurrentUser.CreateSubKey(_TypedPaths))
			{
				foreach (string String_Key in RegistryKey_Paths.GetValueNames())
				{
					string String_Value = RegistryKey_Paths.GetValue(String_Key).ToString();

					Dictionary_Paths.Add(String_Key, String_Value);
					ListBox_Paths.Items.Add(String_Value);
				}
			}
		}

		private void Path_ShowDialog()
		{
			FolderBrowserDialog_Path.Description = Classes.Class_LocalizationManager.Translation_Get("TemporaryPaths_FolderBrowserDialog_Path_Description", Classes.Class_SavedData.String_Language);

			if (FolderBrowserDialog_Path.ShowDialog() == DialogResult.OK)
			{
				TextBox_Path.Text = FolderBrowserDialog_Path.SelectedPath;
				Paths_Refresh();
			}
		}

		private void TypedPath_Refresh()
		{
			Classes.Class_TypedPaths.TypedPaths_Rewrite(Dictionary_Paths);
			Paths_Refresh();

			Classes.Class_AdditionalMethods.Explorer_Restart();
		}

		private void Path_Add(string String_Path)
		{
			Dictionary_Paths.Add($"url{Dictionary_Paths.Keys.Count + 1}", String_Path);
			TypedPath_Refresh();
		}

		private void Path_Delete()
		{
			int Int_RemoveKeyIndex = new List<string>(Dictionary_Paths.Keys).IndexOf($"url{ListBox_Paths.SelectedIndex + 1}");
			Dictionary_Paths.Remove($"url{ListBox_Paths.SelectedIndex + 1}");

			for (int Int_KeyIndex = Int_RemoveKeyIndex; Int_KeyIndex < Dictionary_Paths.Keys.Count; Int_KeyIndex++)
			{
				string String_OldKey = new List<string>(Dictionary_Paths.Keys)[Int_KeyIndex];
				string String_NewValue = Dictionary_Paths[String_OldKey];
				string String_NewKey = $"url{Int_KeyIndex + 1}";

				Dictionary_Paths.Remove(String_OldKey);
				Dictionary_Paths.Add(String_NewKey, String_NewValue);
			}

			TypedPath_Refresh();
		}

		private void Path_Edit()
		{
			Dictionary_Paths[$"url{ListBox_Paths.SelectedIndex + 1}"] = TextBox_Path.Text;
			TypedPath_Refresh();
		}

		private void Path_Open(string String_Path)
		{
			if (Bool_TemporaryPaths == true)
			{ Path_Add(String_Path); }

			Classes.Class_AdditionalMethods.Process_Start("Explorer.exe", String_Path);
		}

		private void TextBox_Path_DoubleClick(object Object_TextBox, EventArgs EventArgs_DoubleClick)
		{ Path_ShowDialog(); }

		private void Button_RefreshList_Click(object Object_Button, EventArgs EventArgs_Click)
		{ Paths_Refresh(); }

		private void Button_AddPath_Click(object Object_Button, EventArgs EventArgs_Click)
		{ if (TextBox_Path.Text != string.Empty) { Path_Add(TextBox_Path.Text); } }

		private void Button_DeletePath_Click(object Object_Button, EventArgs EventArgs_Click)
		{ if (ListBox_Paths.SelectedItem != null) { Path_Delete(); } }

		private void Button_EditPath_Click(object Object_Button, EventArgs EventArgs_Click)
		{ if (ListBox_Paths.SelectedItem != null && TextBox_Path.Text != string.Empty) { Path_Edit(); } }

		private void Button_CopyPath_Click(object Object_Button, EventArgs EventArgs_Click)
		{ if (ListBox_Paths.Text != string.Empty) { Clipboard.SetText(ListBox_Paths.Text); } }

		private void CheckBox_TemporaryPaths_Click(object Object_CheckBox, EventArgs EventArgs_Click)
		{ Bool_TemporaryPaths = ((CheckBox)Object_CheckBox).Checked; }

		private void Button_Applications_Click(object Object_Button, EventArgs EventArgs_Click)
		{ Path_Open(_Applications); }

		private void Form_TemporaryPaths_Load(object Object_Form, EventArgs EventArgs_Load)
		{ Paths_Refresh(); }

		private void Form_TemporaryPaths_Shown(object Object_Form, EventArgs EventArgs_Shown)
		{ Classes.Class_LocalizationManager.Forms_Translate(); }

		private void Form_TemporaryPaths_SizeChanged(object Object_Form, EventArgs EventArgs_SizeChanged)
		{ Panel_Left.Size = new Size((Panel_Left.Size.Width + Panel_Right.Size.Width) / 2 + Panel_Right.Width / 4, Panel_Left.Size.Height); }
	}
}