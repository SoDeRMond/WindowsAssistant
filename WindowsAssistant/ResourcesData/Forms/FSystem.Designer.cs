using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace WindowsAssistant.ResourcesData.Forms
{
	public partial class FSystem
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
			this.GroupBox_PowerScheme = new GroupBox();
			this.RadioButton_PowerScheme_Unlock = new RadioButton();
			this.RadioButton_PowerScheme_Lock = new RadioButton();
			this.Panel_Layer = new Panel();
			this.GroupBox_WindowsUpdates = new GroupBox();
			this.RadioButton_WindowsUpdates_Enable = new RadioButton();
			this.RadioButton_WindowsUpdates_Disable = new RadioButton();
			this.Panel_Right = new Panel();
			this.GroupBox_AntiCrash = new GroupBox();
			this.RadioButton_AntiCrash_Enable = new RadioButton();
			this.RadioButton_AntiCrash_Disable = new RadioButton();
			this.Panel_Left.SuspendLayout();
			this.GroupBox_PowerScheme.SuspendLayout();
			this.GroupBox_WindowsUpdates.SuspendLayout();
			this.Panel_Right.SuspendLayout();
			this.GroupBox_AntiCrash.SuspendLayout();
			this.SuspendLayout();

			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))));
			this.ClientSize = new Size(760, 540);
			this.Controls.Add(this.Panel_Right);
			this.Controls.Add(this.Panel_Left);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "FSystem";
			this.Text = "System";
			this.Load += new EventHandler(this.Form_System_Load);
			this.Shown += new EventHandler(this.Form_System_Shown);
			this.SizeChanged += new EventHandler(this.Form_System_SizeChanged);
			this.Panel_Left.ResumeLayout(false);
			this.GroupBox_PowerScheme.ResumeLayout(false);
			this.GroupBox_WindowsUpdates.ResumeLayout(false);
			this.Panel_Right.ResumeLayout(false);
			this.GroupBox_AntiCrash.ResumeLayout(false);
			this.ResumeLayout(false);

			this.Panel_Left.Controls.Add(this.GroupBox_WindowsUpdates);
			this.Panel_Left.Controls.Add(this.Panel_Layer);
			this.Panel_Left.Controls.Add(this.GroupBox_PowerScheme);
			this.Panel_Left.Dock = DockStyle.Left;
			this.Panel_Left.Location = new Point(0, 0);
			this.Panel_Left.Name = "Panel_Left";
			this.Panel_Left.Padding = new Padding(4, 2, 4, 2);
			this.Panel_Left.Size = new Size(380, 540);
			this.Panel_Left.TabIndex = 0;

			this.GroupBox_PowerScheme.Controls.Add(this.RadioButton_PowerScheme_Lock);
			this.GroupBox_PowerScheme.Controls.Add(this.RadioButton_PowerScheme_Unlock);
			this.GroupBox_PowerScheme.Dock = DockStyle.Top;
			this.GroupBox_PowerScheme.Font = new Font("Microsoft Sans Serif", 12F);
			this.GroupBox_PowerScheme.ForeColor = Color.White;
			this.GroupBox_PowerScheme.Location = new Point(4, 2);
			this.GroupBox_PowerScheme.Name = "GroupBox_PowerScheme";
			this.GroupBox_PowerScheme.Size = new Size(372, 70);
			this.GroupBox_PowerScheme.TabIndex = 0;
			this.GroupBox_PowerScheme.TabStop = false;
			this.GroupBox_PowerScheme.Text = "\"Ultimate Performance\" Power Scheme";

			this.RadioButton_PowerScheme_Unlock.Dock = DockStyle.Top;
			this.RadioButton_PowerScheme_Unlock.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_PowerScheme_Unlock.Location = new Point(3, 22);
			this.RadioButton_PowerScheme_Unlock.Name = "RadioButton_PowerScheme_Unlock";
			this.RadioButton_PowerScheme_Unlock.Padding = new Padding(4, 2, 0, 0);
			this.RadioButton_PowerScheme_Unlock.Size = new Size(366, 23);
			this.RadioButton_PowerScheme_Unlock.TabIndex = 0;
			this.RadioButton_PowerScheme_Unlock.Text = "Unlock and Activate";
			this.RadioButton_PowerScheme_Unlock.Click += new EventHandler(this.RadioButtons_PowerScheme_Click);

			this.RadioButton_PowerScheme_Lock.Dock = DockStyle.Top;
			this.RadioButton_PowerScheme_Lock.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_PowerScheme_Lock.Location = new Point(3, 45);
			this.RadioButton_PowerScheme_Lock.Name = "RadioButton_PowerScheme_Lock";
			this.RadioButton_PowerScheme_Lock.Padding = new Padding(4, 0, 0, 0);
			this.RadioButton_PowerScheme_Lock.Size = new Size(366, 21);
			this.RadioButton_PowerScheme_Lock.TabIndex = 1;
			this.RadioButton_PowerScheme_Lock.Text = "Lock and Deactivate";
			this.RadioButton_PowerScheme_Lock.Click += new EventHandler(this.RadioButtons_PowerScheme_Click);

			this.Panel_Layer.Dock = DockStyle.Top;
			this.Panel_Layer.Location = new Point(4, 72);
			this.Panel_Layer.Name = "Panel_Layer";
			this.Panel_Layer.Size = new Size(372, 4);
			this.Panel_Layer.TabIndex = 0;

			this.GroupBox_WindowsUpdates.Controls.Add(this.RadioButton_WindowsUpdates_Disable);
			this.GroupBox_WindowsUpdates.Controls.Add(this.RadioButton_WindowsUpdates_Enable);
			this.GroupBox_WindowsUpdates.Dock = DockStyle.Top;
			this.GroupBox_WindowsUpdates.Font = new Font("Microsoft Sans Serif", 12F);
			this.GroupBox_WindowsUpdates.ForeColor = Color.White;
			this.GroupBox_WindowsUpdates.Location = new Point(4, 76);
			this.GroupBox_WindowsUpdates.Name = "GroupBox_WindowsUpdates";
			this.GroupBox_WindowsUpdates.Size = new Size(372, 70);
			this.GroupBox_WindowsUpdates.TabIndex = 0;
			this.GroupBox_WindowsUpdates.TabStop = false;
			this.GroupBox_WindowsUpdates.Text = "Windows Updates";

			this.RadioButton_WindowsUpdates_Enable.Dock = DockStyle.Top;
			this.RadioButton_WindowsUpdates_Enable.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_WindowsUpdates_Enable.Location = new Point(3, 22);
			this.RadioButton_WindowsUpdates_Enable.Name = "RadioButton_WindowsUpdates_Enable";
			this.RadioButton_WindowsUpdates_Enable.Padding = new Padding(4, 2, 0, 0);
			this.RadioButton_WindowsUpdates_Enable.Size = new Size(366, 23);
			this.RadioButton_WindowsUpdates_Enable.TabIndex = 0;
			this.RadioButton_WindowsUpdates_Enable.Text = "Enable";
			this.RadioButton_WindowsUpdates_Enable.Click += new EventHandler(this.RadioButtons_WindowsUpdates_Click);

			this.RadioButton_WindowsUpdates_Disable.Dock = DockStyle.Top;
			this.RadioButton_WindowsUpdates_Disable.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_WindowsUpdates_Disable.Location = new Point(3, 45);
			this.RadioButton_WindowsUpdates_Disable.Name = "RadioButton_WindowsUpdates_Disable";
			this.RadioButton_WindowsUpdates_Disable.Padding = new Padding(4, 0, 0, 0);
			this.RadioButton_WindowsUpdates_Disable.Size = new Size(366, 21);
			this.RadioButton_WindowsUpdates_Disable.TabIndex = 1;
			this.RadioButton_WindowsUpdates_Disable.Text = "Disable";
			this.RadioButton_WindowsUpdates_Disable.Click += new EventHandler(this.RadioButtons_WindowsUpdates_Click);

			this.Panel_Right.Controls.Add(this.GroupBox_AntiCrash);
			this.Panel_Right.Dock = DockStyle.Fill;
			this.Panel_Right.Location = new Point(380, 0);
			this.Panel_Right.Name = "Panel_Right";
			this.Panel_Right.Padding = new Padding(4, 2, 4, 2);
			this.Panel_Right.Size = new Size(380, 540);
			this.Panel_Right.TabIndex = 0;

			this.GroupBox_AntiCrash.Controls.Add(this.RadioButton_AntiCrash_Disable);
			this.GroupBox_AntiCrash.Controls.Add(this.RadioButton_AntiCrash_Enable);
			this.GroupBox_AntiCrash.Dock = DockStyle.Top;
			this.GroupBox_AntiCrash.Font = new Font("Microsoft Sans Serif", 12F);
			this.GroupBox_AntiCrash.ForeColor = Color.White;
			this.GroupBox_AntiCrash.Location = new Point(4, 76);
			this.GroupBox_AntiCrash.Name = "GroupBox_AntiCrash";
			this.GroupBox_AntiCrash.Size = new Size(372, 70);
			this.GroupBox_AntiCrash.TabIndex = 0;
			this.GroupBox_AntiCrash.TabStop = false;
			this.GroupBox_AntiCrash.Text = "Anti-Crash in Unreal Engine Games";

			this.RadioButton_AntiCrash_Enable.Dock = DockStyle.Top;
			this.RadioButton_AntiCrash_Enable.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_AntiCrash_Enable.Location = new Point(3, 22);
			this.RadioButton_AntiCrash_Enable.Name = "RadioButton_AntiCrash_Enable";
			this.RadioButton_AntiCrash_Enable.Padding = new Padding(4, 2, 0, 0);
			this.RadioButton_AntiCrash_Enable.Size = new Size(366, 23);
			this.RadioButton_AntiCrash_Enable.TabIndex = 0;
			this.RadioButton_AntiCrash_Enable.Text = "Enable";
			this.RadioButton_AntiCrash_Enable.Click += new EventHandler(this.RadioButtons_AntiCrash_Click);

			this.RadioButton_AntiCrash_Disable.Dock = DockStyle.Top;
			this.RadioButton_AntiCrash_Disable.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_AntiCrash_Disable.Location = new Point(3, 45);
			this.RadioButton_AntiCrash_Disable.Name = "RadioButton_AntiCrash_Disable";
			this.RadioButton_AntiCrash_Disable.Padding = new Padding(4, 0, 0, 0);
			this.RadioButton_AntiCrash_Disable.Size = new Size(366, 21);
			this.RadioButton_AntiCrash_Disable.TabIndex = 1;
			this.RadioButton_AntiCrash_Disable.Text = "Disable";
			this.RadioButton_AntiCrash_Disable.Click += new EventHandler(this.RadioButtons_AntiCrash_Click);
		}

		private Panel Panel_Left;
		private GroupBox GroupBox_PowerScheme;
		private RadioButton RadioButton_PowerScheme_Unlock;
		private RadioButton RadioButton_PowerScheme_Lock;
		private Panel Panel_Layer;
		private GroupBox GroupBox_WindowsUpdates;
		private RadioButton RadioButton_WindowsUpdates_Enable;
		private RadioButton RadioButton_WindowsUpdates_Disable;
		private Panel Panel_Right;
		private GroupBox GroupBox_AntiCrash;
		private RadioButton RadioButton_AntiCrash_Enable;
		private RadioButton RadioButton_AntiCrash_Disable;
	}
}