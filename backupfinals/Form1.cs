using MySql.Data.MySqlClient;
namespace backupfinals
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        public Form1()

        {

            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=finalsdb;username=root;password=;");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtUsername.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Enter both username and password");
            }
            try
            {
                connection.Open();
                string loginquery = "SELECT COUNT(*) FROM users WHERE username=@username And password=@password";
                MySqlCommand command = new MySqlCommand(loginquery, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Successfully Login");
                    Inventory inventorypage = new Inventory();
                    inventorypage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username and passowrd");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
