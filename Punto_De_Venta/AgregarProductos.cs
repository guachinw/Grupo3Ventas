using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_De_Venta
{
    public partial class AgregarProductos : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=tcp:grupo3dsd.database.windows.net;Initial Catalog=Ventas;User ID=grupo3;Password=Grup0Tr3s");
        public AgregarProductos()
        {
            InitializeComponent();
        }
        private void limpiar()
        {
            txt_Producto.Text = "";
        }
        public static string codigo;
        public static string nombre;
        public static decimal precio;

       

        private void btn_BuscarProd_Click_1(object sender, EventArgs e)
        {
            string sql = "select a.Id_producto,a.Nombre_producto,a.Precio_producto from Tb_Productos as a where Nombre_producto like '%'+@nombreProducto+'%' and Stock_producto > 0 and a.Estado_producto = 1";

            connection.Open();
            SqlCommand comando = new SqlCommand(sql, connection);
            comando.Parameters.AddWithValue("@nombreProducto", txt_Producto.Text);

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable table = new DataTable();
            adaptador.Fill(table);
            dgv_Prod.DataSource = table;

            connection.Close();
            limpiar();
        }

        private void dgv_Prod_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow dgv in dgv_Prod.SelectedRows)
            {
                string codigo;
                string nombre;
                decimal precioventa;
                int cantidad = 1;

                codigo = this.dgv_Prod.CurrentRow.Cells[0].Value.ToString();
                nombre = this.dgv_Prod.CurrentRow.Cells[1].Value.ToString();
                precioventa = Convert.ToDecimal(this.dgv_Prod.CurrentRow.Cells[2].Value.ToString());


                Form_Ventas ventas = new Form_Ventas();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "Form_Ventas")
                    {
                        ventas = (Form_Ventas)frm;
                        ventas.dgv_ventas.Rows.Add(codigo, nombre, "", "", precioventa, cantidad);
                    }
                }
            }
        }
    }
}
