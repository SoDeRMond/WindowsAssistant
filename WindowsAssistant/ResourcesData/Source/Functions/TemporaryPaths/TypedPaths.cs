using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;

namespace WindowsAssistant.ResourcesData.Source.Functions.TemporaryPaths
{
	public class TypedPaths
	{
		private readonly string _TypedPaths = Path.Combine("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\TypedPaths");


		public void TypedPaths_Rewrite(Dictionary<string, string> Dictionary_Paths)
		{
			Registry.CurrentUser.DeleteSubKeyTree(_TypedPaths, false);

			using (RegistryKey RegistryKey_Rewrite = Registry.CurrentUser.CreateSubKey(_TypedPaths))
			{
				foreach (KeyValuePair<string, string> KeyValuePair_Path in Dictionary_Paths)
				{
					string String_Key = KeyValuePair_Path.Key;
					string String_Value = KeyValuePair_Path.Value;

					RegistryKey_Rewrite.SetValue(String_Key, String_Value);
				}
			}
		}
	}
}