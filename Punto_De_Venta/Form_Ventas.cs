using Mensajeria_courier.Dominio;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_De_Venta
{
    public partial class Form_Ventas : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=tcp:grupo3dsd.database.windows.net;Initial Catalog=Ventas;User ID=grupo3;Password=Grup0Tr3s");
        public Form_Ventas()
        {
            InitializeComponent();
        }


        public void TraerMoneda()
        {
            string sql = "SELECT Id_moneda,Tipo_moneda FROM Tb_Moneda";
            SqlCommand comando = new SqlCommand(sql, connection);

            connection.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                lb_idmone.Text = registro["Id_moneda"].ToString();
                lb_tipomone.Text = registro["Tipo_moneda"].ToString();
            }
            connection.Close();
        }
       

        private void calculoImporteTotal()
        {

            if (this.dgv_ventas.Rows.Count > 0)
            {
                decimal igvtotal = 0;
                decimal total = 0;
                foreach (DataGridViewRow row in dgv_ventas.Rows)
                {

                    decimal precioventa = decimal.Parse(row.Cells[4].Value.ToString());
                    int cantidad = Convert.ToInt32(row.Cells[5].Value.ToString());

                    row.Cells[2].Value = decimal.Round((precioventa / Convert.ToDecimal(1.18)), 2);
                    row.Cells[3].Value = decimal.Round((Convert.ToDecimal(row.Cells[2].Value) * Convert.ToDecimal(0.18)), 2);
                    row.Cells[6].Value = precioventa * cantidad;

                    total += Convert.ToDecimal(row.Cells[6].Value);
                    igvtotal += Convert.ToDecimal(row.Cells[3].Value);
                }
                lb_imptotal.Text = Convert.ToString(total);
                decimal subtotal = total / Convert.ToDecimal(1.18);
                lb_igv.Text = Convert.ToString(decimal.Round((subtotal * Convert.ToDecimal(0.18)), 2));
            }
        }

        private string RL { get; set; }
        
        private void Form_Ventas_Load_1(object sender, EventArgs e)
        {
            TraerMoneda();
            lb_idusu.Text = Session.id.ToString();
            dgv_ventas.AllowUserToAddRows = false;

            string sql = "SELECT RazonSocial_empresa,Ruc_empresa,Direccion_empresa FROM Tb_Empresa";
            SqlCommand comando = new SqlCommand(sql, connection);

            connection.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                lb_razone.Text = registro["RazonSocial_empresa"].ToString();
                lb_direccione.Text = registro["Direccion_empresa"].ToString();
                lb_ruce.Text = registro["Ruc_empresa"].ToString();
            }
            connection.Close();
        }

        private void cb_tipodocveb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = cb_tipodocveb.SelectedIndex;
            lb_tipodoce.Text = cb_tipodocveb.Items[ind].ToString();
            if (cb_tipodocveb.Text == "BOLETA DE VENTA ELECTRÓNICA")
            {
                string sql = "select top(1) Id_documento_venta,Nun_serie_venta,Nun_correlativo_venta,Nun_correlativo_venta+1 as new_correlativo from Tb_Cabecera_Venta where Nun_serie_venta like '%B%' order by Nun_correlativo_venta desc";
                SqlCommand comando = new SqlCommand(sql, connection);

                connection.Open();
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    string serie = registro["Nun_serie_venta"].ToString();
                    string correlativo = registro["new_correlativo"].ToString();
                    lb_serieven.Text = serie;
                    lb_correven.Text = "000" + correlativo;
                }
                connection.Close();
            }
            else if ((cb_tipodocveb.Text == "FACTURA ELECTRÓNICA"))
            {
                string sql = " select top(1) Id_documento_venta,Nun_serie_venta,Nun_correlativo_venta,Nun_correlativo_venta+1 as new_correlativo from Tb_Cabecera_Venta where Nun_serie_venta like '%F%' order by Nun_correlativo_venta desc";
                SqlCommand comando = new SqlCommand(sql, connection);

                connection.Open();
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    string serie = registro["Nun_serie_venta"].ToString();
                    string correlativo = registro["new_correlativo"].ToString();
                    lb_serieven.Text = serie;
                    lb_correven.Text = "000" + correlativo;
                }
                connection.Close();
            }
            else
            {
                lb_serieven.Text = "B001";
                lb_correven.Text = "0000";
            }
        }

        private void bt_validar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_numcli.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese un numero de documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string sql = "SELECT a.Id_cliente,b.Descripcion,Nombre_cliente,Apellido_cliente,Direccion,Telefono FROM Tb_Cliente AS a INNER JOIN Tb_Documento_Identidad AS b ON a.Id_documento_identidad = b.Id_documento_identidad WHERE Numero_Documento = '" + txt_numcli.Text + "'";
                    SqlCommand comando = new SqlCommand(sql, connection);
                    connection.Open();

                    SqlDataReader registro = comando.ExecuteReader();

                    if (registro.Read())
                    {
                        lb_idcli.Text = registro["Id_cliente"].ToString();
                        cb_tipodoccli.Text = registro["Descripcion"].ToString();
                        txt_nomcli.Text = registro["Nombre_cliente"].ToString();
                        txt_apecli.Text = registro["Apellido_cliente"].ToString();
                        txt_dircli.Text = registro["Direccion"].ToString();
                        txt_telcli.Text = registro["Telefono"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No existe cliente");
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void bt_consultaSunat_Click_1(object sender, EventArgs e)
        {
            bool flag = this.txt_numcli.TextLength == 11;
            if (flag)
            {
                this.RL = null;


                Compania contribuyente = new ExtraerJson().GetContribuyente(this.txt_numcli.Text);
                bool flag2 = contribuyente != null;
                if (flag2)
                {
                    //this.txtRucRead.Text = contribuyente.Ruc;
                    this.cb_tipodoccli.SelectedIndex = 2;
                    this.txt_nomcli.Text = contribuyente.Razon_social;
                    this.txt_apecli.Text = contribuyente.nombre_comercial;
                    this.txt_dircli.Text = contribuyente.domicilio_fiscal;
                    this.RL = contribuyente.Representante_legal.ToString();

                    try
                    {
                        string sql = "INSERT INTO Tb_Cliente(Nombre_cliente,Apellido_cliente,Id_documento_identidad,Numero_Documento,Direccion,Telefono) values(@nomCli,@apeCli,@docCli,@numCli,@dirCli,@telCli)";
                        connection.Open();

                        SqlCommand comando = new SqlCommand(sql, connection);
                        comando.Parameters.AddWithValue("@nomCli", txt_nomcli.Text);
                        comando.Parameters.AddWithValue("@apeCli", txt_apecli.Text);
                        comando.Parameters.AddWithValue("@docCli", cb_tipodoccli.SelectedIndex);
                        comando.Parameters.AddWithValue("@numCli", txt_numcli.Text);
                        comando.Parameters.AddWithValue("@dirCli", txt_dircli.Text);
                        comando.Parameters.AddWithValue("@telCli", txt_telcli.Text);

                        comando.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Cliente Insertado");

                        string sql2 = "SELECT a.Id_cliente,b.Descripcion,Nombre_cliente,Apellido_cliente,Direccion,Telefono FROM Tb_Cliente AS a INNER JOIN Tb_Documento_Identidad AS b ON a.Id_documento_identidad = b.Id_documento_identidad WHERE Numero_Documento = '" + txt_numcli.Text + "'";
                        SqlCommand comando2 = new SqlCommand(sql2, connection);
                        connection.Open();

                        SqlDataReader registro2 = comando2.ExecuteReader();

                        if (registro2.Read())
                        {
                            lb_idcli.Text = registro2["Id_cliente"].ToString();
                            cb_tipodoccli.Text = registro2["Descripcion"].ToString();
                            txt_nomcli.Text = registro2["Nombre_cliente"].ToString();
                            txt_apecli.Text = registro2["Apellido_cliente"].ToString();
                            txt_dircli.Text = registro2["Direccion"].ToString();
                            txt_telcli.Text = registro2["Telefono"].ToString();
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("No se pudo insertar cliente");
                    }
                }
                else
                {
                    MessageBox.Show("Contribuyente no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("errpr");
            }
        }

        private void bt_quitarpro_Click_1(object sender, EventArgs e)
        {
            decimal igvtotal = 0;
            decimal total = 0;

            foreach (DataGridViewRow row in dgv_ventas.SelectedRows)
            {
                dgv_ventas.Rows.RemoveAt(row.Index);
            }

            foreach (DataGridViewRow row in dgv_ventas.Rows)
            {
                total += Convert.ToDecimal(row.Cells[6].Value);
                igvtotal += Convert.ToDecimal(row.Cells[3].Value);
            }
            lb_imptotal.Text = Convert.ToString(total);
            decimal subtotal = total / Convert.ToDecimal(1.18);
            lb_igv.Text = Convert.ToString(decimal.Round((subtotal * Convert.ToDecimal(0.18)), 2));
        }

        private void bt_grabar_Click_1(object sender, EventArgs e)
        {
            DateTime date = dtp_fechae.Value;

            int estadoven = 1;
            DateTime fech = Convert.ToDateTime(date.ToString("dd/MM/yyyy HH:mm:ss"));
            try
            {
                string sql = "INSERT INTO Tb_Cabecera_Venta(Id_documento_venta,Nun_serie_venta,Nun_correlativo_venta,Nun_documento_venta,Fecha_emision,Estado_Venta,Id_cliente,Id_moneda,Id_Usuarios,Observacion_venta) values(@idDocumento,@numSerie,@numCorrelativo,@numDocumento,@fechaEmision,@estadoVenta,@idCliente,@idMoneda,@idUsuarios,@obsVenta)";
                connection.Open();
                SqlCommand comando = new SqlCommand(sql, connection);
                comando.Parameters.AddWithValue("@idDocumento", cb_tipodocveb.SelectedIndex);
                comando.Parameters.AddWithValue("@numSerie", lb_serieven.Text);
                comando.Parameters.AddWithValue("@numCorrelativo", lb_correven.Text);
                comando.Parameters.AddWithValue("@numDocumento", lb_serieven.Text + "-" + lb_correven.Text);
                comando.Parameters.AddWithValue("@fechaEmision", fech);
                comando.Parameters.AddWithValue("@estadoVenta", estadoven);
                comando.Parameters.AddWithValue("@idCliente", Int32.Parse(lb_idcli.Text));
                comando.Parameters.AddWithValue("@idMoneda", Int32.Parse(lb_idmone.Text));
                comando.Parameters.AddWithValue("@idUsuarios", Int32.Parse(lb_idusu.Text));
                comando.Parameters.AddWithValue("@obsVenta", txt_obsven.Text);

                comando.ExecuteNonQuery();

                connection.Close();

                string sql2 = "select top(1) Id_venta from Tb_Cabecera_Venta order by Id_venta desc";
                SqlCommand comando2 = new SqlCommand(sql2, connection);

                connection.Open();
                SqlDataReader registro2 = comando2.ExecuteReader();
                if (registro2.Read())
                {
                    int idventa = Convert.ToInt32(registro2["Id_venta"]);

                    lb_idventa.Text = idventa.ToString();

                }
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            try
            {
                foreach (DataGridViewRow row in dgv_ventas.Rows)
                {
                    string sql = "INSERT INTO Tb_Detalle_Venta(Id_producto,Id_venta,Cantidad,Subtotal,IGV,Precio_venta,Importe_total) values(@idProducto,@idVenta,@cantidad,@subtotal,@igv,@precioVenta,@importeTotal)";
                    connection.Open();
                    SqlCommand comando = new SqlCommand(sql, connection);

                    comando.Parameters.AddWithValue("@idProducto", Int32.Parse(row.Cells[0].Value.ToString()));
                    comando.Parameters.AddWithValue("@idVenta", Int32.Parse(lb_idventa.Text));
                    comando.Parameters.AddWithValue("@cantidad", Int32.Parse(row.Cells[5].Value.ToString()));
                    comando.Parameters.AddWithValue("@subtotal", decimal.Parse(row.Cells[2].Value.ToString()));
                    comando.Parameters.AddWithValue("@igv", decimal.Parse(row.Cells[3].Value.ToString()));
                    comando.Parameters.AddWithValue("@precioVenta", decimal.Parse(row.Cells[4].Value.ToString()));
                    comando.Parameters.AddWithValue("@importeTotal", decimal.Parse(row.Cells[6].Value.ToString()));

                    comando.ExecuteNonQuery();

                    connection.Close();
                }
                MessageBox.Show("VENTA REALIZADA");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            /*mesanjeria*/
            

                foreach (DataGridViewRow row in dgv_ventas.Rows)
            {
                string nombre = "";
                //decimal precioventa;
                int cantidad = 0;
                nombre = row.Cells[1].Value.ToString();
                cantidad = Convert.ToInt32(row.Cells[5].Value.ToString());
                RestClient proxy = new RestClient("http://localhost:65369/Productos_courier.svc");
                RestRequest req = new RestRequest("Producto/" + nombre + "/" + cantidad, Method.GET, DataFormat.Json);
                IRestResponse<Productos> res = proxy.Execute<Productos>(req);
                nombre = res.Data.Nombre;
                cantidad = Convert.ToInt32(res.Data.Cantidad.ToString());
            }

            
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            Form agregar = new AgregarProductos();
            agregar.Show();
        }

        private void txt_numcli_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dgv_ventas_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            decimal igvtotal = 0;
            decimal total = 0;

            calculoImporteTotal();

            foreach (DataGridViewRow row in dgv_ventas.Rows)
            {
                total += Convert.ToDecimal(row.Cells[6].Value);
                igvtotal += Convert.ToDecimal(row.Cells[3].Value);
            }

            lb_imptotal.Text = Convert.ToString(total);
            decimal subtotal = total / Convert.ToDecimal(1.18);
            lb_igv.Text = Convert.ToString(decimal.Round((subtotal * Convert.ToDecimal(0.18)), 2));
        }

        private void dgv_ventas_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            string cellValue = "";

            cellValue = dgv_ventas.CurrentCell.Value.ToString();
            if (cellValue != "")
            {
                calculoImporteTotal();
            }
        }
    }
}
