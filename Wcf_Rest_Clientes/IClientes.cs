using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web.Script.Services;
using System.Text;
using Wcf_Rest_Clientes;
using Wcf_Rest_Clientes.Modelo;

namespace Wcf_Rest_Clientes
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IClientes" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IClientes
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "clientes", Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        List<Clientes_model> ListarClientes();


        [OperationContract]
        [WebInvoke(UriTemplate = "clientes/{dni}", Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Clientes_model BuscarPersona(string dni);


        [WebInvoke(UriTemplate = "EmplEliminar/{dni}", 
            Method = "DELETE",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
         string DeleterPersona(string dni);

        /*[WebInvoke(UriTemplate = "UpdateCli/{id}", 
            Method = "PUT", 
            ResponseFormat = WebMessageFormat.Json, 
            RequestFormat = WebMessageFormat.Json)]
        string UpdateCli(string id);*/

        [WebInvoke(UriTemplate = "UpdateCli/{id}/{nombre}/{apellido}/{numero}/{direccion}/{telefono}/{descipcion}",
           Method = "PUT",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json)]
        string UpdateCli(string nombre, string apellido, string numero, string direccion, string telefono, string descipcion, string id);


        [WebInvoke(UriTemplate = "CrearCli/{nombre}/{apellido}/{numero}/{direccion}/{telefono}/{descipcion}",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        string CrearCli(string nombre, string apellido, string numero, string direccion, string telefono, string descipcion);





        string GetDeta(int id);
    }
}
