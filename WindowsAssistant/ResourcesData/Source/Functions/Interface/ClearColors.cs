using System.IO;
using Microsoft.Win32;

namespace WindowsAssistant.ResourcesData.Source.Functions.Interface
{
	public class ClearColors
	{
		private readonly string _Colors = Path.Combine("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\History\\Colors");


		public void Colors_Clear()
		{
			using (RegistryKey RegistryKey_ClearColors = Registry.CurrentUser.CreateSubKey(_Colors))
			{
				foreach (string String_Name in RegistryKey_ClearColors.GetValueNames())
				{ RegistryKey_ClearColors.DeleteValue(String_Name, false); }
			}
		}
	}
}