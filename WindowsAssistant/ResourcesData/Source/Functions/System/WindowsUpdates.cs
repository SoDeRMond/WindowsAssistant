using System.IO;
using Microsoft.Win32;

namespace WindowsAssistant.ResourcesData.Source.Functions.System
{
	public class WindowsUpdates
	{
		private const string _Internet = "DoNotConnectToWindowsUpdateInternetLocations";
		private const string _Server = "server.wsus";


		private readonly string _WindowsUpdate = Path.Combine("SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate");
		private readonly string _AU = Path.Combine("SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU");


		public void WindowsUpdates_Enable()
		{ Registry.LocalMachine.DeleteSubKeyTree(_WindowsUpdate, false); }

		public void WindowsUpdates_Disable()
		{
			using (RegistryKey RegistryKey_WindowsUpdates = Registry.LocalMachine.CreateSubKey(_WindowsUpdate))
			{
				RegistryKey_WindowsUpdates.SetValue(_Internet, 1, RegistryValueKind.DWord);
				RegistryKey_WindowsUpdates.SetValue("UpdateServiceUrlAlternate", _Server);
				RegistryKey_WindowsUpdates.SetValue("WUServer", _Server);
				RegistryKey_WindowsUpdates.SetValue("WUStatusServer", _Server);
			}

			using (RegistryKey RegistryKey_WindowsUpdates = Registry.LocalMachine.CreateSubKey(_AU))
			{ RegistryKey_WindowsUpdates.SetValue("UseWUServer", 1, RegistryValueKind.DWord); }
		}

		public int Status_Get()
		{
			using (RegistryKey RegistryKey_WindowsUpdates = Registry.LocalMachine.CreateSubKey(_WindowsUpdate))
			{
				if (RegistryKey_WindowsUpdates.GetValue(_Internet) == null) { return 0; }
				else { return 1; }
			}
		}
	}
}