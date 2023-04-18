﻿using WindowsAssistant.ResourcesData.Source.Core;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace WindowsAssistant.ResourcesData.Forms
{
	public partial class Interface : Form
	{
		public Interface()
		{ InitializeComponent(); }

		private void UI_Refresh()
		{
			if (Classes.Class_SavedData.Int_SecondsClock == 0) { RadioButton_Add.Checked = true; }
			else { RadioButton_Delete.Checked = true; }
		}

		private void RadioButtons_SecondsClock_Click(object Object_RadioButton, EventArgs EventArgs_Click)
		{
			if (((RadioButton)Object_RadioButton).TabIndex == 0) { Classes.Class_SecondsClock.SecondsClock_Add(); }
			else { Classes.Class_SecondsClock.SecondsClock_Delete(); }

			Classes.Class_SavedData.Int_SecondsClock = ((RadioButton)Object_RadioButton).TabIndex;
			Classes.Class_AdditionalMethods.Explorer_Restart();
		}

		private void Button_ClearWallpapers_Click(object Object_Button, EventArgs EventArgs_Click)
		{ Classes.Class_ClearWallpapers.Wallpapers_Clear(); }

		private void Button_DesktopUpdate_Click(object Object_Button, EventArgs EventArgs_Click)
		{
			Classes.Class_Corrections.DesktopUpdate();
			Classes.Class_AdditionalMethods.Explorer_Restart();
		}

		private void Button_IconCache_Click(object Object_Button, EventArgs EventArgs_Click)
		{
			Classes.Class_Corrections.IconCache();
			Classes.Class_AdditionalMethods.Explorer_Restart();
		}

		private void Form_Interface_Load(object Object_Form, EventArgs EventArgs_Load)
		{ UI_Refresh(); }

		private void Form_Interface_Shown(object Object_Form, EventArgs EventArgs_Shown)
		{ Classes.Class_LocalizationManager.Forms_Translate(); }

		private void Form_Interface_SizeChanged(object Object_Form, EventArgs EventArgs_SizeChanged)
		{ Panel_Left.Size = new Size((Panel_Left.Size.Width + Panel_Right.Size.Width) / 2, Panel_Left.Size.Height); }
	}
}