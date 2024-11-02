using LibrarySystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Services
{
	public class BookServices : ICrudOperations<Book>
	{
		private readonly BookLibrary context;
		public BookServices(BookLibrary context)
		{
			this.context = context;
		}
		public string Delete(int Id, Book entity)
		{
			throw new NotImplementedException();
		}

		public List<Book> GetAll()
		{
			throw new NotImplementedException();
		}

		public Book GetById(int Id)
		{
			throw new NotImplementedException();
		}

		public string Insert(Book entity)
		{
			if (entity == null) throw new ArgumentNullException("Book Is Empty.");
			else
			{
				try
				{
					var newBook = context.Pro_InsertBook(entity.ISBNCode, entity.BookTitle, entity.CategoryId, entity.PublisherId, entity.PublicationYear, entity.BookEdition, entity.CopiesTotal, entity.CopiesAvailable);
					context.SaveChanges();
					return "Create New Book Successfully.";
				}
				catch (Exception ex)
				{
					return ex.Message;
				}
			}
		}

		public string Update(int Id, Book entity)
		{
			throw new NotImplementedException();
		}
	}
}
