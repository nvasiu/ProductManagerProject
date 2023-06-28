namespace ProductManager
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            homeButton = new Button();
            closeButton = new Button();
            refreshButton = new Button();
            clearButton = new Button();
            addButton = new Button();
            labelcf = new Label();
            textCatname = new TextBox();
            custhomeButton = new Button();
            dataGridView1 = new DataGridView();
            catid = new DataGridViewTextBoxColumn();
            catname = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(171, 71);
            label2.Name = "label2";
            label2.Size = new Size(465, 39);
            label2.TabIndex = 2;
            label2.Text = "Manage Product Categories";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(243, 28);
            label1.Name = "label1";
            label1.Size = new Size(321, 33);
            label1.TabIndex = 1;
            label1.Text = "Store Product Manager";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(homeButton);
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 150);
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
            homeButton.Location = new Point(718, 12);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(30, 30);
            homeButton.TabIndex = 21;
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
            closeButton.Location = new Point(754, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 30);
            closeButton.TabIndex = 22;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            refreshButton.Location = new Point(225, 244);
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
            clearButton.Location = new Point(119, 244);
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
            addButton.Location = new Point(13, 244);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 40);
            addButton.TabIndex = 20;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // labelcf
            // 
            labelcf.AutoSize = true;
            labelcf.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelcf.Location = new Point(13, 182);
            labelcf.Name = "labelcf";
            labelcf.Size = new Size(97, 21);
            labelcf.TabIndex = 17;
            labelcf.Text = "Cat. Name";
            // 
            // textCatname
            // 
            textCatname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textCatname.Location = new Point(123, 179);
            textCatname.Name = "textCatname";
            textCatname.Size = new Size(200, 29);
            textCatname.TabIndex = 16;
            // 
            // custhomeButton
            // 
            custhomeButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            custhomeButton.Location = new Point(12, 523);
            custhomeButton.Name = "custhomeButton";
            custhomeButton.Size = new Size(125, 40);
            custhomeButton.TabIndex = 23;
            custhomeButton.Text = "<< Home";
            custhomeButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { catid, catname, edit, delete });
            dataGridView1.Location = new Point(337, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(444, 407);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // catid
            // 
            catid.HeaderText = "ID";
            catid.Name = "catid";
            catid.ReadOnly = true;
            // 
            // catname
            // 
            catname.HeaderText = "Name";
            catname.Name = "catname";
            catname.ReadOnly = true;
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
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 575);
            Controls.Add(dataGridView1);
            Controls.Add(custhomeButton);
            Controls.Add(refreshButton);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(labelcf);
            Controls.Add(textCatname);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Categories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories";
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
        private Label labelcpn;
        private TextBox textCustphone;
        private Label labelcf;
        private TextBox textCatname;
        private Button custhomeButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn catid;
        private DataGridViewTextBoxColumn catname;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
        private Button homeButton;
        private Button closeButton;
    }
}