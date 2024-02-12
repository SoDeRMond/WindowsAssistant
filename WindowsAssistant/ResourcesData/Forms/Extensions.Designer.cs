using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace WindowsAssistant.ResourcesData.Forms
{
	public partial class Extensions
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
			this.Panel_Top = new Panel();
			this.Panel_Extension = new Panel();
			this.Label_Extension = new Label();
			this.TextBox_Extension = new TextBox();
			this.Panel_Left = new Panel();
			this.Button_Add = new Button();
			this.Panel_Right = new Panel();
			this.Button_Remove = new Button();
			this.Panel_Top.SuspendLayout();
			this.Panel_Extension.SuspendLayout();
			this.Panel_Left.SuspendLayout();
			this.Panel_Right.SuspendLayout();
			this.SuspendLayout();

			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))));
			this.ClientSize = new Size(760, 540);
			this.Controls.Add(this.Panel_Right);
			this.Controls.Add(this.Panel_Left);
			this.Controls.Add(this.Panel_Top);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "Extensions";
			this.Text = "Extensions";
			this.Shown += new EventHandler(this.Form_Extensions_Shown);
			this.Panel_Top.ResumeLayout(false);
			this.Panel_Extension.ResumeLayout(false);
			this.Panel_Extension.PerformLayout();
			this.Panel_Left.ResumeLayout(false);
			this.Panel_Right.ResumeLayout(false);
			this.ResumeLayout(false);

			this.Panel_Top.Controls.Add(this.Panel_Extension);
			this.Panel_Top.Dock = DockStyle.Top;
			this.Panel_Top.Location = new Point(0, 0);
			this.Panel_Top.Name = "Panel_Top";
			this.Panel_Top.Padding = new Padding(4, 2, 4, 2);
			this.Panel_Top.Size = new Size(760, 28);
			this.Panel_Top.TabIndex = 0;

			this.Panel_Extension.BorderStyle = BorderStyle.FixedSingle;
			this.Panel_Extension.Controls.Add(this.TextBox_Extension);
			this.Panel_Extension.Controls.Add(this.Label_Extension);
			this.Panel_Extension.Dock = DockStyle.Fill;
			this.Panel_Extension.Location = new Point(4, 2);
			this.Panel_Extension.Name = "Panel_Extension";
			this.Panel_Extension.Size = new Size(752, 24);
			this.Panel_Extension.TabIndex = 0;

			this.Label_Extension.AutoSize = true;
			this.Label_Extension.Dock = DockStyle.Left;
			this.Label_Extension.Font = new Font("Microsoft Sans Serif", 12F);
			this.Label_Extension.ForeColor = Color.Silver;
			this.Label_Extension.Location = new Point(0, 0);
			this.Label_Extension.Name = "Label_Extension";
			this.Label_Extension.Size = new Size(88, 20);
			this.Label_Extension.TabIndex = 0;
			this.Label_Extension.Text = "Extension -";
			this.Label_Extension.TextAlign = ContentAlignment.MiddleCenter;

			this.TextBox_Extension.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
			this.TextBox_Extension.BorderStyle = BorderStyle.None;
			this.TextBox_Extension.Dock = DockStyle.Fill;
			this.TextBox_Extension.Font = new Font("Microsoft Sans Serif", 13F);
			this.TextBox_Extension.ForeColor = Color.WhiteSmoke;
			this.TextBox_Extension.Location = new Point(88, 0);
			this.TextBox_Extension.Name = "TextBox_Extension";
			this.TextBox_Extension.Size = new Size(662, 20);
			this.TextBox_Extension.TabIndex = 0;
			this.TextBox_Extension.Text = "Without Dot";

			this.Panel_Left.Controls.Add(this.Button_Add);
			this.Panel_Left.Dock = DockStyle.Left;
			this.Panel_Left.Location = new Point(0, 28);
			this.Panel_Left.Name = "Panel_Left";
			this.Panel_Left.Padding = new Padding(4, 2, 4, 2);
			this.Panel_Left.Size = new Size(380, 512);
			this.Panel_Left.TabIndex = 0;

			this.Button_Add.Dock = DockStyle.Top;
			this.Button_Add.FlatAppearance.BorderSize = 0;
			this.Button_Add.FlatStyle = FlatStyle.Flat;
			this.Button_Add.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_Add.ForeColor = Color.White;
			this.Button_Add.Location = new Point(4, 2);
			this.Button_Add.Name = "Button_Add";
			this.Button_Add.Size = new Size(372, 30);
			this.Button_Add.TabIndex = 0;
			this.Button_Add.Text = "Add";
			this.Button_Add.Click += new EventHandler(this.Button_Add_Click);

			this.Panel_Right.Controls.Add(this.Button_Remove);
			this.Panel_Right.Dock = DockStyle.Fill;
			this.Panel_Right.Location = new Point(380, 28);
			this.Panel_Right.Name = "Panel_Right";
			this.Panel_Right.Padding = new Padding(4, 2, 4, 2);
			this.Panel_Right.Size = new Size(380, 512);
			this.Panel_Right.TabIndex = 0;

			this.Button_Remove.Dock = DockStyle.Top;
			this.Button_Remove.FlatAppearance.BorderSize = 0;
			this.Button_Remove.FlatStyle = FlatStyle.Flat;
			this.Button_Remove.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_Remove.ForeColor = Color.White;
			this.Button_Remove.Location = new Point(4, 2);
			this.Button_Remove.Name = "Button_Remove";
			this.Button_Remove.Size = new Size(372, 30);
			this.Button_Remove.TabIndex = 0;
			this.Button_Remove.Text = "Remove";
			this.Button_Remove.Click += new EventHandler(this.Button_Remove_Click);
		}

		private Panel Panel_Top;
		private Panel Panel_Extension;
		private Label Label_Extension;
		private TextBox TextBox_Extension;
		private Panel Panel_Left;
		private Button Button_Add;
		private Panel Panel_Right;
		private Button Button_Remove;
	}
}