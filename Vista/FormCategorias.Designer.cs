namespace Vista
{
    partial class FormCategorias
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
            dgvDatos = new DataGridView();
            gBoxCliente = new GroupBox();
            checkedProductos = new CheckedListBox();
            label4 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtCodigo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            gBoxCliente.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(585, 257);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(149, 23);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(280, 30);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(454, 218);
            dgvDatos.TabIndex = 13;
            dgvDatos.CellClick += dgvDatos_CellClick;
            // 
            // gBoxCliente
            // 
            gBoxCliente.Controls.Add(checkedProductos);
            gBoxCliente.Controls.Add(label4);
            gBoxCliente.Controls.Add(btnEliminar);
            gBoxCliente.Controls.Add(btnModificar);
            gBoxCliente.Controls.Add(btnAgregar);
            gBoxCliente.Controls.Add(label3);
            gBoxCliente.Controls.Add(txtDescripcion);
            gBoxCliente.Controls.Add(label2);
            gBoxCliente.Controls.Add(txtNombre);
            gBoxCliente.Controls.Add(label1);
            gBoxCliente.Controls.Add(txtCodigo);
            gBoxCliente.Location = new Point(31, 30);
            gBoxCliente.Name = "gBoxCliente";
            gBoxCliente.Size = new Size(217, 383);
            gBoxCliente.TabIndex = 12;
            gBoxCliente.TabStop = false;
            gBoxCliente.Text = "Datos:";
            // 
            // checkedProductos
            // 
            checkedProductos.FormattingEnabled = true;
            checkedProductos.Location = new Point(17, 156);
            checkedProductos.Name = "checkedProductos";
            checkedProductos.Size = new Size(181, 112);
            checkedProductos.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 135);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 11;
            label4.Text = "Productos:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(37, 343);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(37, 317);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(149, 23);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(37, 288);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 100);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(98, 92);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 71);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(98, 34);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // FormCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 424);
            Controls.Add(btnSalir);
            Controls.Add(dgvDatos);
            Controls.Add(gBoxCliente);
            Name = "FormCategorias";
            Text = "FormCategorias";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            gBoxCliente.ResumeLayout(false);
            gBoxCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected Button btnSalir;
        protected DataGridView dgvDatos;
        protected GroupBox gBoxCliente;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label4;
        private TextBox txtContacto;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtCodigo;
        private CheckedListBox checkedProductos;
    }
}