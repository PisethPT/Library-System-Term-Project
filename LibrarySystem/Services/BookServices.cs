using LibrarySystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibrarySystem.Services
{
    public class BookServices : ICrudOperations<Book>
    {
        public readonly BookLibrary context;

        public BookServices()
        {
            this.context = new BookLibrary();
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
            var book = context.Books.FirstOrDefault(b => b.BookId == Id);
            if (book is null)
                return null;

            return book;
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
            if (entity == null) throw new ArgumentNullException("Book Is Empty.");
            else
            {
                try
                {
                    var existingBook = context.Books.FirstOrDefault(b => b.BookId == Id);
                    if (existingBook is null)
                        return "Book not found.";
                    else
                    {
                        existingBook.ISBNCode = entity.ISBNCode;
                        existingBook.BookTitle = entity.BookTitle;
                        existingBook.CategoryId = entity.CategoryId;
                        existingBook.PublisherId = entity.PublisherId;
                        existingBook.PublicationYear = entity.PublicationYear;
                        existingBook.BookEdition = entity.BookEdition;
                        existingBook.CopiesTotal = entity.CopiesTotal;
                        existingBook.CopiesAvailable = entity.CopiesAvailable;

                        context.SaveChanges();
                        return "Update Book Successfully.";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public List<GetViewBooks_Result> GetViewBooks() => context.GetViewBooks().ToList();

        // Add a new method to get available books
        public List<Book> GetAvailableBooks()
        {
            return context.Books
                          .Where(b => b.CopiesAvailable > 0)
                          .ToList();
        }
    }
}
