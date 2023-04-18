using System.Runtime.InteropServices;
using System.IO;
using System;
using Microsoft.Win32.SafeHandles;
using Microsoft.Win32;

namespace WindowsAssistant.ResourcesData.Source.Functions.Interface
{
	public class Corrections
	{
		[DllImport("IEFrame.dll", SetLastError = true)]
		static extern int IEGetWriteableHKCU(ref IntPtr IntPtr_PreexistingHandle);


		private readonly string _IconCache = Path.Combine("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\IconCache");


		public void DesktopUpdate()
		{ File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "IconCache.db")); }

		public void IconCache()
		{
			IntPtr IntPtr_PreexistingHandle = IntPtr.Zero;

			if (IEGetWriteableHKCU(ref IntPtr_PreexistingHandle) == 0)
			{
				using (RegistryKey RegistryKey_Corrections = RegistryKey.FromHandle(new SafeRegistryHandle(IntPtr_PreexistingHandle, true)))
				{ RegistryKey_Corrections.DeleteSubKeyTree(_IconCache, false); }
			}
		}
	}
}