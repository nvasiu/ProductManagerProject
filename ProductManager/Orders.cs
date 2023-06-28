using Microsoft.VisualBasic.Devices;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProductManager
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            Load();
            getCategories();
        }

        SqlConnection con = new SqlConnection("Data Source=NICI7\\SQLEXPRESS; Initial Catalog=ProductInv; User Id=sa; Password=admin123;");
        SqlCommand cmd;
        SqlDataReader read;
        string id;
        string sql;

        public void Load()
        {
            try
            {
                sql = "SELECT * FROM Customers";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                custGridview.Rows.Clear();
                while (read.Read())
                {
                    custGridview.Rows.Add(read[0], read[1], read[2]);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                sql = "SELECT * FROM Products";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                prodGridview.Rows.Clear();
                while (read.Read())
                {
                    prodGridview.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5]);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                sql = "SELECT * FROM Orders";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                orderGridview.Rows.Clear();
                while (read.Read())
                {
                    orderGridview.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5], read[6]);
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
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                cats.Load(read);
                searchBox.ValueMember = "Catname";
                searchBox.DataSource = cats;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                prodGridview.Rows.Clear();
                while (read.Read())
                {
                    prodGridview.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5]);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void custGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textCustomer.Text = custGridview.CurrentRow.Cells[0].Value.ToString() + " | " + custGridview.CurrentRow.Cells[1].Value.ToString();
        }

        private void prodGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textProduct.Text = prodGridview.CurrentRow.Cells[0].Value.ToString() + " | " + prodGridview.CurrentRow.Cells[1].Value.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textCustomer.Clear();
            textProduct.Clear();
            numQuantity.Value = 0;
            textDate.Value = DateTime.Now;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textCustomer.Text) || string.IsNullOrEmpty(textProduct.Text))
            {
                MessageBox.Show("Please select a customer and product to create an order.");
            }
            else if (numQuantity.Value == 0)
            {
                MessageBox.Show("Please select the quantity of products to order.");
            }
            else if ((int)numQuantity.Value > int.Parse(prodGridview.CurrentRow.Cells[2].Value.ToString()))
            {
                MessageBox.Show("We do not have enough of this product in stock for an order of your selected quantity.");
            }
            else
            {
                string orderprod = prodGridview.CurrentRow.Cells[0].Value.ToString();
                string ordercust = custGridview.CurrentRow.Cells[0].Value.ToString();
                string quanity = numQuantity.Value.ToString();
                string price = prodGridview.CurrentRow.Cells[3].Value.ToString();
                decimal sum = decimal.Multiply(decimal.Parse(prodGridview.CurrentRow.Cells[3].Value.ToString(), System.Globalization.NumberStyles.Currency), (decimal)numQuantity.Value);
                string total = sum.ToString();
                string date = textDate.Text;

                sql = "INSERT INTO Orders(product, customer, quantity, unitprice, totalprice, date) VALUES(@orderprod, @ordercust, @quanity, @price, @total, @date)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@orderprod", orderprod);
                cmd.Parameters.AddWithValue("@ordercust", ordercust);
                cmd.Parameters.AddWithValue("@quanity", quanity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();

                id = prodGridview.CurrentRow.Cells[0].Value.ToString();

                int prevQuantity = int.Parse(prodGridview.CurrentRow.Cells[2].Value.ToString());
                int newQuantity = prevQuantity - (int)numQuantity.Value;

                sql = "UPDATE Products SET quantity = @newQuantity WHERE id = @id";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@newQuantity", newQuantity);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Order Created");
                textCustomer.Clear();
                textProduct.Clear();
                numQuantity.Value = 0;
                textDate.Value = DateTime.Now;

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
