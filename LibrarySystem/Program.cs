using LibrarySystem.Views;
using System;
using System.Windows.Forms;

namespace LibrarySystem
{
	internal static class Program
	{
		public static Main main;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			main = new Main();
			Application.Run(main);
		}
	}
}
