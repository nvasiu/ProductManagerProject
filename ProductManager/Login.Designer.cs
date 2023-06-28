namespace ProductManager
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label2 = new Label();
            showCheckbox = new CheckBox();
            quitButton = new Button();
            loginButton = new Button();
            passLabel = new TextBox();
            userLabel = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(showCheckbox);
            panel1.Controls.Add(quitButton);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(passLabel);
            panel1.Controls.Add(userLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(49, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 400);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 34);
            label2.Name = "label2";
            label2.Size = new Size(321, 33);
            label2.TabIndex = 6;
            label2.Text = "Store Product Manager";
            // 
            // showCheckbox
            // 
            showCheckbox.AutoSize = true;
            showCheckbox.BackColor = Color.Transparent;
            showCheckbox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            showCheckbox.ForeColor = Color.White;
            showCheckbox.Location = new Point(23, 271);
            showCheckbox.Name = "showCheckbox";
            showCheckbox.Size = new Size(168, 26);
            showCheckbox.TabIndex = 5;
            showCheckbox.Text = "Show Password";
            showCheckbox.UseVisualStyleBackColor = false;
            showCheckbox.CheckedChanged += showCheckbox_CheckedChanged_1;
            // 
            // quitButton
            // 
            quitButton.BackColor = Color.FromArgb(10, 15, 0);
            quitButton.FlatAppearance.BorderSize = 0;
            quitButton.FlatAppearance.MouseDownBackColor = Color.Black;
            quitButton.FlatStyle = FlatStyle.Flat;
            quitButton.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            quitButton.ForeColor = Color.White;
            quitButton.Location = new Point(269, 324);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(104, 57);
            quitButton.TabIndex = 4;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += quitButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(10, 15, 0);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = Color.Black;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(23, 324);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(104, 57);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passLabel
            // 
            passLabel.BackColor = Color.FromArgb(10, 15, 0);
            passLabel.BorderStyle = BorderStyle.None;
            passLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            passLabel.ForeColor = Color.White;
            passLabel.Location = new Point(23, 220);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(350, 34);
            passLabel.TabIndex = 2;
            passLabel.Text = "Password";
            passLabel.UseSystemPasswordChar = true;
            // 
            // userLabel
            // 
            userLabel.BackColor = Color.FromArgb(10, 15, 0);
            userLabel.BorderStyle = BorderStyle.None;
            userLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            userLabel.ForeColor = Color.White;
            userLabel.Location = new Point(23, 167);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(350, 34);
            userLabel.TabIndex = 1;
            userLabel.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 27.75F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(128, 87);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(137, 44);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(500, 500);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox passLabel;
        private TextBox userLabel;
        private Label label1;
        private Button loginButton;
        private CheckBox showCheckbox;
        private Button quitButton;
        private Label label2;
    }
}