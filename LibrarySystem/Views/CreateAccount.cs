using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibrarySystem.Views
{
    public partial class CreateAccountFrom : Form
    {
        public CreateAccountFrom()
        {
            InitializeComponent();
        }

        private void txtFNamr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LJ2Q0UL\SQL2022;Initial Catalog=BookLibrary;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Login]
            ([username]
           ,[password])
         VALUES
               ('" + txtFName.Text + "','" + txtpass.Text + ")", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Register SuccessFully");

        }
    }
}
