using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroProductos
{
    public class ProductoBE
    {
        //[DataMember]
        private int? id_producto;
        //[DataMember]
        private string codigo_producto;
        //[DataMember]
        private string nombre_producto;
        //[DataMember]
        private float precio_producto;
        //[DataMember]
        private int estado_producto;
        //[DataMember]
        private int stock_producto;
        //[DataMember]
        private int id_Categoria;
        //[DataMember]
        private int id_Deta_Producto;
        //[DataMember]
        private int id_Clase;

        public int? Id_producto { get => id_producto; set => id_producto = value; }
        public string Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public float Precio_producto { get => precio_producto; set => precio_producto = value; }
        public int Estado_producto { get => estado_producto; set => estado_producto = value; }
        public int Stock_producto { get => stock_producto; set => stock_producto = value; }
        public int Id_Categoria { get => id_Categoria; set => id_Categoria = value; }
        public int Id_Deta_Producto { get => id_Deta_Producto; set => id_Deta_Producto = value; }
        public int Id_Clase { get => id_Clase; set => id_Clase = value; }
    }
}