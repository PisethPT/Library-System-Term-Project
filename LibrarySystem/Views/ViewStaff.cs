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

namespace LibrarySystem.Views
{
    public partial class ViewStaff : Form
    {
        public ViewStaff()
        {
            InitializeComponent();
        }

        DataStaffDataContext db = new DataStaffDataContext();

        

        private void ViewStaff_Load(object sender, EventArgs e)
        {
           var pro = from s in db.Staffs select s;
            dataGridView.DataSource = pro;

        }

        private void cboStaff_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
