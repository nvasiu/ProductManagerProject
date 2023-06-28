using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class PrintOrders : Form
    {
        public PrintOrders()
        {
            InitializeComponent();
            Load();
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
                sql = "SELECT * FROM Orders";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5], read[6]);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Print"].Index && e.RowIndex >= 0)
            {
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font drawFont = new Font("Century", 25);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            StringFormat titleFormat = new StringFormat();
            titleFormat.LineAlignment = StringAlignment.Center;
            titleFormat.Alignment = StringAlignment.Center;

            StringFormat contentFormat = new StringFormat();
            contentFormat.LineAlignment = StringAlignment.Near;
            contentFormat.Alignment = StringAlignment.Near;

            Pen blackPen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen, (this.ClientRectangle.Width / 2 - 250.0F), 10, 500.0F, 50.0F);

            e.Graphics.DrawString("Order Summary", drawFont, drawBrush, new RectangleF((this.ClientRectangle.Width / 2 - 250.0F), 10, 500.0F, 50.0F), titleFormat);
            e.Graphics.DrawString("Order ID: " + dataGridView1.CurrentRow.Cells[0].Value.ToString(), drawFont, drawBrush, new RectangleF(50, 100, (float)this.ClientRectangle.Width, 50.0F), contentFormat);
            e.Graphics.DrawString("Order Date: " + dataGridView1.CurrentRow.Cells[6].Value.ToString(), drawFont, drawBrush, new RectangleF(50, 130, (float)this.ClientRectangle.Width, 50.0F), contentFormat);

            try
            {
                sql = "SELECT * FROM Customers WHERE id ='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    e.Graphics.DrawString("Customer ID: " + read[0].ToString(), drawFont, drawBrush, new RectangleF(50, 200, (float)this.ClientRectangle.Width, 50.0F), contentFormat);
                    e.Graphics.DrawString("Customer Name: " + read[1].ToString(), drawFont, drawBrush, new RectangleF(50, 230, (float)this.ClientRectangle.Width, 50.0F), contentFormat);
                    e.Graphics.DrawString("Customer Phone Number: " + read[2].ToString(), drawFont, drawBrush, new RectangleF(50, 260, (float)this.ClientRectangle.Width, 50.0F), contentFormat);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                sql = "SELECT * FROM Products WHERE id ='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    e.Graphics.DrawString("Product ID: " + read[0].ToString(), drawFont, drawBrush, new RectangleF(50, 330, (float)this.ClientRectangle.Width, 50.0F), contentFormat);
                    e.Graphics.DrawString("Product Name: " + read[1].ToString(), drawFont, drawBrush, new RectangleF(50, 360, (float)this.ClientRectangle.Width, 50.0F), contentFormat);
                    e.Graphics.DrawString("Product Price Per Unit: $" + read[3].ToString(), drawFont, drawBrush, new RectangleF(50, 390, (float)this.ClientRectangle.Width, 50.0F), contentFormat);
                    e.Graphics.DrawString("Product Category: " + read[5].ToString(), drawFont, drawBrush, new RectangleF(50, 420, (float)this.ClientRectangle.Width, 50.0F), contentFormat);
                    e.Graphics.DrawString("Product Description: ", drawFont, drawBrush, new RectangleF(50, 450, (float)this.ClientRectangle.Width, 50.0F), contentFormat);
                    e.Graphics.DrawString(read[4].ToString(), drawFont, drawBrush, new RectangleF(50, 480, (float)this.ClientRectangle.Width, 50.0F), contentFormat);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            e.Graphics.DrawString("Units Ordered: " + dataGridView1.CurrentRow.Cells[3].Value.ToString(), drawFont, drawBrush, new RectangleF(50, 550, (float)this.ClientRectangle.Width, 50.0F), contentFormat);
            e.Graphics.DrawString("Total Price: $" + dataGridView1.CurrentRow.Cells[5].Value.ToString(), drawFont, drawBrush, new RectangleF(50, 580, (float)this.ClientRectangle.Width, 50.0F), contentFormat);

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
