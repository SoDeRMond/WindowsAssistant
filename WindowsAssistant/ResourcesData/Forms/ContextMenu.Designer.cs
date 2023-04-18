using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace WindowsAssistant.ResourcesData.Forms
{
	public partial class ContextMenu
	{
		private IContainer IContainer_Components = null;


		protected override void Dispose(bool Bool_Disposing)
		{
			if (Bool_Disposing && (IContainer_Components != null))
			{ IContainer_Components.Dispose(); }

			base.Dispose(Bool_Disposing);
		}

		private void InitializeComponent()
		{
			this.Panel_Left = new Panel();
			this.GroupBox_ControlPanel = new GroupBox();
			this.RadioButton_ControlPanel_Add = new RadioButton();
			this.RadioButton_ControlPanel_Delete = new RadioButton();
			this.Panel_Layer = new Panel();
			this.GroupBox_RegistryEditor = new GroupBox();
			this.RadioButton_RegistryEditor_Add = new RadioButton();
			this.RadioButton_RegistryEditor_Delete = new RadioButton();
			this.Panel_Right = new Panel();
			this.Panel_Left.SuspendLayout();
			this.GroupBox_ControlPanel.SuspendLayout();
			this.GroupBox_RegistryEditor.SuspendLayout();
			this.SuspendLayout();

			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))));
			this.ClientSize = new Size(760, 540);
			this.Controls.Add(this.Panel_Right);
			this.Controls.Add(this.Panel_Left);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "ContextMenu";
			this.Text = "Context Menu";
			this.Load += new EventHandler(this.Form_ContextMenu_Load);
			this.Shown += new EventHandler(this.Form_ContextMenu_Shown);
			this.SizeChanged += new EventHandler(this.Form_ContextMenu_SizeChanged);
			this.Panel_Left.ResumeLayout(false);
			this.GroupBox_RegistryEditor.ResumeLayout(false);
			this.GroupBox_ControlPanel.ResumeLayout(false);
			this.ResumeLayout(false);

			this.Panel_Left.Controls.Add(this.GroupBox_RegistryEditor);
			this.Panel_Left.Controls.Add(this.Panel_Layer);
			this.Panel_Left.Controls.Add(this.GroupBox_ControlPanel);
			this.Panel_Left.Dock = DockStyle.Left;
			this.Panel_Left.Location = new Point(0, 0);
			this.Panel_Left.Name = "Panel_Left";
			this.Panel_Left.Padding = new Padding(4, 2, 4, 2);
			this.Panel_Left.Size = new Size(380, 540);
			this.Panel_Left.TabIndex = 0;

			this.GroupBox_ControlPanel.Controls.Add(this.RadioButton_ControlPanel_Delete);
			this.GroupBox_ControlPanel.Controls.Add(this.RadioButton_ControlPanel_Add);
			this.GroupBox_ControlPanel.Dock = DockStyle.Top;
			this.GroupBox_ControlPanel.Font = new Font("Microsoft Sans Serif", 12F);
			this.GroupBox_ControlPanel.ForeColor = Color.White;
			this.GroupBox_ControlPanel.Location = new Point(4, 2);
			this.GroupBox_ControlPanel.Name = "GroupBox_ControlPanel";
			this.GroupBox_ControlPanel.Size = new Size(372, 70);
			this.GroupBox_ControlPanel.TabIndex = 0;
			this.GroupBox_ControlPanel.TabStop = false;
			this.GroupBox_ControlPanel.Text = "Control Panel";

			this.RadioButton_ControlPanel_Add.Dock = DockStyle.Top;
			this.RadioButton_ControlPanel_Add.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_ControlPanel_Add.Location = new Point(3, 22);
			this.RadioButton_ControlPanel_Add.Name = "RadioButton_ControlPanel_Add";
			this.RadioButton_ControlPanel_Add.Padding = new Padding(4, 2, 0, 0);
			this.RadioButton_ControlPanel_Add.Size = new Size(366, 23);
			this.RadioButton_ControlPanel_Add.TabIndex = 0;
			this.RadioButton_ControlPanel_Add.Text = "Add";
			this.RadioButton_ControlPanel_Add.Click += new EventHandler(this.RadioButtons_ControlPanel_Click);

			this.RadioButton_ControlPanel_Delete.Dock = DockStyle.Top;
			this.RadioButton_ControlPanel_Delete.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_ControlPanel_Delete.Location = new Point(3, 45);
			this.RadioButton_ControlPanel_Delete.Name = "RadioButton_ControlPanel_Delete";
			this.RadioButton_ControlPanel_Delete.Padding = new Padding(4, 0, 0, 0);
			this.RadioButton_ControlPanel_Delete.Size = new Size(366, 21);
			this.RadioButton_ControlPanel_Delete.TabIndex = 1;
			this.RadioButton_ControlPanel_Delete.Text = "Delete";
			this.RadioButton_ControlPanel_Delete.Click += new EventHandler(this.RadioButtons_ControlPanel_Click);

			this.Panel_Layer.Dock = DockStyle.Top;
			this.Panel_Layer.Location = new Point(4, 72);
			this.Panel_Layer.Name = "Panel_Layer";
			this.Panel_Layer.Size = new Size(372, 4);
			this.Panel_Layer.TabIndex = 1;

			this.GroupBox_RegistryEditor.Controls.Add(this.RadioButton_RegistryEditor_Delete);
			this.GroupBox_RegistryEditor.Controls.Add(this.RadioButton_RegistryEditor_Add);
			this.GroupBox_RegistryEditor.Dock = DockStyle.Top;
			this.GroupBox_RegistryEditor.Font = new Font("Microsoft Sans Serif", 12F);
			this.GroupBox_RegistryEditor.ForeColor = Color.White;
			this.GroupBox_RegistryEditor.Location = new Point(4, 76);
			this.GroupBox_RegistryEditor.Name = "GroupBox_RegistryEditor";
			this.GroupBox_RegistryEditor.Size = new Size(372, 70);
			this.GroupBox_RegistryEditor.TabIndex = 2;
			this.GroupBox_RegistryEditor.TabStop = false;
			this.GroupBox_RegistryEditor.Text = "Registry Editor";

			this.RadioButton_RegistryEditor_Add.Dock = DockStyle.Top;
			this.RadioButton_RegistryEditor_Add.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_RegistryEditor_Add.Location = new Point(3, 22);
			this.RadioButton_RegistryEditor_Add.Name = "RadioButton_RegistryEditor_Add";
			this.RadioButton_RegistryEditor_Add.Padding = new Padding(4, 2, 0, 0);
			this.RadioButton_RegistryEditor_Add.Size = new Size(366, 23);
			this.RadioButton_RegistryEditor_Add.TabIndex = 0;
			this.RadioButton_RegistryEditor_Add.Text = "Add";
			this.RadioButton_RegistryEditor_Add.Click += new EventHandler(this.RadioButtons_RegistryEditor_Click);

			this.RadioButton_RegistryEditor_Delete.Dock = DockStyle.Top;
			this.RadioButton_RegistryEditor_Delete.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_RegistryEditor_Delete.Location = new Point(3, 45);
			this.RadioButton_RegistryEditor_Delete.Name = "RadioButton_RegistryEditor_Delete";
			this.RadioButton_RegistryEditor_Delete.Padding = new Padding(4, 0, 0, 0);
			this.RadioButton_RegistryEditor_Delete.Size = new Size(366, 21);
			this.RadioButton_RegistryEditor_Delete.TabIndex = 1;
			this.RadioButton_RegistryEditor_Delete.Text = "Delete";
			this.RadioButton_RegistryEditor_Delete.Click += new EventHandler(this.RadioButtons_RegistryEditor_Click);

			this.Panel_Right.Dock = DockStyle.Fill;
			this.Panel_Right.Location = new Point(380, 0);
			this.Panel_Right.Name = "Panel_Right";
			this.Panel_Right.Padding = new Padding(4, 2, 4, 2);
			this.Panel_Right.Size = new Size(380, 540);
			this.Panel_Right.TabIndex = 1;
		}

		private Panel Panel_Left;
		private GroupBox GroupBox_ControlPanel;
		private RadioButton RadioButton_ControlPanel_Add;
		private RadioButton RadioButton_ControlPanel_Delete;
		private Panel Panel_Layer;
		private GroupBox GroupBox_RegistryEditor;
		private RadioButton RadioButton_RegistryEditor_Add;
		private RadioButton RadioButton_RegistryEditor_Delete;
		private Panel Panel_Right;
	}
}