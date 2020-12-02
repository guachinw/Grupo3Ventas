using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Mensajeria_courier.Dominio
{
    [DataContract]
    public class Productos
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public int Cantidad { get; set; }
    }
}