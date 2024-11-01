using LibrarySystem.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem.UserControls
{
	public partial class ViewBooks : UserControl
	{
		private BookLibrary context;
		public ViewBooks()
		{
			InitializeComponent();
			context = new BookLibrary();

			GetViewBooks();
		}

		private void GetViewBooks() => this.ViewBookTable.DataSource = context.GetViewBooks();
	}
}
