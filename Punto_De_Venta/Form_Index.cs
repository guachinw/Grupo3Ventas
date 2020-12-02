using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Punto_De_Venta
{
    public partial class Form_Index : Form
    {
        public Form_Index()
        {
            InitializeComponent();

            
        }

        private void Form_Index_Load(object sender, EventArgs e)
        {
            tb_nomUser.Text = "Usuario: " + Session.nombre.ToString();
        }

        private void pb_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pb_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pb_maximizar.Visible = false;
            pb_restaurar.Visible = true;
        }

        private void pb_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pb_restaurar.Visible = false;
            pb_maximizar.Visible = true;
        }

        private void pb_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnl_barraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_reportproductos_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_reportVentas_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_reportCompras_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_reportPagos_Click(object sender, EventArgs e)
        {
            
        }

        private void AbrirFormHijas(object formhijas)
        {
            if (this.pnl_panelControlador.Controls.Count > 0)
                this.pnl_panelControlador.Controls.RemoveAt(0);
            Form fh = formhijas as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_panelControlador.Controls.Add(fh);
            this.pnl_panelControlador.Tag = fh;
            fh.Show();

        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            AbrirFormHijas(new Form_Productos());
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijas(new Form_Clientes());
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            AbrirFormHijas(new Form_Ventas());
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            AbrirFormHijas(new Form_Empleados());
        }

        
        private void btn_Categoria_Click(object sender, EventArgs e)
        {
            AbrirFormHijas(new Form_Categoria());
        }

       

       

        private void btn_Clase_Click(object sender, EventArgs e)
        {
            AbrirFormHijas(new Form_Clase());
        }

        private void btn_currier_Click(object sender, EventArgs e)
        {
            AbrirFormHijas(new Form_Currier());
        }
    }
}
