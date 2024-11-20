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

namespace LibrarySystem.Views
{
    public partial class User_Login : Form
    {
        public User_Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LJ2Q0UL\SQL2022;Initial Catalog=BookLibrary;Integrated Security=True");

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }
        
        private void User_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txtUsername.Text;
            user_password = txtPassword.Text;

            try
            { 
                String querry = "SELECT * FROM Login WHERE username = '"+txtUsername.Text+"'AND password = '"+txtPassword+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtaTable = new DataTable();
                sda.Fill(dtaTable);

                if(dtaTable.Rows.Count > 0 )
                {
                    username = txtUsername.Text;
                    user_password = txtPassword.Text;


                    Main form2 = new Main();

                } 
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();

                    txtUsername.Focus();    
                }
            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {
                conn.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Clear() ;
            txtPassword.Clear() ;

            txtUsername.Focus() ;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateAccountFrom  obj = new CreateAccountFrom();
            obj.Show();
            this.Hide();
        }
    }
}
