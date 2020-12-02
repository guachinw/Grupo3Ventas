namespace Punto_De_Venta
{
    partial class Form_Empleados
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
            this.components = new System.ComponentModel.Container();
            this.dgv_contenedor = new System.Windows.Forms.DataGridView();
            this.tbUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_contraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_correo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_cargo = new System.Windows.Forms.ComboBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contenedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_contenedor
            // 
            this.dgv_contenedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contenedor.Location = new System.Drawing.Point(37, 80);
            this.dgv_contenedor.Name = "dgv_contenedor";
            this.dgv_contenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_contenedor.Size = new System.Drawing.Size(527, 306);
            this.dgv_contenedor.TabIndex = 11;
            this.dgv_contenedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tbUsuariosBindingSource
            // 
            this.tbUsuariosBindingSource.DataMember = "Tb_Usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "EMPLEADOS";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(120, 458);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(102, 29);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(237, 458);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(98, 29);
            this.btn_editar.TabIndex = 8;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "MANTENIMIENTO";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(680, 87);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(121, 20);
            this.tb_nombre.TabIndex = 13;
            // 
            // tb_apellido
            // 
            this.tb_apellido.Location = new System.Drawing.Point(680, 118);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.Size = new System.Drawing.Size(121, 20);
            this.tb_apellido.TabIndex = 14;
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(680, 149);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(121, 20);
            this.tb_usuario.TabIndex = 15;
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.Location = new System.Drawing.Point(680, 184);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.Size = new System.Drawing.Size(121, 20);
            this.tb_contraseña.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "APELLIDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "USUARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "CONTRASEÑA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "CORREO";
            // 
            // tb_correo
            // 
            this.tb_correo.Location = new System.Drawing.Point(680, 217);
            this.tb_correo.Name = "tb_correo";
            this.tb_correo.Size = new System.Drawing.Size(121, 20);
            this.tb_correo.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(612, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "ESTADO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "CARGO";
            // 
            // cb_cargo
            // 
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Items.AddRange(new object[] {
            "",
            "ADMINISTRADOR",
            "CAJA"});
            this.cb_cargo.Location = new System.Drawing.Point(680, 243);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(121, 21);
            this.cb_cargo.TabIndex = 25;
            this.cb_cargo.SelectedIndexChanged += new System.EventHandler(this.cb_cargo_SelectedIndexChanged);
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Inactivo",
            "Disponible"});
            this.cb_estado.Location = new System.Drawing.Point(680, 276);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(121, 21);
            this.cb_estado.TabIndex = 26;
            this.cb_estado.SelectedIndexChanged += new System.EventHandler(this.cb_estado_SelectedIndexChanged);
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(357, 458);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(98, 29);
            this.btn_Crear.TabIndex = 27;
            this.btn_Crear.Text = "CREAR";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(803, 247);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(14, 13);
            this.lb1.TabIndex = 28;
            this.lb1.Text = "#";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(802, 281);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(14, 13);
            this.lb2.TabIndex = 29;
            this.lb2.Text = "#";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(680, 61);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(121, 20);
            this.tb_id.TabIndex = 30;
            // 
            // Form_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 499);
            this.Controls.Add(this.dgv_contenedor);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.cb_cargo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_correo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_contraseña);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.tb_apellido);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Empleados";
            this.Text = "Form_Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contenedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_contenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
     
        private System.Windows.Forms.BindingSource tbUsuariosBindingSource;
        
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.TextBox tb_contraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_correo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_cargo;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox tb_id;
    }
}