using System.IO;
using Microsoft.Win32;

namespace WindowsAssistant.ResourcesData.Source.Functions.Interface
{
	public class SearchHistory
	{
		private const string _Search = "DisableSearchBoxSuggestions";


		private readonly string _Explorer = Path.Combine("SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer");


		public void SearchHistory_Enable()
		{
			using (RegistryKey RegistryKey_SearchHistory = Registry.CurrentUser.CreateSubKey(_Explorer))
			{ RegistryKey_SearchHistory.DeleteValue(_Search, false); }
		}

		public void SearchHistory_Disable()
		{
			using (RegistryKey RegistryKey_SearchHistory = Registry.CurrentUser.CreateSubKey(_Explorer))
			{ RegistryKey_SearchHistory.SetValue(_Search, 1, RegistryValueKind.DWord); }
		}

		public int Status_Get()
		{
			using (RegistryKey RegistryKey_SearchHistory = Registry.CurrentUser.CreateSubKey(_Explorer))
			{
				if (RegistryKey_SearchHistory.GetValue(_Search) == null) { return 0; }
				else { return 1; }
			}
		}
	}
}