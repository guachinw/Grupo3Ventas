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
    public partial class RegistrarMan02 : Form
    {
        RegistrarProductoWCF.RegistrarProductoClient registrarProducto = new RegistrarProductoWCF.RegistrarProductoClient();
        RegistrarProductoWCF.ProductoBE productoBE = new RegistrarProductoWCF.ProductoBE();
        CategoriaWCF.CategoriaClient categoria = new CategoriaWCF.CategoriaClient();
        ClaseWCF.ClaseClient clase = new ClaseWCF.ClaseClient();
        DetalleWCF.Detalle_ProductoClient Detalle_Producto = new DetalleWCF.Detalle_ProductoClient();
        EstadoWCF.EstadoClient estado = new EstadoWCF.EstadoClient();

        public RegistrarMan02()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertarProducto()
        {
            productoBE.Id_producto = null;
            productoBE.Codigo_producto = txCodigo.Text;
            productoBE.Nombre_producto = txNombre.Text;
            productoBE.Precio_producto = Convert.ToSingle(tnPrecio.Value);
            productoBE.Estado_producto = 1;
            productoBE.Stock_producto = Convert.ToInt32(tnStock.Value);
            productoBE.Id_Categoria = Convert.ToInt32(cboCategoria.SelectedValue);
            productoBE.Id_Clase = Convert.ToInt32(cboClase.SelectedValue);
            productoBE.Id_Deta_Producto = Convert.ToInt32(cboDetalle.SelectedValue);
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                InsertarProducto();
                if (registrarProducto.InsertarProducto(productoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error, verifique los datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void RegistrarMan02_Load(object sender, EventArgs e)
        {
            try
            {
                cboCategoria.DataSource = categoria.ListarCategoria();
                cboCategoria.ValueMember = "Id_categoria";
                cboCategoria.DisplayMember = "Nombre_categoria";

                cboClase.DataSource = clase.ListarClase();
                cboClase.ValueMember = "Id_Clase";
                cboClase.DisplayMember = "Nombre_Clase";

                cboDetalle.DataSource = Detalle_Producto.ListarDetalle_Producto();
                cboDetalle.ValueMember = "Id_Deta_Producto";
                cboDetalle.DisplayMember = "Nombre_Deta_Producto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
