using Punto_De_Venta.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_De_Venta
{
    public partial class Form_Clientes : Form
    {
        public Form_Clientes()
        {
            InitializeComponent();
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            RestClient proxy = new RestClient("http://localhost:50547/Clientes.svc");
            RestRequest request = new RestRequest("clientes", Method.GET, DataFormat.Json);
            IRestResponse<List<Clientes_model>> response = proxy.Execute<List<Clientes_model>>(request);
            dataGridView1.Visible = true;
            dataGridView1.Rows.Clear();
            if (response.Data != null)
            {
                foreach (Clientes_model mpers  in response.Data)
                {
                    int row = dataGridView1.Rows.Add();
                    dataGridView1.Rows[row].Cells[0].Value = mpers.Id;
                    dataGridView1.Rows[row].Cells[1].Value = mpers.Nombre;
                    dataGridView1.Rows[row].Cells[2].Value = mpers.Apellido;
                    dataGridView1.Rows[row].Cells[3].Value = mpers.Descripcion_edintidad;
                    dataGridView1.Rows[row].Cells[4].Value = mpers.Documento;
                    dataGridView1.Rows[row].Cells[5].Value = mpers.Direccion;
                    dataGridView1.Rows[row].Cells[6].Value = mpers.Telefono;

                }
            }
            else
            {
                MessageBox.Show("El servicio no está en linea", "Error");
            }
        }

        public void selecttes()
        {
            RestClient proxy = new RestClient("http://localhost:50547/Clientes.svc");
            RestRequest request = new RestRequest("clientes", Method.GET, DataFormat.Json);
            IRestResponse<List<Clientes_model>> response = proxy.Execute<List<Clientes_model>>(request);
            dataGridView1.Visible = true;
            dataGridView1.Rows.Clear();
            if (response.Data != null)
            {
                foreach (Clientes_model mpers in response.Data)
                {
                    int row = dataGridView1.Rows.Add();
                    dataGridView1.Rows[row].Cells[0].Value = mpers.Id;
                    dataGridView1.Rows[row].Cells[1].Value = mpers.Nombre;
                    dataGridView1.Rows[row].Cells[2].Value = mpers.Apellido;
                    dataGridView1.Rows[row].Cells[3].Value = mpers.Descripcion_edintidad;
                    dataGridView1.Rows[row].Cells[4].Value = mpers.Documento;
                    dataGridView1.Rows[row].Cells[5].Value = mpers.Direccion;
                    dataGridView1.Rows[row].Cells[6].Value = mpers.Telefono;

                }
            }
            else
            {
                MessageBox.Show("El servicio no está en linea", "Error");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            tb_id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_nombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_apellido.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cob_ROD.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tb_Numero.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_Direccion.Text= this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tb_Telefono.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void limpiar()
        {
            tb_id.Text = "";
            tb_nombre.Text = "";
            tb_apellido.Text = "";
            tb_Numero.Text = "";
           
            tb_Direccion.Text = "";
            tb_Telefono.Text = "";
        }

        private void Form_Clientes_Load(object sender, EventArgs e)
        {
            cob_ROD.Items.Add("");
            cob_ROD.Items.Add("DNI");
            cob_ROD.Items.Add("RUC");

        }

        private void cob_ROD_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = cob_ROD.SelectedIndex;
            lb_numero.Text = cob_ROD.Items[ind].ToString();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
             string dni = tb_id.Text;
             RestClient proxy = new RestClient("http://localhost:50547/Clientes.svc");
             RestRequest request = new RestRequest("EmplEliminar/"+ dni, Method.DELETE, DataFormat.Json);
             IRestResponse response = proxy.Execute(request);
             MessageBox.Show(response.Content);
            selecttes();
            
           
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            
            string nombre = tb_nombre.Text;
            string apellido = tb_apellido.Text;
            string telefono = tb_Telefono.Text; 
            string direccion = tb_Direccion.Text;
            string numero = tb_Numero.Text;
            string descipcion = cob_ROD.SelectedIndex.ToString();
            string id = tb_id.Text;

            RestClient proxy = new RestClient("http://localhost:50547/Clientes.svc");
            RestRequest request = new RestRequest("UpdateCli/" + nombre + "/" + apellido + "/" + numero + "/" + direccion + "/" + telefono + "/" + descipcion + "/" + id, Method.PUT, DataFormat.Json);
            IRestResponse response = proxy.Execute(request);
            MessageBox.Show(response.Content);
            selecttes();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            string nombre = tb_nombre.Text;
            string apellido = tb_apellido.Text;
            string telefono = tb_Telefono.Text;
            string direccion = tb_Direccion.Text;
            string numero = tb_Numero.Text;
            string descipcion = cob_ROD.SelectedIndex.ToString();
            RestClient proxy = new RestClient("http://localhost:50547/Clientes.svc");
            RestRequest request = new RestRequest("CrearCli/" + nombre + "/" + apellido + "/" + numero + "/" + direccion + "/" + telefono + "/" + descipcion , Method.POST, DataFormat.Json);
            IRestResponse response = proxy.Execute(request);
            MessageBox.Show(response.Content);
            selecttes();
        }
    }
}
