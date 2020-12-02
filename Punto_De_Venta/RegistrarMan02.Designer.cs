namespace Punto_De_Venta
{
    partial class RegistrarMan02
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboClase = new System.Windows.Forms.ComboBox();
            this.cboDetalle = new System.Windows.Forms.ComboBox();
            this.tnStock = new System.Windows.Forms.NumericUpDown();
            this.tnPrecio = new System.Windows.Forms.NumericUpDown();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tnStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tnPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(18, 286);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(129, 286);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 30;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Clase";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Detalles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Codigo";
            // 
            // cboClase
            // 
            this.cboClase.FormattingEnabled = true;
            this.cboClase.Location = new System.Drawing.Point(83, 201);
            this.cboClase.Name = "cboClase";
            this.cboClase.Size = new System.Drawing.Size(121, 21);
            this.cboClase.TabIndex = 22;
            // 
            // cboDetalle
            // 
            this.cboDetalle.FormattingEnabled = true;
            this.cboDetalle.Location = new System.Drawing.Point(82, 245);
            this.cboDetalle.Name = "cboDetalle";
            this.cboDetalle.Size = new System.Drawing.Size(121, 21);
            this.cboDetalle.TabIndex = 21;
            // 
            // tnStock
            // 
            this.tnStock.Location = new System.Drawing.Point(83, 129);
            this.tnStock.Name = "tnStock";
            this.tnStock.Size = new System.Drawing.Size(120, 20);
            this.tnStock.TabIndex = 20;
            // 
            // tnPrecio
            // 
            this.tnPrecio.DecimalPlaces = 2;
            this.tnPrecio.Location = new System.Drawing.Point(83, 94);
            this.tnPrecio.Name = "tnPrecio";
            this.tnPrecio.Size = new System.Drawing.Size(120, 20);
            this.tnPrecio.TabIndex = 19;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(83, 55);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(100, 20);
            this.txNombre.TabIndex = 18;
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(83, 16);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(100, 20);
            this.txCodigo.TabIndex = 17;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(83, 163);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 16;
            // 
            // RegistrarMan02
            // 
            this.AcceptButton = this.btnInsertar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(215, 328);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClase);
            this.Controls.Add(this.cboDetalle);
            this.Controls.Add(this.tnStock);
            this.Controls.Add(this.tnPrecio);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.cboCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RegistrarMan02";
            this.Text = "Ingresar Producto";
            this.Load += new System.EventHandler(this.RegistrarMan02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tnStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tnPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClase;
        private System.Windows.Forms.ComboBox cboDetalle;
        private System.Windows.Forms.NumericUpDown tnStock;
        private System.Windows.Forms.NumericUpDown tnPrecio;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.ComboBox cboCategoria;
    }
}