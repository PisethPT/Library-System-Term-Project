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
		private readonly BookServices operations;
		public AddBook()
		{
			InitializeComponent();
			if (this != null)
			{
				Static.Component.ISBNCode = this.ISBNCode;
				Static.Component.BookTitle = this.BookTitle;
				Static.Component.Category = this.Category;
				Static.Component.Publisher = this.Publisher;
				Static.Component.PublicationDate = this.PublicationDate;
				Static.Component.BookEdition = this.BookEdition;
				Static.Component.CopiesTotal = this.CopiesTotal;
				Static.Component.CopiesAvailable = this.CopiesAvailable;
			}

			operations = new BookServices();
			GetCategories();
			GetPublishers();
		}

		private void GetPublishers()
		{
			this.Publisher.Items.Clear();
			var publishers = operations.context.Publishers.Select(p => p.PublisherName).ToList();
			foreach (var publisher in publishers)
			{
				this.Publisher.Items.Add(publisher);
			}
			this.Publisher.SelectedIndex = 0;
		}

		private void GetCategories()
		{
			this.Category.Items.Clear();
			var categories = operations.context.Categories.Select(p => p.CategoryName).ToList();
			foreach (var category in categories)
			{
				this.Category.Items.Add(category);
			}
			this.Category.SelectedIndex = 0;
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			var message = operations.Insert(Static.Component.BookDetail());
			MessageBox.Show(message);
			Static.Component.ClearFields();
		}

		private void Publisher_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.Publisher.SelectedIndex >= 0)
			{	
				var publisherName = this.Publisher.Items[this.Publisher.SelectedIndex].ToString();
				var publicationLanguage = operations.context.Publishers.FirstOrDefault(p => p.PublisherName.Equals(publisherName)).PublicationLanguage;
				if (publicationLanguage != null)
					this.PublicationLanguage.Text = publicationLanguage;


				var publicationType = operations.context.Publishers.FirstOrDefault(p => p.PublisherName.Equals(publisherName)).PublicationType;
				if (publicationType != null)
					this.PublicationType.Text = publicationType;
			}
		}


		private void BtnReset_Click(object sender, EventArgs e) => Static.Component.ClearFields();


	}
}
