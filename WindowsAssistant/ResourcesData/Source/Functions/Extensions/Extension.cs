using System.IO;
using Microsoft.Win32;

namespace WindowsAssistant.ResourcesData.Source.Functions.Extensions
{
	public class Extension
	{
		private readonly string _ShellNew = Path.Combine("\\ShellNew");


		public void Extension_Add(string String_Extension)
		{
			using (RegistryKey RegistryKey_FindExtension = Registry.ClassesRoot.OpenSubKey($".{String_Extension}"))
			{
				if (RegistryKey_FindExtension != null)
				{
					using (RegistryKey RegistryKey_Extension = Registry.ClassesRoot.CreateSubKey($".{String_Extension}{_ShellNew}"))
					{ RegistryKey_Extension.SetValue("NullFile", "1"); }
				}
			}
		}

		public void Extension_Remove(string String_Extension)
		{ Registry.ClassesRoot.DeleteSubKeyTree($".{String_Extension}{_ShellNew}", false); }
	}
}