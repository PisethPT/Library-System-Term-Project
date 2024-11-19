using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystem.Data; // Reference for your database context

namespace LibrarySystem.UserControls
{
    public partial class BookIssue : UserControl
    {
        public BookIssue()
        {
            InitializeComponent();
            LoadIssuedBooks();
        }
        public void LoadIssuedBooks()
        {
            try
            {
                using (var context = new BookLibrary()) // Replace with your actual database context
                {
                    // Fetch data from the BookIssue table, including BookName and Borrower Name
                    var issuedBooks = context.BookIssues
                                              .Join(
                                                  context.BookRequests, // Join with BookRequests table
                                                  issue => issue.RequestId, // Match RequestId in BookIssues
                                                  request => request.RequestId, // Match RequestId in BookRequests
                                                  (issue, request) => new { issue, request })
                                              .Join(
                                                  context.Members, // Join with Members table
                                                  combined => combined.request.MemberId, // Match MemberId in BookRequests
                                                  member => member.MemberId, // Match MemberId in Members
                                                  (combined, member) => new
                                                  {
                                                      IssueId = combined.issue.IssueId,
                                                      BorrowerName = member.FirstName + " " + member.LastName, // Fetch Borrower Name
                                                      BookName = context.Books.FirstOrDefault(b => b.BookId == combined.issue.BookId).BookTitle, // Fetch BookName
                                                      Amount = combined.issue.BookAmount,
                                                      IssueDate = combined.issue.IssueDate,
                                                      ReturnDate = combined.issue.ReturnDate,
                                                      Status = combined.issue.IssueStatus.HasValue && combined.issue.IssueStatus.Value ? "Issued" : "Returned"
                                                  })
                                              .ToList();

                    // Bind data to the DataGridView
                    dataGridViewBookIssues.DataSource = issuedBooks;

                    // Configure the DataGridView (styling)
                    dataGridViewBookIssues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewBookIssues.ReadOnly = true;
                    dataGridViewBookIssues.RowHeadersVisible = false;
                    dataGridViewBookIssues.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading issued books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
