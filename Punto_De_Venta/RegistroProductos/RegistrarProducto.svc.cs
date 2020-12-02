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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "RegistrarProducto" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione RegistrarProducto.svc o RegistrarProducto.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class RegistrarProducto : IRegistrarProducto
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;
        Boolean blnexito = false;
        DataView dv;

        public DataTable ListarProductos()
        {
            DataSet data = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "crud_Tb_ProductosListPulido";
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data, "Productos");
                dv = data.Tables["Productos"].DefaultView;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en el listado" + ex.Message);
            }
            return data.Tables["Productos"];
        }

        public Boolean InsertarProducto(ProductoBE producto)
        {

            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "crud_Tb_ProductosInsert";


            try
            {
                cmd.Parameters.Add(new SqlParameter("@Codigo_producto", SqlDbType.VarChar, 20));
                cmd.Parameters["@Codigo_producto"].Value = producto.Codigo_producto;

                cmd.Parameters.Add(new SqlParameter("@Nombre_producto", SqlDbType.VarChar, 100));
                cmd.Parameters["@Nombre_producto"].Value = producto.Nombre_producto;

                cmd.Parameters.Add(new SqlParameter("@Precio_producto", SqlDbType.Decimal){ Precision = 8, Scale = 2});
                cmd.Parameters["@Precio_producto"].Value = producto.Precio_producto;

                cmd.Parameters.Add(new SqlParameter("@Estado_producto", SqlDbType.Int));
                cmd.Parameters["@Estado_producto"].Value = producto.Estado_producto;

                cmd.Parameters.Add(new SqlParameter("@Stock_producto", SqlDbType.Int));
                cmd.Parameters["@Stock_producto"].Value = producto.Stock_producto;

                cmd.Parameters.Add(new SqlParameter("@Id_Categoria", SqlDbType.Int));
                cmd.Parameters["@Id_Categoria"].Value = producto.Id_Categoria;

                cmd.Parameters.Add(new SqlParameter("@Id_Deta_Producto", SqlDbType.Int));
                cmd.Parameters["@Id_Deta_Producto"].Value = producto.Id_Deta_Producto;

                cmd.Parameters.Add(new SqlParameter("@Id_Clase", SqlDbType.Int));
                cmd.Parameters["@Id_Clase"].Value = producto.Id_Clase;

                cnx.Open();
                cmd.ExecuteNonQuery();
                blnexito = true;


            }
            catch (SqlException ex)
            {
                blnexito = false;
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return blnexito;

        }

        public Boolean ActualizarProducto(ProductoBE producto)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "crud_Tb_ProductosUpdate";
            //Agregar Parametros
            try
            {
                cmd.Parameters.Add(new SqlParameter("@Id_producto", SqlDbType.Int));
                cmd.Parameters["@Id_producto"].Value = producto.Id_producto;

                cmd.Parameters.Add(new SqlParameter("@Codigo_producto", SqlDbType.VarChar, 20));
                cmd.Parameters["@Codigo_producto"].Value = producto.Codigo_producto;

                cmd.Parameters.Add(new SqlParameter("@Nombre_producto", SqlDbType.VarChar, 100));
                cmd.Parameters["@Nombre_producto"].Value = producto.Nombre_producto;

                cmd.Parameters.Add(new SqlParameter("@Precio_producto", SqlDbType.Decimal) { Precision = 8, Scale = 2 });
                cmd.Parameters["@Precio_producto"].Value = producto.Precio_producto;

                cmd.Parameters.Add(new SqlParameter("@Estado_producto", SqlDbType.Int));
                cmd.Parameters["@Estado_producto"].Value = producto.Estado_producto;

                cmd.Parameters.Add(new SqlParameter("@Stock_producto", SqlDbType.Int));
                cmd.Parameters["@Stock_producto"].Value = producto.Stock_producto;

                cmd.Parameters.Add(new SqlParameter("@Id_Categoria", SqlDbType.Int));
                cmd.Parameters["@Id_Categoria"].Value = producto.Id_Categoria;

                cmd.Parameters.Add(new SqlParameter("@Id_Deta_Producto", SqlDbType.Int));
                cmd.Parameters["@Id_Deta_Producto"].Value = producto.Id_Deta_Producto;

                cmd.Parameters.Add(new SqlParameter("@Id_Clase", SqlDbType.Int));
                cmd.Parameters["@Id_Clase"].Value = producto.Id_Clase;
                cnx.Open();
                cmd.ExecuteNonQuery();
                blnexito = true;
            }
            catch (SqlException ex)
            {
                blnexito = false;
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return blnexito;
        }

        public Boolean DeshabilitarProducto(int cod)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "crud_Tb_ProductosDisable";
            //Agregar Parametros
            try
            {
                cmd.Parameters.Add(new SqlParameter("@Id_producto", SqlDbType.Int));
                cmd.Parameters["@Id_producto"].Value = cod;
                cnx.Open();
                cmd.ExecuteNonQuery();
                blnexito = true;
            }
            catch (SqlException ex)
            {
                blnexito = false;
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return blnexito;
        }

        public ProductoBE ConsultarProducto(int cod)
        {
            ProductoBE producto = new ProductoBE();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "crud_Tb_ProductosSelect";
                //Agregar Parametros
                cmd.Parameters.Add(new SqlParameter("@Id_producto", SqlDbType.Int));
                cmd.Parameters["@Id_producto"].Value = cod;
                cnx.Open();
                sdr = cmd.ExecuteReader();
                if (sdr.HasRows == true)
                {
                    sdr.Read();
                    producto.Id_producto = Convert.ToInt32(sdr.GetValue(sdr.GetOrdinal("Id_producto")));
                    producto.Codigo_producto = sdr.GetValue(sdr.GetOrdinal("Codigo_producto")).ToString();
                    producto.Nombre_producto = sdr.GetValue(sdr.GetOrdinal("Nombre_producto")).ToString();
                    producto.Precio_producto = Convert.ToSingle(sdr.GetValue(sdr.GetOrdinal("Precio_producto")));
                    producto.Estado_producto = Convert.ToInt32(sdr.GetValue(sdr.GetOrdinal("Estado_producto")));
                    producto.Stock_producto = Convert.ToInt32(sdr.GetValue(sdr.GetOrdinal("Stock_producto")));
                    producto.Id_Categoria = Convert.ToInt32(sdr.GetValue(sdr.GetOrdinal("Id_Categoria")));
                    producto.Id_Deta_Producto = Convert.ToInt32(sdr.GetValue(sdr.GetOrdinal("Id_Deta_Producto")));
                    producto.Id_Clase = Convert.ToInt32(sdr.GetValue(sdr.GetOrdinal("Id_Clase")));
                    sdr.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return producto;
        }

    }
}
