using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_De_Venta
{
    public partial class Form_Productos : Form
    {
        RegistrarProductoWCF.RegistrarProductoClient registrarProducto = new RegistrarProductoWCF.RegistrarProductoClient();
        public Form_Productos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void CargarDatos()
        {
            registrarProducto.ListarProductos();
            dgvProductos.DataSource = registrarProducto.ListarProductos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Deshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                //obtenems el ID de la entrada a eliminar
                int code;
                code = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);

                // Consultamos si deseamos eliminarlo
                DialogResult rpta;
                rpta = MessageBox.Show("¿Seguro de deshabilitar el producto seleccionado?", "confirme",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si se confirma se procede a invocar al metodo que elimina al proveedor

                if (rpta == DialogResult.Yes)
                {
                    if (registrarProducto.DeshabilitarProducto(code) == true)
                    {
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error, verificar los datos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            RegistrarMan03 man03 = new RegistrarMan03();
            man03.Codigo = Convert.ToInt16(dgvProductos.CurrentRow.Cells[0].Value);

            //abrir formulario
            man03.ShowDialog();

            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarMan02 man02 = new RegistrarMan02();
            man02.ShowDialog();
            CargarDatos();
        }

        private void Form_Productos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
