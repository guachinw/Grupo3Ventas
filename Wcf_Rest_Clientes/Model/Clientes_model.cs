using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Wcf_Rest_Clientes.Modelo
{
    [DataContract]
    public class Clientes_model
    {
       [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellido { get; set; }
        [DataMember]
        public string Documento { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string Telefono { get; set; }
        [DataMember]
        public string Descripcion_edintidad { get; set; }
    }
}