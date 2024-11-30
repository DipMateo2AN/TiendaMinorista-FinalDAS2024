namespace Vista
{
    partial class FormVenta
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
            gBoxFactura = new GroupBox();
            cmbCliente = new ComboBox();
            btnAbrir = new Button();
            label3 = new Label();
            label1 = new Label();
            txtNumero = new TextBox();
            gBoxDetalle = new GroupBox();
            txtCantidad = new TextBox();
            btnEliminar = new Button();
            btnAgregar = new Button();
            label5 = new Label();
            label4 = new Label();
            cmbProducto = new ComboBox();
            dgvFacturas = new DataGridView();
            dgvDetallesFactura = new DataGridView();
            btnSalir = new Button();
            label2 = new Label();
            label7 = new Label();
            gBoxFactura.SuspendLayout();
            gBoxDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesFactura).BeginInit();
            SuspendLayout();
            // 
            // gBoxFactura
            // 
            gBoxFactura.Controls.Add(cmbCliente);
            gBoxFactura.Controls.Add(btnAbrir);
            gBoxFactura.Controls.Add(label3);
            gBoxFactura.Controls.Add(label1);
            gBoxFactura.Controls.Add(txtNumero);
            gBoxFactura.Location = new Point(32, 28);
            gBoxFactura.Margin = new Padding(3, 4, 3, 4);
            gBoxFactura.Name = "gBoxFactura";
            gBoxFactura.Padding = new Padding(3, 4, 3, 4);
            gBoxFactura.Size = new Size(262, 236);
            gBoxFactura.TabIndex = 0;
            gBoxFactura.TabStop = false;
            gBoxFactura.Text = "Datos factura:";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(129, 104);
            cmbCliente.Margin = new Padding(3, 4, 3, 4);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(114, 28);
            cmbCliente.TabIndex = 10;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(65, 179);
            btnAbrir.Margin = new Padding(3, 4, 3, 4);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(131, 31);
            btnAbrir.TabIndex = 8;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 115);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 6;
            label3.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 52);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 4;
            label1.Text = "Numero:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(129, 41);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(114, 27);
            txtNumero.TabIndex = 3;
            // 
            // gBoxDetalle
            // 
            gBoxDetalle.Controls.Add(txtCantidad);
            gBoxDetalle.Controls.Add(btnEliminar);
            gBoxDetalle.Controls.Add(btnAgregar);
            gBoxDetalle.Controls.Add(label5);
            gBoxDetalle.Controls.Add(label4);
            gBoxDetalle.Controls.Add(cmbProducto);
            gBoxDetalle.Enabled = false;
            gBoxDetalle.Location = new Point(32, 320);
            gBoxDetalle.Margin = new Padding(3, 4, 3, 4);
            gBoxDetalle.Name = "gBoxDetalle";
            gBoxDetalle.Padding = new Padding(3, 4, 3, 4);
            gBoxDetalle.Size = new Size(262, 216);
            gBoxDetalle.TabIndex = 1;
            gBoxDetalle.TabStop = false;
            gBoxDetalle.Text = "Detalle:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(129, 95);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(114, 27);
            txtCantidad.TabIndex = 11;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(158, 163);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(15, 163);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 105);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 13;
            label5.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 67);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 11;
            label4.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(129, 56);
            cmbProducto.Margin = new Padding(3, 4, 3, 4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(114, 28);
            cmbProducto.TabIndex = 11;
            // 
            // dgvFacturas
            // 
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(359, 56);
            dgvFacturas.Margin = new Padding(3, 4, 3, 4);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.Size = new Size(515, 200);
            dgvFacturas.TabIndex = 2;
            dgvFacturas.CellClick += dgvFacturas_CellClick;
            dgvFacturas.SelectionChanged += dgvFacturas_SelectionChanged;
            // 
            // dgvDetallesFactura
            // 
            dgvDetallesFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesFactura.Location = new Point(359, 297);
            dgvDetallesFactura.Margin = new Padding(3, 4, 3, 4);
            dgvDetallesFactura.Name = "dgvDetallesFactura";
            dgvDetallesFactura.RowHeadersWidth = 51;
            dgvDetallesFactura.Size = new Size(515, 200);
            dgvDetallesFactura.TabIndex = 3;
            dgvDetallesFactura.CellClick += dgvDetallesFactura_CellClick;
            // 
            // btnSalir
            // 
            btnSalir.Enabled = false;
            btnSalir.Location = new Point(789, 505);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 31);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 28);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 11;
            label2.Text = "Factura:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(359, 273);
            label7.Name = "label7";
            label7.Size = new Size(147, 20);
            label7.TabIndex = 15;
            label7.Text = "Detalle de la factura:";
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 567);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(dgvDetallesFactura);
            Controls.Add(dgvFacturas);
            Controls.Add(gBoxDetalle);
            Controls.Add(gBoxFactura);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVenta";
            Text = "FormVenta";
            gBoxFactura.ResumeLayout(false);
            gBoxFactura.PerformLayout();
            gBoxDetalle.ResumeLayout(false);
            gBoxDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gBoxFactura;
        private GroupBox gBoxDetalle;
        private Button btnAbrir;
        private Label label3;
        private Label label1;
        private TextBox txtNumero;
        private ComboBox cmbCliente;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox cmbProducto;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnAgregar;
        private Button btnEliminar;
        private DataGridView dgvFacturas;
        private DataGridView dgvDetallesFactura;
        private Button btnSalir;
        private TextBox txtCantidad;
        private Label label2;
        private Label label7;
    }
}