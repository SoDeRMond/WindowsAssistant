using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace WindowsAssistant.ResourcesData.Forms
{
	public partial class TemporaryPaths
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
			this.Panel_Path = new Panel();
			this.Label_Path = new Label();
			this.TextBox_Path = new TextBox();
			this.Panel_Left = new Panel();
			this.Label_PathsList = new Label();
			this.ListBox_Paths = new ListBox();
			this.Panel_Right = new Panel();
			this.Button_RefreshList = new Button();
			this.Panel_Layer_One = new Panel();
			this.Button_AddPath = new Button();
			this.Button_DeletePath = new Button();
			this.Panel_Layer_Two = new Panel();
			this.Button_EditPath = new Button();
			this.FolderBrowserDialog_Path = new FolderBrowserDialog();
			this.Panel_Top.SuspendLayout();
			this.Panel_Path.SuspendLayout();
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
			this.Name = "TemporaryPaths";
			this.Text = "Temporary Paths";
			this.Load += new EventHandler(this.Form_TemporaryPaths_Load);
			this.Shown += new EventHandler(this.Form_TemporaryPaths_Shown);
			this.SizeChanged += new EventHandler(this.Form_TemporaryPaths_SizeChanged);
			this.Panel_Top.ResumeLayout(false);
			this.Panel_Path.ResumeLayout(false);
			this.Panel_Path.PerformLayout();
			this.Panel_Left.ResumeLayout(false);
			this.Panel_Right.ResumeLayout(false);
			this.ResumeLayout(false);

			this.Panel_Top.Controls.Add(this.Panel_Path);
			this.Panel_Top.Dock = DockStyle.Top;
			this.Panel_Top.Location = new Point(0, 0);
			this.Panel_Top.Name = "Panel_Top";
			this.Panel_Top.Padding = new Padding(4, 2, 4, 0);
			this.Panel_Top.Size = new Size(760, 28);
			this.Panel_Top.TabIndex = 0;

			this.Panel_Path.BorderStyle = BorderStyle.FixedSingle;
			this.Panel_Path.Controls.Add(this.TextBox_Path);
			this.Panel_Path.Controls.Add(this.Label_Path);
			this.Panel_Path.Dock = DockStyle.Top;
			this.Panel_Path.Location = new Point(4, 2);
			this.Panel_Path.Name = "Panel_Path";
			this.Panel_Path.Size = new Size(752, 24);
			this.Panel_Path.TabIndex = 0;

			this.Label_Path.AutoSize = true;
			this.Label_Path.Dock = DockStyle.Left;
			this.Label_Path.Font = new Font("Microsoft Sans Serif", 12F);
			this.Label_Path.ForeColor = Color.Silver;
			this.Label_Path.Location = new Point(0, 0);
			this.Label_Path.Name = "Label_Path";
			this.Label_Path.Size = new Size(51, 20);
			this.Label_Path.TabIndex = 0;
			this.Label_Path.Text = "Path -";
			this.Label_Path.TextAlign = ContentAlignment.MiddleCenter;

			this.TextBox_Path.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
			this.TextBox_Path.BorderStyle = BorderStyle.None;
			this.TextBox_Path.Dock = DockStyle.Fill;
			this.TextBox_Path.Font = new Font("Microsoft Sans Serif", 13F);
			this.TextBox_Path.ForeColor = Color.WhiteSmoke;
			this.TextBox_Path.Location = new Point(51, 0);
			this.TextBox_Path.Name = "TextBox_Path";
			this.TextBox_Path.ReadOnly = true;
			this.TextBox_Path.Size = new Size(699, 20);
			this.TextBox_Path.TabIndex = 1;
			this.TextBox_Path.DoubleClick += new EventHandler(this.TextBox_Path_DoubleClick);

			this.Panel_Left.Controls.Add(this.ListBox_Paths);
			this.Panel_Left.Controls.Add(this.Label_PathsList);
			this.Panel_Left.Dock = DockStyle.Left;
			this.Panel_Left.Location = new Point(0, 28);
			this.Panel_Left.Name = "Panel_Left";
			this.Panel_Left.Padding = new Padding(4, 0, 0, 0);
			this.Panel_Left.Size = new Size(475, 512);
			this.Panel_Left.TabIndex = 1;

			this.Label_PathsList.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
			this.Label_PathsList.Dock = DockStyle.Top;
			this.Label_PathsList.Font = new Font("Microsoft Sans Serif", 12F);
			this.Label_PathsList.ForeColor = SystemColors.ActiveCaption;
			this.Label_PathsList.Location = new Point(4, 0);
			this.Label_PathsList.Name = "Label_PathsList";
			this.Label_PathsList.Size = new Size(471, 30);
			this.Label_PathsList.TabIndex = 0;
			this.Label_PathsList.Text = "Paths List";
			this.Label_PathsList.TextAlign = ContentAlignment.MiddleCenter;

			this.ListBox_Paths.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))));
			this.ListBox_Paths.BorderStyle = BorderStyle.None;
			this.ListBox_Paths.Dock = DockStyle.Fill;
			this.ListBox_Paths.Font = new Font("Microsoft Sans Serif", 10F);
			this.ListBox_Paths.ForeColor = Color.White;
			this.ListBox_Paths.ItemHeight = 16;
			this.ListBox_Paths.Location = new Point(4, 30);
			this.ListBox_Paths.Name = "ListBox_Paths";
			this.ListBox_Paths.Size = new Size(471, 482);
			this.ListBox_Paths.TabIndex = 1;
			this.ListBox_Paths.Tag = "";

			this.Panel_Right.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
			this.Panel_Right.Controls.Add(this.Button_EditPath);
			this.Panel_Right.Controls.Add(this.Panel_Layer_Two);
			this.Panel_Right.Controls.Add(this.Button_DeletePath);
			this.Panel_Right.Controls.Add(this.Button_AddPath);
			this.Panel_Right.Controls.Add(this.Panel_Layer_One);
			this.Panel_Right.Controls.Add(this.Button_RefreshList);
			this.Panel_Right.Dock = DockStyle.Fill;
			this.Panel_Right.Location = new Point(475, 28);
			this.Panel_Right.Name = "Panel_Right";
			this.Panel_Right.Padding = new Padding(0, 0, 4, 0);
			this.Panel_Right.Size = new Size(285, 512);
			this.Panel_Right.TabIndex = 2;

			this.Button_RefreshList.Dock = DockStyle.Top;
			this.Button_RefreshList.FlatAppearance.BorderSize = 0;
			this.Button_RefreshList.FlatStyle = FlatStyle.Flat;
			this.Button_RefreshList.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_RefreshList.ForeColor = Color.White;
			this.Button_RefreshList.Location = new Point(0, 0);
			this.Button_RefreshList.Name = "Button_RefreshList";
			this.Button_RefreshList.Size = new Size(281, 30);
			this.Button_RefreshList.TabIndex = 0;
			this.Button_RefreshList.Text = "Refresh List";
			this.Button_RefreshList.Click += new EventHandler(this.Button_RefreshList_Click);

			this.Panel_Layer_One.Dock = DockStyle.Top;
			this.Panel_Layer_One.Location = new Point(0, 30);
			this.Panel_Layer_One.Name = "Panel_Layer_One";
			this.Panel_Layer_One.Size = new Size(281, 30);
			this.Panel_Layer_One.TabIndex = 1;

			this.Button_AddPath.Dock = DockStyle.Top;
			this.Button_AddPath.FlatAppearance.BorderSize = 0;
			this.Button_AddPath.FlatStyle = FlatStyle.Flat;
			this.Button_AddPath.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_AddPath.ForeColor = Color.White;
			this.Button_AddPath.Location = new Point(0, 60);
			this.Button_AddPath.Name = "Button_AddPath";
			this.Button_AddPath.Size = new Size(281, 30);
			this.Button_AddPath.TabIndex = 2;
			this.Button_AddPath.Text = "Add Path";
			this.Button_AddPath.Click += new EventHandler(this.Button_AddPath_Click);

			this.Button_DeletePath.Dock = DockStyle.Top;
			this.Button_DeletePath.FlatAppearance.BorderSize = 0;
			this.Button_DeletePath.FlatStyle = FlatStyle.Flat;
			this.Button_DeletePath.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_DeletePath.ForeColor = Color.White;
			this.Button_DeletePath.Location = new Point(0, 90);
			this.Button_DeletePath.Name = "Button_DeletePath";
			this.Button_DeletePath.Size = new Size(281, 30);
			this.Button_DeletePath.TabIndex = 3;
			this.Button_DeletePath.Text = "Delete Path";
			this.Button_DeletePath.Click += new EventHandler(this.Button_DeletePath_Click);

			this.Panel_Layer_Two.Dock = DockStyle.Top;
			this.Panel_Layer_Two.Location = new Point(0, 120);
			this.Panel_Layer_Two.Name = "Panel_Layer_Two";
			this.Panel_Layer_Two.Size = new Size(281, 45);
			this.Panel_Layer_Two.TabIndex = 4;

			this.Button_EditPath.Dock = DockStyle.Top;
			this.Button_EditPath.FlatAppearance.BorderSize = 0;
			this.Button_EditPath.FlatStyle = FlatStyle.Flat;
			this.Button_EditPath.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_EditPath.ForeColor = Color.White;
			this.Button_EditPath.Location = new Point(0, 165);
			this.Button_EditPath.Name = "Button_EditPath";
			this.Button_EditPath.Size = new Size(281, 30);
			this.Button_EditPath.TabIndex = 5;
			this.Button_EditPath.Text = "Edit Path";
			this.Button_EditPath.Click += new EventHandler(this.Button_EditPath_Click);
		}

		private Panel Panel_Top;
		private Panel Panel_Path;
		private Label Label_Path;
		private TextBox TextBox_Path;
		private Panel Panel_Left;
		private Label Label_PathsList;
		private ListBox ListBox_Paths;
		private Panel Panel_Right;
		private Button Button_RefreshList;
		private Panel Panel_Layer_One;
		private Button Button_AddPath;
		private Button Button_DeletePath;
		private Panel Panel_Layer_Two;
		private Button Button_EditPath;
		private FolderBrowserDialog FolderBrowserDialog_Path;
	}
}