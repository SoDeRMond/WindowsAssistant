using System.IO;
using Microsoft.Win32;

namespace WindowsAssistant.ResourcesData.Source.Functions.Interface
{
	public class SecondsClock
	{
		private const string _Seconds = "ShowSecondsInSystemClock";


		private readonly string _Advanced = Path.Combine("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");


		public void SecondsClock_Add()
		{
			using (RegistryKey RegistryKey_SecondsClock = Registry.CurrentUser.CreateSubKey(_Advanced))
			{ RegistryKey_SecondsClock.SetValue(_Seconds, 1, RegistryValueKind.DWord); }
		}

		public void SecondsClock_Remove()
		{
			using (RegistryKey RegistryKey_SecondsClock = Registry.CurrentUser.CreateSubKey(_Advanced))
			{ RegistryKey_SecondsClock.DeleteValue(_Seconds, false); }
		}

		public int Status_Get()
		{
			using (RegistryKey RegistryKey_SecondsClock = Registry.CurrentUser.CreateSubKey(_Advanced))
			{
				if (RegistryKey_SecondsClock.GetValue(_Seconds) != null) { return 0; }
				else { return 1; }
			}
		}
	}
}