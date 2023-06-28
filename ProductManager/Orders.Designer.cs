namespace ProductManager
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            panel1 = new Panel();
            homeButton = new Button();
            label2 = new Label();
            closeButton = new Button();
            label1 = new Label();
            custGridview = new DataGridView();
            custid = new DataGridViewTextBoxColumn();
            custname = new DataGridViewTextBoxColumn();
            custphone = new DataGridViewTextBoxColumn();
            prodGridview = new DataGridView();
            prodid = new DataGridViewTextBoxColumn();
            prodname = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label3 = new Label();
            searchButton = new Button();
            label8 = new Label();
            searchBox = new ComboBox();
            label4 = new Label();
            textProduct = new TextBox();
            label6 = new Label();
            textCustomer = new TextBox();
            label7 = new Label();
            textDate = new DateTimePicker();
            label9 = new Label();
            orderGridview = new DataGridView();
            orderid = new DataGridViewTextBoxColumn();
            orderprod = new DataGridViewTextBoxColumn();
            ordercustomer = new DataGridViewTextBoxColumn();
            orderquantity = new DataGridViewTextBoxColumn();
            unitprice = new DataGridViewTextBoxColumn();
            totalprice = new DataGridViewTextBoxColumn();
            orderdate = new DataGridViewTextBoxColumn();
            refreshButton = new Button();
            label10 = new Label();
            panel2 = new Panel();
            numQuantity = new NumericUpDown();
            clearButton = new Button();
            orderButton = new Button();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)custGridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prodGridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderGridview).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(homeButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 150);
            panel1.TabIndex = 2;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.FromArgb(0, 64, 0);
            homeButton.BackgroundImage = (Image)resources.GetObject("homeButton.BackgroundImage");
            homeButton.BackgroundImageLayout = ImageLayout.Stretch;
            homeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Location = new Point(1081, 12);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(30, 30);
            homeButton.TabIndex = 47;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(449, 76);
            label2.Name = "label2";
            label2.Size = new Size(265, 39);
            label2.TabIndex = 2;
            label2.Text = "Manage Orders";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(0, 64, 0);
            closeButton.BackgroundImage = (Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(1117, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 30);
            closeButton.TabIndex = 48;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(421, 33);
            label1.Name = "label1";
            label1.Size = new Size(321, 33);
            label1.TabIndex = 1;
            label1.Text = "Store Product Manager";
            // 
            // custGridview
            // 
            custGridview.AllowUserToAddRows = false;
            custGridview.AllowUserToDeleteRows = false;
            custGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            custGridview.Columns.AddRange(new DataGridViewColumn[] { custid, custname, custphone });
            custGridview.Location = new Point(12, 197);
            custGridview.Name = "custGridview";
            custGridview.ReadOnly = true;
            custGridview.RowTemplate.Height = 25;
            custGridview.Size = new Size(361, 315);
            custGridview.TabIndex = 3;
            custGridview.TabStop = false;
            custGridview.CellContentClick += custGridview_CellContentClick;
            // 
            // custid
            // 
            custid.HeaderText = "ID";
            custid.Name = "custid";
            custid.ReadOnly = true;
            // 
            // custname
            // 
            custname.HeaderText = "Name";
            custname.Name = "custname";
            custname.ReadOnly = true;
            // 
            // custphone
            // 
            custphone.HeaderText = "Phone";
            custphone.Name = "custphone";
            custphone.ReadOnly = true;
            // 
            // prodGridview
            // 
            prodGridview.AllowUserToAddRows = false;
            prodGridview.AllowUserToDeleteRows = false;
            prodGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prodGridview.Columns.AddRange(new DataGridViewColumn[] { prodid, prodname, quantity, price, description, category });
            prodGridview.Location = new Point(487, 197);
            prodGridview.Name = "prodGridview";
            prodGridview.ReadOnly = true;
            prodGridview.RowTemplate.Height = 25;
            prodGridview.Size = new Size(660, 315);
            prodGridview.TabIndex = 4;
            prodGridview.CellContentClick += prodGridview_CellContentClick;
            // 
            // prodid
            // 
            prodid.HeaderText = "ID";
            prodid.Name = "prodid";
            prodid.ReadOnly = true;
            // 
            // prodname
            // 
            prodname.HeaderText = "Name";
            prodname.Name = "prodname";
            prodname.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.HeaderText = "In Stock";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // description
            // 
            description.HeaderText = "Description";
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // category
            // 
            category.HeaderText = "Category";
            category.Name = "category";
            category.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(12, 165);
            label5.Name = "label5";
            label5.Size = new Size(92, 21);
            label5.TabIndex = 14;
            label5.Text = "Customers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(487, 165);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 15;
            label3.Text = "Products";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.White;
            searchButton.BackgroundImageLayout = ImageLayout.Center;
            searchButton.FlatAppearance.BorderColor = Color.White;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.Image = Properties.Resources.download1;
            searchButton.ImageAlign = ContentAlignment.TopLeft;
            searchButton.Location = new Point(1079, 161);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(30, 30);
            searchButton.TabIndex = 32;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(720, 165);
            label8.Name = "label8";
            label8.Size = new Size(147, 21);
            label8.TabIndex = 31;
            label8.Text = "Search Category:";
            // 
            // searchBox
            // 
            searchBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.FormattingEnabled = true;
            searchBox.Location = new Point(873, 162);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(200, 29);
            searchBox.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 648);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 36;
            label4.Text = "Product";
            // 
            // textProduct
            // 
            textProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textProduct.Location = new Point(147, 645);
            textProduct.Name = "textProduct";
            textProduct.ReadOnly = true;
            textProduct.Size = new Size(200, 29);
            textProduct.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(37, 600);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 34;
            label6.Text = "Customer";
            // 
            // textCustomer
            // 
            textCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textCustomer.Location = new Point(147, 597);
            textCustomer.Name = "textCustomer";
            textCustomer.ReadOnly = true;
            textCustomer.Size = new Size(200, 29);
            textCustomer.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(37, 697);
            label7.Name = "label7";
            label7.Size = new Size(80, 21);
            label7.TabIndex = 38;
            label7.Text = "Quantity";
            // 
            // textDate
            // 
            textDate.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textDate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDate.Location = new Point(37, 778);
            textDate.Name = "textDate";
            textDate.Size = new Size(310, 27);
            textDate.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label9.Location = new Point(147, 744);
            label9.Name = "label9";
            label9.Size = new Size(99, 21);
            label9.TabIndex = 41;
            label9.Text = "Order Date";
            // 
            // orderGridview
            // 
            orderGridview.AllowUserToAddRows = false;
            orderGridview.AllowUserToDeleteRows = false;
            orderGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderGridview.Columns.AddRange(new DataGridViewColumn[] { orderid, orderprod, ordercustomer, orderquantity, unitprice, totalprice, orderdate });
            orderGridview.Location = new Point(385, 530);
            orderGridview.Name = "orderGridview";
            orderGridview.ReadOnly = true;
            orderGridview.RowTemplate.Height = 25;
            orderGridview.Size = new Size(762, 372);
            orderGridview.TabIndex = 42;
            // 
            // orderid
            // 
            orderid.HeaderText = "Order Num.";
            orderid.Name = "orderid";
            orderid.ReadOnly = true;
            // 
            // orderprod
            // 
            orderprod.HeaderText = "Product ID";
            orderprod.Name = "orderprod";
            orderprod.ReadOnly = true;
            // 
            // ordercustomer
            // 
            ordercustomer.HeaderText = "Customer ID";
            ordercustomer.Name = "ordercustomer";
            ordercustomer.ReadOnly = true;
            // 
            // orderquantity
            // 
            orderquantity.HeaderText = "Quantity";
            orderquantity.Name = "orderquantity";
            orderquantity.ReadOnly = true;
            // 
            // unitprice
            // 
            unitprice.HeaderText = "Unit Price";
            unitprice.Name = "unitprice";
            unitprice.ReadOnly = true;
            // 
            // totalprice
            // 
            totalprice.HeaderText = "Total Price";
            totalprice.Name = "totalprice";
            totalprice.ReadOnly = true;
            // 
            // orderdate
            // 
            orderdate.HeaderText = "Date Ordered";
            orderdate.Name = "orderdate";
            orderdate.ReadOnly = true;
            // 
            // refreshButton
            // 
            refreshButton.Image = Properties.Resources._54303;
            refreshButton.Location = new Point(1114, 161);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(30, 30);
            refreshButton.TabIndex = 43;
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            label10.Location = new Point(112, 540);
            label10.Name = "label10";
            label10.Size = new Size(160, 33);
            label10.TabIndex = 44;
            label10.Text = "New Order";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(numQuantity);
            panel2.Controls.Add(clearButton);
            panel2.Controls.Add(orderButton);
            panel2.Location = new Point(12, 532);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 370);
            panel2.TabIndex = 45;
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numQuantity.Location = new Point(134, 162);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(200, 29);
            numQuantity.TabIndex = 46;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.Location = new Point(234, 308);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 40);
            clearButton.TabIndex = 22;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // orderButton
            // 
            orderButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            orderButton.Location = new Point(24, 308);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(100, 40);
            orderButton.TabIndex = 21;
            orderButton.Text = "Order";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(387, 332);
            label11.Name = "label11";
            label11.Size = new Size(85, 44);
            label11.TabIndex = 46;
            label11.Text = ">>>";
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 915);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(refreshButton);
            Controls.Add(orderGridview);
            Controls.Add(label9);
            Controls.Add(textDate);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(textProduct);
            Controls.Add(label6);
            Controls.Add(textCustomer);
            Controls.Add(searchButton);
            Controls.Add(label8);
            Controls.Add(searchBox);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(prodGridview);
            Controls.Add(custGridview);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)custGridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)prodGridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderGridview).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private DataGridView custGridview;
        private DataGridView prodGridview;
        private Label label5;
        private Label label3;
        private Button searchButton;
        private Label label8;
        private ComboBox searchBox;
        private Label label4;
        private TextBox textProduct;
        private Label label6;
        private TextBox textCustomer;
        private Label label7;
        private DateTimePicker textDate;
        private Label label9;
        private DataGridView orderGridview;
        private DataGridViewTextBoxColumn custid;
        private DataGridViewTextBoxColumn custname;
        private DataGridViewTextBoxColumn custphone;
        private Button refreshButton;
        private Label label10;
        private Panel panel2;
        private NumericUpDown numQuantity;
        private Button clearButton;
        private Button orderButton;
        private Label label11;
        private DataGridViewTextBoxColumn orderid;
        private DataGridViewTextBoxColumn orderprod;
        private DataGridViewTextBoxColumn ordercustomer;
        private DataGridViewTextBoxColumn orderquantity;
        private DataGridViewTextBoxColumn unitprice;
        private DataGridViewTextBoxColumn totalprice;
        private DataGridViewTextBoxColumn orderdate;
        private DataGridViewTextBoxColumn prodid;
        private DataGridViewTextBoxColumn prodname;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn category;
        private Button homeButton;
        private Button closeButton;
    }
}