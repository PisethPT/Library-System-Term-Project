using LibrarySystem.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using static LibrarySystem.Static.Component;

namespace LibrarySystem.Views
{
	public partial class BookSearch : Form
	{
		private readonly BookLibrary context;
		public BookSearch()
		{
			InitializeComponent();
			context = new BookLibrary();

			this.Category.Items.Clear();
			this.Publisher.Items.Clear();
			this.Category.Items.AddRange(context.Categories.Select(c => c.CategoryName).ToArray());
			this.Publisher.Items.AddRange(context.Publishers.Select(p => p.PublisherName).ToArray());

			if (iSNBCode != null )
				this.ISNBCode.Text = iSNBCode;

			if(bookTitle != null )
				this.BookTitle.Text = bookTitle;

			if(categoryId != null )
				this.Category.SelectedIndex = (int)categoryId - 1;

			if (publisherId != null)
				this.Publisher.SelectedIndex = (int)publisherId - 1 ;	
			
			if (bookEdition != null)
				this.BookEdition.Value = bookEdition.Value;
		}

		private void Search_Click(object sender, EventArgs e) => SearchBook();

		private void SearchBook()
		{

			if (string.IsNullOrWhiteSpace(this.ISNBCode.Text) || string.IsNullOrEmpty(this.ISNBCode.Text))
				iSNBCode = null;
			else
				iSNBCode = this.ISNBCode.Text;


			if (string.IsNullOrWhiteSpace(this.BookTitle.Text) || string.IsNullOrEmpty(this.BookTitle.Text))
				bookTitle = null;
			else
				bookTitle = this.BookTitle.Text;

			if (!string.IsNullOrWhiteSpace(this.Category.Text) || !string.IsNullOrEmpty(this.Category.Text))
				categoryId = this.Category.SelectedIndex + 1;
			else
				categoryId = null;

			if (!string.IsNullOrWhiteSpace(this.Publisher.Text) || !string.IsNullOrEmpty(this.Publisher.Text))
				publisherId = this.Publisher.SelectedIndex + 1;
			else
				publisherId = null;

			if (byte.Parse(this.BookEdition.Text.Trim()) == 0)
				bookEdition = null;
			else
			bookEdition = byte.Parse(this.BookEdition.Text.Trim());

			var Books = context.SearchBook(iSNBCode, bookTitle, categoryId, publisherId, null, bookEdition);

			ViewBookTable.DataSource = Books;

			this.Close();
		}

		private void Reset_Click(object sender, EventArgs e)
		{
			this.ISNBCode.Text = string.Empty;
			this.BookTitle.Text = string.Empty;
			this.Category.Text = string.Empty;
			this.Publisher.Text = string.Empty;
			this.BookEdition.Value = 0;

			iSNBCode = null;
			bookTitle = null;
			categoryId = null;
			publisherId = null;
			bookEdition = null;
		}
	}
}
