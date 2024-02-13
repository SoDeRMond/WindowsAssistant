using WindowsAssistant.ResourcesData.Source.Controllers.Localization;
using WindowsAssistant.ResourcesData.Source.Functions.TemporaryPaths;
using WindowsAssistant.ResourcesData.Source.Functions.ContextMenu;
using WindowsAssistant.ResourcesData.Source.Functions.Extensions;
using WindowsAssistant.ResourcesData.Source.Functions.Interface;
using WindowsAssistant.ResourcesData.Source.Controllers.Saves;
using WindowsAssistant.ResourcesData.Source.Functions.System;
using WindowsAssistant.ResourcesData.Source.Controllers;
using WindowsAssistant.ResourcesData.Source.Managers;
using WindowsAssistant.ResourcesData.Source.Data;

namespace WindowsAssistant.ResourcesData.Source.Root
{
	public static class Classes
	{
		public static AdditionalMethods Class_AdditionalMethods = new AdditionalMethods();
		public static SavedData Class_SavedData = new SavedData();
		public static Colors Class_Colors = new Colors();


		public static PowerScheme Class_PowerScheme = new PowerScheme();
		public static WindowsUpdates Class_WindowsUpdates = new WindowsUpdates();
		public static AntiCrash Class_AntiCrash = new AntiCrash();


		public static SecondsClock Class_SecondsClock = new SecondsClock();
		public static SearchHistory Class_SearchHistory = new SearchHistory();
		public static ClearWallpapers Class_ClearWallpapers = new ClearWallpapers();
		public static ClearColors Class_ClearColors = new ClearColors();
		public static Corrections Class_Corrections = new Corrections();


		public static ControlPanel Class_ControlPanel = new ControlPanel();
		public static RegistryEditor Class_RegistryEditor = new RegistryEditor();


		public static Extension Class_Extension = new Extension();


		public static TypedPaths Class_TypedPaths = new TypedPaths();


		public static LocalizationManager Class_LocalizationManager = new LocalizationManager();
		public static UpdatesManager Class_UpdatesManager = new UpdatesManager();
		public static SavesManager Class_SavesManager = new SavesManager();


		public static LocalizationController Class_LocalizationController = new LocalizationController();
		public static TranslationsController Class_TranslationsController = new TranslationsController();


		public static UpdatesController Class_UpdatesController = new UpdatesController();
		public static SavesController Class_SavesController = new SavesController();
		public static PathController Class_PathController = new PathController();
	}
}