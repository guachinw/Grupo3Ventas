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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Estado" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Estado.svc o Estado.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Estado : IEstado
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;
        Boolean blnexito = false;
        DataView dv;

        public DataTable ListarEstado()
        {
            DataSet data = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "crud_Tb_EstadoList";
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data, "Estado");
                dv = data.Tables["Estado"].DefaultView;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en el listado" + ex.Message);
            }
            return data.Tables["Estado"];
        }
    }
}
