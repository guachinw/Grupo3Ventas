using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RegistroProductos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Categoria" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Categoria.svc o Categoria.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Categoria : ICategoria
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;
        Boolean blnexito = false;
        DataView dv;

        public DataTable ListarCategoria()
        {
            DataSet data = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "crud_Tb_CategoriaList";
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data, "Categoria");
                dv = data.Tables["Categoria"].DefaultView;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en el listado" + ex.Message);
            }
            return data.Tables["Categoria"];
        }

    }
}
