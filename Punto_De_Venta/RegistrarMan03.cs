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
    public partial class RegistrarMan03 : Form
    {
        RegistrarProductoWCF.RegistrarProductoClient registrarProducto = new RegistrarProductoWCF.RegistrarProductoClient();
        RegistrarProductoWCF.ProductoBE productoBE = new RegistrarProductoWCF.ProductoBE();
        CategoriaWCF.CategoriaClient categoria = new CategoriaWCF.CategoriaClient();
        ClaseWCF.ClaseClient clase = new ClaseWCF.ClaseClient();
        DetalleWCF.Detalle_ProductoClient Detalle_Producto = new DetalleWCF.Detalle_ProductoClient();
        EstadoWCF.EstadoClient estado = new EstadoWCF.EstadoClient();

        private int codigo;
        public int Codigo { get => codigo; set => codigo = value; }

        public RegistrarMan03()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                GrabarProducto();
                //se invoca el metodo de actualizacion
                if (registrarProducto.ActualizarProducto(productoBE) == true)
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

        private void RegistrarMan03_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
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

                cboEstado.DataSource = estado.ListarEstado();
                cboEstado.ValueMember = "Id_Estado";
                cboEstado.DisplayMember = "Descripcion_Estado";

                productoBE = registrarProducto.ConsultarProducto(codigo);

                txCodigo.Text = productoBE.Codigo_producto;
                txNombre.Text = productoBE.Nombre_producto;
                tnPrecio.Value = Convert.ToDecimal(productoBE.Precio_producto);
                cboEstado.SelectedValue = productoBE.Estado_producto;
                tnStock.Value = Convert.ToInt32(productoBE.Stock_producto);
                cboCategoria.SelectedValue = productoBE.Id_Categoria;
                cboClase.SelectedValue = productoBE.Id_Clase;
                cboDetalle.SelectedValue = productoBE.Id_Deta_Producto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void GrabarProducto()
        {
            productoBE.Id_producto = codigo;
            productoBE.Codigo_producto = txCodigo.Text;
            productoBE.Nombre_producto = txNombre.Text;
            productoBE.Precio_producto = Convert.ToSingle(tnPrecio.Value);
            productoBE.Estado_producto = Convert.ToInt32(cboEstado.SelectedValue);
            productoBE.Stock_producto = Convert.ToInt32(tnStock.Value);
            productoBE.Id_Categoria = Convert.ToInt32(cboCategoria.SelectedValue);
            productoBE.Id_Clase = Convert.ToInt32(cboClase.SelectedValue);
            productoBE.Id_Deta_Producto = Convert.ToInt32(cboDetalle.SelectedValue);
        }

    }
}
