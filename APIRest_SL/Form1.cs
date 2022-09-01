using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using APIRest_SL.ApiRest;
using System.Net;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using System.Runtime.Serialization.Json;
using System.Windows.Documents;
using System.Dynamic;
using System.Diagnostics;
using System.Configuration;

namespace APIRest_SL
{
    public partial class Form1 : Form
    {
        DBApi dBApi = new DBApi();
        private DataTable dt;
        //string _TokenSecret = null;
        public Form1()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void btnConexion_Click(object sender, EventArgs e)
        {
            var Servidor = ConfigurationSettings.AppSettings["Servidor"];
            var UsrSAP = ConfigurationSettings.AppSettings["UsrSAP"];
            var PswSAP = ConfigurationSettings.AppSettings["PswSAP"];
            var CmpSAP = ConfigurationSettings.AppSettings["CmpSAP"];


            DatosSL datos = new DatosSL
            {
                UserName = UsrSAP.ToString(),
                CompanyDB = CmpSAP.ToString(),
                Password = PswSAP.ToString()
            };

            string json_cadena = JsonConvert.SerializeObject(datos);
            dynamic resp = dBApi.Post(Servidor.ToString(), json_cadena);

            var json = JsonConvert.SerializeObject(resp);

            rtxtResult.Text = json;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
           
            DatosBP datos = new DatosBP
            {
                CardCode = txtCodigo.Text,
                CardName = txtNombre.Text,
                CardType = txtTipos.Text,
                FederalTaxID = txtRfc.Text
            };

            string json_cadena = JsonConvert.SerializeObject(datos);
            dynamic resp = dBApi.PostBusinessPartNers(json_cadena);

            rtxtResult.Text = resp.ToString();
            //MessageBox.Show(resp.ToString());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            respuesta _respuesta;

            DatosBP datos = new DatosBP
            {
                CardCode = txtCodigo.Text,
                CardName = txtNombre.Text,
                CardType = txtTipos.Text,
                FederalTaxID = txtRfc.Text
            };

            string json_cadena = JsonConvert.SerializeObject(datos);
            dynamic resp = dBApi.GetBusinessPartNers(json_cadena, txtCodigo.Text);

            if (resp != null)
            {
                var json = resp.ToString();
                _respuesta = System.Text.Json.JsonSerializer.Deserialize<respuesta>(json.ToString());
                dynamic IntermedioObject = JObject.Parse(json);           

                if (_respuesta.error != null)
            {
                string title = "Advertencia";
                string message = "Verifique la informacion del Panel";

                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                rtxtResult.Text = _respuesta.error.message.value.ToString();
                return;
            }
            else { 

            GetDatosBP getDatosBP = new GetDatosBP()
            {
                Codigo = IntermedioObject["CardCode"].ToString(),
                Nombre = IntermedioObject["CardName"].ToString(),
                Tipo = IntermedioObject["CardType"].ToString(),
                RFC = IntermedioObject["FederalTaxID"].ToString(),

            };

                string title = "Exito";
                string message = "Se ha concluido con exito la busqueda";
                MessageBox.Show(message, title);

                txtCodigo.Text = getDatosBP.Codigo.ToString();
                txtNombre.Text = getDatosBP.Nombre.ToString();
                txtTipos.Text = getDatosBP.Tipo.ToString();
                txtRfc.Text = getDatosBP.RFC.ToString();

                rtxtResult.Text = resp.ToString();

            }
            }
            else
            {
                string title = "Advertencia";
                string message = "Verifique la informacion del Panel";

                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                rtxtResult.Text = "No se encontro documento de busqueda" + Environment.NewLine + "O la conexion aun no fue abierta";
                return;
            }

        }

        private void btnCreaItem_Click(object sender, EventArgs e)
        {
            DatosItems datos = new DatosItems
            {
                ItemCode = txtItemCode.Text,
                ItemName = txtItemName.Text,
                ItemType = txtItemType.Text,
            };

            string json_cadena = JsonConvert.SerializeObject(datos);
            dynamic resp = dBApi.PostItemMaster(json_cadena);
            //MessageBox.Show(resp.ToString());

            rtxtResult.Text = resp.ToString();
        }

        private void btnBuscaItem_Click(object sender, EventArgs e)
        {
            respuesta _respuesta;

            DatosItems datos = new DatosItems
            {
                ItemCode = txtCodigo.Text,
                ItemName = txtNombre.Text,
            };

            string json_cadena = JsonConvert.SerializeObject(datos);
            dynamic resp = dBApi.GetBItemMaster(json_cadena, txtItemCode.Text);

            if (resp != null)
            {
                var json = resp.ToString();
            _respuesta = System.Text.Json.JsonSerializer.Deserialize<respuesta>(json.ToString());
            dynamic IntermedioObject = JObject.Parse(json);

            if (_respuesta.error != null)
            {
                string title = "Advertencia";
                string message = "Verifique la informacion del Panel";

                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                rtxtResult.Text = _respuesta.error.message.value.ToString();
                return;
            }
            else
            {

                GetDatosItems getDatosItem = new GetDatosItems()
                {
                    ItemCode = IntermedioObject["ItemCode"].ToString(),
                    ItemName = IntermedioObject["ItemName"].ToString(),
                    ItemType = IntermedioObject["ItemType"].ToString(),
                   

                };

                string title = "Exito";
                string message = "Se ha concluido con exito la busqueda";
                MessageBox.Show(message, title);

                txtItemCode.Text = getDatosItem.ItemCode.ToString();
                txtItemName.Text = getDatosItem.ItemName.ToString();
                txtItemType.Text = getDatosItem.ItemType.ToString();

                rtxtResult.Text = resp.ToString();

            }
        }
            else
            {
                string title = "Advertencia";
                string message = "Verifique la informacion del Panel";

                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                rtxtResult.Text = "No se encontro documento de busqueda" + Environment.NewLine + "O la conexion aun no fue abierta";
                return;
            }
}

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtItemCode.Text = "";
            txtItemName.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtRfc.Text = "";
            rtxtResult.Text = "";
            txtOdrTaxCode.Text = "";
            txtOdrQuantity.Text = "";
            txtOdrPrice.Text = "";
            txtOdrItemCode.Text = "";
            txtOdrDocDueDate.Text = "";
            txtOdrDocDate.Text = "";
            txtOdrCardCode.Text = "";
            txtDocNum.Text = "";
            DataTable dt =  (DataTable) dataGridView1.DataSource;
            if(dt != null) { dt.Clear(); }
            

        }

        private void btnGetOrdVenta_Click(object sender, EventArgs e)
        {
            respuesta _respuesta;

            List<Concepto> Lineas = new List<Concepto>();

            foreach (DataRow rows in dt.Rows)
            {
                Lineas.Add(new Concepto
                {
                    ItemCode = rows["Codigo"].ToString(),
                    Quantity = Convert.ToDecimal(rows["Cantidad"].ToString()),
                    UnitPrice = Convert.ToDecimal(rows["Precio"].ToString()),
                    TaxCode = rows["Indicador de Impuesto"].ToString(),
                });
            }

            ODV_Encabezado datos = new ODV_Encabezado
            {
                CardCode = txtOdrCardCode.Text,
                DocDate = txtOdrDocDate.Text,
                DocDueDate = txtOdrDocDueDate.Text,
                DocumentLines = Lineas,
            };         


            string json_cadena = JsonConvert.SerializeObject(datos);
            dynamic resp = dBApi.PostOrdenVenta(json_cadena);

            var json = resp.ToString();
            _respuesta = System.Text.Json.JsonSerializer.Deserialize<respuesta>(json.ToString());
            dynamic IntermedioObject = JObject.Parse(json);

            if (_respuesta.error != null)
            {
                string title = "Advertencia";
                string message = "Verifique la informacion del Panel";

                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                rtxtResult.Text = _respuesta.error.message.value.ToString();
                return;
            }
            else
            {
                string title = "Exito";
                string message = "Se ha concluido con exito la busqueda";
                MessageBox.Show(message, title);

                rtxtResult.Text = resp.ToString();

                txtOdrTaxCode.Text = "";
                txtOdrQuantity.Text = "";
                txtOdrPrice.Text = "";
                txtOdrItemCode.Text = "";
                txtOdrDocDueDate.Text = "";
                txtOdrDocDate.Text = "";
                txtOdrCardCode.Text = "";

                if (dt != null) { dt.Clear(); dataGridView1.DataSource = dt; }
                

            }
        }

        private void btnBuscarOV_Click(object sender, EventArgs e)
        {
            respuesta _respuesta;
            GET_ODV_Encabezado datos;

            if(string.IsNullOrEmpty(txtDocNum.Text))
            {
                MessageBox.Show("Debe de ingresar un numero de documento");
                    return;
            }

            GetDatosOV _datos = new GetDatosOV()
            {
                DocNum = Convert.ToInt32(txtDocNum.Text)
            };

            string json_cadena = JsonConvert.SerializeObject(_datos);
            dynamic resp = dBApi.GETOrdenVenta(json_cadena, Convert.ToInt16(txtDocNum.Text));

            if (resp != null)
            {
                var json = resp.ToString();
                _respuesta = System.Text.Json.JsonSerializer.Deserialize<respuesta>(json.ToString());
                datos = System.Text.Json.JsonSerializer.Deserialize<GET_ODV_Encabezado>(json.ToString()); 

                
                if (_respuesta.error != null)
                {
                    string title = "Advertencia";
                    string message = "Verifique la informacion del Panel";

                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    rtxtResult.Text = _respuesta.error.message.value.ToString();
                    return;
                }
                else
                {
                    using (DataTable dt = new DataTable())
                    {
                        dt.Columns.Add("No. Linea");
                        dt.Columns.Add("Codigo");
                        dt.Columns.Add("Descripcion");
                        dt.Columns.Add("Precio");
                        dt.Columns.Add("Cantidad");
                        dt.Columns.Add("Total");
                        dt.Columns.Add("Indicador de Impuesto");


                        foreach (var item in datos.DocumentLines)
                        {
                            dt.Rows.Add(item.LineNum, item.ItemCode, item.ItemDescription, item.Price, item.Quantity, item.LineTotal, item.TaxCode);
                        }

                        dataGridView1.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.DataSource = dt;
                    }

                    txtOdrCardCode.Text = datos.CardCode.ToString();
                    txtOdrDocDate.Text = datos.DocDate.ToString();
                    txtOdrDocDueDate.Text = datos.DocDueDate.ToString();

                    string title = "Exito";
                    string message = "Se ha concluido con exito la busqueda";
                    MessageBox.Show(message, title);

                    rtxtResult.Text = resp.ToString();

                }

            }
            else
            {
                string title = "Advertencia";
                string message = "Verifique la informacion del Panel";

                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                rtxtResult.Text = "No se encontro documento de busqueda" + Environment.NewLine + "O la conexion aun no fue abierta";
                return;
            }
            
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {

            DataRow row = dt.NewRow();

            int _NoLinea = dt.Rows.Count;

            row["No. Linea"] = _NoLinea;
            row["Codigo"] = txtOdrItemCode.Text;
            row["Precio"] = txtOdrPrice.Text;
            row["Cantidad"] = txtOdrQuantity.Text;
            row["Total"] = Convert.ToDecimal(txtOdrPrice.Text) * Convert.ToDecimal(txtOdrQuantity.Text);
            row["Indicador de Impuesto"] = txtOdrTaxCode.Text;
            dt.Rows.Add(row);



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("No. Linea");
            dt.Columns.Add("Codigo");
            //dt.Columns.Add("Descripcion");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Total");
            dt.Columns.Add("Indicador de Impuesto");
            dataGridView1.DataSource = dt;
        }

        private void btntbludf_Click(object sender, EventArgs e)
        {
            respuesta _respuesta;

            GetTBLUUID datos = new GetTBLUUID
            {
                SqlCode = "SQL01",
                //QueryCategory = "-1",
                //Query = "SELECT T0.[Code], T0.[Name], T0.[U_POLIZA], T0.[U_UUID], T0.[U_RFC], T0.[U_MONTO], T0.[U_FECHA] FROM [dbo].[@UUID_COM]  T0",

                SqlName= "QueryOnTB",
                SQLText = "SELECT T0.[Code], T0.[Name], T0.[U_POLIZA], T0.[U_UUID], T0.[U_RFC], T0.[U_MONTO], T0.[U_FECHA] FROM [dbo].[@UUID_COM]  T0"
            };

            string json_cadena = JsonConvert.SerializeObject(datos);
            dynamic resp = dBApi.GETTableUserDefined(json_cadena);

            if (resp != null)
            {
                var json = resp.ToString();
                _respuesta = System.Text.Json.JsonSerializer.Deserialize<respuesta>(json.ToString());
                dynamic IntermedioObject = JObject.Parse(json);

                if (_respuesta.error != null)
                {
                    string title = "Advertencia";
                    string message = "Verifique la informacion del Panel";

                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    rtxtResult.Text = _respuesta.error.message.value.ToString();
                    return;
                }
                else
                {

                   

                    string title = "Exito";
                    string message = "Se ha concluido con exito la busqueda";
                    MessageBox.Show(message, title);


                    rtxtResult.Text = resp.ToString();

                }
            }
            else
            {
                string title = "Advertencia";
                string message = "Verifique la informacion del Panel";

                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                rtxtResult.Text = "No se encontro documento de busqueda" + Environment.NewLine + "O la conexion aun no fue abierta";
                return;
            }


        }
    }

    #region Definicion de Propiedades
    public class DatosSL
        {
            public string UserName { get; set; }
            public string Password { get; set; }
            public string CompanyDB { get; set; }
        }

    public class DatosBP
    {
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string CardType { get; set; }
        public string FederalTaxID { get; set; }
    } 

    public class DatosItems
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
    }

    public class GetDatosItems
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }

    }

    public class GetDatosBP
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string RFC { get; set; }
    }

    class datamodel
    {
        public string SessionTimeout { get; set; }
        public string SessionId { get; set; }
        public string Version { get; set; }
    }

    class respuesta_error
    {
        public int code { get; set; }

        public respuesta_mensaje message { get; set; }
    }

    class respuesta_mensaje
    {
        public string lang { get; set; }
        public string value { get; set; }
    }

    class respuesta
    {
        public respuesta_error error { get; set; }        

    }

    public class Concepto
    {
        public string ItemCode { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public string TaxCode { get; set; }
    }

    class ODV_Encabezado
    {
        public string CardCode { get; set; }
        public string DocDate { get; set; }
        public string DocDueDate { get; set; }
        public string CardName { get; set; }

        public List<Concepto> DocumentLines { get; set; }
    }

    public class GetDatosOV
    {
        public int DocNum { get; set; }

    }

    public class GetTBLUUID
{        
       public string SqlCode { get; set; }
       //public string QueryCategory { get; set; }
       //public string QueryDescription { get; set; }
       public string SqlName { get; set; }
       public string SQLText { get; set; }
}

    public class GET_ODV_Encabezado
    {
        public string CardCode { get; set; }
        public string DocDate { get; set; }
        public string DocDueDate { get; set; }
        public string CardName { get; set; }

        public List<GET_ODV_Lineas> DocumentLines { get; set; }
    }

    public class GET_ODV_Lineas
    {
        public int LineNum { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public string TaxCode { get; set; }
        public decimal LineTotal { get; set; }
        public string Currency { get; set; }
    }
    #endregion
}
