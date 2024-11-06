using LibrarySystem.Data;
using LibrarySystem.Services;
using LibrarySystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.UserControls
{
	public partial class UpdateBook : UserControl
	{
		private readonly ICrudOperations<Book> operations;
		private readonly BookLibrary context;
		public UpdateBook()
		{
			InitializeComponent();
			operations = new BookServices(context);
		}

		private void BookList_Click(object sender, EventArgs e)
		{
			BookList bookList = new BookList();
			bookList.ShowDialog();
		}

	}
}
