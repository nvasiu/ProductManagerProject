using Microsoft.VisualBasic.Devices;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ProductManager
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            Load();
            getCategories();
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
                sql = "SELECT * FROM Products";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5]);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getCategories()
        {
            try
            {
                sql = "SELECT * FROM Categories";
                DataTable cats = new DataTable();
                DataTable catSearch = new DataTable();
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                cats.Load(read);
                catSearch = cats.Clone();
                foreach (DataRow row in cats.Rows)
                {
                    catSearch.ImportRow(row);
                }

                boxCategory.ValueMember = "Catname";
                boxCategory.DataSource = cats;
                searchBox.ValueMember = "Catname";
                searchBox.DataSource = catSearch;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string prodName = textProdname.Text;
            string quantity = textQty.Text;
            string price = textPrice.Text;
            string desc = textDesc.Text;
            string category = boxCategory.Text;

            if (AddMode)
            {
                sql = "INSERT INTO Products(prodname, quantity, price, description, category) VALUES(@prodname, @qty, @price, @desc, @cat)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@prodname", prodName);
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@cat", category);
                MessageBox.Show("Product Added");
                cmd.ExecuteNonQuery();

                textProdname.Clear();
                textQty.Clear();
                textPrice.Clear();
                textDesc.Clear();
                boxCategory.SelectedIndex = 0;
            }
            else
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                sql = "UPDATE Products SET prodname = @prodname, quantity = @qty, price = @price, description = @desc, category = @cat WHERE id = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@prodname", prodName);
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@cat", category);
                cmd.Parameters.AddWithValue("@id", id);
                MessageBox.Show("Product Updated");
                cmd.ExecuteNonQuery();

                textProdname.Clear();
                textQty.Clear();
                textPrice.Clear();
                textDesc.Clear();
                boxCategory.SelectedIndex = 0;
                addButton.Text = "Add";
                AddMode = true;
            }

            con.Close();
            Load();
        }

        public void getRecord(string id)
        {
            sql = "SELECT * FROM Products WHERE id = '" + id + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                textProdname.Text = read[1].ToString();
                textQty.Text = read[2].ToString();
                textPrice.Text = read[3].ToString();
                textDesc.Text = read[4].ToString();
                boxCategory.Text = read[5].ToString();
            }

            con.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textProdname.Clear();
            textQty.Clear();
            textPrice.Clear();
            textDesc.Clear();
            boxCategory.SelectedIndex = 0;
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

                sql = "DELETE FROM Products WHERE id = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MessageBox.Show("Product Deleted");
                cmd.ExecuteNonQuery();

                con.Close();
                Load();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT * FROM Products WHERE Category = '" + searchBox.SelectedValue + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5]);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
