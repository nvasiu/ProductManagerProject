using Microsoft.VisualBasic.Devices;
using System.Data.SqlClient;
using System.Drawing;
using System.Xml.Linq;

namespace ProductManager
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            Load();
        }

        SqlConnection con = new SqlConnection("Data Source=NICI7\\SQLEXPRESS; Initial Catalog=ProductInv; User Id=sa; Password=admin123;");
        SqlCommand cmd;
        SqlDataReader read;
        string cid;
        bool AddMode = true;
        string sql;

        public void Load()
        {
            try
            {
                sql = "SELECT * FROM Customers";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(read[0], read[1], read[2]);
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
            string custname = textCustname.Text;
            string custphone = textCustphone.Text;

            if (AddMode)
            {
                sql = "INSERT INTO Customers(Custname, Custphone) VALUES(@name, @phone)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", custname);
                cmd.Parameters.AddWithValue("@phone", custphone);
                MessageBox.Show("Customer Added");
                cmd.ExecuteNonQuery();

                textCustname.Clear();
                textCustphone.Clear();
            }
            else
            {
                cid = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                sql = "UPDATE Customers SET Custname = @name, Custphone = @phone WHERE id = @cid";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", custname);
                cmd.Parameters.AddWithValue("@phone", custphone);
                cmd.Parameters.AddWithValue("@cid", cid);
                MessageBox.Show("Customer Updated");
                cmd.ExecuteNonQuery();

                textCustname.Clear();
                textCustphone.Clear();
                addButton.Text = "Add";
                AddMode = true;
            }

            con.Close();
            Load();
        }

        public void getRecord(string cid)
        {
            sql = "SELECT * FROM Customers WHERE id = '" + cid + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                textCustname.Text = read[1].ToString();
                textCustphone.Text = read[2].ToString();
            }

            con.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textCustname.Clear();
            textCustphone.Clear();
            addButton.Text = "Add";
            AddMode = true;
            ordercountText.Text = "...";
            ordervalText.Text = "...";
            selectedCustomer.Text = "Customer";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                AddMode = false;
                cid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                getRecord(cid);
                addButton.Text = "Edit";
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                cid = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                sql = "DELETE FROM Customers WHERE id = @cid";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cid", cid);
                MessageBox.Show("Customer Deleted");
                cmd.ExecuteNonQuery();

                con.Close();
                Load();
            }

            selectedCustomer.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            try
            {
                cid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "SELECT COUNT(ID) FROM Orders WHERE Customer = '" + cid + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ordercountText.Text = read[0].ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                cid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "SELECT TotalPrice FROM Orders WHERE Customer = '" + cid + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                decimal orderSum = 0;

                while (read.Read())
                {
                    orderSum = orderSum + decimal.Parse(read[0].ToString(), System.Globalization.NumberStyles.Currency);

                }
                if (!read.HasRows)
                {
                    ordervalText.Text = "0.00";
                }
                else
                {
                    ordervalText.Text = orderSum.ToString();
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
