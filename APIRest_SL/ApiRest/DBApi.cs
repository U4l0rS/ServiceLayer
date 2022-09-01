using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace APIRest_SL.ApiRest
{
    public class DBApi
    {
        public CookieCollection Cookies;
        string _CadenaConexion = "https://";
        

        public dynamic Post(string url, string json)
        {
            try
            {
                url = url + "/b1s/v1/Login";
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;            

                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                _CadenaConexion = _CadenaConexion + client.BaseUrl.Authority;

                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK || response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    Cookies = AddCookies(response);

                }

                dynamic datos = JsonConvert.DeserializeObject(response.Content);


                
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public dynamic PostBusinessPartNers(string json)
        {
            try
            {
                dynamic datos = null;
                string _link = _CadenaConexion + "/b1s/v1/BusinessPartners";

                var client = new RestClient(_link);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                client.Timeout = -1;
                client.CookieContainer = new CookieContainer();
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                //request.AddHeader("Cookie", "B1SESSION="+Token.ToString()+"; ROUTEID=.node6");
                //request.AddHeader("Cookie", $"{Cookies[0].Name}={Cookies[0].Value}; {Cookies[1].Name}={Cookies[1].Value}");
                //client.CookieContainer.Add(new Uri("https://xam-uas-997f-l.scanda.com.mx"), this.Cookies);

                client.CookieContainer.Add(new Uri(_link), this.Cookies);
                json = json.Replace("\t", "").Replace("\r","").Replace("\n","");

                request.AddParameter("application/json", json, ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);

                if(response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
                {
                     datos = JsonConvert.DeserializeObject(response.Content);
                }                

                if(response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.Forbidden || response.StatusCode == HttpStatusCode.BadRequest)
                {
                    datos = JsonConvert.DeserializeObject(response.Content);
                }

                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public dynamic GetBusinessPartNers(string json, string _cardCode)
        {
            try
            {
                dynamic datos = null;

                string _link = _CadenaConexion + "/b1s/v1/BusinessPartners('" + _cardCode + "')?$select=CardCode,CardName,CardType,FederalTaxID";
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                var client = new RestClient(_link);
                client.Timeout = -1;
                client.CookieContainer = new CookieContainer();

                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");
                client.CookieContainer.Add(new Uri(_link), this.Cookies);
                json = @"";//json.Replace("\t", "").Replace("\r", "").Replace("\n", "");

                request.AddParameter("application/json", json, ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
                {
                    datos = JsonConvert.DeserializeObject(response.Content);
                }

                if (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.Forbidden || response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.NotFound)
                {
                    datos = JsonConvert.DeserializeObject(response.Content);
                }

                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

      
        public dynamic PostItemMaster(string json)
        {
            try
            {
                dynamic datos = null;
                string _link = _CadenaConexion + "/b1s/v1/Items";

                var client = new RestClient(_link);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                client.Timeout = -1;
                client.CookieContainer = new CookieContainer();
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");

                client.CookieContainer.Add(new Uri(_link), this.Cookies);
                json = json.Replace("\t", "").Replace("\r", "").Replace("\n", "");

                request.AddParameter("application/json", json, ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
                {
                    datos = JsonConvert.DeserializeObject(response.Content);
                }

                if (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.Forbidden || response.StatusCode == HttpStatusCode.BadRequest)
                {
                    datos = JsonConvert.DeserializeObject(response.Content);
                }

                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public dynamic GetBItemMaster(string json, string _ItemCode)
        {
            try
            {
                dynamic datos = null;

                string _link = _CadenaConexion + "/b1s/v1/Items('" + _ItemCode + "')?$select=ItemCode,ItemName, ItemType";
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                var client = new RestClient(_link);
                client.Timeout = -1;
                client.CookieContainer = new CookieContainer();

                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");
                client.CookieContainer.Add(new Uri(_link), this.Cookies);
                json = @"";//json.Replace("\t", "").Replace("\r", "").Replace("\n", "");

                request.AddParameter("application/json", json, ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
                {
                    datos = JsonConvert.DeserializeObject(response.Content);
                }

                if (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.Forbidden || response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.NotFound)
                {
                    datos = JsonConvert.DeserializeObject(response.Content);
                }

                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public dynamic PostOrdenVenta(string json)
        {
            try
            {
                dynamic datos = null;
                string _link = _CadenaConexion + "/b1s/v1/Orders";

                var client = new RestClient(_link);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                client.Timeout = -1;
                client.CookieContainer = new CookieContainer();
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");

                client.CookieContainer.Add(new Uri(_link), this.Cookies);
                json = json.Replace("\t", "").Replace("\r", "").Replace("\n", "");

                request.AddParameter("application/json", json, ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
                {
                    datos = JsonConvert.DeserializeObject(response.Content);
                }

                if (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.Forbidden || response.StatusCode == HttpStatusCode.BadRequest)
                {
                    datos = JsonConvert.DeserializeObject(response.Content);
                }

                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public dynamic GETOrdenVenta(string json, int _DocNum)
        {
            try
            {
                dynamic datos = null;
                string _link = _CadenaConexion + "/b1s/v1/Orders("+ _DocNum + ")";

                var client = new RestClient(_link);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                client.Timeout = -1;
                client.CookieContainer = new CookieContainer();
                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");

                client.CookieContainer.Add(new Uri(_link), this.Cookies);
                json = json.Replace("\t", "").Replace("\r", "").Replace("\n", "");

                request.AddParameter("application/json", json, ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
                {
                    datos = JsonConvert.DeserializeObject(response.Content);
                }

                if (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.Forbidden || response.StatusCode == HttpStatusCode.BadRequest)
                {
                    datos = JsonConvert.DeserializeObject(response.Content);
                }

                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public dynamic GETTableUserDefined(string json)
        {
            try
            {
                dynamic datos = null;
                string _link = _CadenaConexion + "/b1s/v1/SQLQueries";

                var client = new RestClient(_link);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                client.Timeout = -1;
                client.CookieContainer = new CookieContainer();
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                //request.AddHeader("Cookie", "B1SESSION="+Token.ToString()+"; ROUTEID=.node6");
                //request.AddHeader("Cookie", $"{Cookies[0].Name}={Cookies[0].Value}; {Cookies[1].Name}={Cookies[1].Value}");
                //client.CookieContainer.Add(new Uri("https://xam-uas-997f-l.scanda.com.mx"), this.Cookies);

                client.CookieContainer.Add(new Uri(_link), this.Cookies);
                json = json.Replace("\t", "").Replace("\r", "").Replace("\n", "");

                request.AddParameter("application/json", json, ParameterType.RequestBody);
                

                IRestResponse response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
                {
                    datos = JsonConvert.DeserializeObject(response.Content);
                }

                if (response.StatusCode == HttpStatusCode.InternalServerError || response.StatusCode == HttpStatusCode.NotFound || response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.Forbidden || response.StatusCode == HttpStatusCode.BadRequest)
                {
                    datos = JsonConvert.DeserializeObject(response.Content);
                }

                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private CookieCollection AddCookies(IRestResponse r)
        {
            CookieCollection oCookie = new CookieCollection();

            r.Cookies.ToList().ForEach((x) =>
            {
                oCookie.Add(new Cookie
                {
                    Name = x.Name,
                    Value = x.Value
                });
            });
            return oCookie;
        }
    }
}
