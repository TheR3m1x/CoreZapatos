namespace Presentacion.Forms
{
    partial class Productos
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
            this.groupArriba = new System.Windows.Forms.GroupBox();
            this.ButtonReload = new FontAwesome.Sharp.IconButton();
            this.buttonLimpiar = new FontAwesome.Sharp.IconButton();
            this.textID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.textProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupAbajo = new System.Windows.Forms.GroupBox();
            this.buttomDelete = new FontAwesome.Sharp.IconButton();
            this.buttomUpdate = new FontAwesome.Sharp.IconButton();
            this.buttomGuardar = new FontAwesome.Sharp.IconButton();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupAbajo.SuspendLayout();
            this.SuspendLayout();
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
            this.groupArriba.Controls.Add(this.numericCantidad);
            this.groupArriba.Controls.Add(this.textProveedor);
            this.groupArriba.Controls.Add(this.label3);
            this.groupArriba.Controls.Add(this.labelCantidad);
            this.groupArriba.Controls.Add(this.textPrecio);
            this.groupArriba.Controls.Add(this.labelPassword);
            this.groupArriba.Controls.Add(this.textDescripcion);
            this.groupArriba.Controls.Add(this.LabelDescripcion);
            this.groupArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupArriba.Location = new System.Drawing.Point(0, 0);
            this.groupArriba.Name = "groupArriba";
            this.groupArriba.Size = new System.Drawing.Size(793, 136);
            this.groupArriba.TabIndex = 5;
            this.groupArriba.TabStop = false;
            // 
            // ButtonReload
            // 
            this.ButtonReload.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            this.ButtonReload.IconColor = System.Drawing.Color.Black;
            this.ButtonReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonReload.IconSize = 32;
            this.ButtonReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonReload.Location = new System.Drawing.Point(6, 74);
            this.ButtonReload.Name = "ButtonReload";
            this.ButtonReload.Size = new System.Drawing.Size(99, 43);
            this.ButtonReload.TabIndex = 26;
            this.ButtonReload.Text = "Reload";
            this.ButtonReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonReload.UseVisualStyleBackColor = true;
            this.ButtonReload.Click += new System.EventHandler(this.ButtonReload_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.buttonLimpiar.IconColor = System.Drawing.Color.Black;
            this.buttonLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonLimpiar.IconSize = 32;
            this.buttonLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpiar.Location = new System.Drawing.Point(7, 26);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(99, 43);
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
            this.textID.Location = new System.Drawing.Point(153, 74);
            this.textID.Margin = new System.Windows.Forms.Padding(4);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(86, 25);
            this.textID.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(152, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "ID";
            // 
            // numericCantidad
            // 
            this.numericCantidad.BackColor = System.Drawing.SystemColors.Info;
            this.numericCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCantidad.Location = new System.Drawing.Point(546, 74);
            this.numericCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(80, 22);
            this.numericCantidad.TabIndex = 21;
            // 
            // textProveedor
            // 
            this.textProveedor.BackColor = System.Drawing.SystemColors.Info;
            this.textProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textProveedor.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProveedor.Location = new System.Drawing.Point(633, 74);
            this.textProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.textProveedor.Multiline = true;
            this.textProveedor.Name = "textProveedor";
            this.textProveedor.Size = new System.Drawing.Size(129, 25);
            this.textProveedor.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Proveedor";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.Location = new System.Drawing.Point(541, 56);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(82, 29);
            this.labelCantidad.TabIndex = 6;
            this.labelCantidad.Text = "Cantidad";
            // 
            // textPrecio
            // 
            this.textPrecio.BackColor = System.Drawing.SystemColors.Info;
            this.textPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrecio.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecio.Location = new System.Drawing.Point(395, 74);
            this.textPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.textPrecio.Multiline = true;
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(144, 25);
            this.textPrecio.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(394, 56);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(61, 29);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Precio";
            // 
            // textDescripcion
            // 
            this.textDescripcion.BackColor = System.Drawing.SystemColors.Info;
            this.textDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDescripcion.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescripcion.Location = new System.Drawing.Point(247, 74);
            this.textDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(143, 25);
            this.textDescripcion.TabIndex = 1;
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescripcion.Location = new System.Drawing.Point(246, 56);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(103, 29);
            this.LabelDescripcion.TabIndex = 0;
            this.LabelDescripcion.Text = "Descripcion";
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
            this.dataGrid.Size = new System.Drawing.Size(793, 475);
            this.dataGrid.TabIndex = 6;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
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
            this.groupAbajo.TabIndex = 7;
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
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(169)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(793, 611);
            this.Controls.Add(this.groupAbajo);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupArriba);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.groupArriba.ResumeLayout(false);
            this.groupArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupAbajo.ResumeLayout(false);
            this.groupAbajo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupArriba;
        private FontAwesome.Sharp.IconButton ButtonReload;
        private FontAwesome.Sharp.IconButton buttonLimpiar;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.TextBox textProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label LabelDescripcion;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupAbajo;
        private FontAwesome.Sharp.IconButton buttomDelete;
        private FontAwesome.Sharp.IconButton buttomUpdate;
        private FontAwesome.Sharp.IconButton buttomGuardar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label label6;
    }
}