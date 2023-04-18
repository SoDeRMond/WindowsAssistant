using System.Windows.Forms;
using System;

namespace WindowsAssistant
{
	public static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Template());
		}
	}
}