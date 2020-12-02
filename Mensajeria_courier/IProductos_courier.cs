using Mensajeria_courier.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Mensajeria_courier
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProductos_courier" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProductos_courier
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "Producto/{nombreprod}/{cantProd}",
             Method = "GET",
             ResponseFormat = WebMessageFormat.Json,
             RequestFormat = WebMessageFormat.Json)]
        Productos menssageriaProd(string nombreProd, string cantProd);
    }
}
