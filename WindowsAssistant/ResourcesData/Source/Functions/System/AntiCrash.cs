using System.IO;
using Microsoft.Win32;

namespace WindowsAssistant.ResourcesData.Source.Functions.System
{
	public class AntiCrash
	{
		private const string _OPENSSL = "OPENSSL_ia32cap";


		private readonly string _Environment = Path.Combine("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Environment");


		public void AntiCrash_Enable()
		{
			using (RegistryKey RegistryKey_AntiCrash = Registry.LocalMachine.CreateSubKey(_Environment))
			{ RegistryKey_AntiCrash.SetValue(_OPENSSL, "~0x20000000"); }
		}

		public void AntiCrash_Disable()
		{
			using (RegistryKey RegistryKey_AntiCrash = Registry.LocalMachine.CreateSubKey(_Environment))
			{ RegistryKey_AntiCrash.DeleteValue(_OPENSSL, false); }
		}

		public int Status_Get()
		{
			using (RegistryKey RegistryKey_AntiCrash = Registry.LocalMachine.CreateSubKey(_Environment))
			{
				if (RegistryKey_AntiCrash.GetValue(_OPENSSL) != null) { return 0; }
				else { return 1; }
			}
		}
	}
}