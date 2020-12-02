namespace Punto_De_Venta
{
    partial class Form_Currier
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
            this.btn_currier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_currier
            // 
            this.btn_currier.Location = new System.Drawing.Point(247, 375);
            this.btn_currier.Name = "btn_currier";
            this.btn_currier.Size = new System.Drawing.Size(148, 33);
            this.btn_currier.TabIndex = 1;
            this.btn_currier.Text = "Consultar";
            this.btn_currier.UseVisualStyleBackColor = true;
            this.btn_currier.Click += new System.EventHandler(this.btn_currier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "CURRIER";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 113);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(345, 179);
            this.textBox3.TabIndex = 40;
            // 
            // Form_Currier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 457);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_currier);
            this.Name = "Form_Currier";
            this.Text = "Form_Currier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_currier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
    }
}