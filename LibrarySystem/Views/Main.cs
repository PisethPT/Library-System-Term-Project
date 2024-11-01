using LibrarySystem.Models;
using LibrarySystem.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem.Views
{
	public partial class Main : Form
	{
		private Options Option;
		public Main()
		{
			InitializeComponent();
			Option = new Options();
		}

		private void SelectMenu(SystemOption option)
		{
			this.MainFlowContainer.Controls.Clear();

			switch (option)
			{
				case SystemOption.None:
					{
						Option.ShowUserControl<Dashboard>(this.MainFlowContainer, new Dashboard());
						break;
					}
				case SystemOption.BorrowBook:
					{
						break;
					}
				case SystemOption.BookIssue:
					{
						break;
					}
				case SystemOption.ViewBooks:
					{
						Option.ShowUserControl<ViewBooks>(this.MainFlowContainer, new ViewBooks());
						break;
					}
				case SystemOption.AddNewBook:
					{
						break;
					}
				case SystemOption.UpdateBook:
					{
						break;
					}
				case SystemOption.DeleteBook:
					{
						break;
					}
				case SystemOption.ViewStaffs:
					{
						break;
					}
				case SystemOption.AddNewStaff:
					{
						break;
					}
				case SystemOption.UpdateStaff:
					{
						break;
					}
				case SystemOption.DeleteStaff:
					{
						break;
					}
				case SystemOption.AdminInfo:
					{
						break;
					}
			}

		}

		private void dashboardToolStripMenuItem_Click(object sender, EventArgs e) => SelectMenu(SystemOption.None);

		private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e) => SelectMenu(SystemOption.BorrowBook);

		private void bookIssueToolStripMenuItem_Click(object sender, EventArgs e) => SelectMenu(SystemOption.BookIssue);

		private void listOfStaffToolStripMenuItem_Click(object sender, EventArgs e) => SelectMenu(SystemOption.ViewBooks);
	}


	public class Options
	{
		public void ShowUserControl<T>(FlowLayoutPanel panel, T t)
		{
			var control = t as UserControl;
			if (control is null)
			{
				control.BackColor = SystemColors.Window;
				control.Location = new Point(3, 3);
				control.Name = t.ToString().ToLower();
				control.Size = new Size(1873, 925);
				control.TabIndex = 0;
			}
			if (!panel.Controls.Contains(control))
			{
				panel.Controls.Add(control);
				control.BringToFront();
			}
			//control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			control.Show();

		}
	}


}
