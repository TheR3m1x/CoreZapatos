namespace Presentacion.Forms
{
    partial class Usuarios
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
            this.groupAbajo = new System.Windows.Forms.GroupBox();
            this.buttomDelete = new FontAwesome.Sharp.IconButton();
            this.buttomUpdate = new FontAwesome.Sharp.IconButton();
            this.buttomGuardar = new FontAwesome.Sharp.IconButton();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupArriba = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new FontAwesome.Sharp.IconButton();
            this.textID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericRol = new System.Windows.Forms.NumericUpDown();
            this.textGenero = new System.Windows.Forms.TextBox();
            this.textCedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textConfirmarPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.ButtonReload = new FontAwesome.Sharp.IconButton();
            this.groupAbajo.SuspendLayout();
            this.groupArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupAbajo
            // 
            this.groupAbajo.AutoSize = true;
            this.groupAbajo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupAbajo.Controls.Add(this.buttomDelete);
            this.groupAbajo.Controls.Add(this.buttomUpdate);
            this.groupAbajo.Controls.Add(this.buttomGuardar);
            this.groupAbajo.Controls.Add(this.textBuscar);
            this.groupAbajo.Controls.Add(this.label6);
            this.groupAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupAbajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupAbajo.Location = new System.Drawing.Point(0, 513);
            this.groupAbajo.Name = "groupAbajo";
            this.groupAbajo.Size = new System.Drawing.Size(793, 98);
            this.groupAbajo.TabIndex = 2;
            this.groupAbajo.TabStop = false;
            // 
            // buttomDelete
            // 
            this.buttomDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.buttomDelete.IconColor = System.Drawing.Color.Black;
            this.buttomDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttomDelete.IconSize = 32;
            this.buttomDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttomDelete.Location = new System.Drawing.Point(669, 36);
            this.buttomDelete.Name = "buttomDelete";
            this.buttomDelete.Size = new System.Drawing.Size(118, 43);
            this.buttomDelete.TabIndex = 23;
            this.buttomDelete.Text = "Delete";
            this.buttomDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttomDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttomDelete.UseVisualStyleBackColor = true;
            this.buttomDelete.Click += new System.EventHandler(this.buttomDelete_Click);
            // 
            // buttomUpdate
            // 
            this.buttomUpdate.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.buttomUpdate.IconColor = System.Drawing.Color.Black;
            this.buttomUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttomUpdate.IconSize = 32;
            this.buttomUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttomUpdate.Location = new System.Drawing.Point(545, 35);
            this.buttomUpdate.Name = "buttomUpdate";
            this.buttomUpdate.Size = new System.Drawing.Size(118, 43);
            this.buttomUpdate.TabIndex = 22;
            this.buttomUpdate.Text = "Update";
            this.buttomUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttomUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttomUpdate.UseVisualStyleBackColor = true;
            this.buttomUpdate.Click += new System.EventHandler(this.buttomUpdate_Click);
            // 
            // buttomGuardar
            // 
            this.buttomGuardar.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.buttomGuardar.IconColor = System.Drawing.Color.Black;
            this.buttomGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttomGuardar.IconSize = 32;
            this.buttomGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttomGuardar.Location = new System.Drawing.Point(421, 35);
            this.buttomGuardar.Name = "buttomGuardar";
            this.buttomGuardar.Size = new System.Drawing.Size(118, 43);
            this.buttomGuardar.TabIndex = 21;
            this.buttomGuardar.Text = "Guardar";
            this.buttomGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttomGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttomGuardar.UseVisualStyleBackColor = true;
            this.buttomGuardar.Click += new System.EventHandler(this.buttomGuardar_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.BackColor = System.Drawing.SystemColors.Info;
            this.textBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBuscar.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(7, 48);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textBuscar.Multiline = true;
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(383, 25);
            this.textBuscar.TabIndex = 20;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Buscar";
            // 
            // groupArriba
            // 
            this.groupArriba.AutoSize = true;
            this.groupArriba.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupArriba.Controls.Add(this.ButtonReload);
            this.groupArriba.Controls.Add(this.buttonLimpiar);
            this.groupArriba.Controls.Add(this.textID);
            this.groupArriba.Controls.Add(this.label8);
            this.groupArriba.Controls.Add(this.numericRol);
            this.groupArriba.Controls.Add(this.textGenero);
            this.groupArriba.Controls.Add(this.textCedula);
            this.groupArriba.Controls.Add(this.label5);
            this.groupArriba.Controls.Add(this.label1);
            this.groupArriba.Controls.Add(this.textEmail);
            this.groupArriba.Controls.Add(this.labelEmail);
            this.groupArriba.Controls.Add(this.textApellido);
            this.groupArriba.Controls.Add(this.label4);
            this.groupArriba.Controls.Add(this.textNombre);
            this.groupArriba.Controls.Add(this.label3);
            this.groupArriba.Controls.Add(this.label2);
            this.groupArriba.Controls.Add(this.textConfirmarPassword);
            this.groupArriba.Controls.Add(this.labelConfirmPassword);
            this.groupArriba.Controls.Add(this.textPassword);
            this.groupArriba.Controls.Add(this.labelPassword);
            this.groupArriba.Controls.Add(this.textUsername);
            this.groupArriba.Controls.Add(this.LabelUsername);
            this.groupArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupArriba.Location = new System.Drawing.Point(0, 0);
            this.groupArriba.Name = "groupArriba";
            this.groupArriba.Size = new System.Drawing.Size(793, 136);
            this.groupArriba.TabIndex = 3;
            this.groupArriba.TabStop = false;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.buttonLimpiar.IconColor = System.Drawing.Color.Black;
            this.buttonLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonLimpiar.IconSize = 32;
            this.buttonLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpiar.Location = new System.Drawing.Point(12, 74);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(89, 43);
            this.buttonLimpiar.TabIndex = 25;
            this.buttonLimpiar.Text = "Clear";
            this.buttonLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textID
            // 
            this.textID.BackColor = System.Drawing.SystemColors.Menu;
            this.textID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textID.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(12, 35);
            this.textID.Margin = new System.Windows.Forms.Padding(4);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(89, 25);
            this.textID.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "ID";
            // 
            // numericRol
            // 
            this.numericRol.BackColor = System.Drawing.SystemColors.Info;
            this.numericRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericRol.Location = new System.Drawing.Point(404, 38);
            this.numericRol.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericRol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRol.Name = "numericRol";
            this.numericRol.Size = new System.Drawing.Size(50, 22);
            this.numericRol.TabIndex = 21;
            this.numericRol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textGenero
            // 
            this.textGenero.BackColor = System.Drawing.SystemColors.Info;
            this.textGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textGenero.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGenero.Location = new System.Drawing.Point(378, 85);
            this.textGenero.Margin = new System.Windows.Forms.Padding(4);
            this.textGenero.MaxLength = 1;
            this.textGenero.Multiline = true;
            this.textGenero.Name = "textGenero";
            this.textGenero.Size = new System.Drawing.Size(118, 25);
            this.textGenero.TabIndex = 20;
            // 
            // textCedula
            // 
            this.textCedula.BackColor = System.Drawing.SystemColors.Info;
            this.textCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCedula.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCedula.Location = new System.Drawing.Point(645, 85);
            this.textCedula.Margin = new System.Windows.Forms.Padding(4);
            this.textCedula.MaxLength = 11;
            this.textCedula.Multiline = true;
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(116, 25);
            this.textCedula.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(640, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cedula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Genero";
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.SystemColors.Info;
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(645, 38);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(116, 25);
            this.textEmail.TabIndex = 13;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(640, 20);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 29);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email";
            // 
            // textApellido
            // 
            this.textApellido.BackColor = System.Drawing.SystemColors.Info;
            this.textApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textApellido.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(504, 85);
            this.textApellido.Margin = new System.Windows.Forms.Padding(4);
            this.textApellido.Multiline = true;
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(129, 25);
            this.textApellido.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido";
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.SystemColors.Info;
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNombre.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(504, 38);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textNombre.Multiline = true;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(129, 25);
            this.textNombre.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rol";
            // 
            // textConfirmarPassword
            // 
            this.textConfirmarPassword.BackColor = System.Drawing.SystemColors.Info;
            this.textConfirmarPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textConfirmarPassword.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmarPassword.Location = new System.Drawing.Point(216, 85);
            this.textConfirmarPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textConfirmarPassword.Multiline = true;
            this.textConfirmarPassword.Name = "textConfirmarPassword";
            this.textConfirmarPassword.Size = new System.Drawing.Size(144, 25);
            this.textConfirmarPassword.TabIndex = 5;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(211, 66);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(151, 29);
            this.labelConfirmPassword.TabIndex = 4;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.SystemColors.Info;
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPassword.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(216, 35);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(144, 25);
            this.textPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(215, 17);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(85, 29);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // textUsername
            // 
            this.textUsername.BackColor = System.Drawing.SystemColors.Info;
            this.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUsername.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(109, 35);
            this.textUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textUsername.Multiline = true;
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(86, 25);
            this.textUsername.TabIndex = 1;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(108, 17);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(90, 29);
            this.LabelUsername.TabIndex = 0;
            this.LabelUsername.Text = "Username";
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 136);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(793, 377);
            this.dataGrid.TabIndex = 4;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // ButtonReload
            // 
            this.ButtonReload.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            this.ButtonReload.IconColor = System.Drawing.Color.Black;
            this.ButtonReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonReload.IconSize = 32;
            this.ButtonReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonReload.Location = new System.Drawing.Point(106, 74);
            this.ButtonReload.Name = "ButtonReload";
            this.ButtonReload.Size = new System.Drawing.Size(89, 43);
            this.ButtonReload.TabIndex = 26;
            this.ButtonReload.Text = "Reload";
            this.ButtonReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonReload.UseVisualStyleBackColor = true;
            this.ButtonReload.Click += new System.EventHandler(this.ButtonReload_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(169)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(793, 611);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupArriba);
            this.Controls.Add(this.groupAbajo);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.groupAbajo.ResumeLayout(false);
            this.groupAbajo.PerformLayout();
            this.groupArriba.ResumeLayout(false);
            this.groupArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAbajo;
        private System.Windows.Forms.GroupBox groupArriba;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaUltimaAccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textConfirmarPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox textCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton buttomDelete;
        private FontAwesome.Sharp.IconButton buttomUpdate;
        private FontAwesome.Sharp.IconButton buttomGuardar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textGenero;
        private System.Windows.Forms.NumericUpDown numericRol;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton buttonLimpiar;
        private FontAwesome.Sharp.IconButton ButtonReload;
    }
}