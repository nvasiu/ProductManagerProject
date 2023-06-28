using Microsoft.VisualBasic.Devices;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ProductManager
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            Load();
        }

        SqlConnection con = new SqlConnection("Data Source=NICI7\\SQLEXPRESS; Initial Catalog=ProductInv; User Id=sa; Password=admin123;");
        SqlCommand cmd;
        SqlDataReader read;
        string id;
        bool AddMode = true;
        string sql;

        public void Load()
        {
            try
            {
                sql = "SELECT * FROM Users";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(read[0], read[1], read[2], read[3], read[4]);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string username = textUser.Text;
            string fullname = textName.Text;
            string phonenum = textPhone.Text;
            string password = textPass.Text;

            if (AddMode)
            {
                sql = "INSERT INTO Users(username, name, phone, password) VALUES(@username, @name, @phone, @password)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@name", fullname);
                cmd.Parameters.AddWithValue("@phone", phonenum);
                cmd.Parameters.AddWithValue("@password", password);
                MessageBox.Show("User Added");
                cmd.ExecuteNonQuery();

                textUser.Clear();
                textName.Clear();
                textPhone.Clear();
                textPass.Clear();
            }
            else
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                sql = "UPDATE Users SET username = @username, name = @name, phone = @phone, password = @password WHERE id = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@name", fullname);
                cmd.Parameters.AddWithValue("@phone", phonenum);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@id", id);
                MessageBox.Show("User Updated");
                cmd.ExecuteNonQuery();

                textUser.Clear();
                textName.Clear();
                textPhone.Clear();
                textPass.Clear();
                addButton.Text = "Add";
                AddMode = true;
            }

            con.Close();
            Load();
        }

        public void getRecord(string id)
        {
            sql = "SELECT * FROM Users WHERE id = '" + id + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                textUser.Text = read[1].ToString();
                textName.Text = read[2].ToString();
                textPhone.Text = read[3].ToString();
                textPass.Text = read[4].ToString();
            }

            con.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textUser.Clear();
            textName.Clear();
            textPhone.Clear();
            textPass.Clear();
            addButton.Text = "Add";
            AddMode = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                AddMode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                getRecord(id);
                addButton.Text = "Edit";
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                sql = "DELETE FROM Users WHERE id = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MessageBox.Show("User Deleted");
                cmd.ExecuteNonQuery();

                con.Close();
                Load();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Hide();
        }
    }
}
