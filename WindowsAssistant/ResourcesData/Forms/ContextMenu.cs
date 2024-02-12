using WindowsAssistant.ResourcesData.Source.Root;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace WindowsAssistant.ResourcesData.Forms
{
	public partial class ContextMenu : Form
	{
		public ContextMenu()
		{ InitializeComponent(); }

		private void UI_Refresh()
		{
			if (Classes.Class_SavedData.Int_ControlPanel == 0) { RadioButton_ControlPanel_Add.Checked = true; }
			else { RadioButton_ControlPanel_Remove.Checked = true; }

			if (Classes.Class_SavedData.Int_RegistryEditor == 0) { RadioButton_RegistryEditor_Add.Checked = true; }
			else { RadioButton_RegistryEditor_Remove.Checked = true; }
		}

		private void RadioButtons_ControlPanel_Click(object Object_RadioButton, EventArgs EventArgs_Click)
		{
			if (((RadioButton)Object_RadioButton).TabIndex == 0) { Classes.Class_ControlPanel.ControlPanel_Add(); }
			else { Classes.Class_ControlPanel.ControlPanel_Remove(); }

			Classes.Class_SavedData.Int_ControlPanel = ((RadioButton)Object_RadioButton).TabIndex;
		}

		private void RadioButtons_RegistryEditor_Click(object Object_RadioButton, EventArgs EventArgs_Click)
		{
			if (((RadioButton)Object_RadioButton).TabIndex == 0) { Classes.Class_RegistryEditor.RegistryEditor_Add(); }
			else { Classes.Class_RegistryEditor.RegistryEditor_Remove(); }

			Classes.Class_SavedData.Int_RegistryEditor = ((RadioButton)Object_RadioButton).TabIndex;
		}

		private void Form_ContextMenu_Load(object Object_Form, EventArgs EventArgs_Load)
		{ UI_Refresh(); }

		private void Form_ContextMenu_Shown(object Object_Form, EventArgs EventArgs_Shown)
		{ Classes.Class_LocalizationManager.Forms_Translate(); }

		private void Form_ContextMenu_SizeChanged(object Object_Form, EventArgs EventArgs_SizeChanged)
		{ Panel_Left.Size = new Size((Panel_Left.Size.Width + Panel_Right.Size.Width) / 2, Panel_Left.Size.Height); }
	}
}