namespace LibrarySystem.Views
{
	partial class BookList
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ViewBookTable = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.ViewBookTable)).BeginInit();
			this.SuspendLayout();
			// 
			// ViewBookTable
			// 
			this.ViewBookTable.AllowUserToAddRows = false;
			this.ViewBookTable.AllowUserToDeleteRows = false;
			this.ViewBookTable.AllowUserToResizeRows = false;
			this.ViewBookTable.BackgroundColor = System.Drawing.SystemColors.Window;
			this.ViewBookTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ViewBookTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.ViewBookTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ViewBookTable.DefaultCellStyle = dataGridViewCellStyle2;
			this.ViewBookTable.Location = new System.Drawing.Point(12, 84);
			this.ViewBookTable.Name = "ViewBookTable";
			this.ViewBookTable.ReadOnly = true;
			this.ViewBookTable.RowHeadersVisible = false;
			this.ViewBookTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ViewBookTable.Size = new System.Drawing.Size(1099, 433);
			this.ViewBookTable.TabIndex = 3;
			// 
			// BookList
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1123, 567);
			this.Controls.Add(this.ViewBookTable);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BookList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Book List";
			((System.ComponentModel.ISupportInitialize)(this.ViewBookTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.DataGridView ViewBookTable;
	}
}