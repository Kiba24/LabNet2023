namespace ManejoExepciones.Presentacion
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
            this.Separator1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtDivZero = new System.Windows.Forms.TextBox();
            this.btnDividirZero = new System.Windows.Forms.Button();
            this.lblDivisionZero = new System.Windows.Forms.Label();
            this.lblIngreso1 = new System.Windows.Forms.Label();
            this.btnDividir = new System.Windows.Forms.Button();
            this.lblDivision = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.btnCustomExepcion = new System.Windows.Forms.Button();
            this.btnExepcion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExepcion = new System.Windows.Forms.Label();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Separator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Separator1
            // 
            this.Separator1.BackgroundImage = global::ManejoExepciones.Properties.Resources.Vertical_Line_PNG_Images;
            this.Separator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Separator1.Location = new System.Drawing.Point(212, -15);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(32, 554);
            this.Separator1.TabIndex = 0;
            this.Separator1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ManejoExepciones.Properties.Resources.Vertical_Line_PNG_Images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(496, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 554);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ManejoExepciones.Properties.Resources.Vertical_Line_PNG_Images;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(794, -15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 554);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // txtDivZero
            // 
            this.txtDivZero.BackColor = System.Drawing.SystemColors.Window;
            this.txtDivZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivZero.Location = new System.Drawing.Point(58, 146);
            this.txtDivZero.Name = "txtDivZero";
            this.txtDivZero.Size = new System.Drawing.Size(100, 70);
            this.txtDivZero.TabIndex = 3;
            // 
            // btnDividirZero
            // 
            this.btnDividirZero.Location = new System.Drawing.Point(58, 304);
            this.btnDividirZero.Name = "btnDividirZero";
            this.btnDividirZero.Size = new System.Drawing.Size(100, 37);
            this.btnDividirZero.TabIndex = 4;
            this.btnDividirZero.Text = "ACCION";
            this.btnDividirZero.UseVisualStyleBackColor = true;
            this.btnDividirZero.Click += new System.EventHandler(this.btnDividirZero_Click);
            // 
            // lblDivisionZero
            // 
            this.lblDivisionZero.AutoSize = true;
            this.lblDivisionZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisionZero.Location = new System.Drawing.Point(30, 19);
            this.lblDivisionZero.Name = "lblDivisionZero";
            this.lblDivisionZero.Size = new System.Drawing.Size(156, 25);
            this.lblDivisionZero.TabIndex = 5;
            this.lblDivisionZero.Text = "Division por cero";
            // 
            // lblIngreso1
            // 
            this.lblIngreso1.AutoSize = true;
            this.lblIngreso1.Location = new System.Drawing.Point(46, 118);
            this.lblIngreso1.Name = "lblIngreso1";
            this.lblIngreso1.Size = new System.Drawing.Size(121, 16);
            this.lblIngreso1.TabIndex = 6;
            this.lblIngreso1.Text = "Ingresar un numero";
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(322, 304);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(100, 37);
            this.btnDividir.TabIndex = 7;
            this.btnDividir.Text = "ACCION";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivision.Location = new System.Drawing.Point(327, 19);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(80, 25);
            this.lblDivision.TabIndex = 8;
            this.lblDivision.Text = "Division";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingresar dos numeros";
            // 
            // txtDivisor
            // 
            this.txtDivisor.BackColor = System.Drawing.SystemColors.Window;
            this.txtDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisor.Location = new System.Drawing.Point(322, 194);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 70);
            this.txtDivisor.TabIndex = 9;
            // 
            // btnCustomExepcion
            // 
            this.btnCustomExepcion.Location = new System.Drawing.Point(910, 155);
            this.btnCustomExepcion.Name = "btnCustomExepcion";
            this.btnCustomExepcion.Size = new System.Drawing.Size(100, 77);
            this.btnCustomExepcion.TabIndex = 11;
            this.btnCustomExepcion.Text = "ACCION";
            this.btnCustomExepcion.UseVisualStyleBackColor = true;
            this.btnCustomExepcion.Click += new System.EventHandler(this.btnCustomExepcion_Click);
            // 
            // btnExepcion
            // 
            this.btnExepcion.Location = new System.Drawing.Point(610, 155);
            this.btnExepcion.Name = "btnExepcion";
            this.btnExepcion.Size = new System.Drawing.Size(100, 77);
            this.btnExepcion.TabIndex = 12;
            this.btnExepcion.Text = "ACCION";
            this.btnExepcion.UseVisualStyleBackColor = true;
            this.btnExepcion.Click += new System.EventHandler(this.btnExepcion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(853, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Exepcion Personalizada";
            // 
            // lblExepcion
            // 
            this.lblExepcion.AutoSize = true;
            this.lblExepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExepcion.Location = new System.Drawing.Point(561, 48);
            this.lblExepcion.Name = "lblExepcion";
            this.lblExepcion.Size = new System.Drawing.Size(200, 25);
            this.lblExepcion.TabIndex = 14;
            this.lblExepcion.Text = "Exepcion del Sistema";
            // 
            // txtDividendo
            // 
            this.txtDividendo.BackColor = System.Drawing.SystemColors.Window;
            this.txtDividendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDividendo.Location = new System.Drawing.Point(322, 118);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 70);
            this.txtDividendo.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 374);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.lblExepcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExepcion);
            this.Controls.Add(this.btnCustomExepcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.lblIngreso1);
            this.Controls.Add(this.lblDivisionZero);
            this.Controls.Add(this.btnDividirZero);
            this.Controls.Add(this.txtDivZero);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Separator1);
            this.Name = "MainForm";
            this.Text = "Prueba de exepciones";
            ((System.ComponentModel.ISupportInitialize)(this.Separator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Separator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtDivZero;
        private System.Windows.Forms.Button btnDividirZero;
        private System.Windows.Forms.Label lblDivisionZero;
        private System.Windows.Forms.Label lblIngreso1;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Button btnCustomExepcion;
        private System.Windows.Forms.Button btnExepcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExepcion;
        private System.Windows.Forms.TextBox txtDividendo;
    }
}