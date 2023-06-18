using WindowsAssistant.ResourcesData.Source.Root;
using System.IO;
using Microsoft.Win32;

namespace WindowsAssistant.ResourcesData.Source.Functions.System
{
	public class PowerScheme
	{
		private const string _PowerShell = "PowerShell.exe";
		private const string _PowerCFG = "PowerCFG";

		private const string _SetActive = "-SetActive";


		private readonly string _UltimatePerformance = Path.Combine("SYSTEM\\CurrentControlSet\\Control\\Power\\User\\PowerSchemes\\e9a42b02-d5df-448d-aa00-03f14749eb61");
		private readonly string _PowerSchemes = Path.Combine("SYSTEM\\CurrentControlSet\\Control\\Power\\User\\PowerSchemes");


		private string UltimatePerformance_Get()
		{
			using (RegistryKey RegistryKey_UltimatePerformance = Registry.LocalMachine.OpenSubKey(_UltimatePerformance))
			{ return RegistryKey_UltimatePerformance.GetValue("FriendlyName").ToString(); }
		}

		private string GUIDScheme_Get()
		{
			string String_UltimatePerformance = UltimatePerformance_Get();

			using (RegistryKey RegistryKey_PowerSchemes = Registry.LocalMachine.OpenSubKey(_PowerSchemes))
			{
				foreach (string String_GUID in RegistryKey_PowerSchemes.GetSubKeyNames())
				{
					if (String_GUID == "e9a42b02-d5df-448d-aa00-03f14749eb61")
					{ continue; }

					using (RegistryKey RegistryKey_GUIDScheme = Registry.LocalMachine.OpenSubKey(Path.Combine($"{_PowerSchemes}\\{String_GUID}")))
					{
						if (RegistryKey_GUIDScheme.GetValue("FriendlyName").ToString() == String_UltimatePerformance)
						{ return String_GUID; }
					}
				}
			}

			return string.Empty;
		}

		public void PowerScheme_Unlock()
		{
			string String_GUIDScheme = GUIDScheme_Get();

			if (String_GUIDScheme == string.Empty)
			{
				Classes.Class_AdditionalMethods.Process_Start(_PowerShell, $"{_PowerCFG} -DuplicateScheme e9a42b02-d5df-448d-aa00-03f14749eb61");
				Classes.Class_AdditionalMethods.Process_Start(_PowerShell, $"{_PowerCFG} {_SetActive} {GUIDScheme_Get()}");
			}
			else
			{
				using (RegistryKey RegistryKey_PowerSchemes = Registry.LocalMachine.OpenSubKey(_PowerSchemes))
				{
					if (RegistryKey_PowerSchemes.GetValue("ActivePowerScheme").ToString() != String_GUIDScheme)
					{ Classes.Class_AdditionalMethods.Process_Start(_PowerShell, $"{_PowerCFG} {_SetActive} {String_GUIDScheme}"); }
				}
			}
		}

		public void PowerScheme_Lock()
		{
			Classes.Class_AdditionalMethods.Process_Start(_PowerShell, $"{_PowerCFG} {_SetActive} 381b4222-f694-41f0-9685-ff5bb260df2e");
			Classes.Class_AdditionalMethods.Process_Start(_PowerShell, $"{_PowerCFG} -Delete {GUIDScheme_Get()}");
		}

		public int Status_Get()
		{
			try
			{
				string String_ActivatedScheme = Classes.Class_AdditionalMethods.Process_Start(_PowerShell, $"{_PowerCFG} -GetActiveScheme");
				string String_GUIDScheme = GUIDScheme_Get();

				if (String_GUIDScheme != string.Empty && String_ActivatedScheme.Contains(String_GUIDScheme) == true) { return 0; }
				else { return 1; }
			} catch { return 1; }
		}
	}
}