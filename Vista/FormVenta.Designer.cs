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
            btnCerrar = new Button();
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
            gBoxFactura.Controls.Add(btnCerrar);
            gBoxFactura.Controls.Add(btnAbrir);
            gBoxFactura.Controls.Add(label3);
            gBoxFactura.Controls.Add(label1);
            gBoxFactura.Controls.Add(txtNumero);
            gBoxFactura.Location = new Point(28, 21);
            gBoxFactura.Name = "gBoxFactura";
            gBoxFactura.Size = new Size(229, 177);
            gBoxFactura.TabIndex = 0;
            gBoxFactura.TabStop = false;
            gBoxFactura.Text = "Datos factura:";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(113, 78);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(100, 23);
            cmbCliente.TabIndex = 10;
            // 
            // btnCerrar
            // 
            btnCerrar.Enabled = false;
            btnCerrar.Location = new Point(138, 134);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(13, 134);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 23);
            btnAbrir.TabIndex = 8;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 86);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 39);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Numero:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(113, 31);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
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
            gBoxDetalle.Location = new Point(28, 240);
            gBoxDetalle.Name = "gBoxDetalle";
            gBoxDetalle.Size = new Size(229, 162);
            gBoxDetalle.TabIndex = 1;
            gBoxDetalle.TabStop = false;
            gBoxDetalle.Text = "Detalle:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(113, 71);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 11;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(138, 122);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(13, 122);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 79);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 13;
            label5.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 50);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 11;
            label4.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(113, 42);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(100, 23);
            cmbProducto.TabIndex = 11;
            // 
            // dgvFacturas
            // 
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(314, 42);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.Size = new Size(451, 150);
            dgvFacturas.TabIndex = 2;
            dgvFacturas.CellClick += dgvFacturas_CellClick;
            // 
            // dgvDetallesFactura
            // 
            dgvDetallesFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesFactura.Location = new Point(314, 223);
            dgvDetallesFactura.Name = "dgvDetallesFactura";
            dgvDetallesFactura.Size = new Size(451, 150);
            dgvDetallesFactura.TabIndex = 3;
            // 
            // btnSalir
            // 
            btnSalir.Enabled = false;
            btnSalir.Location = new Point(690, 379);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 21);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 11;
            label2.Text = "Factura:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(314, 205);
            label7.Name = "label7";
            label7.Size = new Size(114, 15);
            label7.TabIndex = 15;
            label7.Text = "Detalle de la factura:";
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 425);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(dgvDetallesFactura);
            Controls.Add(dgvFacturas);
            Controls.Add(gBoxDetalle);
            Controls.Add(gBoxFactura);
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
        private Button btnCerrar;
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