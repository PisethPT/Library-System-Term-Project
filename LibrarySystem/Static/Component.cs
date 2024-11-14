using LibrarySystem.Data;
using System;
using System.Windows.Forms;

namespace LibrarySystem.Static
{
    public static class Component
    {
        /// <summary>
        /// Book Start 
        /// </summary>
        /// 

        public static DataGridView ViewBookTable { get; set; } = null;

        public static string iSNBCode;
        public static string bookTitle;
        public static Nullable<int> categoryId;
        public static Nullable<int> publisherId;
        //public static Nullable<DateTime> publicationYear;
        public static Nullable<byte> bookEdition;

        public static int BookId { get; set; }
        public static TextBox ISBNCode { get; set; }
        public static TextBox BookTitle { get; set; }
        public static ComboBox Category { get; set; }
        public static ComboBox Publisher { get; set; }
        public static DateTimePicker PublicationDate { get; set; }
        public static NumericUpDown BookEdition { get; set; }
        public static NumericUpDown CopiesTotal { get; set; }
        public static NumericUpDown CopiesAvailable { get; set; }

        public static Book BookDetail()
        {
            var book = new Book();
            book.ISBNCode = ISBNCode.Text;
            book.BookTitle = BookTitle.Text;
            book.CategoryId = Category.SelectedIndex + 1;
            book.PublisherId = Publisher.SelectedIndex + 1;
            book.PublicationYear = PublicationDate.Value.Date;
            book.BookEdition = (byte)BookEdition.Value;
            book.CopiesTotal = (int)CopiesTotal.Value;
            book.CopiesAvailable = (int)CopiesAvailable.Value;

            return book;
        }

        public static void ClearFields()
        {
            ISBNCode.Text = string.Empty;
            BookTitle.Text = string.Empty;
            Category.SelectedIndex = 0;
            Publisher.SelectedIndex = 0;
            PublicationDate.Value = DateTime.Today;
            BookEdition.Value = 1;
            CopiesTotal.Value = 1;
            CopiesAvailable.Value = 1;
        }

        /// <summery>
        /// Book End
        /// </summery>
        ///

    }

}
