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
    public partial class Form_Empleados : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=tcp:grupo3dsd.database.windows.net;Initial Catalog=Ventas;User ID=grupo3;Password=Grup0Tr3s");

        
        
        public Form_Empleados()
        {
            InitializeComponent();
            selectes();
            //tb_id.Enabled = false;
        }
    
       public void selectes()
        {
            string sql = "select a.Id_usuarios,a.Nombre_user,a.Apellido_user,a.Nickname_user,a.Password_user,a.Correo_user,a.Id_cargo,b.Descripcion_Estado from Tb_Usuarios as a inner join Tb_Estado as b on a.Estado_user = b.Id_Estado where  a.Estado_user=1";
            SqlCommand comando = new SqlCommand(sql, connection);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable table = new DataTable();
            adaptador.Fill(table);
            dgv_contenedor.DataSource = table;
        }
        private void limpiar() 
        {
            tb_nombre.Text = "";
            tb_apellido.Text = "";
            tb_usuario.Text = "";
            tb_contraseña.Text = "";
            tb_correo.Text = "";
            
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "insert into Tb_Usuarios (Nombre_user,Apellido_user,Nickname_user,Password_user,Correo_user,Id_cargo,Estado_user) values(@nombre, @apellido, @usuario, @password, @correo, @cargo, @estado)"; ;
                connection.Open();
                SqlCommand comando = new SqlCommand(sql, connection);
                comando.Parameters.AddWithValue("@nombre", tb_nombre.Text);
                comando.Parameters.AddWithValue("@apellido", tb_apellido.Text);
                comando.Parameters.AddWithValue("@usuario", tb_usuario.Text);
                comando.Parameters.AddWithValue("@password", tb_contraseña.Text);
                comando.Parameters.AddWithValue("@correo", tb_correo.Text);
                comando.Parameters.AddWithValue("@cargo", Int32.Parse(lb1.Text));
                comando.Parameters.AddWithValue("@estado", Int32.Parse(lb2.Text));
               
                comando.ExecuteNonQuery();
                
                connection.Close();
               
                MessageBox.Show("INSERTADO");
                limpiar();
                selectes();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cb_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_cargo.SelectedIndex;
            lb1.Text = index.ToString(); ;
        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_estado.SelectedIndex;
            lb2.Text = index.ToString(); ;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            tb_id.Text = this.dgv_contenedor.CurrentRow.Cells[0].Value.ToString();
            tb_nombre.Text = this.dgv_contenedor.CurrentRow.Cells[1].Value.ToString();
            tb_apellido.Text = this.dgv_contenedor.CurrentRow.Cells[2].Value.ToString();
            tb_usuario.Text = this.dgv_contenedor.CurrentRow.Cells[3].Value.ToString();
            tb_contraseña.Text = this.dgv_contenedor.CurrentRow.Cells[4].Value.ToString();
            tb_correo.Text = this.dgv_contenedor.CurrentRow.Cells[5].Value.ToString();
            
            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE Tb_Usuarios SET Nombre_user=@nombre,Apellido_user=@apellido,Nickname_user=@usuario,Password_user=@password,Correo_user=@correo,Id_cargo=@cargo,Estado_user=@estado where id_usuarios=@id";
                
                connection.Open();
                SqlCommand comando = new SqlCommand(sql, connection);
                comando.Parameters.AddWithValue("@id", tb_id.Text);
                comando.Parameters.AddWithValue("@nombre", tb_nombre.Text);
                comando.Parameters.AddWithValue("@apellido", tb_apellido.Text);
                comando.Parameters.AddWithValue("@usuario", tb_usuario.Text);
                comando.Parameters.AddWithValue("@password", tb_contraseña.Text);
                comando.Parameters.AddWithValue("@correo", tb_correo.Text);
                comando.Parameters.AddWithValue("@cargo", Int32.Parse(lb1.Text));
                comando.Parameters.AddWithValue("@estado", Int32.Parse(lb2.Text));

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
                string sql = "UPDATE Tb_Usuarios SET Estado_user=0 where id_usuarios=@id";

                connection.Open();
                SqlCommand comando = new SqlCommand(sql, connection);
                comando.Parameters.AddWithValue("@id", tb_id.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
