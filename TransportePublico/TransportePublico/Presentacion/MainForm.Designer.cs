namespace TransportePublico.Presentacion
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
            this.txtPasajeros = new System.Windows.Forms.TextBox();
            this.dgvTransporte = new System.Windows.Forms.DataGridView();
            this.ColumnaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAvanzar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDetener = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblPasajeros = new System.Windows.Forms.Label();
            this.lblTaxi = new System.Windows.Forms.Label();
            this.lblBus = new System.Windows.Forms.Label();
            this.btnBus = new System.Windows.Forms.Button();
            this.btnTaxi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransporte)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPasajeros
            // 
            this.txtPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasajeros.Location = new System.Drawing.Point(155, 78);
            this.txtPasajeros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasajeros.Name = "txtPasajeros";
            this.txtPasajeros.Size = new System.Drawing.Size(175, 64);
            this.txtPasajeros.TabIndex = 2;
            // 
            // dgvTransporte
            // 
            this.dgvTransporte.AllowUserToAddRows = false;
            this.dgvTransporte.AllowUserToDeleteRows = false;
            this.dgvTransporte.AllowUserToResizeColumns = false;
            this.dgvTransporte.AllowUserToResizeRows = false;
            this.dgvTransporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaTipo,
            this.ColumnPasajero,
            this.ColAvanzar,
            this.ColDetener});
            this.dgvTransporte.Location = new System.Drawing.Point(509, 25);
            this.dgvTransporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTransporte.Name = "dgvTransporte";
            this.dgvTransporte.ReadOnly = true;
            this.dgvTransporte.RowHeadersWidth = 51;
            this.dgvTransporte.RowTemplate.Height = 24;
            this.dgvTransporte.Size = new System.Drawing.Size(515, 291);
            this.dgvTransporte.TabIndex = 3;
            this.dgvTransporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransporte_CellContentClick);
            // 
            // ColumnaTipo
            // 
            this.ColumnaTipo.HeaderText = "Transporte";
            this.ColumnaTipo.MinimumWidth = 6;
            this.ColumnaTipo.Name = "ColumnaTipo";
            this.ColumnaTipo.ReadOnly = true;
            this.ColumnaTipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnaTipo.Width = 125;
            // 
            // ColumnPasajero
            // 
            this.ColumnPasajero.HeaderText = "Cantidad de Pasajeros";
            this.ColumnPasajero.MinimumWidth = 6;
            this.ColumnPasajero.Name = "ColumnPasajero";
            this.ColumnPasajero.ReadOnly = true;
            this.ColumnPasajero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnPasajero.Width = 125;
            // 
            // ColAvanzar
            // 
            this.ColAvanzar.HeaderText = "Avanzar";
            this.ColAvanzar.MinimumWidth = 6;
            this.ColAvanzar.Name = "ColAvanzar";
            this.ColAvanzar.ReadOnly = true;
            this.ColAvanzar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColAvanzar.Text = "Accion";
            this.ColAvanzar.UseColumnTextForButtonValue = true;
            this.ColAvanzar.Width = 125;
            // 
            // ColDetener
            // 
            this.ColDetener.HeaderText = "Detener";
            this.ColDetener.MinimumWidth = 6;
            this.ColDetener.Name = "ColDetener";
            this.ColDetener.ReadOnly = true;
            this.ColDetener.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColDetener.Text = "Accion";
            this.ColDetener.UseColumnTextForButtonValue = true;
            this.ColDetener.Width = 125;
            // 
            // lblPasajeros
            // 
            this.lblPasajeros.AutoSize = true;
            this.lblPasajeros.Font = new System.Drawing.Font("Miriam CLM", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPasajeros.Location = new System.Drawing.Point(135, 49);
            this.lblPasajeros.Name = "lblPasajeros";
            this.lblPasajeros.Size = new System.Drawing.Size(209, 25);
            this.lblPasajeros.TabIndex = 4;
            this.lblPasajeros.Text = "Cantidad de pasajeros:";
            // 
            // lblTaxi
            // 
            this.lblTaxi.AutoSize = true;
            this.lblTaxi.Font = new System.Drawing.Font("Miriam CLM", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTaxi.Location = new System.Drawing.Point(40, 171);
            this.lblTaxi.Name = "lblTaxi";
            this.lblTaxi.Size = new System.Drawing.Size(124, 25);
            this.lblTaxi.TabIndex = 5;
            this.lblTaxi.Text = "Agregar Taxi";
            // 
            // lblBus
            // 
            this.lblBus.AutoSize = true;
            this.lblBus.Font = new System.Drawing.Font("Miriam CLM", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBus.Location = new System.Drawing.Point(312, 171);
            this.lblBus.Name = "lblBus";
            this.lblBus.Size = new System.Drawing.Size(120, 25);
            this.lblBus.TabIndex = 6;
            this.lblBus.Text = "Agregar Bus";
            // 
            // btnBus
            // 
            this.btnBus.BackgroundImage = global::TransportePublico.Properties.Resources.Bus_Icon;
            this.btnBus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBus.Location = new System.Drawing.Point(300, 197);
            this.btnBus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(139, 119);
            this.btnBus.TabIndex = 1;
            this.btnBus.UseVisualStyleBackColor = true;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click);
            // 
            // btnTaxi
            // 
            this.btnTaxi.BackgroundImage = global::TransportePublico.Properties.Resources.Taxi_Icon;
            this.btnTaxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTaxi.Location = new System.Drawing.Point(35, 199);
            this.btnTaxi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaxi.Name = "btnTaxi";
            this.btnTaxi.Size = new System.Drawing.Size(139, 117);
            this.btnTaxi.TabIndex = 0;
            this.btnTaxi.UseVisualStyleBackColor = true;
            this.btnTaxi.Click += new System.EventHandler(this.btnTaxi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1062, 353);
            this.Controls.Add(this.lblBus);
            this.Controls.Add(this.lblTaxi);
            this.Controls.Add(this.lblPasajeros);
            this.Controls.Add(this.dgvTransporte);
            this.Controls.Add(this.txtPasajeros);
            this.Controls.Add(this.btnBus);
            this.Controls.Add(this.btnTaxi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Sistema de Transporte Publico";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaxi;
        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.TextBox txtPasajeros;
        private System.Windows.Forms.DataGridView dgvTransporte;
        private System.Windows.Forms.Label lblPasajeros;
        private System.Windows.Forms.Label lblTaxi;
        private System.Windows.Forms.Label lblBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPasajero;
        private System.Windows.Forms.DataGridViewButtonColumn ColAvanzar;
        private System.Windows.Forms.DataGridViewButtonColumn ColDetener;
    }
}