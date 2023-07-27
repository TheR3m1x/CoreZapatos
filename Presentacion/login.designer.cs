namespace Presentacion
{
    partial class login
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.checkboxPassword = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttomClear = new System.Windows.Forms.Button();
            this.buttomMinus = new FontAwesome.Sharp.IconButton();
            this.buttomClose = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Myanmar Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(167, 9);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(224, 66);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Bienvenido";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(183)))), ((int)(((byte)(157)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 557);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 43);
            this.panel1.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernameLabel.Location = new System.Drawing.Point(116, 155);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(114, 37);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(183)))), ((int)(((byte)(157)))));
            this.panel2.Controls.Add(this.buttomMinus);
            this.panel2.Controls.Add(this.buttomClose);
            this.panel2.Controls.Add(this.LoginLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 79);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passwordLabel.Location = new System.Drawing.Point(116, 242);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(110, 37);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtUsername.Location = new System.Drawing.Point(123, 185);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 31);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPassword.Location = new System.Drawing.Point(123, 272);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(300, 31);
            this.txtPassword.TabIndex = 8;
            // 
            // checkboxPassword
            // 
            this.checkboxPassword.AutoSize = true;
            this.checkboxPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxPassword.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkboxPassword.Location = new System.Drawing.Point(293, 309);
            this.checkboxPassword.Name = "checkboxPassword";
            this.checkboxPassword.Size = new System.Drawing.Size(150, 33);
            this.checkboxPassword.TabIndex = 9;
            this.checkboxPassword.Text = "Show Password";
            this.checkboxPassword.UseVisualStyleBackColor = true;
            this.checkboxPassword.CheckedChanged += new System.EventHandler(this.checkboxPassword_CheckedChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(169)))), ((int)(((byte)(126)))));
            this.buttonLogin.Location = new System.Drawing.Point(123, 348);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(300, 60);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttomLogin_Click);
            // 
            // buttomClear
            // 
            this.buttomClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttomClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttomClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttomClear.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttomClear.ForeColor = System.Drawing.Color.White;
            this.buttomClear.Location = new System.Drawing.Point(123, 429);
            this.buttomClear.Name = "buttomClear";
            this.buttomClear.Size = new System.Drawing.Size(300, 60);
            this.buttomClear.TabIndex = 11;
            this.buttomClear.Text = "CLEAR";
            this.buttomClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttomClear.UseVisualStyleBackColor = true;
            this.buttomClear.Click += new System.EventHandler(this.buttomClear_Click);
            // 
            // buttomMinus
            // 
            this.buttomMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttomMinus.FlatAppearance.BorderSize = 0;
            this.buttomMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttomMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttomMinus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttomMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.buttomMinus.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttomMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttomMinus.IconSize = 16;
            this.buttomMinus.Location = new System.Drawing.Point(500, 3);
            this.buttomMinus.Name = "buttomMinus";
            this.buttomMinus.Size = new System.Drawing.Size(16, 16);
            this.buttomMinus.TabIndex = 13;
            this.buttomMinus.UseVisualStyleBackColor = true;
            this.buttomMinus.Click += new System.EventHandler(this.buttomMinus_Click);
            // 
            // buttomClose
            // 
            this.buttomClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttomClose.FlatAppearance.BorderSize = 0;
            this.buttomClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttomClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttomClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttomClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.buttomClose.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttomClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttomClose.IconSize = 16;
            this.buttomClose.Location = new System.Drawing.Point(522, 3);
            this.buttomClose.Name = "buttomClose";
            this.buttomClose.Size = new System.Drawing.Size(16, 16);
            this.buttomClose.TabIndex = 12;
            this.buttomClose.UseVisualStyleBackColor = true;
            this.buttomClose.Click += new System.EventHandler(this.buttomClose_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(169)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(550, 600);
            this.Controls.Add(this.buttomClear);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkboxPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox checkboxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttomClear;
        private FontAwesome.Sharp.IconButton buttomMinus;
        private FontAwesome.Sharp.IconButton buttomClose;
    }
}

