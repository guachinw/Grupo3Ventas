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
    public partial class Form_Categoria : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=tcp:grupo3dsd.database.windows.net;Initial Catalog=Ventas;User ID=grupo3;Password=Grup0Tr3s");

        public Form_Categoria()
        {
            InitializeComponent();
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "  select a.Id_categoria,a.Nombre_categoria,b.Descripcion_Estado from Tb_Categoria a inner join Tb_Estado b on a.Estado_categoria = b.Id_Estado where a.Estado_categoria=1";
                SqlCommand comando = new SqlCommand(sql, connection);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable table = new DataTable();
                adaptador.Fill(table);
                dataGridView1.DataSource = table;
                selectes();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void selectes()
        {
            try
            {

                string sql = "select a.Id_categoria,a.Nombre_categoria,b.Descripcion_Estado from Tb_Categoria a inner join Tb_Estado b on a.Estado_categoria = b.Id_Estado where a.Estado_categoria=1";
                SqlCommand comando = new SqlCommand(sql, connection);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable table = new DataTable();
                adaptador.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void limpiar()
        {
            tb_buscar.Text = "";
            tb_nombre.Text = "";
        }


        private void btn_Crear_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into Tb_categoria (Nombre_categoria,Estado_categoria) values(@nombre, @estado)"; ;
                connection.Open();
                SqlCommand comando = new SqlCommand(sql, connection);
                comando.Parameters.AddWithValue("@nombre", tb_nombre.Text);
                comando.Parameters.AddWithValue("@estado", Int32.Parse(cb_estado.SelectedIndex.ToString()));
                comando.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("INSERTADO");
                connection.Close();
                limpiar();
                selectes();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE Tb_categoria SET Nombre_categoria=@nombre,Estado_categoria=@estado where id_categoria=@id";

                connection.Open();
                SqlCommand comando = new SqlCommand(sql, connection);
                comando.Parameters.AddWithValue("@id", tb_id.Text);
                comando.Parameters.AddWithValue("@nombre", tb_nombre.Text);
                comando.Parameters.AddWithValue("@estado", Int32.Parse(cb_estado.SelectedIndex.ToString()));

                comando.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("EDITADO ");
                limpiar();
                selectes();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE Tb_categoria SET Estado_categoria=0 where id_categoria=@id";

                connection.Open();
                SqlCommand comando = new SqlCommand(sql, connection);
                comando.Parameters.AddWithValue("@id", tb_id.Text);
                comando.Parameters.AddWithValue("@estado", Int32.Parse(cb_estado.SelectedIndex.ToString()));

                comando.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("ELIMINADO ");
                limpiar();
                selectes();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select a.Id_categoria,a.Nombre_categoria,b.Descripcion_Estado from Tb_Categoria a inner join Tb_Estado b on a.Estado_categoria = b.Id_Estado where a.Estado_categoria=1 and a.Nombre_categoria = '" + tb_buscar.Text + "'";
                SqlCommand comando = new SqlCommand(sql, connection);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable table = new DataTable();
                adaptador.Fill(table);
                dataGridView1.DataSource = table;
                //selectes();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            tb_id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_nombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
