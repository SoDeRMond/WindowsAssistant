using WindowsAssistant.ResourcesData.Source.Root;
using System.IO;
using Microsoft.Win32;

namespace WindowsAssistant.ResourcesData.Source.Functions.ContextMenu
{
	public class RegistryEditor
	{
		private readonly string _Regedit = Path.Combine("DesktopBackground\\Shell\\Regedit");
		private readonly string _Command = Path.Combine("DesktopBackground\\Shell\\Regedit\\Command");


		public void RegistryEditor_Add()
		{
			using (RegistryKey RegistryKey_RegistryEditor = Registry.ClassesRoot.CreateSubKey(_Regedit))
			{
				RegistryKey_RegistryEditor.SetValue("MuiVerb", Classes.Class_LocalizationManager.Translation_Get("ContextMenu_RegistryEditor", Classes.Class_SavedData.String_Language));
				RegistryKey_RegistryEditor.SetValue("Icon", "Regedit.exe");
				RegistryKey_RegistryEditor.SetValue("Position", "Bottom");
			}

			using (RegistryKey RegistryKey_RegistryEditor = Registry.ClassesRoot.CreateSubKey(_Command))
			{ RegistryKey_RegistryEditor.SetValue(string.Empty, "Regedit.exe"); }
		}

		public void RegistryEditor_Remove()
		{ Registry.ClassesRoot.DeleteSubKeyTree(_Regedit, false); }

		public int Status_Get()
		{
			try
			{
				using (RegistryKey RegistryKey_RegistryEditor = Registry.ClassesRoot.OpenSubKey(_Regedit))
				{
					if (RegistryKey_RegistryEditor.GetValue("MuiVerb") != null) { return 0; }
					else { return 1; }
				}
			}

			catch { return 1; }
		}
	}
}