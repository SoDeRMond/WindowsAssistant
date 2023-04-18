using System.IO;
using Microsoft.Win32;

namespace WindowsAssistant.ResourcesData.Source.Functions.Interface
{
	public class ClearWallpapers
	{
		private readonly string _Wallpapers = Path.Combine("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Wallpapers");


		public void Wallpapers_Clear()
		{
			using (RegistryKey RegistryKey_ClearWallpapers = Registry.CurrentUser.CreateSubKey(_Wallpapers))
			{
				foreach (string String_Name in RegistryKey_ClearWallpapers.GetValueNames())
				{
					if (String_Name.StartsWith("BackgroundHistoryPath") && !String_Name.EndsWith("0"))
					{ RegistryKey_ClearWallpapers.DeleteValue(String_Name, false); }
				}
			}
		}
	}
}