using System;
using System.Windows.Forms;

namespace LibrarySystem.Static
{
	public static class Component
	{
		public static DataGridView ViewBookTable { get; set; } = null;

		public static string iSNBCode;
		public static string bookTitle;
		public static Nullable<int> categoryId;
		public static Nullable<int> publisherId;
		//public static Nullable<DateTime> publicationYear;
		public static Nullable<byte> bookEdition;

	}
}
