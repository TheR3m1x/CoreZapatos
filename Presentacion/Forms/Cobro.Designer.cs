namespace Presentacion.Forms
{
    partial class Cobro
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
            this.textMontoPagado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.textMontoTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textProductoID = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonReload = new FontAwesome.Sharp.IconButton();
            this.buttonLimpiar = new FontAwesome.Sharp.IconButton();
            this.textIdCuentaPorCobrar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textIdCliente = new System.Windows.Forms.TextBox();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupAbajo.SuspendLayout();
            this.groupArriba.SuspendLayout();
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
            this.groupAbajo.TabIndex = 20;
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
            this.groupArriba.Controls.Add(this.textMontoPagado);
            this.groupArriba.Controls.Add(this.label9);
            this.groupArriba.Controls.Add(this.dateFechaEmision);
            this.groupArriba.Controls.Add(this.textMontoTotal);
            this.groupArriba.Controls.Add(this.label2);
            this.groupArriba.Controls.Add(this.textProductoID);
            this.groupArriba.Controls.Add(this.textDescripcion);
            this.groupArriba.Controls.Add(this.label1);
            this.groupArriba.Controls.Add(this.ButtonReload);
            this.groupArriba.Controls.Add(this.buttonLimpiar);
            this.groupArriba.Controls.Add(this.textIdCuentaPorCobrar);
            this.groupArriba.Controls.Add(this.label8);
            this.groupArriba.Controls.Add(this.label3);
            this.groupArriba.Controls.Add(this.textIdCliente);
            this.groupArriba.Controls.Add(this.LabelDescripcion);
            this.groupArriba.Controls.Add(this.labelPassword);
            this.groupArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupArriba.Location = new System.Drawing.Point(0, 0);
            this.groupArriba.Name = "groupArriba";
            this.groupArriba.Size = new System.Drawing.Size(793, 187);
            this.groupArriba.TabIndex = 19;
            this.groupArriba.TabStop = false;
            // 
            // textMontoPagado
            // 
            this.textMontoPagado.BackColor = System.Drawing.SystemColors.Info;
            this.textMontoPagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMontoPagado.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMontoPagado.Location = new System.Drawing.Point(591, 40);
            this.textMontoPagado.Margin = new System.Windows.Forms.Padding(4);
            this.textMontoPagado.Multiline = true;
            this.textMontoPagado.Name = "textMontoPagado";
            this.textMontoPagado.Size = new System.Drawing.Size(129, 25);
            this.textMontoPagado.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(587, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 29);
            this.label9.TabIndex = 35;
            this.label9.Text = "Monto Pagado";
            // 
            // dateFechaEmision
            // 
            this.dateFechaEmision.CalendarForeColor = System.Drawing.SystemColors.Info;
            this.dateFechaEmision.CalendarMonthBackground = System.Drawing.SystemColors.WindowText;
            this.dateFechaEmision.Location = new System.Drawing.Point(247, 148);
            this.dateFechaEmision.Name = "dateFechaEmision";
            this.dateFechaEmision.Size = new System.Drawing.Size(143, 20);
            this.dateFechaEmision.TabIndex = 34;
            // 
            // textMontoTotal
            // 
            this.textMontoTotal.BackColor = System.Drawing.SystemColors.Info;
            this.textMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMontoTotal.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMontoTotal.Location = new System.Drawing.Point(592, 88);
            this.textMontoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textMontoTotal.Multiline = true;
            this.textMontoTotal.Name = "textMontoTotal";
            this.textMontoTotal.Size = new System.Drawing.Size(129, 25);
            this.textMontoTotal.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Monto total";
            // 
            // textProductoID
            // 
            this.textProductoID.BackColor = System.Drawing.SystemColors.Info;
            this.textProductoID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textProductoID.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProductoID.Location = new System.Drawing.Point(432, 40);
            this.textProductoID.Margin = new System.Windows.Forms.Padding(4);
            this.textProductoID.Multiline = true;
            this.textProductoID.Name = "textProductoID";
            this.textProductoID.Size = new System.Drawing.Size(129, 25);
            this.textProductoID.TabIndex = 28;
            // 
            // textDescripcion
            // 
            this.textDescripcion.BackColor = System.Drawing.SystemColors.Info;
            this.textDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDescripcion.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescripcion.Location = new System.Drawing.Point(432, 88);
            this.textDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(129, 25);
            this.textDescripcion.TabIndex = 28;
            this.textDescripcion.TextChanged += new System.EventHandler(this.textDescripcion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID_Producto";
            // 
            // ButtonReload
            // 
            this.ButtonReload.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            this.ButtonReload.IconColor = System.Drawing.Color.Black;
            this.ButtonReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonReload.IconSize = 32;
            this.ButtonReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonReload.Location = new System.Drawing.Point(60, 102);
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
            this.buttonLimpiar.Location = new System.Drawing.Point(60, 40);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(99, 43);
            this.buttonLimpiar.TabIndex = 25;
            this.buttonLimpiar.Text = "Clear";
            this.buttonLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textIdCuentaPorCobrar
            // 
            this.textIdCuentaPorCobrar.BackColor = System.Drawing.SystemColors.Menu;
            this.textIdCuentaPorCobrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIdCuentaPorCobrar.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdCuentaPorCobrar.Location = new System.Drawing.Point(247, 40);
            this.textIdCuentaPorCobrar.Margin = new System.Windows.Forms.Padding(4);
            this.textIdCuentaPorCobrar.Multiline = true;
            this.textIdCuentaPorCobrar.Name = "textIdCuentaPorCobrar";
            this.textIdCuentaPorCobrar.ReadOnly = true;
            this.textIdCuentaPorCobrar.Size = new System.Drawing.Size(139, 25);
            this.textIdCuentaPorCobrar.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(243, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion";
            // 
            // textIdCliente
            // 
            this.textIdCliente.BackColor = System.Drawing.SystemColors.Info;
            this.textIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIdCliente.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdCliente.Location = new System.Drawing.Point(247, 96);
            this.textIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textIdCliente.Multiline = true;
            this.textIdCliente.Name = "textIdCliente";
            this.textIdCliente.Size = new System.Drawing.Size(143, 25);
            this.textIdCliente.TabIndex = 1;
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescripcion.Location = new System.Drawing.Point(246, 73);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(91, 29);
            this.LabelDescripcion.TabIndex = 0;
            this.LabelDescripcion.Text = "ID_Cliente";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(244, 125);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPassword.Size = new System.Drawing.Size(57, 29);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Fecha";
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 187);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.Size = new System.Drawing.Size(793, 326);
            this.dataGrid.TabIndex = 21;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // Cobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(169)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(793, 611);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupAbajo);
            this.Controls.Add(this.groupArriba);
            this.Name = "Cobro";
            this.Text = "Cobro";
            this.Load += new System.EventHandler(this.Cobro_Load);
            this.groupAbajo.ResumeLayout(false);
            this.groupAbajo.PerformLayout();
            this.groupArriba.ResumeLayout(false);
            this.groupArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAbajo;
        private FontAwesome.Sharp.IconButton buttomDelete;
        private FontAwesome.Sharp.IconButton buttomUpdate;
        private FontAwesome.Sharp.IconButton buttomGuardar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupArriba;
        private System.Windows.Forms.TextBox textMontoPagado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateFechaEmision;
        private System.Windows.Forms.TextBox textMontoTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textProductoID;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ButtonReload;
        private FontAwesome.Sharp.IconButton buttonLimpiar;
        private System.Windows.Forms.TextBox textIdCuentaPorCobrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIdCliente;
        private System.Windows.Forms.Label LabelDescripcion;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}