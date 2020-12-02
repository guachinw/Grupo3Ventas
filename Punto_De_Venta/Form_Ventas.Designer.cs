namespace Punto_De_Venta
{
    partial class Form_Ventas
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
            this.lb_idventa = new System.Windows.Forms.Label();
            this.lb_idusu = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.lb_imptotal = new System.Windows.Forms.Label();
            this.lb_tributos = new System.Windows.Forms.Label();
            this.lb_cargos = new System.Windows.Forms.Label();
            this.lb_igv = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_grabar = new System.Windows.Forms.Button();
            this.dgv_ventas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_consultaSunat = new System.Windows.Forms.Button();
            this.lb_idmone = new System.Windows.Forms.Label();
            this.lb_idcli = new System.Windows.Forms.Label();
            this.bt_quitarpro = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_tipodocveb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_telcli = new System.Windows.Forms.TextBox();
            this.txt_apecli = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_numcli = new System.Windows.Forms.TextBox();
            this.txt_dircli = new System.Windows.Forms.TextBox();
            this.txt_nomcli = new System.Windows.Forms.TextBox();
            this.cb_tipodoccli = new System.Windows.Forms.ComboBox();
            this.bt_validar = new System.Windows.Forms.Button();
            this.txt_obsven = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_fechae = new System.Windows.Forms.DateTimePicker();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_tipomone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_direccione = new System.Windows.Forms.Label();
            this.lb_razone = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_correven = new System.Windows.Forms.Label();
            this.lb_serieven = new System.Windows.Forms.Label();
            this.lb_tipodoce = new System.Windows.Forms.Label();
            this.lb_ruce = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_idventa
            // 
            this.lb_idventa.AutoSize = true;
            this.lb_idventa.Location = new System.Drawing.Point(142, 49);
            this.lb_idventa.Name = "lb_idventa";
            this.lb_idventa.Size = new System.Drawing.Size(42, 13);
            this.lb_idventa.TabIndex = 41;
            this.lb_idventa.Text = "idventa";
            this.lb_idventa.Visible = false;
            // 
            // lb_idusu
            // 
            this.lb_idusu.AutoSize = true;
            this.lb_idusu.Location = new System.Drawing.Point(65, 49);
            this.lb_idusu.Name = "lb_idusu";
            this.lb_idusu.Size = new System.Drawing.Size(32, 13);
            this.lb_idusu.TabIndex = 40;
            this.lb_idusu.Text = "idusu";
            this.lb_idusu.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bt_cancelar);
            this.groupBox4.Controls.Add(this.lb_imptotal);
            this.groupBox4.Controls.Add(this.lb_tributos);
            this.groupBox4.Controls.Add(this.lb_cargos);
            this.groupBox4.Controls.Add(this.lb_igv);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.bt_grabar);
            this.groupBox4.Controls.Add(this.dgv_ventas);
            this.groupBox4.Location = new System.Drawing.Point(68, 449);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(888, 252);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(786, 188);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(96, 38);
            this.bt_cancelar.TabIndex = 28;
            this.bt_cancelar.Text = "CANCELAR";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // lb_imptotal
            // 
            this.lb_imptotal.AutoSize = true;
            this.lb_imptotal.Location = new System.Drawing.Point(778, 140);
            this.lb_imptotal.Name = "lb_imptotal";
            this.lb_imptotal.Size = new System.Drawing.Size(95, 13);
            this.lb_imptotal.TabIndex = 27;
            this.lb_imptotal.Text = "IMPORTE VENTA";
            // 
            // lb_tributos
            // 
            this.lb_tributos.AutoSize = true;
            this.lb_tributos.Location = new System.Drawing.Point(778, 105);
            this.lb_tributos.Name = "lb_tributos";
            this.lb_tributos.Size = new System.Drawing.Size(28, 13);
            this.lb_tributos.TabIndex = 26;
            this.lb_tributos.Text = "0.00";
            // 
            // lb_cargos
            // 
            this.lb_cargos.AutoSize = true;
            this.lb_cargos.Location = new System.Drawing.Point(778, 73);
            this.lb_cargos.Name = "lb_cargos";
            this.lb_cargos.Size = new System.Drawing.Size(28, 13);
            this.lb_cargos.TabIndex = 25;
            this.lb_cargos.Text = "0.00";
            // 
            // lb_igv
            // 
            this.lb_igv.AutoSize = true;
            this.lb_igv.Location = new System.Drawing.Point(778, 45);
            this.lb_igv.Name = "lb_igv";
            this.lb_igv.Size = new System.Drawing.Size(64, 13);
            this.lb_igv.TabIndex = 24;
            this.lb_igv.Text = "IGV VENTA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(663, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Importe Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(691, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Otros Tributos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(696, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Otros Cargos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(741, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "IGV:";
            // 
            // bt_grabar
            // 
            this.bt_grabar.Location = new System.Drawing.Point(654, 188);
            this.bt_grabar.Name = "bt_grabar";
            this.bt_grabar.Size = new System.Drawing.Size(110, 38);
            this.bt_grabar.TabIndex = 5;
            this.bt_grabar.Text = "GRABAR";
            this.bt_grabar.UseVisualStyleBackColor = true;
            this.bt_grabar.Click += new System.EventHandler(this.bt_grabar_Click_1);
            // 
            // dgv_ventas
            // 
            this.dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.PrecioUnitario,
            this.IGV,
            this.PrecioVenta,
            this.Cantidad,
            this.ImporteVenta});
            this.dgv_ventas.Location = new System.Drawing.Point(0, 12);
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.Size = new System.Drawing.Size(636, 214);
            this.dgv_ventas.TabIndex = 3;
            this.dgv_ventas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ventas_CellEndEdit_1);
            this.dgv_ventas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_ventas_RowsAdded_1);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Descripcion";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 120;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Sub Total";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Width = 80;
            // 
            // IGV
            // 
            this.IGV.HeaderText = "IGV";
            this.IGV.Name = "IGV";
            this.IGV.ReadOnly = true;
            this.IGV.Width = 50;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 80;
            // 
            // ImporteVenta
            // 
            this.ImporteVenta.HeaderText = "Importe Venta";
            this.ImporteVenta.MaxInputLength = 33000;
            this.ImporteVenta.Name = "ImporteVenta";
            this.ImporteVenta.ReadOnly = true;
            this.ImporteVenta.Width = 115;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_consultaSunat);
            this.groupBox3.Controls.Add(this.lb_idmone);
            this.groupBox3.Controls.Add(this.lb_idcli);
            this.groupBox3.Controls.Add(this.bt_quitarpro);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cb_tipodocveb);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_telcli);
            this.groupBox3.Controls.Add(this.txt_apecli);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_numcli);
            this.groupBox3.Controls.Add(this.txt_dircli);
            this.groupBox3.Controls.Add(this.txt_nomcli);
            this.groupBox3.Controls.Add(this.cb_tipodoccli);
            this.groupBox3.Controls.Add(this.bt_validar);
            this.groupBox3.Controls.Add(this.txt_obsven);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtp_fechae);
            this.groupBox3.Controls.Add(this.btn_Agregar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lb_tipomone);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(68, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(870, 249);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // bt_consultaSunat
            // 
            this.bt_consultaSunat.Location = new System.Drawing.Point(658, 96);
            this.bt_consultaSunat.Name = "bt_consultaSunat";
            this.bt_consultaSunat.Size = new System.Drawing.Size(113, 23);
            this.bt_consultaSunat.TabIndex = 38;
            this.bt_consultaSunat.Text = "Consultar Sunat";
            this.bt_consultaSunat.UseVisualStyleBackColor = true;
            this.bt_consultaSunat.Click += new System.EventHandler(this.bt_consultaSunat_Click_1);
            // 
            // lb_idmone
            // 
            this.lb_idmone.AutoSize = true;
            this.lb_idmone.Location = new System.Drawing.Point(24, 174);
            this.lb_idmone.Name = "lb_idmone";
            this.lb_idmone.Size = new System.Drawing.Size(41, 13);
            this.lb_idmone.TabIndex = 37;
            this.lb_idmone.Text = "idmone";
            this.lb_idmone.Visible = false;
            // 
            // lb_idcli
            // 
            this.lb_idcli.AutoSize = true;
            this.lb_idcli.Location = new System.Drawing.Point(24, 101);
            this.lb_idcli.Name = "lb_idcli";
            this.lb_idcli.Size = new System.Drawing.Size(25, 13);
            this.lb_idcli.TabIndex = 36;
            this.lb_idcli.Text = "idcli";
            this.lb_idcli.Visible = false;
            // 
            // bt_quitarpro
            // 
            this.bt_quitarpro.Location = new System.Drawing.Point(716, 198);
            this.bt_quitarpro.Name = "bt_quitarpro";
            this.bt_quitarpro.Size = new System.Drawing.Size(131, 23);
            this.bt_quitarpro.TabIndex = 34;
            this.bt_quitarpro.Text = "QUITAR PRODUCTOS";
            this.bt_quitarpro.UseVisualStyleBackColor = true;
            this.bt_quitarpro.Click += new System.EventHandler(this.bt_quitarpro_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(376, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Numero Documento:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Tipo Documento:";
            // 
            // cb_tipodocveb
            // 
            this.cb_tipodocveb.FormattingEnabled = true;
            this.cb_tipodocveb.Items.AddRange(new object[] {
            "",
            "BOLETA DE VENTA ELECTRÓNICA",
            "FACTURA ELECTRÓNICA"});
            this.cb_tipodocveb.Location = new System.Drawing.Point(488, 19);
            this.cb_tipodocveb.Name = "cb_tipodocveb";
            this.cb_tipodocveb.Size = new System.Drawing.Size(217, 21);
            this.cb_tipodocveb.TabIndex = 20;
            this.cb_tipodocveb.SelectedIndexChanged += new System.EventHandler(this.cb_tipodocveb_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Tipo Documento Venta:";
            // 
            // txt_telcli
            // 
            this.txt_telcli.Location = new System.Drawing.Point(488, 134);
            this.txt_telcli.Name = "txt_telcli";
            this.txt_telcli.Size = new System.Drawing.Size(153, 20);
            this.txt_telcli.TabIndex = 31;
            // 
            // txt_apecli
            // 
            this.txt_apecli.Location = new System.Drawing.Point(488, 95);
            this.txt_apecli.Name = "txt_apecli";
            this.txt_apecli.Size = new System.Drawing.Size(153, 20);
            this.txt_apecli.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(429, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Telefono:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Direccion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Apellido:";
            // 
            // txt_numcli
            // 
            this.txt_numcli.Location = new System.Drawing.Point(491, 57);
            this.txt_numcli.Name = "txt_numcli";
            this.txt_numcli.Size = new System.Drawing.Size(150, 20);
            this.txt_numcli.TabIndex = 26;
            this.txt_numcli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numcli_KeyPress_1);
            // 
            // txt_dircli
            // 
            this.txt_dircli.Location = new System.Drawing.Point(140, 131);
            this.txt_dircli.Name = "txt_dircli";
            this.txt_dircli.Size = new System.Drawing.Size(203, 20);
            this.txt_dircli.TabIndex = 25;
            // 
            // txt_nomcli
            // 
            this.txt_nomcli.Location = new System.Drawing.Point(140, 95);
            this.txt_nomcli.Name = "txt_nomcli";
            this.txt_nomcli.Size = new System.Drawing.Size(203, 20);
            this.txt_nomcli.TabIndex = 24;
            // 
            // cb_tipodoccli
            // 
            this.cb_tipodoccli.FormattingEnabled = true;
            this.cb_tipodoccli.Items.AddRange(new object[] {
            "",
            "DNI",
            "RUC"});
            this.cb_tipodoccli.Location = new System.Drawing.Point(140, 52);
            this.cb_tipodoccli.Name = "cb_tipodoccli";
            this.cb_tipodoccli.Size = new System.Drawing.Size(79, 21);
            this.cb_tipodoccli.TabIndex = 23;
            // 
            // bt_validar
            // 
            this.bt_validar.Location = new System.Drawing.Point(658, 57);
            this.bt_validar.Name = "bt_validar";
            this.bt_validar.Size = new System.Drawing.Size(113, 23);
            this.bt_validar.TabIndex = 22;
            this.bt_validar.Text = "Validar en Sistema";
            this.bt_validar.UseVisualStyleBackColor = true;
            this.bt_validar.Click += new System.EventHandler(this.bt_validar_Click_1);
            // 
            // txt_obsven
            // 
            this.txt_obsven.Location = new System.Drawing.Point(155, 205);
            this.txt_obsven.Name = "txt_obsven";
            this.txt_obsven.Size = new System.Drawing.Size(354, 20);
            this.txt_obsven.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha de Emision:";
            // 
            // dtp_fechae
            // 
            this.dtp_fechae.Location = new System.Drawing.Point(142, 16);
            this.dtp_fechae.Name = "dtp_fechae";
            this.dtp_fechae.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechae.TabIndex = 11;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(553, 198);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(140, 23);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "AGREGAR PRODUCTOS";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo de Moneda:";
            // 
            // lb_tipomone
            // 
            this.lb_tipomone.AutoSize = true;
            this.lb_tipomone.Location = new System.Drawing.Point(152, 174);
            this.lb_tipomone.Name = "lb_tipomone";
            this.lb_tipomone.Size = new System.Drawing.Size(100, 13);
            this.lb_tipomone.TabIndex = 17;
            this.lb_tipomone.Text = "TIPO DE MONEDA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Observación:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_direccione);
            this.groupBox2.Controls.Add(this.lb_razone);
            this.groupBox2.Location = new System.Drawing.Point(68, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 101);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // lb_direccione
            // 
            this.lb_direccione.AutoSize = true;
            this.lb_direccione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_direccione.Location = new System.Drawing.Point(24, 60);
            this.lb_direccione.Name = "lb_direccione";
            this.lb_direccione.Size = new System.Drawing.Size(123, 16);
            this.lb_direccione.TabIndex = 6;
            this.lb_direccione.Text = "Direccion Empresa";
            // 
            // lb_razone
            // 
            this.lb_razone.AutoSize = true;
            this.lb_razone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_razone.Location = new System.Drawing.Point(24, 24);
            this.lb_razone.Name = "lb_razone";
            this.lb_razone.Size = new System.Drawing.Size(105, 16);
            this.lb_razone.TabIndex = 2;
            this.lb_razone.Text = "Razon Empresa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lb_correven);
            this.groupBox1.Controls.Add(this.lb_serieven);
            this.groupBox1.Controls.Add(this.lb_tipodoce);
            this.groupBox1.Controls.Add(this.lb_ruce);
            this.groupBox1.Location = new System.Drawing.Point(698, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 118);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(117, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "-";
            // 
            // lb_correven
            // 
            this.lb_correven.AutoSize = true;
            this.lb_correven.Location = new System.Drawing.Point(133, 88);
            this.lb_correven.Name = "lb_correven";
            this.lb_correven.Size = new System.Drawing.Size(31, 13);
            this.lb_correven.TabIndex = 10;
            this.lb_correven.Text = "0000";
            // 
            // lb_serieven
            // 
            this.lb_serieven.AutoSize = true;
            this.lb_serieven.Location = new System.Drawing.Point(83, 88);
            this.lb_serieven.Name = "lb_serieven";
            this.lb_serieven.Size = new System.Drawing.Size(32, 13);
            this.lb_serieven.TabIndex = 9;
            this.lb_serieven.Text = "B001";
            // 
            // lb_tipodoce
            // 
            this.lb_tipodoce.AutoSize = true;
            this.lb_tipodoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tipodoce.Location = new System.Drawing.Point(19, 24);
            this.lb_tipodoce.Name = "lb_tipodoce";
            this.lb_tipodoce.Size = new System.Drawing.Size(198, 18);
            this.lb_tipodoce.TabIndex = 7;
            this.lb_tipodoce.Text = "TIPO DOCUMENTO VENTA";
            // 
            // lb_ruce
            // 
            this.lb_ruce.AutoSize = true;
            this.lb_ruce.Location = new System.Drawing.Point(83, 61);
            this.lb_ruce.Name = "lb_ruce";
            this.lb_ruce.Size = new System.Drawing.Size(85, 13);
            this.lb_ruce.TabIndex = 8;
            this.lb_ruce.Text = "RUC EMPRESA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "VENTAS";
            // 
            // Form_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 733);
            this.Controls.Add(this.lb_idventa);
            this.Controls.Add(this.lb_idusu);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Ventas";
            this.Text = "Form_Ventas";
            this.Load += new System.EventHandler(this.Form_Ventas_Load_1);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_idventa;
        private System.Windows.Forms.Label lb_idusu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Label lb_imptotal;
        private System.Windows.Forms.Label lb_tributos;
        private System.Windows.Forms.Label lb_cargos;
        private System.Windows.Forms.Label lb_igv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_grabar;
        public System.Windows.Forms.DataGridView dgv_ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteVenta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_consultaSunat;
        private System.Windows.Forms.Label lb_idmone;
        private System.Windows.Forms.Label lb_idcli;
        private System.Windows.Forms.Button bt_quitarpro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_tipodocveb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_telcli;
        private System.Windows.Forms.TextBox txt_apecli;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_numcli;
        private System.Windows.Forms.TextBox txt_dircli;
        private System.Windows.Forms.TextBox txt_nomcli;
        private System.Windows.Forms.ComboBox cb_tipodoccli;
        private System.Windows.Forms.Button bt_validar;
        private System.Windows.Forms.TextBox txt_obsven;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.DateTimePicker dtp_fechae;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_tipomone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_direccione;
        private System.Windows.Forms.Label lb_razone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_correven;
        private System.Windows.Forms.Label lb_serieven;
        private System.Windows.Forms.Label lb_tipodoce;
        private System.Windows.Forms.Label lb_ruce;
        private System.Windows.Forms.Label label2;
    }
}