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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Detalle_Producto" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Detalle_Producto.svc o Detalle_Producto.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Detalle_Producto : IDetalle_Producto
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;
        Boolean blnexito = false;
        DataView dv;

        public DataTable ListarDetalle_Producto()
        {
            DataSet data = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "crud_Tb_Deta_ProductoList";
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data, "Detalle");
                dv = data.Tables["Detalle"].DefaultView;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en el listado" + ex.Message);
            }
            return data.Tables["Detalle"];
        }
    }
}
