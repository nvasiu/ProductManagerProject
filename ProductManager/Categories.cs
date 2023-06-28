using Microsoft.VisualBasic.Devices;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ProductManager
{
    public partial class Categories : Form
    {
        public Categories()
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
                sql = "SELECT * FROM Categories";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(read[0], read[1]);
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
            string catName = textCatname.Text;

            if (AddMode)
            {
                sql = "INSERT INTO Categories(catname) VALUES(@catname)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@catname", catName);
                MessageBox.Show("Category Added");
                cmd.ExecuteNonQuery();

                textCatname.Clear();
            }
            else
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                sql = "UPDATE Categories SET catname = @catname WHERE id = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@catname", catName);
                cmd.Parameters.AddWithValue("@id", id);
                MessageBox.Show("Category Updated");
                cmd.ExecuteNonQuery();

                textCatname.Clear();
                addButton.Text = "Add";
                AddMode = true;
            }

            con.Close();
            Load();
        }

        public void getRecord(string id)
        {
            sql = "SELECT * FROM Categories WHERE id = '" + id + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                textCatname.Text = read[1].ToString();
            }

            con.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textCatname.Clear();
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

                sql = "DELETE FROM Categories WHERE id = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MessageBox.Show("Category Deleted");
                cmd.ExecuteNonQuery();

                con.Close();
                Load();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Hide();
        }
    }
}
