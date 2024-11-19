using LibrarySystem.Data;
using LibrarySystem.Services;
using System;
using System.Linq;
using System.Windows.Forms;
using LibrarySystem.Data;


namespace LibrarySystem.UserControls
{
    public partial class BorrowBook : UserControl
    {
        private readonly BookServices bookServices;
        private readonly BookRequestServices bookRequestServices; // New service for BookRequest
        private readonly BookLibrary context;

        public BorrowBook()
        {
            InitializeComponent();

            // Disable accessibility COM interactions
            this.dataGridViewBooks.AccessibleRole = AccessibleRole.None;
            this.dataGridViewSelectedBooks.AccessibleRole = AccessibleRole.None;

            // Disable visual styles
            this.dataGridViewBooks.EnableHeadersVisualStyles = false;
            this.dataGridViewSelectedBooks.EnableHeadersVisualStyles = false;

            bookServices = new BookServices();
            bookRequestServices = new BookRequestServices(); // Initialize the BookRequestServices
            context = new BookLibrary();
            LoadAvailableBooks();
            InitializeSelectedBooksTable();
            LoadMembers();
        }

        // Method to load available books (existing code)
        private void LoadAvailableBooks()
        {
            var availableBooks = bookServices.GetAvailableBooks()
                .Select(book => new
                {
                    ISBN = book.ISBNCode,
                    Name = book.BookTitle,
                    Category = book.Category.CategoryName,
                    AvailableCopies = book.CopiesAvailable
                })
                .ToList();

            this.dataGridViewBooks.DataSource = availableBooks;

            this.dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.MultiSelect = false;
            this.dataGridViewBooks.RowHeadersVisible = false;

            this.dataGridViewBooks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewBooks.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewBooks.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewBooks.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewBooks.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridViewBooks.CellClick += DataGridViewBooks_CellClick;
        }

        // Method to initialize selected books table (existing code)
        private void InitializeSelectedBooksTable()
        {
            this.dataGridViewSelectedBooks.ColumnCount = 3;
            this.dataGridViewSelectedBooks.Columns[0].Name = "ISBN";
            this.dataGridViewSelectedBooks.Columns[1].Name = "Name";
            this.dataGridViewSelectedBooks.Columns[2].Name = "Number of Borrow";

            this.dataGridViewSelectedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelectedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSelectedBooks.MultiSelect = false;
            this.dataGridViewSelectedBooks.RowHeadersVisible = false;

            // Make "Number of Borrow" editable, other columns read-only
            this.dataGridViewSelectedBooks.Columns[0].ReadOnly = true; // ISBN
            this.dataGridViewSelectedBooks.Columns[1].ReadOnly = true; // Name
            this.dataGridViewSelectedBooks.Columns[2].ReadOnly = false; // Editable for "Number of Borrow"
        }

        // Method to handle book selection (existing code)
        private void DataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewBooks.Rows[e.RowIndex];
                string isbn = selectedRow.Cells["ISBN"].Value.ToString();
                string name = selectedRow.Cells["Name"].Value.ToString();

                foreach (DataGridViewRow row in dataGridViewSelectedBooks.Rows)
                {
                    if (row.Cells["ISBN"].Value?.ToString() == isbn)
                    {
                        MessageBox.Show("This book is already selected.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Add to the selected books table with default "Number of Borrow" value
                dataGridViewSelectedBooks.Rows.Add(isbn, name, 1); // Default value is 1
            }
        }
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewSelectedBooks.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show(
                    "Are you sure you want to remove the selected book from the list?",
                    "Confirm Remove",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Remove the selected row
                    dataGridViewSelectedBooks.Rows.RemoveAt(dataGridViewSelectedBooks.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Method to load members (existing code)
        private void LoadMembers()
        {
            try
            {
                var members = context.Members
                                     .Select(m => new
                                     {
                                         FullName = m.FirstName + " " + m.LastName,
                                         MemberId = m.MemberId
                                     })
                                     .ToList();

                comboBoxMember.DataSource = members;
                comboBoxMember.DisplayMember = "FullName";
                comboBoxMember.ValueMember = "MemberId";

                comboBoxMember.SelectedIndexChanged += ComboBoxMember_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMember.SelectedValue != null)
            {
                // Display the Member ID in the text box
                textBoxMemberId.Text = comboBoxMember.SelectedValue.ToString();
            }
            else
            {
                textBoxMemberId.Text = string.Empty; // Clear if no member is selected
            }
        }

        // Refactored method to use BookRequestServices for inserting a BookRequest

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            // Check if member is selected and if the member ID is valid
            if (string.IsNullOrWhiteSpace(textBoxMemberId.Text) || !int.TryParse(textBoxMemberId.Text, out int memberId))
            {
                MessageBox.Show("Please select a valid member.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if any books have been selected
            if (dataGridViewSelectedBooks.Rows.Count == 0)
            {
                MessageBox.Show("Please select at least one book before confirming.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate staff ID
            if (string.IsNullOrWhiteSpace(textBoxStaffId.Text) || !int.TryParse(textBoxStaffId.Text, out int staffId))
            {
                MessageBox.Show("Please enter a valid Staff ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the request date from the DateTime picker
                DateTime requestDate = dateTimePickerBorrowDate.Value;

                // Calculate the total number of books being requested (number of rows in the selected books grid)
                int totalBooks = dataGridViewSelectedBooks.Rows.Count;

                // Create a new BookRequest using the BookRequestServices
                var newRequest = new BookRequest
                {
                    MemberId = memberId,
                    StaffId = staffId,
                    RequestBookTotal = totalBooks,
                    RequestDate = requestDate
                };

                // Use the BookRequestServices to insert the new request
                string result = bookRequestServices.Insert(newRequest); // Use service method to insert the request

                // Show success or error message based on the result
                MessageBox.Show(result, "Book Request", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == "BookRequest created successfully.")
                {
                    // After creating the request, now insert the issue details into the BookIssue table
                    int requestId = context.BookRequests
                                            .Where(br => br.MemberId == memberId && br.RequestDate == requestDate)
                                            .Select(br => br.RequestId)
                                            .FirstOrDefault();

                    // Loop through the selected books in the data grid and insert each one as a BookIssue
                    foreach (DataGridViewRow row in dataGridViewSelectedBooks.Rows)
                    {
                        if (row.Cells["ISBN"].Value != null && row.Cells["Number of Borrow"].Value != null)
                        {
                            string isbn = row.Cells["ISBN"].Value.ToString();
                            int borrowQuantity = Convert.ToInt32(row.Cells["Number of Borrow"].Value);

                            // Find the BookId corresponding to the ISBN
                            var book = context.Books.FirstOrDefault(b => b.ISBNCode == isbn);
                            if (book != null)
                            {
                                // Create a new BookIssue entry (from LibrarySystem.Data)
                                var newIssue = new LibrarySystem.Data.BookIssue
                                {
                                    RequestId = requestId,
                                    BookId = book.BookId,
                                    BookAmount = borrowQuantity,
                                    IssueDate = requestDate,
                                    ReturnDate = requestDate.AddDays(14), // Example of return period
                                    IssueStatus = true
                                };

                                // Insert the BookIssue entry
                                context.BookIssues.Add(newIssue);
                            }
                        }
                    }

                    // Save all changes to the database
                    context.SaveChanges();

                    // Clear the selected books list after a successful request
                    dataGridViewSelectedBooks.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                // Show detailed error message
                MessageBox.Show($"Error: {ex.Message}\n\n{ex.InnerException?.Message}\n\n{ex.StackTrace}",
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        private void TextBoxStaffId_Enter(object sender, EventArgs e)
        {
            if (textBoxStaffId.Text == "Enter Staff ID")
            {
                textBoxStaffId.Text = string.Empty;
                textBoxStaffId.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TextBoxStaffId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxStaffId.Text))
            {
                textBoxStaffId.Text = "Enter Staff ID";
                textBoxStaffId.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
