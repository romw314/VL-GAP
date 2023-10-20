using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace VL_GreenAcidPipe
{
	internal static class Program
	{
		[DllImport("user32.dll")]
		public static extern IntPtr GetDC(IntPtr hWnd);
		[DllImport("user32.dll")]
		public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr dc);

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			try
			{
				// To customize application configuration such as set high DPI settings or default font,
				// see https://aka.ms/applicationconfiguration.
				ApplicationConfiguration.Initialize();
				Application.Run(new MainForm());
			}
			catch
			{
				MessageBox.Show(
					"Unknown error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
					MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
			}
		}
	}
}