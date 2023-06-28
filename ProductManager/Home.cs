using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            Users userpage = new Users();
            userpage.Show();
            this.Hide();
        }

        private void catButton_Click(object sender, EventArgs e)
        {
            Categories catpage = new Categories();
            catpage.Show();
            this.Hide();
        }

        private void prodButton_Click(object sender, EventArgs e)
        {
            Products prodpage = new Products();
            prodpage.Show();
            this.Hide();
        }

        private void custButton_Click(object sender, EventArgs e)
        {
            Customers custpage = new Customers();
            custpage.Show();
            this.Hide();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            Orders orderpage = new Orders();
            orderpage.Show();
            this.Hide();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintOrders printpage = new PrintOrders();
            printpage.Show();
            this.Hide();
        }
    }
}
