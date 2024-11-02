using LibrarySystem.Data;
using LibrarySystem.Views;
using System;
using System.Windows.Forms;
using static LibrarySystem.Program;

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

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			BookSearch search = new BookSearch();
			search.Owner = main;
			search.ShowDialog();
		}
	}
}
