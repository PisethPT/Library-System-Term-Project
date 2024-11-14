namespace LibrarySystem.UserControls
{
	partial class BorrowBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrow Book";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.BtnReset);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(62, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1447, 444);
            this.panel1.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.PublicationType);
            this.panel6.Controls.Add(this.PublicationDate);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(39, 225);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1364, 43);
            this.panel6.TabIndex = 10;
            // 
            // PublicationType
            // 
            this.PublicationType.BackColor = System.Drawing.SystemColors.Window;
            this.PublicationType.Enabled = false;
            this.PublicationType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicationType.Location = new System.Drawing.Point(187, 4);
            this.PublicationType.Margin = new System.Windows.Forms.Padding(4);
            this.PublicationType.Multiline = true;
            this.PublicationType.Name = "PublicationType";
            this.PublicationType.ReadOnly = true;
            this.PublicationType.Size = new System.Drawing.Size(296, 35);
            this.PublicationType.TabIndex = 6;
            // 
            // PublicationDate
            // 
            this.PublicationDate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicationDate.CustomFormat = "";
            this.PublicationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicationDate.Location = new System.Drawing.Point(968, 4);
            this.PublicationDate.Margin = new System.Windows.Forms.Padding(4);
            this.PublicationDate.Name = "PublicationDate";
            this.PublicationDate.Size = new System.Drawing.Size(359, 34);
            this.PublicationDate.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(785, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 28);
            this.label10.TabIndex = 7;
            this.label10.Text = "Publication Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 28);
            this.label11.TabIndex = 7;
            this.label11.Text = "Publication Type:";
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(197, 369);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(127, 36);
            this.BtnReset.TabIndex = 10;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(39, 369);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(127, 36);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.CopiesAvailable);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.CopiesTotal);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.BookEdition);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(39, 283);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1364, 43);
            this.panel5.TabIndex = 9;
            // 
            // CopiesAvailable
            // 
            this.CopiesAvailable.DecimalPlaces = 1;
            this.CopiesAvailable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopiesAvailable.Location = new System.Drawing.Point(1085, 4);
            this.CopiesAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.CopiesAvailable.Name = "CopiesAvailable";
            this.CopiesAvailable.Size = new System.Drawing.Size(243, 34);
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
            this.label9.Location = new System.Drawing.Point(913, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 28);
            this.label9.TabIndex = 7;
            this.label9.Text = "Copies Available:";
            // 
            // CopiesTotal
            // 
            this.CopiesTotal.DecimalPlaces = 1;
            this.CopiesTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopiesTotal.Location = new System.Drawing.Point(603, 4);
            this.CopiesTotal.Margin = new System.Windows.Forms.Padding(4);
            this.CopiesTotal.Name = "CopiesTotal";
            this.CopiesTotal.Size = new System.Drawing.Size(243, 34);
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
            this.label7.Location = new System.Drawing.Point(455, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Copies Total:";
            // 
            // BookEdition
            // 
            this.BookEdition.DecimalPlaces = 1;
            this.BookEdition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookEdition.Location = new System.Drawing.Point(159, 4);
            this.BookEdition.Margin = new System.Windows.Forms.Padding(4);
            this.BookEdition.Name = "BookEdition";
            this.BookEdition.Size = new System.Drawing.Size(243, 34);
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
            this.label8.Location = new System.Drawing.Point(11, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Book Edition:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PublicationLanguage);
            this.panel4.Controls.Add(this.Publisher);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(39, 167);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1364, 43);
            this.panel4.TabIndex = 9;
            // 
            // PublicationLanguage
            // 
            this.PublicationLanguage.BackColor = System.Drawing.SystemColors.Window;
            this.PublicationLanguage.Enabled = false;
            this.PublicationLanguage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicationLanguage.Location = new System.Drawing.Point(1009, 4);
            this.PublicationLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.PublicationLanguage.Multiline = true;
            this.PublicationLanguage.Name = "PublicationLanguage";
            this.PublicationLanguage.ReadOnly = true;
            this.PublicationLanguage.Size = new System.Drawing.Size(317, 35);
            this.PublicationLanguage.TabIndex = 6;
            // 
            // Publisher
            // 
            this.Publisher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher.FormattingEnabled = true;
            this.Publisher.Items.AddRange(new object[] {
            "ISBN Code",
            "Book Name",
            "Category",
            "Publisher Name"});
            this.Publisher.Location = new System.Drawing.Point(187, 5);
            this.Publisher.Margin = new System.Windows.Forms.Padding(4);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(464, 36);
            this.Publisher.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(785, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Publication Language:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Publisher:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Category);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.BookTitle);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(39, 110);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1364, 43);
            this.panel3.TabIndex = 7;
            // 
            // Category
            // 
            this.Category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "ISBN Code",
            "Book Name",
            "Category",
            "Publisher Name"});
            this.Category.Location = new System.Drawing.Point(1009, 4);
            this.Category.Margin = new System.Windows.Forms.Padding(4);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(317, 36);
            this.Category.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(900, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category:";
            // 
            // BookTitle
            // 
            this.BookTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTitle.Location = new System.Drawing.Point(187, 4);
            this.BookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.BookTitle.Multiline = true;
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(657, 35);
            this.BookTitle.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Book Title:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ISBNCode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(39, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 43);
            this.panel2.TabIndex = 5;
            // 
            // ISBNCode
            // 
            this.ISBNCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNCode.Location = new System.Drawing.Point(187, 5);
            this.ISBNCode.Margin = new System.Windows.Forms.Padding(4);
            this.ISBNCode.Multiline = true;
            this.ISBNCode.Name = "ISBNCode";
            this.ISBNCode.Size = new System.Drawing.Size(296, 35);
            this.ISBNCode.TabIndex = 6;
            this.ISBNCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "ISNB Code:";
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BorrowBook";
            this.Size = new System.Drawing.Size(2497, 1138);
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

		private System.Windows.Forms.Label label1;
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
    }
}
