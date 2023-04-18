using WindowsAssistant.ResourcesData.Source.Core;
using System.IO;
using Microsoft.Win32;

namespace WindowsAssistant.ResourcesData.Source.Functions.ContextMenu
{
	public class ControlPanel
	{
		private readonly string _Control = Path.Combine("DesktopBackground\\Shell\\Control");
		private readonly string _Command = Path.Combine("DesktopBackground\\Shell\\Control\\Command");


		public void ControlPanel_Add()
		{
			using (RegistryKey RegistryKey_ControlPanel = Registry.ClassesRoot.CreateSubKey(_Control))
			{
				RegistryKey_ControlPanel.SetValue("MuiVerb", Classes.Class_LocalizationManager.Translation_Get("ContextMenu_ControlPanel", Classes.Class_SavedData.String_Language));
				RegistryKey_ControlPanel.SetValue("Icon", "Control.exe");
				RegistryKey_ControlPanel.SetValue("Position", "Bottom");
			}

			using (RegistryKey RegistryKey_ControlPanel = Registry.ClassesRoot.CreateSubKey(_Command))
			{ RegistryKey_ControlPanel.SetValue(string.Empty, "Control.exe"); }
		}

		public void ControlPanel_Delete()
		{ Registry.ClassesRoot.DeleteSubKeyTree(_Control, false); }

		public int Status_Get()
		{
			try
			{
				using (RegistryKey RegistryKey_ControlPanel = Registry.ClassesRoot.OpenSubKey(_Control))
				{
					if (RegistryKey_ControlPanel.GetValue("MuiVerb") != null) { return 0; }
					else { return 1; }
				}
			}

			catch { return 1; }
		}
	}
}