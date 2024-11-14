using LibrarySystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.UserControls
{
	public partial class AddStaff : UserControl
	{
		private BookLibrary context;
		private int staffId = 0;
        public AddStaff()
		{
			InitializeComponent();
			context = new BookLibrary();
			this.UserType.SelectedIndex = 0;
			staffId = context.Staffs.OrderByDescending(s => s.StaffId).First().StaffId + 1;
			this.txtStaffId.Text = staffId.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
			Staff newStaff = new Staff();
            try
            {
                newStaff.StaffId = staffId;
                if (string.IsNullOrEmpty(this.FristName.Text))
                {
                    MessageBox.Show("First Name is empty.");
                    return;
                }
                else
                {
                    newStaff.FirstName = this.FristName.Text;
                }

                newStaff.LastName = this.LastName.Text;
                newStaff.StaffName = this.StaffName.Text;
                newStaff.Password = this.Password.Text;
                newStaff.UserType = this.UserType.SelectedItem.ToString();

                context.Staffs.Add(newStaff);
                context.SaveChanges();
                MessageBox.Show("Create Success.");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
