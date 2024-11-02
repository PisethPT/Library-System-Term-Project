using LibrarySystem.Data;
using LibrarySystem.Services;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace LibrarySystem.UserControls
{
	public partial class AddBook : UserControl
	{
		private BookLibrary context;
		private readonly ICrudOperations<Book> operations;
		public AddBook()
		{
			InitializeComponent();
			context = new BookLibrary();
			operations = new BookServices(context);
			GetCategories();
			GetPublishers();
		}

		private void GetPublishers()
		{
			this.Publisher.Items.Clear();
			var publishers = context.Publishers.Select(p => p.PublisherName).ToList();
			foreach (var publisher in publishers)
			{
				this.Publisher.Items.Add(publisher);
			}
			this.Publisher.SelectedIndex = 0;
		}

		private void GetCategories()
		{
			this.Category.Items.Clear();
			var categories = context.Categories.Select(p => p.CategoryName).ToList();
			foreach (var category in categories)
			{
				this.Category.Items.Add(category);
			}
			this.Category.SelectedIndex = 0;
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			var message = operations.Insert(BookDetail());
			MessageBox.Show(message);
		}

		private void Publisher_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.Publisher.SelectedIndex >= 0)
			{	
				var publisherName = this.Publisher.Items[this.Publisher.SelectedIndex].ToString();
				var publicationLanguage = context.Publishers.FirstOrDefault(p => p.PublisherName.Equals(publisherName)).PublicationLanguage;
				if (publicationLanguage != null)
					this.PublicationLanguage.Text = publicationLanguage;


				var publicationType = context.Publishers.FirstOrDefault(p => p.PublisherName.Equals(publisherName)).PublicationType;
				if (publicationType != null)
					this.PublicationType.Text = publicationType;
			}
		}

		private Book BookDetail()
		{
			var book = new Book();
			book.ISBNCode = this.ISBNCode.Text;
			book.BookTitle = this.BookTitle.Text;
			book.CategoryId = this.Category.SelectedIndex + 1;
			book.PublisherId = this.Publisher.SelectedIndex + 1;
			book.PublicationYear = this.PublicationDate.Value.Date;
			book.BookEdition = (byte)this.BookEdition.Value;
			book.CopiesTotal = (int)this.CopiesTotal.Value;
			book.CopiesAvailable = (int)this.CopiesAvailable.Value;

			return book;
		}

	}
}
