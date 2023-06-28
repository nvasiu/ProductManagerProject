namespace ProductManager
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            label1 = new Label();
            panel1 = new Panel();
            homeButton = new Button();
            label2 = new Label();
            closeButton = new Button();
            labelcpn = new Label();
            textCustphone = new TextBox();
            labelcf = new Label();
            textCustname = new TextBox();
            refreshButton = new Button();
            clearButton = new Button();
            addButton = new Button();
            custhomeButton = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            custname = new DataGridViewTextBoxColumn();
            custphone = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            panel2 = new Panel();
            selectedCustomer = new Label();
            ordervalText = new Label();
            label6 = new Label();
            ordercountText = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(288, 28);
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
            panel1.Size = new Size(897, 150);
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
            homeButton.Location = new Point(819, 12);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(30, 30);
            homeButton.TabIndex = 21;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(287, 71);
            label2.Name = "label2";
            label2.Size = new Size(323, 39);
            label2.TabIndex = 2;
            label2.Text = "Manage Customers";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(0, 64, 0);
            closeButton.BackgroundImage = (Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(855, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 30);
            closeButton.TabIndex = 22;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // labelcpn
            // 
            labelcpn.AutoSize = true;
            labelcpn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelcpn.Location = new Point(13, 228);
            labelcpn.Name = "labelcpn";
            labelcpn.Size = new Size(104, 21);
            labelcpn.TabIndex = 10;
            labelcpn.Text = "Phone Num.";
            // 
            // textCustphone
            // 
            textCustphone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textCustphone.Location = new Point(123, 225);
            textCustphone.Name = "textCustphone";
            textCustphone.Size = new Size(200, 29);
            textCustphone.TabIndex = 9;
            // 
            // labelcf
            // 
            labelcf.AutoSize = true;
            labelcf.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelcf.Location = new Point(13, 180);
            labelcf.Name = "labelcf";
            labelcf.Size = new Size(86, 21);
            labelcf.TabIndex = 8;
            labelcf.Text = "Full Name";
            // 
            // textCustname
            // 
            textCustname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textCustname.Location = new Point(123, 177);
            textCustname.Name = "textCustname";
            textCustname.Size = new Size(200, 29);
            textCustname.TabIndex = 7;
            // 
            // refreshButton
            // 
            refreshButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            refreshButton.Location = new Point(225, 290);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 15;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.Location = new Point(119, 290);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 40);
            clearButton.TabIndex = 14;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // addButton
            // 
            addButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(13, 290);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 40);
            addButton.TabIndex = 13;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // custhomeButton
            // 
            custhomeButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            custhomeButton.Location = new Point(12, 523);
            custhomeButton.Name = "custhomeButton";
            custhomeButton.Size = new Size(125, 40);
            custhomeButton.TabIndex = 16;
            custhomeButton.Text = "<< Home";
            custhomeButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, custname, custphone, edit, delete });
            dataGridView1.Location = new Point(337, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(544, 407);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "Cust. ID";
            id.Name = "id";
            id.ReadOnly = true;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.Controls.Add(selectedCustomer);
            panel2.Controls.Add(ordervalText);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(ordercountText);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(23, 369);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 106);
            panel2.TabIndex = 18;
            // 
            // selectedCustomer
            // 
            selectedCustomer.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            selectedCustomer.ForeColor = Color.White;
            selectedCustomer.Location = new Point(4, 5);
            selectedCustomer.Name = "selectedCustomer";
            selectedCustomer.Size = new Size(283, 21);
            selectedCustomer.TabIndex = 25;
            selectedCustomer.Text = "Customer";
            selectedCustomer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ordervalText
            // 
            ordervalText.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ordervalText.ForeColor = Color.White;
            ordervalText.Location = new Point(182, 73);
            ordervalText.Name = "ordervalText";
            ordervalText.Size = new Size(100, 21);
            ordervalText.TabIndex = 22;
            ordervalText.Text = "...";
            ordervalText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(31, 73);
            label6.Name = "label6";
            label6.Size = new Size(102, 21);
            label6.TabIndex = 21;
            label6.Text = "Order Total:";
            // 
            // ordercountText
            // 
            ordercountText.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ordercountText.ForeColor = Color.White;
            ordercountText.Location = new Point(182, 43);
            ordercountText.Name = "ordercountText";
            ordercountText.Size = new Size(100, 21);
            ordercountText.TabIndex = 20;
            ordercountText.Text = "...";
            ordercountText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 43);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 19;
            label3.Text = "Order Count:";
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 575);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(custhomeButton);
            Controls.Add(refreshButton);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(labelcpn);
            Controls.Add(textCustphone);
            Controls.Add(labelcf);
            Controls.Add(textCustname);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label labelcpn;
        private TextBox textCustphone;
        private Label labelcf;
        private TextBox textCustname;
        private Button refreshButton;
        private Button clearButton;
        private Button addButton;
        private Button custhomeButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn custname;
        private DataGridViewTextBoxColumn custphone;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
        private Panel panel2;
        private Label ordervalText;
        private Label label6;
        private Label ordercountText;
        private Label label3;
        private Label selectedCustomer;
        private Button homeButton;
        private Button closeButton;
    }
}