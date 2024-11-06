namespace LibrarySystem.Views
{
	partial class BookSearch
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.ISNBCode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.BookTitle = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Category = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.Publisher = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.BookEdition = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.Reset = new System.Windows.Forms.Button();
			this.Search = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BookEdition)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.ISNBCode);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(12, 58);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(439, 35);
			this.panel2.TabIndex = 6;
			// 
			// ISNBCode
			// 
			this.ISNBCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ISNBCode.Location = new System.Drawing.Point(119, 4);
			this.ISNBCode.Multiline = true;
			this.ISNBCode.Name = "ISNBCode";
			this.ISNBCode.Size = new System.Drawing.Size(212, 29);
			this.ISNBCode.TabIndex = 6;
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
			this.label1.Location = new System.Drawing.Point(163, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "Search Book";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.BookTitle);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(12, 107);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(439, 35);
			this.panel3.TabIndex = 8;
			// 
			// BookTitle
			// 
			this.BookTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookTitle.Location = new System.Drawing.Point(119, 3);
			this.BookTitle.Multiline = true;
			this.BookTitle.Name = "BookTitle";
			this.BookTitle.Size = new System.Drawing.Size(317, 29);
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
			// panel1
			// 
			this.panel1.Controls.Add(this.Category);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(12, 157);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(439, 35);
			this.panel1.TabIndex = 9;
			// 
			// Category
			// 
			this.Category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Category.FormattingEnabled = true;
			this.Category.Location = new System.Drawing.Point(119, 3);
			this.Category.Name = "Category";
			this.Category.Size = new System.Drawing.Size(257, 29);
			this.Category.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 21);
			this.label4.TabIndex = 7;
			this.label4.Text = "Category:";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.Publisher);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Location = new System.Drawing.Point(12, 207);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(439, 35);
			this.panel4.TabIndex = 10;
			// 
			// Publisher
			// 
			this.Publisher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Publisher.FormattingEnabled = true;
			this.Publisher.Location = new System.Drawing.Point(119, 3);
			this.Publisher.Name = "Publisher";
			this.Publisher.Size = new System.Drawing.Size(257, 29);
			this.Publisher.TabIndex = 8;
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
			// panel6
			// 
			this.panel6.Controls.Add(this.BookEdition);
			this.panel6.Controls.Add(this.label8);
			this.panel6.Location = new System.Drawing.Point(12, 257);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(439, 35);
			this.panel6.TabIndex = 12;
			// 
			// BookEdition
			// 
			this.BookEdition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookEdition.Location = new System.Drawing.Point(119, 3);
			this.BookEdition.Name = "BookEdition";
			this.BookEdition.Size = new System.Drawing.Size(212, 29);
			this.BookEdition.TabIndex = 10;
			this.BookEdition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			// Reset
			// 
			this.Reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Reset.Location = new System.Drawing.Point(234, 357);
			this.Reset.Name = "Reset";
			this.Reset.Size = new System.Drawing.Size(95, 29);
			this.Reset.TabIndex = 13;
			this.Reset.Text = "Reset";
			this.Reset.UseVisualStyleBackColor = true;
			this.Reset.Click += new System.EventHandler(this.Reset_Click);
			// 
			// Search
			// 
			this.Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Search.Location = new System.Drawing.Point(356, 357);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(95, 29);
			this.Search.TabIndex = 14;
			this.Search.Text = "Search";
			this.Search.UseVisualStyleBackColor = true;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// BookSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(464, 398);
			this.ControlBox = false;
			this.Controls.Add(this.Reset);
			this.Controls.Add(this.Search);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BookSearch";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Book Search";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BookEdition)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox ISNBCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox BookTitle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox Category;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.ComboBox Publisher;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.NumericUpDown BookEdition;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button Reset;
		private System.Windows.Forms.Button Search;
	}
}