namespace Punto_De_Venta
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.botonesCirculosDising14 = new Punto_De_Venta.BotonesCirculosDising();
            this.btn_Entrar = new Punto_De_Venta.BotonesCirculosDising();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(285, 95);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(258, 35);
            this.txt_User.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "USER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 27;
            this.label2.Text = "PASSWORD";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(285, 172);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(258, 35);
            this.txt_Password.TabIndex = 28;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // botonesCirculosDising14
            // 
            this.botonesCirculosDising14.BorderColor = System.Drawing.Color.White;
            this.botonesCirculosDising14.ButtonColor = System.Drawing.Color.Turquoise;
            this.botonesCirculosDising14.FlatAppearance.BorderSize = 0;
            this.botonesCirculosDising14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonesCirculosDising14.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonesCirculosDising14.Location = new System.Drawing.Point(299, 12);
            this.botonesCirculosDising14.Name = "botonesCirculosDising14";
            this.botonesCirculosDising14.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.botonesCirculosDising14.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.botonesCirculosDising14.OnHoverTextColor = System.Drawing.Color.Gray;
            this.botonesCirculosDising14.Size = new System.Drawing.Size(218, 47);
            this.botonesCirculosDising14.TabIndex = 25;
            this.botonesCirculosDising14.Text = "LOCAL";
            this.botonesCirculosDising14.TextColor = System.Drawing.Color.White;
            this.botonesCirculosDising14.UseVisualStyleBackColor = true;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BorderColor = System.Drawing.Color.White;
            this.btn_Entrar.ButtonColor = System.Drawing.Color.Turquoise;
            this.btn_Entrar.FlatAppearance.BorderSize = 0;
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.Location = new System.Drawing.Point(342, 230);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btn_Entrar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btn_Entrar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Entrar.Size = new System.Drawing.Size(153, 43);
            this.btn_Entrar.TabIndex = 24;
            this.btn_Entrar.Text = "ENTRAR";
            this.btn_Entrar.TextColor = System.Drawing.Color.White;
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(623, 320);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonesCirculosDising14);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_User;
        private BotonesCirculosDising btn_Entrar;
        private BotonesCirculosDising botonesCirculosDising14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_Password;
    }
}