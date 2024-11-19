namespace LibrarySystem.UserControls
{
    partial class BookIssue
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
            this.dataGridViewBookIssues = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Issue";
            // 
            // dataGridViewBookIssues
            // 
            this.dataGridViewBookIssues.AllowUserToAddRows = false;
            this.dataGridViewBookIssues.AllowUserToDeleteRows = false;
            this.dataGridViewBookIssues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookIssues.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewBookIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookIssues.Location = new System.Drawing.Point(16, 50);
            this.dataGridViewBookIssues.Name = "dataGridViewBookIssues";
            this.dataGridViewBookIssues.ReadOnly = true;
            this.dataGridViewBookIssues.RowHeadersVisible = false;
            this.dataGridViewBookIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookIssues.Size = new System.Drawing.Size(1840, 850);
            this.dataGridViewBookIssues.TabIndex = 2;
            // 
            // BookIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dataGridViewBookIssues);
            this.Controls.Add(this.label1);
            this.Name = "BookIssue";
            this.Size = new System.Drawing.Size(1873, 925);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookIssues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBookIssues;
    }
}
