using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroProductos
{
    public class ProductoBE
    {
        private int? id_producto;
        private string codigo_producto;
        private string nombre_producto;
        private float precio_producto;
        private int estado_producto;
        private int stock_producto;
        private int id_Categoria;
        private int id_Deta_Producto;
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