namespace Punto_De_Venta
{
    partial class Form_Clase
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
        
            this.ventasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
          
           
            this.tbClaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
          
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.tb_buscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
          
            this.tbEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
          
            
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuariosBindingSource)).BeginInit();
         
            ((System.ComponentModel.ISupportInitialize)(this.tbClaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.tbEstadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ventasDataSet
            // 
            
          
            // 
            // ventasDataSetBindingSource
            // 
           
            this.ventasDataSetBindingSource.Position = 0;
            // 
            // tbUsuariosBindingSource
            // 
            this.tbUsuariosBindingSource.DataMember = "Tb_Usuarios";
            this.tbUsuariosBindingSource.DataSource = this.ventasDataSetBindingSource;
            // 
            // tb_UsuariosTableAdapter
            // 
    
            // 
            // ventasDataSet2

            // 
            // tbClaseBindingSource
            // 
            this.tbClaseBindingSource.DataMember = "Tb_Clase";
            
            // 
            // tb_ClaseTableAdapter
            // 
          
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(663, 163);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(121, 20);
            this.tb_id.TabIndex = 51;
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(329, 415);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(98, 29);
            this.btn_Crear.TabIndex = 50;
            this.btn_Crear.Text = "CREAR";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Inactivo",
            "Disponible"});
            this.cb_estado.Location = new System.Drawing.Point(663, 226);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(121, 21);
            this.cb_estado.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(595, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "ESTADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "NOMBRE";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(663, 189);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(121, 20);
            this.tb_nombre.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "MANTENIMIENTO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(527, 278);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "CLASE";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(92, 415);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(102, 29);
            this.btn_eliminar.TabIndex = 31;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(209, 415);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(98, 29);
            this.btn_editar.TabIndex = 32;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(450, 415);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(98, 29);
            this.btn_Listar.TabIndex = 52;
            this.btn_Listar.Text = "LISTAR";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(405, 68);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(98, 23);
            this.btn_Buscar.TabIndex = 55;
            this.btn_Buscar.Text = "BUSCAR";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // tb_buscar
            // 
            this.tb_buscar.Location = new System.Drawing.Point(278, 70);
            this.tb_buscar.Name = "tb_buscar";
            this.tb_buscar.Size = new System.Drawing.Size(121, 20);
            this.tb_buscar.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "NOMBRE";
            // 
            // ventasDataSet3
            // 
        
            // tbEstadoBindingSource
            // 
            this.tbEstadoBindingSource.DataMember = "Tb_Estado";
            
            // 
            // tb_EstadoTableAdapter
          
            // Form_Clase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 524);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.tb_buscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Listar);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Clase";
            this.Text = "Form_Clase";
            ((System.ComponentModel.ISupportInitialize)(this.tbEstadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource ventasDataSetBindingSource;
       
        private System.Windows.Forms.BindingSource tbUsuariosBindingSource;
      
      
        private System.Windows.Forms.BindingSource tbClaseBindingSource;
       
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox tb_buscar;
        private System.Windows.Forms.Label label5;
     
        private System.Windows.Forms.BindingSource tbEstadoBindingSource;
 
    }
}