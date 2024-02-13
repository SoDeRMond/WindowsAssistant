using WindowsAssistant.ResourcesData.Source.Root;
using WindowsAssistant.ResourcesData.Source.Data;
using System.Text.Json;
using System.IO;

namespace WindowsAssistant.ResourcesData.Source.Controllers.Saves
{
	public class SavesController
	{
		private readonly JsonSerializerOptions JsonSerializerOptions_Saving = new JsonSerializerOptions
		{ WriteIndented = true };


		public void Data_Save()
		{
			string String_SavePath = Path.Combine($"{Classes.Class_SavedData.String_SaveDirectory}\\{Classes.Class_SavedData.String_SaveName}");

			string String_SerializeData = JsonSerializer.Serialize(Classes.Class_SavedData, JsonSerializerOptions_Saving);
			File.WriteAllText(String_SavePath, String_SerializeData);
		}

		public void Data_Load()
		{
			string String_SavePath = Path.Combine($"{Classes.Class_SavedData.String_SaveDirectory}\\{Classes.Class_SavedData.String_SaveName}");

			string String_SavedData = File.ReadAllText(String_SavePath);
			Classes.Class_SavedData = JsonSerializer.Deserialize<SavedData>(String_SavedData);
		}

		public void Statuses_Get()
		{
			Classes.Class_SavedData.Int_PowerScheme = Classes.Class_PowerScheme.Status_Get();
			Classes.Class_SavedData.Int_WindowsUpdates = Classes.Class_WindowsUpdates.Status_Get();
			Classes.Class_SavedData.Int_AntiCrash = Classes.Class_AntiCrash.Status_Get();

			Classes.Class_SavedData.Int_SecondsClock = Classes.Class_SecondsClock.Status_Get();
			Classes.Class_SavedData.Int_SearchHistory = Classes.Class_SearchHistory.Status_Get();

			Classes.Class_SavedData.Int_ControlPanel = Classes.Class_ControlPanel.Status_Get();
			Classes.Class_SavedData.Int_RegistryEditor = Classes.Class_RegistryEditor.Status_Get();
		}

		public void Directory_Delete(string String_Directory, bool Bool_PathDelete)
		{
			string[] Strings_Files = Directory.GetFiles(String_Directory);
			bool Bool_DirectoryDelete = true;

			foreach (string String_File in Strings_Files)
			{
				if (Path.GetExtension(String_File) != ".json")
				{ Bool_DirectoryDelete = false; }

				else { File.Delete(String_File); }
			}

			if (Bool_DirectoryDelete == true)
			{ Directory.Delete(String_Directory, true); }

			if (Bool_PathDelete == true)
			{ Classes.Class_PathController.Path_Delete(); }
		}
	}
}