namespace Punto_De_Venta
{
    partial class Form_Clientes
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Direccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Numero = new System.Windows.Forms.TextBox();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.tb_Telefono = new System.Windows.Forms.TextBox();
            this.cob_ROD = new System.Windows.Forms.ComboBox();
            this.lb_numero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(676, 83);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(121, 20);
            this.tb_id.TabIndex = 51;
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(333, 413);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(98, 29);
            this.btn_Crear.TabIndex = 50;
            this.btn_Crear.Text = "CREAR";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(595, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "TELEFONO";
            // 
            // tb_Direccion
            // 
            this.tb_Direccion.Location = new System.Drawing.Point(676, 239);
            this.tb_Direccion.Name = "tb_Direccion";
            this.tb_Direccion.Size = new System.Drawing.Size(121, 20);
            this.tb_Direccion.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "DIRECCION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "RUC O DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "NUMERO DOC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "NOMBRE";
            // 
            // tb_Numero
            // 
            this.tb_Numero.Location = new System.Drawing.Point(676, 171);
            this.tb_Numero.Name = "tb_Numero";
            this.tb_Numero.Size = new System.Drawing.Size(121, 20);
            this.tb_Numero.TabIndex = 38;
            // 
            // tb_apellido
            // 
            this.tb_apellido.Location = new System.Drawing.Point(676, 140);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.Size = new System.Drawing.Size(121, 20);
            this.tb_apellido.TabIndex = 37;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(676, 109);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(121, 20);
            this.tb_nombre.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(589, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "MANTENIMIENTO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Numero_doc,
            this.Descripcion,
            this.Direccion,
            this.Telefono});
            this.dataGridView1.Location = new System.Drawing.Point(31, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(527, 306);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Numero_doc
            // 
            this.Numero_doc.HeaderText = "Numero_doc";
            this.Numero_doc.Name = "Numero_doc";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "CLIENTES";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(96, 413);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(102, 29);
            this.btn_eliminar.TabIndex = 31;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(213, 413);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(98, 29);
            this.btn_editar.TabIndex = 32;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(442, 413);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(98, 29);
            this.btn_Listar.TabIndex = 52;
            this.btn_Listar.Text = "LISTAR";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // tb_Telefono
            // 
            this.tb_Telefono.Location = new System.Drawing.Point(676, 270);
            this.tb_Telefono.Name = "tb_Telefono";
            this.tb_Telefono.Size = new System.Drawing.Size(121, 20);
            this.tb_Telefono.TabIndex = 53;
            // 
            // cob_ROD
            // 
            this.cob_ROD.FormattingEnabled = true;
            this.cob_ROD.Location = new System.Drawing.Point(676, 203);
            this.cob_ROD.Name = "cob_ROD";
            this.cob_ROD.Size = new System.Drawing.Size(121, 21);
            this.cob_ROD.TabIndex = 54;
            this.cob_ROD.SelectedIndexChanged += new System.EventHandler(this.cob_ROD_SelectedIndexChanged);
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(802, 208);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(14, 13);
            this.lb_numero.TabIndex = 55;
            this.lb_numero.Text = "#";
            // 
            // Form_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 477);
            this.Controls.Add(this.lb_numero);
            this.Controls.Add(this.cob_ROD);
            this.Controls.Add(this.tb_Telefono);
            this.Controls.Add(this.btn_Listar);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_Direccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Numero);
            this.Controls.Add(this.tb_apellido);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Clientes";
            this.Text = "Form_Clientes";
            this.Load += new System.EventHandler(this.Form_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Direccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Numero;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.TextBox tb_Telefono;
        private System.Windows.Forms.ComboBox cob_ROD;
        private System.Windows.Forms.Label lb_numero;
    }
}