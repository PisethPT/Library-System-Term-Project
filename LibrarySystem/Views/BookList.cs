using LibrarySystem.Services;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem.Views
{
	public partial class BookList : Form
	{
		private readonly BookServices operations;
		public BookList()
		{
			InitializeComponent();
			operations = new BookServices();
			GetViewBook();
		}

		private void GetViewBook()
		{
			this.ViewBookTable.DataSource = operations.GetViewBooks();
			this.ViewBookTable.CellDoubleClick += ViewBookTable_CellDoubleClick;

			this.ViewBookTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ViewBookTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ViewBookTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ViewBookTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ViewBookTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ViewBookTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ViewBookTable.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ViewBookTable.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ViewBookTable.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ViewBookTable.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ViewBookTable.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


			this.ViewBookTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.ViewBookTable.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.ViewBookTable.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.ViewBookTable.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.ViewBookTable.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.ViewBookTable.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}

		private void ViewBookTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				GetDetailBook(e.RowIndex);
				this.Dispose();
			}
		}

		private void GetDetailBook(int RowIndex)
		{
			Static.Component.BookId = int.Parse(this.ViewBookTable.Rows[RowIndex].Cells[0].Value.ToString());
			Static.Component.ISBNCode.Text = this.ViewBookTable.Rows[RowIndex].Cells[1].Value.ToString();
			Static.Component.BookTitle.Text = this.ViewBookTable.Rows[RowIndex].Cells[2].Value.ToString();
			Static.Component.Category.Items.Clear();
			var categorySelected = this.ViewBookTable.Rows[RowIndex].Cells[3].Value.ToString();
			Static.Component.Category.Items.AddRange(operations.context.Categories.Select(c => c.CategoryName).ToArray());
			Static.Component.Category.SelectedItem = categorySelected;
			Static.Component.Publisher.Items.Clear();
			var publisherSelected = this.ViewBookTable.Rows[RowIndex].Cells[4].Value.ToString();
			Static.Component.Publisher.Items.AddRange(operations.context.Publishers.Select(p => p.PublisherName).ToArray());
			Static.Component.Publisher.SelectedItem = publisherSelected;

			Static.Component.PublicationDate.Text = this.ViewBookTable.Rows[RowIndex].Cells[7].Value.ToString();
			Static.Component.BookEdition.Value = decimal.Parse(this.ViewBookTable.Rows[RowIndex].Cells[8].Value.ToString());
			Static.Component.CopiesTotal.Value = decimal.Parse(this.ViewBookTable.Rows[RowIndex].Cells[9].Value.ToString());
			Static.Component.CopiesAvailable.Value = decimal.Parse(this.ViewBookTable.Rows[RowIndex].Cells[10].Value.ToString());
		}

        private void ViewBookTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
