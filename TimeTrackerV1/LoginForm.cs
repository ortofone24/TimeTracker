using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TimeTrackerV1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connect connection = new Connect();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();

            string query = "SELECT * FROM TimeTrackerUsers WHERE username = @usn AND password = @pass";

            command.CommandText = query;
            command.Connection = connection.getConnection();

            command.Parameters.Add("@usn", SqlDbType.VarChar).Value = txtUsernameInput.Text;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPasswordInput.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mForm = new MainForm();
                mForm.Show();

            }
            else
            {
                if (txtUsernameInput.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPasswordInput.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Username or Password doesn't exists", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
