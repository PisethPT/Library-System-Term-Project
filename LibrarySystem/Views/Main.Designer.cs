﻿namespace LibrarySystem.Views
{
	partial class Main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStaffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFlowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.bookLibraryToolStripMenuItem,
            this.bookManagementToolStripMenuItem,
            this.staffManagementToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(13, 6, 13, 6);
            this.menuStrip.Size = new System.Drawing.Size(1902, 44);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(122, 32);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // bookLibraryToolStripMenuItem
            // 
            this.bookLibraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowBookToolStripMenuItem,
            this.bookIssueToolStripMenuItem});
            this.bookLibraryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLibraryToolStripMenuItem.Name = "bookLibraryToolStripMenuItem";
            this.bookLibraryToolStripMenuItem.Size = new System.Drawing.Size(136, 32);
            this.bookLibraryToolStripMenuItem.Text = "Book Library";
            // 
            // borrowBookToolStripMenuItem
            // 
            this.borrowBookToolStripMenuItem.Name = "borrowBookToolStripMenuItem";
            this.borrowBookToolStripMenuItem.Size = new System.Drawing.Size(211, 32);
            this.borrowBookToolStripMenuItem.Text = "Borrow Book";
            this.borrowBookToolStripMenuItem.Click += new System.EventHandler(this.borrowBookToolStripMenuItem_Click);
            // 
            // bookIssueToolStripMenuItem
            // 
            this.bookIssueToolStripMenuItem.Name = "bookIssueToolStripMenuItem";
            this.bookIssueToolStripMenuItem.Size = new System.Drawing.Size(211, 32);
            this.bookIssueToolStripMenuItem.Text = "Book Issue";
            this.bookIssueToolStripMenuItem.Click += new System.EventHandler(this.bookIssueToolStripMenuItem_Click);
            // 
            // bookManagementToolStripMenuItem
            // 
            this.bookManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfStaffToolStripMenuItem,
            this.addNewStaffToolStripMenuItem});
            this.bookManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookManagementToolStripMenuItem.Name = "bookManagementToolStripMenuItem";
            this.bookManagementToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.bookManagementToolStripMenuItem.Text = "Books Management";
            // 
            // listOfStaffToolStripMenuItem
            // 
            this.listOfStaffToolStripMenuItem.Name = "listOfStaffToolStripMenuItem";
            this.listOfStaffToolStripMenuItem.Size = new System.Drawing.Size(211, 32);
            this.listOfStaffToolStripMenuItem.Text = "View Books";
            this.listOfStaffToolStripMenuItem.Click += new System.EventHandler(this.listOfStaffToolStripMenuItem_Click);
            // 
            // addNewStaffToolStripMenuItem
            // 
            this.addNewStaffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem1,
            this.updateBookToolStripMenuItem,
            this.deleteBookToolStripMenuItem});
            this.addNewStaffToolStripMenuItem.Name = "addNewStaffToolStripMenuItem";
            this.addNewStaffToolStripMenuItem.Size = new System.Drawing.Size(211, 32);
            this.addNewStaffToolStripMenuItem.Text = "Book Modify";
            // 
            // addNewBookToolStripMenuItem1
            // 
            this.addNewBookToolStripMenuItem1.Name = "addNewBookToolStripMenuItem1";
            this.addNewBookToolStripMenuItem1.Size = new System.Drawing.Size(229, 32);
            this.addNewBookToolStripMenuItem1.Text = "Add New Book";
            this.addNewBookToolStripMenuItem1.Click += new System.EventHandler(this.addNewBookToolStripMenuItem1_Click);
            // 
            // updateBookToolStripMenuItem
            // 
            this.updateBookToolStripMenuItem.Name = "updateBookToolStripMenuItem";
            this.updateBookToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.updateBookToolStripMenuItem.Text = "Update Book";
            this.updateBookToolStripMenuItem.Click += new System.EventHandler(this.updateBookToolStripMenuItem_Click);
            // 
            // deleteBookToolStripMenuItem
            // 
            this.deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            this.deleteBookToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.deleteBookToolStripMenuItem.Text = "Delete Book";
            // 
            // staffManagementToolStripMenuItem
            // 
            this.staffManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewStaffToolStripMenuItem,
            this.addNewBookToolStripMenuItem});
            this.staffManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffManagementToolStripMenuItem.Name = "staffManagementToolStripMenuItem";
            this.staffManagementToolStripMenuItem.Size = new System.Drawing.Size(186, 32);
            this.staffManagementToolStripMenuItem.Text = "Staff Management";
            // 
            // ViewStaffToolStripMenuItem
            // 
            this.ViewStaffToolStripMenuItem.Name = "ViewStaffToolStripMenuItem";
            this.ViewStaffToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.ViewStaffToolStripMenuItem.Text = "View Staff";
            this.ViewStaffToolStripMenuItem.Click += new System.EventHandler(this.listOfBooksToolStripMenuItem_Click);
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStaffToolStripMenuItem1,
            this.deleteStaffToolStripMenuItem,
            this.updateStaffToolStripMenuItem});
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.addNewBookToolStripMenuItem.Text = "Staff Modify";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // addNewStaffToolStripMenuItem1
            // 
            this.addNewStaffToolStripMenuItem1.Name = "addNewStaffToolStripMenuItem1";
            this.addNewStaffToolStripMenuItem1.Size = new System.Drawing.Size(224, 32);
            this.addNewStaffToolStripMenuItem1.Text = "Add New Staff";
            this.addNewStaffToolStripMenuItem1.Click += new System.EventHandler(this.addNewStaffToolStripMenuItem1_Click);
            // 
            // updateStaffToolStripMenuItem
            // 
            this.updateStaffToolStripMenuItem.Name = "updateStaffToolStripMenuItem";
            this.updateStaffToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.updateStaffToolStripMenuItem.Text = "Update Staff";
            this.updateStaffToolStripMenuItem.Click += new System.EventHandler(this.updateStaffToolStripMenuItem_Click);
            // 
            // deleteStaffToolStripMenuItem
            // 
            this.deleteStaffToolStripMenuItem.Name = "deleteStaffToolStripMenuItem";
            this.deleteStaffToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.deleteStaffToolStripMenuItem.Text = "Delete Staff";
            this.deleteStaffToolStripMenuItem.Click += new System.EventHandler(this.deleteStaffToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminInfoToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.settingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(97, 32);
            this.settingToolStripMenuItem.Text = "Settings";
            // 
            // adminInfoToolStripMenuItem
            // 
            this.adminInfoToolStripMenuItem.Name = "adminInfoToolStripMenuItem";
            this.adminInfoToolStripMenuItem.Size = new System.Drawing.Size(195, 32);
            this.adminInfoToolStripMenuItem.Text = "Admin Info";
            this.adminInfoToolStripMenuItem.Click += new System.EventHandler(this.adminInfoToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(195, 32);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // MainFlowContainer
            // 
            this.MainFlowContainer.Location = new System.Drawing.Point(16, 119);
            this.MainFlowContainer.Margin = new System.Windows.Forms.Padding(4);
            this.MainFlowContainer.Name = "MainFlowContainer";
            this.MainFlowContainer.Size = new System.Drawing.Size(2507, 1147);
            this.MainFlowContainer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1072, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "LIBRARY SYSTEM";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainFlowContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem bookLibraryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bookManagementToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listOfStaffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewStaffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem staffManagementToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ViewStaffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem updateBookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewStaffToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem updateStaffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteStaffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adminInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem borrowBookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bookIssueToolStripMenuItem;
		private System.Windows.Forms.FlowLayoutPanel MainFlowContainer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
	}
}