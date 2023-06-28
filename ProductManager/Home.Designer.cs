namespace ProductManager
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label2 = new Label();
            panel1 = new Panel();
            closeButton = new Button();
            orderButton = new Button();
            label1 = new Label();
            label3 = new Label();
            userButton = new Button();
            label4 = new Label();
            catButton = new Button();
            label5 = new Label();
            printButton = new Button();
            label6 = new Label();
            prodButton = new Button();
            label7 = new Label();
            custButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(381, 39);
            label2.TabIndex = 2;
            label2.Text = "Store Product Manager";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 150);
            panel1.TabIndex = 4;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(0, 64, 0);
            closeButton.BackgroundImage = (Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(344, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 30);
            closeButton.TabIndex = 18;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click_1;
            // 
            // orderButton
            // 
            orderButton.BackColor = Color.FromArgb(0, 64, 0);
            orderButton.BackgroundImage = (Image)resources.GetObject("orderButton.BackgroundImage");
            orderButton.BackgroundImageLayout = ImageLayout.Stretch;
            orderButton.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            orderButton.FlatAppearance.BorderSize = 10;
            orderButton.FlatStyle = FlatStyle.Flat;
            orderButton.Location = new Point(45, 478);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(100, 100);
            orderButton.TabIndex = 5;
            orderButton.UseVisualStyleBackColor = false;
            orderButton.Click += orderButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(29, 581);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 6;
            label1.Text = "Manage Orders";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(35, 280);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 8;
            label3.Text = "Manage Users";
            // 
            // userButton
            // 
            userButton.BackColor = Color.FromArgb(0, 64, 0);
            userButton.BackgroundImage = (Image)resources.GetObject("userButton.BackgroundImage");
            userButton.BackgroundImageLayout = ImageLayout.Stretch;
            userButton.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            userButton.FlatAppearance.BorderSize = 10;
            userButton.FlatStyle = FlatStyle.Flat;
            userButton.Location = new Point(45, 177);
            userButton.Name = "userButton";
            userButton.Size = new Size(100, 100);
            userButton.TabIndex = 7;
            userButton.UseVisualStyleBackColor = false;
            userButton.Click += userButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(206, 280);
            label4.Name = "label4";
            label4.Size = new Size(168, 21);
            label4.TabIndex = 10;
            label4.Text = "Manage Categories";
            // 
            // catButton
            // 
            catButton.BackColor = Color.FromArgb(0, 64, 0);
            catButton.BackgroundImage = (Image)resources.GetObject("catButton.BackgroundImage");
            catButton.BackgroundImageLayout = ImageLayout.Stretch;
            catButton.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            catButton.FlatAppearance.BorderSize = 10;
            catButton.FlatStyle = FlatStyle.Flat;
            catButton.Location = new Point(240, 177);
            catButton.Name = "catButton";
            catButton.Size = new Size(100, 100);
            catButton.TabIndex = 9;
            catButton.UseVisualStyleBackColor = false;
            catButton.Click += catButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(241, 581);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 12;
            label5.Text = "Print Orders";
            // 
            // printButton
            // 
            printButton.BackColor = Color.FromArgb(0, 64, 0);
            printButton.BackgroundImage = (Image)resources.GetObject("printButton.BackgroundImage");
            printButton.BackgroundImageLayout = ImageLayout.Stretch;
            printButton.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            printButton.FlatAppearance.BorderSize = 10;
            printButton.FlatStyle = FlatStyle.Flat;
            printButton.Location = new Point(240, 478);
            printButton.Name = "printButton";
            printButton.Size = new Size(100, 100);
            printButton.TabIndex = 11;
            printButton.UseVisualStyleBackColor = false;
            printButton.Click += printButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(20, 430);
            label6.Name = "label6";
            label6.Size = new Size(150, 21);
            label6.TabIndex = 14;
            label6.Text = "Manage Products";
            // 
            // prodButton
            // 
            prodButton.BackColor = Color.FromArgb(0, 64, 0);
            prodButton.BackgroundImage = (Image)resources.GetObject("prodButton.BackgroundImage");
            prodButton.BackgroundImageLayout = ImageLayout.Stretch;
            prodButton.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            prodButton.FlatAppearance.BorderSize = 10;
            prodButton.FlatStyle = FlatStyle.Flat;
            prodButton.Location = new Point(45, 327);
            prodButton.Name = "prodButton";
            prodButton.Size = new Size(100, 100);
            prodButton.TabIndex = 13;
            prodButton.UseVisualStyleBackColor = false;
            prodButton.Click += prodButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label7.Location = new Point(208, 430);
            label7.Name = "label7";
            label7.Size = new Size(164, 21);
            label7.TabIndex = 16;
            label7.Text = "Manage Customers";
            // 
            // custButton
            // 
            custButton.BackColor = Color.FromArgb(0, 64, 0);
            custButton.BackgroundImage = (Image)resources.GetObject("custButton.BackgroundImage");
            custButton.BackgroundImageLayout = ImageLayout.Stretch;
            custButton.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            custButton.FlatAppearance.BorderSize = 10;
            custButton.FlatStyle = FlatStyle.Flat;
            custButton.Location = new Point(240, 327);
            custButton.Name = "custButton";
            custButton.Size = new Size(100, 100);
            custButton.TabIndex = 15;
            custButton.UseVisualStyleBackColor = false;
            custButton.Click += custButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 634);
            Controls.Add(label7);
            Controls.Add(custButton);
            Controls.Add(label6);
            Controls.Add(prodButton);
            Controls.Add(label5);
            Controls.Add(printButton);
            Controls.Add(label4);
            Controls.Add(catButton);
            Controls.Add(label3);
            Controls.Add(userButton);
            Controls.Add(label1);
            Controls.Add(orderButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Button closeButton;
        private Button orderButton;
        private Label label1;
        private Label label3;
        private Button userButton;
        private Label label4;
        private Button catButton;
        private Label label5;
        private Button printButton;
        private Label label6;
        private Button prodButton;
        private Label label7;
        private Button custButton;
    }
}