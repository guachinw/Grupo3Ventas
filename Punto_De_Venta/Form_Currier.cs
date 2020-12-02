using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mensajeria_courier.Dominio;
using RabbitMQ.Client;

namespace Punto_De_Venta
{
    public partial class Form_Currier : Form
    {
        public Form_Currier()
        {
            InitializeComponent();
        }

      

        private void btn_currier_Click(object sender, EventArgs e)
        {
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
                //3 dejar el mensaje en la cola
                BasicGetResult consumer = channel.BasicGet("notificaciones", true);
                if (consumer != null)
                {
                    string resultado = Encoding.UTF8.GetString(consumer.Body.ToArray());
                    textBox3.Text = textBox3.Text + "\r\n" + "Mensaje: " + resultado;
                }
            }
        }
    }
}
