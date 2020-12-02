using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Wcf_Rest_Clientes.Modelo;

namespace Wcf_Rest_Clientes
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Clientes" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Clientes.svc o Clientes.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Clientes : IClientes
    {
        SqlConnection connection = new SqlConnection("Data Source=tcp:grupo3dsd.database.windows.net;Initial Catalog=Ventas;User ID=grupo3;Password=Grup0Tr3s");
        public string GetDeta(int id)
        {
            VentasEntities db = new VentasEntities();
            Tb_Cliente cli = new Tb_Cliente();
            Tb_Documento_Identidad deta = new Tb_Documento_Identidad();
            cli = db.Tb_Cliente.Where(x => x.Id_documento_identidad == id).FirstOrDefault();

            deta = db.Tb_Documento_Identidad.Where(x => x.Id_documento_identidad == cli.Id_documento_identidad).FirstOrDefault();
            return deta.Descripcion;
        }
        public Clientes_model BuscarPersona(string dni)
        {
            try
            {
                VentasEntities db = new VentasEntities();
                Tb_Cliente mPersTemp = new Tb_Cliente();
                Clientes_model mPers = new Clientes_model();
                mPersTemp = db.Tb_Cliente.Where(x => x.Numero_Documento == dni).FirstOrDefault();
                mPers.Id = mPersTemp.Id_cliente;
                mPers.Nombre = mPersTemp.Nombre_cliente;
                mPers.Apellido = mPersTemp.Apellido_cliente;
                mPers.Documento = mPersTemp.Numero_Documento;
                mPers.Direccion = mPersTemp.Direccion;
                mPers.Telefono = mPersTemp.Telefono;
                mPers.Descripcion_edintidad = GetDeta(mPers.Id);
                return mPers;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Clientes_model> ListarClientes()
        {
            try
            {
                VentasEntities db = new VentasEntities();
                List<Tb_Cliente> listaTemp = new List<Tb_Cliente>();
                List<Clientes_model> lista = new List<Clientes_model>();
                listaTemp = db.Tb_Cliente.ToList();
                foreach (Tb_Cliente item in listaTemp)
                {
                    Clientes_model mPersona = new Clientes_model();
                    mPersona.Id = item.Id_cliente;
                    mPersona.Nombre = item.Nombre_cliente;
                    mPersona.Apellido = item.Apellido_cliente;
                    mPersona.Descripcion_edintidad = item.Numero_Documento;
                    mPersona.Direccion = item.Direccion;
                    mPersona.Telefono = item.Telefono;
                    mPersona.Documento = GetDeta(item.Id_documento_identidad);
                    lista.Add(mPersona);
                }
                return lista;
            }
            catch (Exception )
            {
                return null;
            }
        }

       
        

        public string DeleterPersona(string dni)
        {

            string sql = "delete from tb_cliente where id_cliente='" + dni + "'";
            connection.Open();
            SqlCommand comando = new SqlCommand(sql, connection);
            comando.ExecuteNonQuery();
            connection.Close();
            return null;
        }

      

       

        public string UpdateCli( string nombre, string apellido, string numero, string direccion, string telefono, string descipcion,string id)
        {
            string sql = "update tb_cliente set nombre_cliente = '" + id + "',apellido_cliente = '" + nombre + "' , numero_documento =" + apellido + ",direccion = '" +  numero + "',telefono = " +   direccion + ",id_documento_identidad =" + telefono + " where id_cliente = " + descipcion + "";
            connection.Open();
            SqlCommand comando = new SqlCommand(sql, connection);
            comando.ExecuteNonQuery();
            connection.Close();
            return null;
        }

        

        public string CrearCli(string nombre, string apellido, string numero, string direccion, string telefono, string descipcion)
        {
            string sql = "insert into tb_cliente (nombre_cliente,apellido_cliente,numero_documento,direccion,telefono,id_documento_identidad)" +
                         "values ('"+nombre+"','"+apellido+"','"+numero+"','"+direccion+"',"+telefono+","+descipcion+")";
            connection.Open();
            SqlCommand comando = new SqlCommand(sql, connection);
            comando.ExecuteNonQuery();
            connection.Close();
            return null;
        }
    }

}
