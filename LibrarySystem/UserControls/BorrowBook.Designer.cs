namespace LibrarySystem.UserControls
{
    partial class BorrowBook
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.labelAvailableBooks = new System.Windows.Forms.Label();
            this.dataGridViewSelectedBooks = new System.Windows.Forms.DataGridView();
            this.labelSelectedBooks = new System.Windows.Forms.Label();
            this.labelMember = new System.Windows.Forms.Label();
            this.comboBoxMember = new System.Windows.Forms.ComboBox();
            this.textBoxMemberId = new System.Windows.Forms.TextBox(); // Added TextBox for MemberId
            this.labelBorrowDate = new System.Windows.Forms.Label();
            this.dateTimePickerBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxStaffId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedBooks)).BeginInit();
            this.SuspendLayout();

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(20, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(180, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Borrow Book";

            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AllowUserToResizeRows = false;
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(20, 100);
            this.dataGridViewBooks.MultiSelect = false;
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersVisible = false;
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(800, 470);
            this.dataGridViewBooks.TabIndex = 1;

            // 
            // labelAvailableBooks
            // 
            this.labelAvailableBooks.AutoSize = true;
            this.labelAvailableBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAvailableBooks.Location = new System.Drawing.Point(20, 70);
            this.labelAvailableBooks.Name = "labelAvailableBooks";
            this.labelAvailableBooks.Size = new System.Drawing.Size(158, 25);
            this.labelAvailableBooks.TabIndex = 2;
            this.labelAvailableBooks.Text = "Available Books:";

            // 
            // dataGridViewSelectedBooks
            // 
            this.dataGridViewSelectedBooks.AllowUserToAddRows = false;
            this.dataGridViewSelectedBooks.AllowUserToDeleteRows = false;
            this.dataGridViewSelectedBooks.AllowUserToResizeRows = false;
            this.dataGridViewSelectedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelectedBooks.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSelectedBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSelectedBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSelectedBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSelectedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedBooks.Location = new System.Drawing.Point(850, 128);
            this.dataGridViewSelectedBooks.MultiSelect = false;
            this.dataGridViewSelectedBooks.Name = "dataGridViewSelectedBooks";
            this.dataGridViewSelectedBooks.RowHeadersVisible = false;
            this.dataGridViewSelectedBooks.RowHeadersWidth = 51;
            this.dataGridViewSelectedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSelectedBooks.Size = new System.Drawing.Size(800, 322);
            this.dataGridViewSelectedBooks.TabIndex = 5;

            // 
            // labelSelectedBooks
            // 
            this.labelSelectedBooks.AutoSize = true;
            this.labelSelectedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSelectedBooks.Location = new System.Drawing.Point(850, 100);
            this.labelSelectedBooks.Name = "labelSelectedBooks";
            this.labelSelectedBooks.Size = new System.Drawing.Size(155, 25);
            this.labelSelectedBooks.TabIndex = 6;
            this.labelSelectedBooks.Text = "Selected Books:";

            // 
            // labelMember
            // 
            this.labelMember.AutoSize = true;
            this.labelMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMember.Location = new System.Drawing.Point(850, 26);
            this.labelMember.Name = "labelMember";
            this.labelMember.Size = new System.Drawing.Size(150, 25);
            this.labelMember.TabIndex = 4;
            this.labelMember.Text = "Select Member:";

            // 
            // comboBoxMember
            // 
            this.comboBoxMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMember.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxMember.Location = new System.Drawing.Point(850, 56);
            this.comboBoxMember.Name = "comboBoxMember";
            this.comboBoxMember.Size = new System.Drawing.Size(300, 36);
            this.comboBoxMember.TabIndex = 3;

            // 
            // textBoxMemberId
            // 
            this.textBoxMemberId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxMemberId.Location = new System.Drawing.Point(1170, 56); // Positioned next to comboBoxMember
            this.textBoxMemberId.Name = "textBoxMemberId";
            this.textBoxMemberId.Size = new System.Drawing.Size(100, 34);
            this.textBoxMemberId.TabIndex = 11;
            this.textBoxMemberId.ReadOnly = true;

            // 
            // labelBorrowDate
            // 
            this.labelBorrowDate.AutoSize = true;
            this.labelBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelBorrowDate.Location = new System.Drawing.Point(1347, 456);
            this.labelBorrowDate.Name = "labelBorrowDate";
            this.labelBorrowDate.Size = new System.Drawing.Size(125, 25);
            this.labelBorrowDate.TabIndex = 8;
            this.labelBorrowDate.Text = "Borrow Date:";

            // 
            // dateTimePickerBorrowDate
            // 
            this.dateTimePickerBorrowDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerBorrowDate.Location = new System.Drawing.Point(1347, 486);
            this.dateTimePickerBorrowDate.Name = "dateTimePickerBorrowDate";
            this.dateTimePickerBorrowDate.Size = new System.Drawing.Size(300, 34);
            this.dateTimePickerBorrowDate.TabIndex = 7;

            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonConfirm.Location = new System.Drawing.Point(1347, 526);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(200, 50);
            this.buttonConfirm.TabIndex = 9;
            this.buttonConfirm.Text = "Confirm Borrow";
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);

            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRemove.Location = new System.Drawing.Point(850, 456);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(200, 50);
            this.buttonRemove.TabIndex = 0;
            this.buttonRemove.Text = "Remove Book";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);

            // 
            // textBoxStaffId
            // 
            this.textBoxStaffId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxStaffId.Location = new System.Drawing.Point(1138, 542);
            this.textBoxStaffId.Name = "textBoxStaffId";
            this.textBoxStaffId.Size = new System.Drawing.Size(176, 34);
            this.textBoxStaffId.TabIndex = 10;
            this.textBoxStaffId.Text = "Enter Staff ID";
            this.textBoxStaffId.ForeColor = System.Drawing.Color.Gray;
            this.textBoxStaffId.Enter += new System.EventHandler(this.TextBoxStaffId_Enter);
            this.textBoxStaffId.Leave += new System.EventHandler(this.TextBoxStaffId_Leave);

            // 
            // BorrowBook
            // 
            this.Controls.Add(this.textBoxMemberId); // Added MemberId TextBox
            this.Controls.Add(this.textBoxStaffId);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.labelAvailableBooks);
            this.Controls.Add(this.comboBoxMember);
            this.Controls.Add(this.labelMember);
            this.Controls.Add(this.dataGridViewSelectedBooks);
            this.Controls.Add(this.labelSelectedBooks);
            this.Controls.Add(this.dateTimePickerBorrowDate);
            this.Controls.Add(this.labelBorrowDate);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "BorrowBook";
            this.Size = new System.Drawing.Size(1700, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Label labelAvailableBooks;
        private System.Windows.Forms.DataGridView dataGridViewSelectedBooks;
        private System.Windows.Forms.Label labelSelectedBooks;
        private System.Windows.Forms.Label labelMember;
        private System.Windows.Forms.ComboBox comboBoxMember;
        private System.Windows.Forms.TextBox textBoxMemberId; // Added TextBox for MemberId
        private System.Windows.Forms.Label labelBorrowDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBorrowDate;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxStaffId;
    }
}
