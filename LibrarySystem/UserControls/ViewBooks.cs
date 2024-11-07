using LibrarySystem.Data;
using LibrarySystem.Services;
using LibrarySystem.Views;
using System;
using System.Windows.Forms;
using static LibrarySystem.Program;

namespace LibrarySystem.UserControls
{
	public partial class ViewBooks : UserControl
	{
		private BookServices operations;
		public ViewBooks()
		{
			InitializeComponent();
			if (this != null)
				Static.Component.ViewBookTable = this.ViewBookTable;

			operations = new BookServices();
			this.SearchType.SelectedIndex = 0;
			GetViewBooks();
		}

		private void GetViewBooks()
		{
			this.ViewBookTable.DataSource = operations.GetViewBooks();

			this.ViewBookTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ViewBookTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			BookSearch search = new BookSearch();
			search.Owner = main;
			search.ShowDialog();
		}
	}
}
