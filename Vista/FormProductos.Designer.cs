namespace Vista
{
    partial class FormProductos
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
            btnSalir = new Button();
            dgvProductos = new DataGridView();
            gBoxCliente = new GroupBox();
            cmbCategorias = new ComboBox();
            label11 = new Label();
            dateTime = new DateTimePicker();
            txtPais = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtStock = new TextBox();
            label8 = new Label();
            cmbTipo = new ComboBox();
            label7 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label4 = new Label();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtCodigo = new TextBox();
            dgvProductosImportados = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            gBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosImportados).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(573, 427);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(149, 23);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(288, 46);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(454, 157);
            dgvProductos.TabIndex = 13;
            // 
            // gBoxCliente
            // 
            gBoxCliente.Controls.Add(cmbCategorias);
            gBoxCliente.Controls.Add(label11);
            gBoxCliente.Controls.Add(dateTime);
            gBoxCliente.Controls.Add(txtPais);
            gBoxCliente.Controls.Add(label10);
            gBoxCliente.Controls.Add(label9);
            gBoxCliente.Controls.Add(txtStock);
            gBoxCliente.Controls.Add(label8);
            gBoxCliente.Controls.Add(cmbTipo);
            gBoxCliente.Controls.Add(label7);
            gBoxCliente.Controls.Add(btnEliminar);
            gBoxCliente.Controls.Add(btnModificar);
            gBoxCliente.Controls.Add(btnAgregar);
            gBoxCliente.Controls.Add(label4);
            gBoxCliente.Controls.Add(txtPrecio);
            gBoxCliente.Controls.Add(label3);
            gBoxCliente.Controls.Add(txtDescripcion);
            gBoxCliente.Controls.Add(label2);
            gBoxCliente.Controls.Add(txtNombre);
            gBoxCliente.Controls.Add(label1);
            gBoxCliente.Controls.Add(txtCodigo);
            gBoxCliente.Location = new Point(19, 24);
            gBoxCliente.Name = "gBoxCliente";
            gBoxCliente.Size = new Size(243, 478);
            gBoxCliente.TabIndex = 12;
            gBoxCliente.TabStop = false;
            gBoxCliente.Text = "Datos:";
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(96, 325);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(132, 23);
            cmbCategorias.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 328);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 19;
            label11.Text = "Categoria:";
            // 
            // dateTime
            // 
            dateTime.Location = new Point(128, 279);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(103, 23);
            dateTime.TabIndex = 18;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(128, 237);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(100, 23);
            txtPais.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 285);
            label10.Name = "label10";
            label10.Size = new Size(109, 15);
            label10.TabIndex = 16;
            label10.Text = "Fecha Importacion:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 245);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 15;
            label9.Text = "Pais Importacion:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(128, 199);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 207);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 13;
            label8.Text = "Stock:";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Nacional", "Importado" });
            cmbTipo.Location = new Point(96, 31);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(132, 23);
            cmbTipo.TabIndex = 12;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 39);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 11;
            label7.Text = "Tipo:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(46, 442);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(46, 416);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(149, 23);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(46, 387);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 173);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(128, 170);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 144);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(128, 136);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 115);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 78);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(128, 70);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // dgvProductosImportados
            // 
            dgvProductosImportados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosImportados.Location = new Point(288, 249);
            dgvProductosImportados.Name = "dgvProductosImportados";
            dgvProductosImportados.Size = new Size(454, 150);
            dgvProductosImportados.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(288, 28);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 16;
            label5.Text = "Productos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(288, 231);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 17;
            label6.Text = "Productos importados";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 511);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dgvProductosImportados);
            Controls.Add(btnSalir);
            Controls.Add(dgvProductos);
            Controls.Add(gBoxCliente);
            Name = "FormProductos";
            Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            gBoxCliente.ResumeLayout(false);
            gBoxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosImportados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Button btnSalir;
        protected DataGridView dgvProductos;
        protected GroupBox gBoxCliente;
        private ComboBox cmbTipo;
        private Label label7;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label4;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtCodigo;
        private DataGridView dgvProductosImportados;
        private Label label5;
        private Label label6;
        private Label label10;
        private Label label9;
        private TextBox txtStock;
        private Label label8;
        private TextBox txtPais;
        private DateTimePicker dateTime;
        private ComboBox cmbCategorias;
        private Label label11;
    }
}