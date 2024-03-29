﻿using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace WindowsAssistant.ResourcesData.Forms
{
	public partial class Interface
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
			this.GroupBox_SecondsClock = new GroupBox();
			this.RadioButton_Add = new RadioButton();
			this.RadioButton_Remove = new RadioButton();
			this.Panel_Left_Layer_One = new Panel();
			this.GroupBox_SearchHistory = new GroupBox();
			this.RadioButton_Enable = new RadioButton();
			this.RadioButton_Disable = new RadioButton();
			this.Panel_Left_Layer_Two = new Panel();
			this.Button_ClearWallpapers = new Button();
			this.Button_ClearColors = new Button();
			this.Panel_Right = new Panel();
			this.GroupBox_Corrections = new GroupBox();
			this.Panel_Right_Layer_One = new Panel();
			this.Button_DesktopUpdate = new Button();
			this.Panel_Right_Layer_Two = new Panel();
			this.Button_IconCache = new Button();
			this.Panel_Left.SuspendLayout();
			this.GroupBox_SecondsClock.SuspendLayout();
			this.GroupBox_SearchHistory.SuspendLayout();
			this.Panel_Right.SuspendLayout();
			this.GroupBox_Corrections.SuspendLayout();
			this.SuspendLayout();

			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))));
			this.ClientSize = new Size(760, 540);
			this.Controls.Add(this.Panel_Right);
			this.Controls.Add(this.Panel_Left);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "Interface";
			this.Text = "Interface";
			this.Load += new EventHandler(this.Form_Interface_Load);
			this.Shown += new EventHandler(this.Form_Interface_Shown);
			this.SizeChanged += new EventHandler(this.Form_Interface_SizeChanged);
			this.Panel_Left.ResumeLayout(false);
			this.GroupBox_SecondsClock.ResumeLayout(false);
			this.GroupBox_SearchHistory.ResumeLayout(false);
			this.Panel_Right.ResumeLayout(false);
			this.GroupBox_Corrections.ResumeLayout(false);
			this.ResumeLayout(false);

			this.Panel_Left.Controls.Add(this.Button_ClearColors);
			this.Panel_Left.Controls.Add(this.Button_ClearWallpapers);
			this.Panel_Left.Controls.Add(this.Panel_Left_Layer_Two);
			this.Panel_Left.Controls.Add(this.GroupBox_SearchHistory);
			this.Panel_Left.Controls.Add(this.Panel_Left_Layer_One);
			this.Panel_Left.Controls.Add(this.GroupBox_SecondsClock);
			this.Panel_Left.Dock = DockStyle.Left;
			this.Panel_Left.Location = new Point(0, 0);
			this.Panel_Left.Name = "Panel_Left";
			this.Panel_Left.Padding = new Padding(4, 2, 4, 2);
			this.Panel_Left.Size = new Size(380, 540);
			this.Panel_Left.TabIndex = 0;

			this.GroupBox_SecondsClock.Controls.Add(this.RadioButton_Remove);
			this.GroupBox_SecondsClock.Controls.Add(this.RadioButton_Add);
			this.GroupBox_SecondsClock.Dock = DockStyle.Top;
			this.GroupBox_SecondsClock.Font = new Font("Microsoft Sans Serif", 12F);
			this.GroupBox_SecondsClock.ForeColor = Color.White;
			this.GroupBox_SecondsClock.Location = new Point(4, 2);
			this.GroupBox_SecondsClock.Name = "GroupBox_SecondsClock";
			this.GroupBox_SecondsClock.Size = new Size(372, 70);
			this.GroupBox_SecondsClock.TabIndex = 0;
			this.GroupBox_SecondsClock.TabStop = false;
			this.GroupBox_SecondsClock.Text = "Seconds in Clock";

			this.RadioButton_Add.Dock = DockStyle.Top;
			this.RadioButton_Add.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_Add.Location = new Point(3, 22);
			this.RadioButton_Add.Name = "RadioButton_Add";
			this.RadioButton_Add.Padding = new Padding(4, 2, 0, 0);
			this.RadioButton_Add.Size = new Size(366, 23);
			this.RadioButton_Add.TabIndex = 0;
			this.RadioButton_Add.Text = "Add";
			this.RadioButton_Add.Click += new EventHandler(this.RadioButtons_SecondsClock_Click);

			this.RadioButton_Remove.Dock = DockStyle.Top;
			this.RadioButton_Remove.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_Remove.Location = new Point(3, 45);
			this.RadioButton_Remove.Name = "RadioButton_Remove";
			this.RadioButton_Remove.Padding = new Padding(4, 0, 0, 0);
			this.RadioButton_Remove.Size = new Size(366, 21);
			this.RadioButton_Remove.TabIndex = 1;
			this.RadioButton_Remove.Text = "Remove";
			this.RadioButton_Remove.Click += new EventHandler(this.RadioButtons_SecondsClock_Click);

			this.Panel_Left_Layer_One.Dock = DockStyle.Top;
			this.Panel_Left_Layer_One.Location = new Point(4, 72);
			this.Panel_Left_Layer_One.Name = "Panel_Left_Layer_One";
			this.Panel_Left_Layer_One.Size = new Size(372, 2);
			this.Panel_Left_Layer_One.TabIndex = 0;

			this.GroupBox_SearchHistory.Controls.Add(this.RadioButton_Disable);
			this.GroupBox_SearchHistory.Controls.Add(this.RadioButton_Enable);
			this.GroupBox_SearchHistory.Dock = DockStyle.Top;
			this.GroupBox_SearchHistory.Font = new Font("Microsoft Sans Serif", 12F);
			this.GroupBox_SearchHistory.ForeColor = Color.White;
			this.GroupBox_SearchHistory.Location = new Point(4, 74);
			this.GroupBox_SearchHistory.Name = "GroupBox_SearchHistory";
			this.GroupBox_SearchHistory.Size = new Size(372, 70);
			this.GroupBox_SearchHistory.TabIndex = 0;
			this.GroupBox_SearchHistory.TabStop = false;
			this.GroupBox_SearchHistory.Text = "Search History";

			this.RadioButton_Enable.Dock = DockStyle.Top;
			this.RadioButton_Enable.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_Enable.Location = new Point(3, 22);
			this.RadioButton_Enable.Name = "RadioButton_Enable";
			this.RadioButton_Enable.Padding = new Padding(4, 2, 0, 0);
			this.RadioButton_Enable.Size = new Size(366, 23);
			this.RadioButton_Enable.TabIndex = 0;
			this.RadioButton_Enable.Text = "Enable";
			this.RadioButton_Enable.Click += new EventHandler(this.RadioButtons_SearchHistory_Click);

			this.RadioButton_Disable.Dock = DockStyle.Top;
			this.RadioButton_Disable.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_Disable.Location = new Point(3, 45);
			this.RadioButton_Disable.Name = "RadioButton_Disable";
			this.RadioButton_Disable.Padding = new Padding(4, 0, 0, 0);
			this.RadioButton_Disable.Size = new Size(366, 21);
			this.RadioButton_Disable.TabIndex = 1;
			this.RadioButton_Disable.Text = "Disable";
			this.RadioButton_Disable.Click += new EventHandler(this.RadioButtons_SearchHistory_Click);

			this.Panel_Left_Layer_Two.Dock = DockStyle.Top;
			this.Panel_Left_Layer_Two.Location = new Point(4, 144);
			this.Panel_Left_Layer_Two.Name = "Panel_Left_Layer_Two";
			this.Panel_Left_Layer_Two.Size = new Size(372, 2);
			this.Panel_Left_Layer_Two.TabIndex = 0;

			this.Button_ClearWallpapers.Dock = DockStyle.Top;
			this.Button_ClearWallpapers.FlatAppearance.BorderSize = 0;
			this.Button_ClearWallpapers.FlatStyle = FlatStyle.Flat;
			this.Button_ClearWallpapers.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_ClearWallpapers.ForeColor = Color.White;
			this.Button_ClearWallpapers.Location = new Point(4, 74);
			this.Button_ClearWallpapers.Name = "Button_ClearWallpapers";
			this.Button_ClearWallpapers.Size = new Size(372, 30);
			this.Button_ClearWallpapers.TabIndex = 0;
			this.Button_ClearWallpapers.Text = "Clear Wallpapers History";
			this.Button_ClearWallpapers.Click += new EventHandler(this.Button_ClearWallpapers_Click);

			this.Button_ClearColors.Dock = DockStyle.Top;
			this.Button_ClearColors.FlatAppearance.BorderSize = 0;
			this.Button_ClearColors.FlatStyle = FlatStyle.Flat;
			this.Button_ClearColors.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_ClearColors.ForeColor = Color.White;
			this.Button_ClearColors.Location = new Point(4, 176);
			this.Button_ClearColors.Name = "Button_ClearColors";
			this.Button_ClearColors.Size = new Size(372, 30);
			this.Button_ClearColors.TabIndex = 0;
			this.Button_ClearColors.Text = "Clear Colors History";
			this.Button_ClearColors.Click += new EventHandler(this.Button_ClearColors_Click);

			this.Panel_Right.Controls.Add(this.GroupBox_Corrections);
			this.Panel_Right.Dock = DockStyle.Fill;
			this.Panel_Right.Location = new Point(380, 0);
			this.Panel_Right.Name = "Panel_Right";
			this.Panel_Right.Padding = new Padding(4, 2, 4, 2);
			this.Panel_Right.Size = new Size(380, 540);
			this.Panel_Right.TabIndex = 0;

			this.GroupBox_Corrections.Controls.Add(this.Button_IconCache);
			this.GroupBox_Corrections.Controls.Add(this.Panel_Right_Layer_Two);
			this.GroupBox_Corrections.Controls.Add(this.Button_DesktopUpdate);
			this.GroupBox_Corrections.Controls.Add(this.Panel_Right_Layer_One);
			this.GroupBox_Corrections.Dock = DockStyle.Top;
			this.GroupBox_Corrections.Font = new Font("Microsoft Sans Serif", 12F);
			this.GroupBox_Corrections.ForeColor = Color.White;
			this.GroupBox_Corrections.Location = new Point(4, 2);
			this.GroupBox_Corrections.Name = "GroupBox_Corrections";
			this.GroupBox_Corrections.Size = new Size(372, 92);
			this.GroupBox_Corrections.TabIndex = 0;
			this.GroupBox_Corrections.TabStop = false;
			this.GroupBox_Corrections.Text = "Corrections";

			this.Panel_Right_Layer_One.Dock = DockStyle.Top;
			this.Panel_Right_Layer_One.Location = new Point(3, 22);
			this.Panel_Right_Layer_One.Name = "Panel_Right_Layer_One";
			this.Panel_Right_Layer_One.Size = new Size(366, 2);
			this.Panel_Right_Layer_One.TabIndex = 0;

			this.Button_DesktopUpdate.Dock = DockStyle.Top;
			this.Button_DesktopUpdate.FlatAppearance.BorderSize = 0;
			this.Button_DesktopUpdate.FlatStyle = FlatStyle.Flat;
			this.Button_DesktopUpdate.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_DesktopUpdate.Location = new Point(3, 24);
			this.Button_DesktopUpdate.Name = "Button_DesktopUpdate";
			this.Button_DesktopUpdate.Size = new Size(366, 30);
			this.Button_DesktopUpdate.TabIndex = 0;
			this.Button_DesktopUpdate.Text = "Desktop Update";
			this.Button_DesktopUpdate.Click += new EventHandler(this.Button_DesktopUpdate_Click);

			this.Panel_Right_Layer_Two.Dock = DockStyle.Top;
			this.Panel_Right_Layer_Two.Location = new Point(3, 54);
			this.Panel_Right_Layer_Two.Name = "Panel_Right_Layer_Two";
			this.Panel_Right_Layer_Two.Size = new Size(366, 4);
			this.Panel_Right_Layer_Two.TabIndex = 0;

			this.Button_IconCache.Dock = DockStyle.Top;
			this.Button_IconCache.FlatAppearance.BorderSize = 0;
			this.Button_IconCache.FlatStyle = FlatStyle.Flat;
			this.Button_IconCache.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_IconCache.Location = new Point(3, 58);
			this.Button_IconCache.Name = "Button_IconCache";
			this.Button_IconCache.Size = new Size(366, 30);
			this.Button_IconCache.TabIndex = 0;
			this.Button_IconCache.Text = "Icon Cache";
			this.Button_IconCache.Click += new EventHandler(this.Button_IconCache_Click);
		}

		private Panel Panel_Left;
		private GroupBox GroupBox_SecondsClock;
		private RadioButton RadioButton_Add;
		private RadioButton RadioButton_Remove;
		private Panel Panel_Left_Layer_One;
		private GroupBox GroupBox_SearchHistory;
		private RadioButton RadioButton_Enable;
		private RadioButton RadioButton_Disable;
		private Panel Panel_Left_Layer_Two;
		private Button Button_ClearWallpapers;
		private Button Button_ClearColors;
		private Panel Panel_Right;
		private GroupBox GroupBox_Corrections;
		private Panel Panel_Right_Layer_One;
		private Button Button_DesktopUpdate;
		private Panel Panel_Right_Layer_Two;
		private Button Button_IconCache;
	}
}