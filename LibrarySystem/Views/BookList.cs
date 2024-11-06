using LibrarySystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Views
{
	public partial class BookList : Form
	{
		private BookLibrary context;
		public BookList()
		{
			InitializeComponent();
			context = new BookLibrary();
			GetViewBook();
		}

		private void GetViewBook()
		{
			this.ViewBookTable.DataSource = context.GetViewBooks();

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
	}
}
