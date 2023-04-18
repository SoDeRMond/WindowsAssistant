using WindowsAssistant.ResourcesData.Source.Core;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace WindowsAssistant.ResourcesData.Forms
{
	public partial class Extensions : Form
	{
		public Extensions()
		{ InitializeComponent(); }

		private void Button_Add_Click(object Object_Button, EventArgs EventArgs_Click)
		{
			Classes.Class_Extension.Extension_Add(TextBox_Extension.Text);
			Classes.Class_AdditionalMethods.Explorer_Restart();
		}

		private void Button_Delete_Click(object Object_Button, EventArgs EventArgs_Click)
		{
			Classes.Class_Extension.Extension_Delete(TextBox_Extension.Text);
			Classes.Class_AdditionalMethods.Explorer_Restart();
		}

		private void Form_Extensions_Shown(object Object_Form, EventArgs EventArgs_Shown)
		{ Classes.Class_LocalizationManager.Forms_Translate(); }

		private void Form_Extensions_SizeChanged(object Object_Form, EventArgs EventArgs_SizeChanged)
		{ Panel_Left.Size = new Size((Panel_Left.Size.Width + Panel_Right.Size.Width) / 2, Panel_Left.Size.Height); }
	}
}