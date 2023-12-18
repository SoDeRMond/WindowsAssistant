﻿using WindowsAssistant.ResourcesData.Source.Root;
using WindowsAssistant.ResourcesData.Forms;
using WindowsAssistant.Properties;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System;

namespace WindowsAssistant
{
	public partial class Template : Form
	{
		[DllImport("User32.dll", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();

		[DllImport("User32.dll", EntryPoint = "SendMessage")]
		private extern static void SendMessage(IntPtr IntPtr_HWND, int Int_WMSG, int Int_WP, int Int_LP);


		private const string _English = "English";


		private Form Form_Active;
		private Panel Panel_LeftBorder;


		private Button Button_Active;
		private string String_ActiveButtonID;


		public Template()
		{ InitializeComponent(); }

		private Bitmap Bitmap_Get()
		{
			if (String_ActiveButtonID == "System") { return Resources.System_White; }
			else if (String_ActiveButtonID == "Interface") { return Resources.Interface_White; }
			else if (String_ActiveButtonID == "ContextMenu") { return Resources.ContextMenu_White; }
			else if (String_ActiveButtonID == "Extensions") { return Resources.Extensions_White; }
			else if (String_ActiveButtonID == "TemporaryPaths") { return Resources.TemporaryPaths_White; }
			else { return Resources.Settings_White; }
		}

		private void Parameters_Set
			(Color Color_Back, Color Color_Fore, Bitmap Bitmap_Button, ContentAlignment ContentAlignment_ImageAlign,
			ContentAlignment ContentAlignment_TextAlign, TextImageRelation TextImageRelation_Button)
		{
			Button_Active.BackColor = Color_Back;
			Button_Active.ForeColor = Color_Fore;

			Button_Active.Image = Bitmap_Button;
			Button_Active.ImageAlign = ContentAlignment_ImageAlign;

			Button_Active.TextAlign = ContentAlignment_TextAlign;
			Button_Active.TextImageRelation = TextImageRelation_Button;
		}

		private void Button_Activate(Button Button_Pressed, Color Color_Form, Bitmap Bitmap_Button)
		{
			Button_Deactivate();

			Button_Active = Button_Pressed;
			String_ActiveButtonID = Classes.Class_LocalizationManager.Translation_Get($"Template_{Button_Pressed.Name}", _English).Replace(" ", string.Empty);

			Parameters_Set(Classes.Class_Colors.Color_ActivateButton, Color_Form, Bitmap_Button,
				ContentAlignment.MiddleCenter, ContentAlignment.MiddleRight, TextImageRelation.TextBeforeImage);

			Panel_LeftBorder.BackColor = Color_Form;
			Panel_LeftBorder.Location = new Point(0, Button_Active.Location.Y);
			Panel_LeftBorder.Visible = true;
			Panel_LeftBorder.BringToFront();
		}

		private void Button_Deactivate()
		{
			if (Button_Active != null)
			{
				Bitmap Bitmap_Button = Bitmap_Get();

				Parameters_Set(Classes.Class_Colors.Color_DeactivatedButton, Color.White, Bitmap_Button,
					ContentAlignment.MiddleLeft, ContentAlignment.MiddleLeft, TextImageRelation.ImageBeforeText);
			}
		}

		private void Form_Open(Form Form_Opening, Color Color_Form)
		{
			Form_Active?.Close();
			Form_Active = Form_Opening;

			Form_Opening.TopLevel = false;
			Form_Opening.Dock = DockStyle.Fill;

			Panel_FormsArea.Controls.Add(Form_Opening);
			Form_Opening.Show();

			Label_Title.ForeColor = Color_Form;
			Label_Title.Text = Classes.Class_LocalizationManager.Translation_Get
				(Form_Opening.Text.Replace(" ", string.Empty).Replace("System", "FSystem"), Classes.Class_SavedData.String_Language);
		}

		private void Home_Open()
		{
			Button_Deactivate();

			Panel_LeftBorder.Visible = false;
			Form_Open(new Home(), Classes.Class_Colors.Color_Home);
		}

		private void Language_Switch()
		{
			if (Classes.Class_SavedData.String_Language == _English)
			{ Classes.Class_SavedData.String_Language = "Russian"; }

			else { Classes.Class_SavedData.String_Language = _English; }

			Classes.Class_SavesManager.Data_Save();
			Classes.Class_LocalizationManager.Forms_Translate();

			Label_Title.Text = Classes.Class_LocalizationManager.Translation_Get(Form_Active.Name, Classes.Class_SavedData.String_Language);
		}

		private void Template_Load()
		{
			Panel_LeftBorder = new Panel { Size = new Size(8, 42) };
			Panel_Tabs.Controls.Add(Panel_LeftBorder);

			Classes.Class_LocalizationManager.Localization_Load();
			Classes.Class_SavesManager.Data_Load();
			Classes.Class_SavesManager.Statuses_Get();

			Home_Open();
		}

		private void Button_System_Click(object Object_Button, EventArgs EventArgs_Click)
		{
			Color Color_System = Classes.Class_Colors.Color_System;

			Button_Activate((Button)Object_Button, Color_System, Resources.System_Colored);
			Form_Open(new FSystem(), Color_System);
		}

		private void Button_Interface_Click(object Object_Button, EventArgs EventArgs_Click)
		{
			Color Color_Interface = Classes.Class_Colors.Color_Interface;

			Button_Activate((Button)Object_Button, Color_Interface, Resources.Interface_Colored);
			Form_Open(new Interface(), Color_Interface);
		}

		private void Button_ContextMenu_Click(object Object_Button, EventArgs EventArgs_Click)
		{
			Color Color_ContextMenu = Classes.Class_Colors.Color_ContextMenu;

			Button_Activate((Button)Object_Button, Color_ContextMenu, Resources.ContextMenu_Colored);
			Form_Open(new ResourcesData.Forms.ContextMenu(), Color_ContextMenu);
		}

		private void Button_Extensions_Click(object Object_Button, EventArgs EventArgs_Click)
		{
			Color Color_Extensions = Classes.Class_Colors.Color_Extensions;

			Button_Activate((Button)Object_Button, Color_Extensions, Resources.Extensions_Colored);
			Form_Open(new Extensions(), Color_Extensions);
		}

		private void Button_TemporaryPaths_Click(object Object_Button, EventArgs EventArgs_Click)
		{
			Color Color_TemporaryPaths = Classes.Class_Colors.Color_TemporaryPaths;

			Button_Activate((Button)Object_Button, Color_TemporaryPaths, Resources.TemporaryPaths_Colored);
			Form_Open(new TemporaryPaths(), Color_TemporaryPaths);
		}

		private void Button_Settings_Click(object Object_Button, EventArgs EventArgs_Click)
		{
			Color Color_Settings = Classes.Class_Colors.Color_Settings;

			Button_Activate((Button)Object_Button, Color_Settings, Resources.Settings_Colored);
			Form_Open(new ResourcesData.Forms.Settings(), Color_Settings);
		}

		private void Button_LanguageSwitcher_Click(object Object_Button, EventArgs EventArgs_Click)
		{ Language_Switch(); }

		private void Label_Logo_Click(object Object_Label, EventArgs EventArgs_Click)
		{ Home_Open(); }

		private void Label_Title_MouseDown(object Object_Label, MouseEventArgs MouseEventArgs_MouseDown)
		{
			ReleaseCapture();
			SendMessage(Handle, 0x112, 0xf012, 0);
		}

		private void Button_Minimize_Click(object Object_Button, EventArgs EventArgs_Click)
		{ WindowState = FormWindowState.Minimized; }

		private void Button_Maximize_Click(object Object_Button, EventArgs EventArgs_Click)
		{
			if (WindowState == FormWindowState.Normal)
			{ WindowState = FormWindowState.Maximized; }

			else { WindowState = FormWindowState.Normal; }
		}

		private void Button_Close_Click(object Object_Button, EventArgs EventArgs_Click)
		{ Process.GetCurrentProcess().Kill(); }

		private void Form_Template_Load(object Object_Form, EventArgs EventArgs_Load)
		{ Template_Load(); }

		private void Form_Template_Shown(object Object_Form, EventArgs EventArgs_Shown)
		{ Classes.Class_LocalizationManager.Forms_Translate(); }
	}
}