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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Clase" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Clase.svc o Clase.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Clase : IClase
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;
        Boolean blnexito = false;
        DataView dv;

        public DataTable ListarClase()
        {
            DataSet data = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "crud_Tb_ClaseList";
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data, "Clase");
                dv = data.Tables["Clase"].DefaultView;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en el listado" + ex.Message);
            }
            return data.Tables["Clase"];
        }
    }
}
