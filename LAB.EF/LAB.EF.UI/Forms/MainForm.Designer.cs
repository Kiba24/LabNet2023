namespace LAB.EF.UI
{
    partial class MainForm
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Ape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToResizeColumns = false;
            this.dgvEmpleados.AllowUserToResizeRows = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_Ape,
            this.Col_Nombre,
            this.Col_Titulo,
            this.Col_Pais});
            this.dgvEmpleados.Location = new System.Drawing.Point(617, 103);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 30;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(433, 297);
            this.dgvEmpleados.TabIndex = 1;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Col_Comp,
            this.Col_CNombre,
            this.Col_Ciudad});
            this.dgvClientes.Location = new System.Drawing.Point(27, 103);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 30;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(433, 297);
            this.dgvClientes.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Col_Comp
            // 
            this.Col_Comp.HeaderText = "Compania";
            this.Col_Comp.MinimumWidth = 6;
            this.Col_Comp.Name = "Col_Comp";
            this.Col_Comp.ReadOnly = true;
            // 
            // Col_CNombre
            // 
            this.Col_CNombre.HeaderText = "Nombre";
            this.Col_CNombre.MinimumWidth = 6;
            this.Col_CNombre.Name = "Col_CNombre";
            this.Col_CNombre.ReadOnly = true;
            // 
            // Col_Ciudad
            // 
            this.Col_Ciudad.HeaderText = "Ciudad";
            this.Col_Ciudad.MinimumWidth = 6;
            this.Col_Ciudad.Name = "Col_Ciudad";
            this.Col_Ciudad.ReadOnly = true;
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Font = new System.Drawing.Font("Microsoft PhagsPa", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliers.Location = new System.Drawing.Point(705, 27);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(259, 54);
            this.lblSuppliers.TabIndex = 3;
            this.lblSuppliers.Text = "Proovedores";
            this.lblSuppliers.Click += new System.EventHandler(this.lblEmpleados_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft PhagsPa", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(148, 27);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(169, 54);
            this.lblClientes.TabIndex = 4;
            this.lblClientes.Text = "Clientes";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::LAB.EF.UI.Properties.Resources.del;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(149, 406);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(55, 47);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::LAB.EF.UI.Properties.Resources.upd;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(88, 406);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(55, 47);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::LAB.EF.UI.Properties.Resources.Check;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(27, 406);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(55, 47);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Col_Id
            // 
            this.Col_Id.HeaderText = "Id";
            this.Col_Id.MinimumWidth = 6;
            this.Col_Id.Name = "Col_Id";
            this.Col_Id.ReadOnly = true;
            // 
            // Col_Ape
            // 
            this.Col_Ape.HeaderText = "Nombre";
            this.Col_Ape.MinimumWidth = 6;
            this.Col_Ape.Name = "Col_Ape";
            this.Col_Ape.ReadOnly = true;
            // 
            // Col_Nombre
            // 
            this.Col_Nombre.HeaderText = "Compania";
            this.Col_Nombre.MinimumWidth = 6;
            this.Col_Nombre.Name = "Col_Nombre";
            this.Col_Nombre.ReadOnly = true;
            // 
            // Col_Titulo
            // 
            this.Col_Titulo.HeaderText = "Titulo";
            this.Col_Titulo.MinimumWidth = 6;
            this.Col_Titulo.Name = "Col_Titulo";
            this.Col_Titulo.ReadOnly = true;
            // 
            // Col_Pais
            // 
            this.Col_Pais.HeaderText = "Ciudad";
            this.Col_Pais.MinimumWidth = 6;
            this.Col_Pais.Name = "Col_Pais";
            this.Col_Pais.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1088, 496);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblSuppliers);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "MainForm";
            this.Text = "Northwind ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Ciudad;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Ape;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Pais;
    }
}

