using Mensajeria_courier.Dominio;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Mensajeria_courier
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Productos_courier" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Productos_courier.svc o Productos_courier.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Productos_courier : IProductos_courier
    {
        public Productos menssageriaProd(string nombreProd, string cantProd)
        {
            Productos producto = new Productos();
            producto.Nombre = nombreProd;
            producto.Cantidad = Int32.Parse(cantProd);
            var factory = new ConnectionFactory()
            {
                HostName = "moose.rmq.cloudamqp.com",
                VirtualHost = "fsxktpfa",
                UserName = "fsxktpfa",
                Password = "8Tw5xX926OpnPZcAyISwpOrnyLyWHvM5"
            };
            using (var connction = factory.CreateConnection())
            //2 establecer el canal y/o la cola
            using (var channel = connction.CreateModel())
            {
                channel.QueueDeclare(queue: "notificaciones",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);
                //3 dejar el mensaje en la cola
                var body = Encoding.UTF8.GetBytes("producto listo =  " + nombreProd + "       "+" cantidad =  " + cantProd);
                channel.BasicPublish(exchange: "",
                                     routingKey: "notificaciones",
                                     basicProperties: null,
                                     body: body);
            }

            return producto;
        }
    }
}
