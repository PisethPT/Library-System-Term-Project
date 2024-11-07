namespace LibrarySystem.UserControls
{
	partial class UpdateBook
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBook));
			this.panel1 = new System.Windows.Forms.Panel();
			this.BookList = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.PublicationType = new System.Windows.Forms.TextBox();
			this.PublicationDate = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.BtnReset = new System.Windows.Forms.Button();
			this.BtnSave = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.CopiesAvailable = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.CopiesTotal = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.BookEdition = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.PublicationLanguage = new System.Windows.Forms.TextBox();
			this.Publisher = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.Category = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.BookTitle = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ISBNCode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CopiesAvailable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CopiesTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BookEdition)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.BookList);
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.BtnReset);
			this.panel1.Controls.Add(this.BtnSave);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(381, 167);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1086, 361);
			this.panel1.TabIndex = 6;
			// 
			// BookList
			// 
			this.BookList.Image = ((System.Drawing.Image)(resources.GetObject("BookList.Image")));
			this.BookList.Location = new System.Drawing.Point(438, 45);
			this.BookList.Name = "BookList";
			this.BookList.Size = new System.Drawing.Size(28, 28);
			this.BookList.TabIndex = 11;
			this.BookList.UseVisualStyleBackColor = true;
			this.BookList.Click += new System.EventHandler(this.BookList_Click);
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.PublicationType);
			this.panel6.Controls.Add(this.PublicationDate);
			this.panel6.Controls.Add(this.label10);
			this.panel6.Controls.Add(this.label11);
			this.panel6.Location = new System.Drawing.Point(29, 183);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(1023, 35);
			this.panel6.TabIndex = 10;
			// 
			// PublicationType
			// 
			this.PublicationType.BackColor = System.Drawing.SystemColors.Window;
			this.PublicationType.Enabled = false;
			this.PublicationType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PublicationType.Location = new System.Drawing.Point(140, 3);
			this.PublicationType.Multiline = true;
			this.PublicationType.Name = "PublicationType";
			this.PublicationType.ReadOnly = true;
			this.PublicationType.Size = new System.Drawing.Size(223, 29);
			this.PublicationType.TabIndex = 6;
			// 
			// PublicationDate
			// 
			this.PublicationDate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PublicationDate.CustomFormat = "";
			this.PublicationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PublicationDate.Location = new System.Drawing.Point(726, 3);
			this.PublicationDate.Name = "PublicationDate";
			this.PublicationDate.Size = new System.Drawing.Size(270, 29);
			this.PublicationDate.TabIndex = 9;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(589, 7);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(126, 21);
			this.label10.TabIndex = 7;
			this.label10.Text = "Publication Date:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(8, 7);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(126, 21);
			this.label11.TabIndex = 7;
			this.label11.Text = "Publication Type:";
			// 
			// BtnReset
			// 
			this.BtnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnReset.Location = new System.Drawing.Point(148, 300);
			this.BtnReset.Name = "BtnReset";
			this.BtnReset.Size = new System.Drawing.Size(95, 29);
			this.BtnReset.TabIndex = 10;
			this.BtnReset.Text = "Reset";
			this.BtnReset.UseVisualStyleBackColor = true;
			// 
			// BtnSave
			// 
			this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSave.Location = new System.Drawing.Point(29, 300);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(95, 29);
			this.BtnSave.TabIndex = 10;
			this.BtnSave.Text = "Save";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.CopiesAvailable);
			this.panel5.Controls.Add(this.label9);
			this.panel5.Controls.Add(this.CopiesTotal);
			this.panel5.Controls.Add(this.label7);
			this.panel5.Controls.Add(this.BookEdition);
			this.panel5.Controls.Add(this.label8);
			this.panel5.Location = new System.Drawing.Point(29, 230);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1023, 35);
			this.panel5.TabIndex = 9;
			// 
			// CopiesAvailable
			// 
			this.CopiesAvailable.DecimalPlaces = 1;
			this.CopiesAvailable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CopiesAvailable.Location = new System.Drawing.Point(814, 3);
			this.CopiesAvailable.Name = "CopiesAvailable";
			this.CopiesAvailable.Size = new System.Drawing.Size(182, 29);
			this.CopiesAvailable.TabIndex = 10;
			this.CopiesAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.CopiesAvailable.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(685, 7);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(127, 21);
			this.label9.TabIndex = 7;
			this.label9.Text = "Copies Available:";
			// 
			// CopiesTotal
			// 
			this.CopiesTotal.DecimalPlaces = 1;
			this.CopiesTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CopiesTotal.Location = new System.Drawing.Point(452, 3);
			this.CopiesTotal.Name = "CopiesTotal";
			this.CopiesTotal.Size = new System.Drawing.Size(182, 29);
			this.CopiesTotal.TabIndex = 10;
			this.CopiesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.CopiesTotal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(341, 7);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 21);
			this.label7.TabIndex = 7;
			this.label7.Text = "Copies Total:";
			// 
			// BookEdition
			// 
			this.BookEdition.DecimalPlaces = 1;
			this.BookEdition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookEdition.Location = new System.Drawing.Point(119, 3);
			this.BookEdition.Name = "BookEdition";
			this.BookEdition.Size = new System.Drawing.Size(182, 29);
			this.BookEdition.TabIndex = 10;
			this.BookEdition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.BookEdition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 7);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 21);
			this.label8.TabIndex = 7;
			this.label8.Text = "Book Edition:";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.PublicationLanguage);
			this.panel4.Controls.Add(this.Publisher);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Location = new System.Drawing.Point(29, 136);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1023, 35);
			this.panel4.TabIndex = 9;
			// 
			// PublicationLanguage
			// 
			this.PublicationLanguage.BackColor = System.Drawing.SystemColors.Window;
			this.PublicationLanguage.Enabled = false;
			this.PublicationLanguage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PublicationLanguage.Location = new System.Drawing.Point(757, 3);
			this.PublicationLanguage.Multiline = true;
			this.PublicationLanguage.Name = "PublicationLanguage";
			this.PublicationLanguage.ReadOnly = true;
			this.PublicationLanguage.Size = new System.Drawing.Size(239, 29);
			this.PublicationLanguage.TabIndex = 6;
			// 
			// Publisher
			// 
			this.Publisher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Publisher.FormattingEnabled = true;
			this.Publisher.Location = new System.Drawing.Point(140, 4);
			this.Publisher.Name = "Publisher";
			this.Publisher.Size = new System.Drawing.Size(349, 29);
			this.Publisher.TabIndex = 8;
			this.Publisher.SelectedIndexChanged += new System.EventHandler(this.Publisher_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(589, 7);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(162, 21);
			this.label6.TabIndex = 6;
			this.label6.Text = "Publication Language:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 7);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 21);
			this.label5.TabIndex = 7;
			this.label5.Text = "Publisher:";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.Category);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.BookTitle);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(29, 89);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1023, 35);
			this.panel3.TabIndex = 7;
			// 
			// Category
			// 
			this.Category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Category.FormattingEnabled = true;
			this.Category.Location = new System.Drawing.Point(757, 3);
			this.Category.Name = "Category";
			this.Category.Size = new System.Drawing.Size(239, 29);
			this.Category.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(675, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 21);
			this.label4.TabIndex = 7;
			this.label4.Text = "Category:";
			// 
			// BookTitle
			// 
			this.BookTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookTitle.Location = new System.Drawing.Point(140, 3);
			this.BookTitle.Multiline = true;
			this.BookTitle.Name = "BookTitle";
			this.BookTitle.Size = new System.Drawing.Size(494, 29);
			this.BookTitle.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 21);
			this.label3.TabIndex = 6;
			this.label3.Text = "Book Title:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.ISBNCode);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(29, 42);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(396, 35);
			this.panel2.TabIndex = 5;
			// 
			// ISBNCode
			// 
			this.ISBNCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ISBNCode.Location = new System.Drawing.Point(140, 4);
			this.ISBNCode.Multiline = true;
			this.ISBNCode.Name = "ISBNCode";
			this.ISBNCode.Size = new System.Drawing.Size(223, 29);
			this.ISBNCode.TabIndex = 6;
			this.ISBNCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 21);
			this.label2.TabIndex = 6;
			this.label2.Text = "ISNB Code:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(406, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "Update Book";
			// 
			// UpdateBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "UpdateBook";
			this.Size = new System.Drawing.Size(1873, 925);
			this.panel1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CopiesAvailable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CopiesTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BookEdition)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox PublicationType;
		private System.Windows.Forms.DateTimePicker PublicationDate;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button BtnReset;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.NumericUpDown CopiesAvailable;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown CopiesTotal;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown BookEdition;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox PublicationLanguage;
		private System.Windows.Forms.ComboBox Publisher;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ComboBox Category;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox BookTitle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox ISBNCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BookList;
	}
}
