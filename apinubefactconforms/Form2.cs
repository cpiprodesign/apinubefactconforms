using Newtonsoft.Json;
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

namespace apinubefactconforms
{
    public partial class Form2 : Form
    {
        /// # RUTA para enviar documentos
        public const string ruta = "https://api.nubefact.com/api/v1/cd90e4e3-ee31-4255-9cbc-d10f9ea78d9e";

        /// # TOKEN para enviar documentos
        public const string token = "b9118d5095f14b5e94648243706f1b50c10dd81ffbd543b8a15bf5167bb653db";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private string CrearFacturaJson()
        {
            // Capturar los valores del formulario
            string operacion = "generar_comprobante";
            int tipoDeComprobante = 1;
            string serie = txtserie.Text;
            int numero = int.Parse(txtnumero.Text);
            int sunatTransaction = 1;
            int clienteTipoDeDocumento = int.Parse(txtClienteTipoDoc.Text);
            string clienteNumeroDeDocumento = txtClienteNumDoc.Text;
            string clienteDenominacion = txtClienteDenominacion.Text;
            string clienteDireccion = txtClienteDireccion.Text;
            DateTime fechaDeEmision = dtpFechaEmision.Value;
            DateTime fechaDeVencimiento = dtpFechaVencimiento.Value;
            int moneda = int.Parse(cmbMoneda.SelectedItem.ToString());
            double porcentajeDeIgv = 18.00; // Valor fijo
            double totalGravada = 0;
            double totalIgv = 0;
            double total = 0;

            // Obtener los ítems desde el DataGridView
            List<Items> items = new List<Items>();
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Cells["Descripcion"].Value != null)
                {
                    Items item = new Items
                    {
                        unidad_de_medida = row.Cells["UnidadDeMedida"].Value?.ToString(),
                        codigo = row.Cells["codigo"].Value?.ToString(),
                        descripcion = row.Cells["descripcion"].Value?.ToString(),
                        cantidad = Convert.ToDouble(row.Cells["cantidad"].Value ?? 0),
                        valor_unitario = Convert.ToDouble(row.Cells["valorunitario"].Value ?? 0),
                        precio_unitario = Convert.ToDouble(row.Cells["preciounitario"].Value ?? 0),
                        subtotal = Convert.ToDouble(row.Cells["subtotal"].Value ?? 0),
                        tipo_de_igv = Convert.ToInt32(row.Cells["tipodeigv"].Value ?? 0),
                        igv = Convert.ToDouble(row.Cells["igv"].Value ?? 0),
                        total = Convert.ToDouble(row.Cells["total"].Value ?? 0)
                    };

                    totalGravada += item.subtotal;
                    totalIgv += item.igv;
                    total += item.total;

                    items.Add(item);
                }
            }

            // Crear el objeto Invoice
            Invoice invoice = new Invoice
            {
                operacion = operacion,
                tipo_de_comprobante = tipoDeComprobante,
                serie = serie,
                numero = numero,
                sunat_transaction = sunatTransaction,
                cliente_tipo_de_documento = clienteTipoDeDocumento,
                cliente_numero_de_documento = clienteNumeroDeDocumento,
                cliente_denominacion = clienteDenominacion,
                cliente_direccion = clienteDireccion,
                fecha_de_emision = fechaDeEmision,
                fecha_de_vencimiento = fechaDeVencimiento,
                moneda = moneda,
                porcentaje_de_igv = porcentajeDeIgv,
                total_gravada = totalGravada,
                total_igv = totalIgv,
                total = total,
                enviar_automaticamente_a_la_sunat = true,
                enviar_automaticamente_al_cliente = false,
                items = items
            };

            // Serializar el objeto a JSON
            return JsonConvert.SerializeObject(invoice, Formatting.Indented);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        static string SendJson(string ruta, string json, string token)
        {
            try
            {
                using (var client = new WebClient())
                {
                    /// ESPECIFICAMOS EL TIPO DE DOCUMENTO EN EL ENCABEZADO
                    client.Headers[HttpRequestHeader.ContentType] = "application/json; charset=utf-8";
                    /// ASI COMO EL TOKEN UNICO
                    client.Headers[HttpRequestHeader.Authorization] = "Token token=" + token;
                    /// OBTENEMOS LA RESPUESTA
                    string respuesta = client.UploadString(ruta, "POST", json);
                    /// Y LA 'RETORNAMOS'
                    return respuesta;
                }
            }
            catch (WebException ex)
            {
                /// EN CASO EXISTA ALGUN ERROR, LO TOMAMOS
                var respuesta = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                /// Y LO 'RETORNAMOS'
                return respuesta;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Generar JSON
            string json = CrearFacturaJson();
            txtOutput.Text = "JSON Generado:\n" + json;

            // Enviar JSON
            txtOutput.AppendText("\n\nEnviando JSON...\n");
            string respuesta = SendJson(ruta, json, token);

            // Mostrar respuesta
            txtOutput.AppendText("Respuesta:\n" + respuesta);
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    public class Invoice
    {
        public string operacion { get; set; }
        public int tipo_de_comprobante { get; set; }
        public string serie { get; set; }
        public int numero { get; set; }
        public int sunat_transaction { get; set; }
        public int cliente_tipo_de_documento { get; set; }
        public string cliente_numero_de_documento { get; set; }
        public string cliente_denominacion { get; set; }
        public string cliente_direccion { get; set; }
        public string cliente_email { get; set; }
        public string cliente_email_1 { get; set; }
        public string cliente_email_2 { get; set; }
        public DateTime fecha_de_emision { get; set; }
        public DateTime fecha_de_vencimiento { get; set; }
        public int moneda { get; set; }
        public dynamic tipo_de_cambio { get; set; } //? MAKES NATURAL TYPES NULLABLE
        public double porcentaje_de_igv { get; set; }
        public dynamic descuento_global { get; set; }
        public dynamic total_descuento { get; set; }
        public dynamic total_anticipo { get; set; }
        public dynamic total_gravada { get; set; }
        public dynamic total_inafecta { get; set; }
        public dynamic total_exonerada { get; set; }
        public double total_igv { get; set; }
        public dynamic total_gratuita { get; set; }
        public dynamic total_otros_cargos { get; set; }
        public double total { get; set; }
        public dynamic percepcion_tipo { get; set; }
        public dynamic percepcion_base_imponible { get; set; }
        public dynamic total_percepcion { get; set; }
        public dynamic total_incluido_percepcion { get; set; }
        public bool detraccion { get; set; }
        public string observaciones { get; set; }
        public dynamic documento_que_se_modifica_tipo { get; set; }
        public string documento_que_se_modifica_serie { get; set; }
        public dynamic documento_que_se_modifica_numero { get; set; }
        public dynamic tipo_de_nota_de_credito { get; set; }
        public dynamic tipo_de_nota_de_debito { get; set; }
        public bool enviar_automaticamente_a_la_sunat { get; set; }
        public bool enviar_automaticamente_al_cliente { get; set; }
        public string codigo_unico { get; set; }
        public string condiciones_de_pago { get; set; }
        public string medio_de_pago { get; set; }
        public string placa_vehiculo { get; set; }
        public string orden_compra_servicio { get; set; }
        public string tabla_personalizada_codigo { get; set; }
        public string formato_de_pdf { get; set; }
        public List<Items> items { get; set; }
        public List<Guias> guias { get; set; }
    }
    public class Items
    {
        public string unidad_de_medida { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public double cantidad { get; set; }
        public double valor_unitario { get; set; }
        public double precio_unitario { get; set; }
        public dynamic descuento { get; set; }
        public double subtotal { get; set; }
        public int tipo_de_igv { get; set; }
        public double igv { get; set; }
        public double total { get; set; }
        public bool anticipo_regularizacion { get; set; }
        public dynamic anticipo_comprobante_serie { get; set; }
        public dynamic anticipo_comprobante_numero { get; set; }
    }
    public class Guias
    {
        public int guia_tipo { get; set; }
        public string guia_serie_numero { get; set; }
    }
    public class Respuesta
    {
        public string errors { get; set; }
        public int tipo { get; set; }
        public string serie { get; set; }
        public int numero { get; set; }
        public string url { get; set; }
        public bool aceptada_por_sunat { get; set; }
        public string sunat_description { get; set; }
        public string sunat_note { get; set; }
        public string sunat_responsecode { get; set; }
        public string sunat_soap_error { get; set; }
        public string pdf_zip_base64 { get; set; }
        public string xml_zip_base64 { get; set; }
        public string cdr_zip_base64 { get; set; }
        public string cadena_para_codigo_qr { get; set; }
        public string codigo_hash { get; set; }
        public string codigo_de_barras { get; set; }
    }

}
