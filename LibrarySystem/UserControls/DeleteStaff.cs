using LibrarySystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.UserControls
{
    public partial class DeleteStaff : UserControl
    {
        private BookLibrary context;
        private int StaffId = 0;

        public DeleteStaff()
        {
            InitializeComponent();
            context = new BookLibrary();
            this.UserType.SelectedIndex = 0;
        }

        public string deleteStaff(int staffId)
        {
            try
            {
                var existingStaff = context.Staffs.FirstOrDefault(s => s.StaffId == StaffId);
                if (existingStaff is null)
                    return "Staff not found.";
                else

                {
                    existingStaff.StaffName = this.StaffName.Text;
                    existingStaff.FirstName = this.FristName.Text;
                    existingStaff.LastName = this.FristName.Text;
                    existingStaff.Password = this.Password.Text;
                    existingStaff.UserType = this.UserType.Text;
                    //--

                    // Remove the person entity
                    context.Staffs.Remove(existingStaff);

                    // Save changes to the database
                    context.SaveChanges();

                    return "Delete Staff Successfully.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Staff DeleteStaff = (Staff)sender;
        }
    }
}
