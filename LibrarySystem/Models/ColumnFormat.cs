using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Models
{
	public static class ColumnFormat
	{
		public static void DataGridColumn(DataGridView dataGridView, params string[] Columns)
		{
			ColumnStyle columnStyle = new ColumnStyle() { Column = "Name",  };



		}
		
	}

	public class ColumnStyle
	{
		public string Column { get; set; }
		public DataGridColumnStyle ColumnType { get; set; }

		public ColumnStyle() 
		{
			ColumnType.Alignment = HorizontalAlignment.Left;
		
		}
	}
}


