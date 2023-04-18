using WindowsAssistant.ResourcesData.Source.Core;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace WindowsAssistant.ResourcesData.Forms
{
	public partial class FSystem : Form
	{
		public FSystem()
		{ InitializeComponent(); }

		private void UI_Refresh()
		{
			if (Classes.Class_SavedData.Int_PowerScheme == 0) { RadioButton_PowerScheme_Unlock.Checked = true; }
			else { RadioButton_PowerScheme_Lock.Checked = true; }

			if (Classes.Class_SavedData.Int_WindowsUpdates == 0) { RadioButton_WindowsUpdates_Enable.Checked = true; }
			else { RadioButton_WindowsUpdates_Disable.Checked = true; }

			if (Classes.Class_SavedData.Int_AntiCrash == 0) { RadioButton_AntiCrash_Enable.Checked = true; }
			else { RadioButton_AntiCrash_Disable.Checked = true; }
		}

		private void RadioButtons_PowerScheme_Click(object Object_RadioButton, EventArgs EventArgs_Click)
		{
			try
			{
				if (((RadioButton)Object_RadioButton).TabIndex == 0) { Classes.Class_PowerScheme.PowerScheme_Unlock(); }
				else { Classes.Class_PowerScheme.PowerScheme_Lock(); }
			} catch { }

			Classes.Class_SavedData.Int_PowerScheme = ((RadioButton)Object_RadioButton).TabIndex;
		}

		private void RadioButtons_WindowsUpdates_Click(object Object_RadioButton, EventArgs EventArgs_Click)
		{
			if (((RadioButton)Object_RadioButton).TabIndex == 0) { Classes.Class_WindowsUpdates.WindowsUpdates_Enable(); }
			else { Classes.Class_WindowsUpdates.WindowsUpdates_Disable(); }

			Classes.Class_SavedData.Int_WindowsUpdates = ((RadioButton)Object_RadioButton).TabIndex;
		}

		private void RadioButtons_AntiCrash_Click(object Object_RadioButton, EventArgs EventArgs_Click)
		{
			if (((RadioButton)Object_RadioButton).TabIndex == 0) { Classes.Class_AntiCrash.AntiCrash_Enable(); }
			else { Classes.Class_AntiCrash.AntiCrash_Disable(); }

			Classes.Class_SavedData.Int_AntiCrash = ((RadioButton)Object_RadioButton).TabIndex;
		}

		private void Form_System_Load(object Object_Form, EventArgs EventArgs_Load)
		{ UI_Refresh(); }

		private void Form_System_Shown(object Object_Form, EventArgs EventArgs_Shown)
		{ Classes.Class_LocalizationManager.Forms_Translate(); }

		private void Form_System_SizeChanged(object Object_Form, EventArgs EventArgs_SizeChanged)
		{ Panel_Left.Size = new Size((Panel_Left.Size.Width + Panel_Right.Size.Width) / 2, Panel_Left.Size.Height); }
	}
}