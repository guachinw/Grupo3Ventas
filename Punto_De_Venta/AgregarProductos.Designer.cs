namespace Punto_De_Venta
{
    partial class AgregarProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Prod = new System.Windows.Forms.DataGridView();
            this.btn_BuscarProd = new System.Windows.Forms.Button();
            this.txt_Producto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Producto:";
            // 
            // dgv_Prod
            // 
            this.dgv_Prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Prod.Location = new System.Drawing.Point(83, 141);
            this.dgv_Prod.Name = "dgv_Prod";
            this.dgv_Prod.ReadOnly = true;
            this.dgv_Prod.Size = new System.Drawing.Size(357, 202);
            this.dgv_Prod.TabIndex = 6;
            this.dgv_Prod.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Prod_CellClick_1);
            // 
            // btn_BuscarProd
            // 
            this.btn_BuscarProd.Location = new System.Drawing.Point(365, 79);
            this.btn_BuscarProd.Name = "btn_BuscarProd";
            this.btn_BuscarProd.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarProd.TabIndex = 5;
            this.btn_BuscarProd.Text = "Buscar";
            this.btn_BuscarProd.UseVisualStyleBackColor = true;
            this.btn_BuscarProd.Click += new System.EventHandler(this.btn_BuscarProd_Click_1);
            // 
            // txt_Producto
            // 
            this.txt_Producto.Location = new System.Drawing.Point(83, 81);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.Size = new System.Drawing.Size(240, 20);
            this.txt_Producto.TabIndex = 4;
            // 
            // AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Prod);
            this.Controls.Add(this.btn_BuscarProd);
            this.Controls.Add(this.txt_Producto);
            this.Name = "AgregarProductos";
            this.Text = "AgregarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_Prod;
        private System.Windows.Forms.Button btn_BuscarProd;
        private System.Windows.Forms.TextBox txt_Producto;
    }
}