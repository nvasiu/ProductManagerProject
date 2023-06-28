using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;

namespace ProductManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=NICI7\\SQLEXPRESS; Initial Catalog=ProductInv; User Id=sa; Password=admin123;");
        SqlCommand cmd;
        SqlDataReader read;
        string id;
        string sql;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(99, 0, 0, 0);
        }

        private void showCheckbox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showCheckbox.Checked) { passLabel.UseSystemPasswordChar = false; }
            else { passLabel.UseSystemPasswordChar = true; }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT COUNT(*) FROM Users WHERE Username = '" + userLabel.Text + "' AND Password = '" + passLabel.Text + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    if (read[0].ToString() == "1")
                    {
                        Home homepage = new Home();
                        homepage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}