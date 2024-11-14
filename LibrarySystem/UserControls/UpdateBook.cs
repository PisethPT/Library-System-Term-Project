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
		private readonly BookServices operations;
		public UpdateBook()
		{
			InitializeComponent();
			if(this != null)
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
		}

		private void BookList_Click(object sender, EventArgs e)
		{
			BookList bookList = new BookList();
			bookList.ShowDialog();
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

		private void BtnSave_Click(object sender, EventArgs e)
		{
			operations.Update(Static.Component.BookId, Static.Component.BookDetail());
			Static.Component.ClearFields();
			Static.Component.Category.Items.Clear();
			Static.Component.Publisher.Items.Clear();
		}

        private void ISBNCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBook_Load(object sender, EventArgs e)
        {

        }
    }
}
