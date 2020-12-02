using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace RegistroProductos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IRegistrarProducto" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IRegistrarProducto
    {
        [OperationContract]
        DataTable ListarProductos();

        [OperationContract]
        Boolean InsertarProducto(ProductoBE producto);

        [OperationContract]
        Boolean ActualizarProducto(ProductoBE producto);

        [OperationContract]
        Boolean DeshabilitarProducto(int cod);

        [OperationContract]
        ProductoBE ConsultarProducto(int cod);
    }
}
