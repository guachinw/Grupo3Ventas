using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_De_Venta
{
    public partial class Form_Login : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=tcp:grupo3dsd.database.windows.net;Initial Catalog=Ventas;User ID=grupo3;Password=Grup0Tr3s");
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load_keyPress(object sender, EventArgs e)
        {
          
               
            

        }


        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txt_User.Text;
                string password = txt_Password.Text;
                if (user.Trim() == "" || password.Trim() == "")
                {
                    MessageBox.Show("imgrese datos","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from tb_usuarios where Nickname_user ='" + txt_User.Text + "' and Password_user=" + txt_Password.Text + "and Estado_user=1", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Session.id = Convert.ToInt32(reader["Id_usuarios"].ToString());
                        Session.nombre = reader["Nombre_user"].ToString();

                        MessageBox.Show("Wellcome: " + txt_User.Text, " Successful");
                        this.Hide();
                        Form_Index Index = new Form_Index();
                        Index.Show();

                    }
                    else
                    {
                        MessageBox.Show("Usuario o password incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            

        }

        private void botonesCirculosDising1_Click(object sender, EventArgs e)
        {
           

        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
           
        }
    }
}
