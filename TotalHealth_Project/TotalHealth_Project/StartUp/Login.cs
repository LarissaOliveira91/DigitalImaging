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

namespace TotalHealth_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " - Login";
            txtPassword.UseSystemPasswordChar = true;
            txtUsername.Text = Environment.UserName.ToString();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidPassword())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Login or password entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("There is no User with this username - " + txtUsername.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidPassword()
        {
            string login = txtUsername.Text;
            string password = txtPassword.Text;

            string query = string.Format("SELECT Password FROM Receptionist WHERE Login = '{0}'", login);
            DataTable dt = GetData(query);

            if(password == dt.Rows[0][0].ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private DataTable GetData(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnString);
            DataTable dt = new DataTable();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand(query, conn); SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

    }
}
