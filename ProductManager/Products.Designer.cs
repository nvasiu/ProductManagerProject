namespace ProductManager
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            homeButton = new Button();
            closeButton = new Button();
            refreshButton = new Button();
            clearButton = new Button();
            addButton = new Button();
            label5 = new Label();
            textDesc = new TextBox();
            label6 = new Label();
            textPrice = new TextBox();
            label4 = new Label();
            textQty = new TextBox();
            label3 = new Label();
            textProdname = new TextBox();
            boxCategory = new ComboBox();
            label7 = new Label();
            custhomeButton = new Button();
            dataGridView1 = new DataGridView();
            prodid = new DataGridViewTextBoxColumn();
            prodname = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            prodcategory = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            label8 = new Label();
            searchBox = new ComboBox();
            searchButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(454, 76);
            label2.Name = "label2";
            label2.Size = new Size(296, 39);
            label2.TabIndex = 2;
            label2.Text = "Manage Products";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(442, 33);
            label1.Name = "label1";
            label1.Size = new Size(321, 33);
            label1.TabIndex = 1;
            label1.Text = "Store Product Manager";
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
            panel1.TabIndex = 1;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.FromArgb(0, 64, 0);
            homeButton.BackgroundImage = (Image)resources.GetObject("homeButton.BackgroundImage");
            homeButton.BackgroundImageLayout = ImageLayout.Stretch;
            homeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Location = new Point(1116, 12);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(30, 30);
            homeButton.TabIndex = 30;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(0, 64, 0);
            closeButton.BackgroundImage = (Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(1152, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 30);
            closeButton.TabIndex = 31;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            refreshButton.Location = new Point(222, 432);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 22;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.Location = new Point(116, 432);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 40);
            clearButton.TabIndex = 21;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // addButton
            // 
            addButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(10, 432);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 40);
            addButton.TabIndex = 20;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 324);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 19;
            label5.Text = "Description";
            // 
            // textDesc
            // 
            textDesc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDesc.Location = new Point(122, 321);
            textDesc.Name = "textDesc";
            textDesc.Size = new Size(200, 29);
            textDesc.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 276);
            label6.Name = "label6";
            label6.Size = new Size(47, 21);
            label6.TabIndex = 17;
            label6.Text = "Price";
            // 
            // textPrice
            // 
            textPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPrice.Location = new Point(122, 273);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(200, 29);
            textPrice.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 226);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 15;
            label4.Text = "Quantity";
            // 
            // textQty
            // 
            textQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textQty.Location = new Point(122, 223);
            textQty.Name = "textQty";
            textQty.Size = new Size(200, 29);
            textQty.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 178);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 13;
            label3.Text = "Prod. Name";
            // 
            // textProdname
            // 
            textProdname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textProdname.Location = new Point(122, 175);
            textProdname.Name = "textProdname";
            textProdname.Size = new Size(200, 29);
            textProdname.TabIndex = 12;
            // 
            // boxCategory
            // 
            boxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            boxCategory.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boxCategory.FormattingEnabled = true;
            boxCategory.Location = new Point(122, 367);
            boxCategory.Name = "boxCategory";
            boxCategory.Size = new Size(200, 29);
            boxCategory.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 370);
            label7.Name = "label7";
            label7.Size = new Size(85, 21);
            label7.TabIndex = 24;
            label7.Text = "Category";
            // 
            // custhomeButton
            // 
            custhomeButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            custhomeButton.Location = new Point(12, 567);
            custhomeButton.Name = "custhomeButton";
            custhomeButton.Size = new Size(125, 40);
            custhomeButton.TabIndex = 25;
            custhomeButton.Text = "<< Home";
            custhomeButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { prodid, prodname, quantity, price, description, prodcategory, edit, delete });
            dataGridView1.Location = new Point(338, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(844, 416);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            quantity.HeaderText = "Quantity";
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
            // prodcategory
            // 
            prodcategory.HeaderText = "Category";
            prodcategory.Name = "prodcategory";
            prodcategory.ReadOnly = true;
            // 
            // edit
            // 
            edit.HeaderText = "Edit";
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            delete.HeaderText = "Delete";
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(793, 159);
            label8.Name = "label8";
            label8.Size = new Size(147, 21);
            label8.TabIndex = 28;
            label8.Text = "Search Category:";
            // 
            // searchBox
            // 
            searchBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.FormattingEnabled = true;
            searchBox.Location = new Point(946, 156);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(200, 29);
            searchBox.TabIndex = 27;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.White;
            searchButton.BackgroundImageLayout = ImageLayout.Center;
            searchButton.FlatAppearance.BorderColor = Color.White;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.Image = Properties.Resources.download1;
            searchButton.ImageAlign = ContentAlignment.TopLeft;
            searchButton.Location = new Point(1152, 156);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(30, 30);
            searchButton.TabIndex = 29;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 619);
            Controls.Add(searchButton);
            Controls.Add(label8);
            Controls.Add(searchBox);
            Controls.Add(dataGridView1);
            Controls.Add(custhomeButton);
            Controls.Add(label7);
            Controls.Add(boxCategory);
            Controls.Add(refreshButton);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(label5);
            Controls.Add(textDesc);
            Controls.Add(label6);
            Controls.Add(textPrice);
            Controls.Add(label4);
            Controls.Add(textQty);
            Controls.Add(label3);
            Controls.Add(textProdname);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button refreshButton;
        private Button clearButton;
        private Button addButton;
        private Label label5;
        private TextBox textDesc;
        private Label label6;
        private TextBox textPrice;
        private Label label4;
        private TextBox textQty;
        private Label label3;
        private TextBox textProdname;
        private ComboBox boxCategory;
        private Label label7;
        private Button custhomeButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn prodid;
        private DataGridViewTextBoxColumn prodname;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn prodcategory;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
        private Label label8;
        private ComboBox searchBox;
        private Button searchButton;
        private Button homeButton;
        private Button closeButton;
    }
}