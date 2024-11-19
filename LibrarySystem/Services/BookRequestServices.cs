using LibrarySystem.Data;
using System;
using System.Linq;

namespace LibrarySystem.Services
{
    public class BookRequestServices : ICrudOperations<BookRequest>
    {
        public readonly BookLibrary context;

        public BookRequestServices()
        {
            this.context = new BookLibrary();
        }

        // Method to insert a new BookRequest
        public string Insert(BookRequest entity)
        {
            if (entity == null) throw new ArgumentNullException("BookRequest is empty.");
            else
            {
                try
                {
                    // Add the new BookRequest to the database
                    context.BookRequests.Add(entity);
                    context.SaveChanges(); // Commit the changes to the database

                    return "BookRequest created successfully.";
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
            }
        }

        // Method to update an existing BookRequest
        public string Update(int Id, BookRequest entity)
        {
            if (entity == null) throw new ArgumentNullException("BookRequest is empty.");
            else
            {
                try
                {
                    var existingRequest = context.BookRequests.FirstOrDefault(br => br.RequestId == Id);
                    if (existingRequest == null)
                        return "BookRequest not found.";
                    else
                    {
                        // Update fields of the BookRequest
                        existingRequest.MemberId = entity.MemberId;
                        existingRequest.StaffId = entity.StaffId;
                        existingRequest.RequestBookTotal = entity.RequestBookTotal;
                        existingRequest.RequestDate = entity.RequestDate;

                        context.SaveChanges(); // Commit the changes to the database
                        return "BookRequest updated successfully.";
                    }
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
            }
        }

        // Method to delete a BookRequest by ID
        public string Delete(int Id, BookRequest entity)
        {
            if (entity == null) throw new ArgumentNullException("BookRequest is empty.");
            else
            {
                try
                {
                    var request = context.BookRequests.FirstOrDefault(br => br.RequestId == Id);
                    if (request == null)
                        return "BookRequest not found.";

                    context.BookRequests.Remove(request); // Remove the BookRequest from the database
                    context.SaveChanges(); // Commit the deletion to the database
                    return "BookRequest deleted successfully.";
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
            }
        }

        // Method to get a specific BookRequest by ID
        public BookRequest GetById(int Id)
        {
            return context.BookRequests.FirstOrDefault(br => br.RequestId == Id);
        }

        // Method to get all BookRequests
        public System.Collections.Generic.List<BookRequest> GetAll()
        {
            return context.BookRequests.ToList();
        }
    }
}
