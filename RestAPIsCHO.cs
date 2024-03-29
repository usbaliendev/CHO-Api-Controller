﻿using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CHO
{
    public partial class RestAPIsCHO : Form
    {
        public RestAPIsCHO()
        {
            InitializeComponent();
        }

        public static void UnloadTabpage(TabPage page)
        {
            while (page.Controls.Count > 0) page.Controls[0].Dispose();
        }

        private static readonly string baseURLCEP = "https://viacep.com.br/ws/";
        private static readonly string baseURLGeo = "https://geocode.xyz/";
        private static readonly string baseURLClima = "https://api.openweathermap.org/data/2.5/weather?";

        string nomebanco = ConfigurationManager.AppSettings["nomebanco"];
        string datasource = ConfigurationManager.AppSettings["datasource"];

        public static async Task<string> GetStatusCEP(string cepnum)
        {
            using (HttpClient client = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                using (HttpResponseMessage res = await client.GetAsync(baseURLCEP + cepnum + "/json/"))
                // using (HttpResponseMessage res = await client.GetAsync("https://viacep.com.br/ws/" + cepnum + "/json/"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string statusBar = (((int)res.StatusCode).ToString() + " - " + res.StatusCode.ToString());
                        if (statusBar != null)
                        {
                            return statusBar;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> GetStatusGEO(string lat, string longt)
        {
            using (HttpClient client = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                using (HttpResponseMessage res = await client.GetAsync(baseURLGeo + lat + "," + longt + "?geoit=json&auth=797165037426226490234x100731"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string statusBar = (((int)res.StatusCode).ToString() + " - " + res.StatusCode.ToString());
                        if (statusBar != null)
                        {
                            return statusBar;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> GetStatusGEOEnd(string endereco)
        {
            using (HttpClient client = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                string enderecopercent = endereco.Replace(' ', '%');
                using (HttpResponseMessage res = await client.GetAsync(baseURLGeo + enderecopercent + "?json=1"))

                {
                    using (HttpContent content = res.Content)
                    {
                        System.Console.WriteLine(res);
                        string statusBar = (((int)res.StatusCode).ToString() + " - " + res.StatusCode.ToString());
                        if (statusBar != null)
                        {
                            return statusBar;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> GetStatusClima(string latt, string longt)
        {
            using (HttpClient client = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                using (HttpResponseMessage res = await client.GetAsync(baseURLClima + "lat=" + latt + "&lon=" + longt + "&exclude=hourly,daily&lang=pt_br&appid=386c4fd2b0685a37ff131405fe7d5d39"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string statusBar = (((int)res.StatusCode).ToString() + " - " + res.StatusCode.ToString());
                        if (statusBar != null)
                        {
                            return statusBar;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> GetStatusClimaEnd(string endereco)
        {
            using (HttpClient client = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                using (HttpResponseMessage res = await client.GetAsync(baseURLClima + "q=" + endereco + "London,uk&appid=386c4fd2b0685a37ff131405fe7d5d39"))
                {
                    using (HttpContent content = res.Content)
                    {
                        System.Console.WriteLine(res);
                        string statusBar = (((int)res.StatusCode).ToString() + " - " + res.StatusCode.ToString());
                        if (statusBar != null)
                        {
                            return statusBar;
                        }
                    }
                }
            }
            return string.Empty;
        }


        private async void btnGetCEP_Click(object sender, EventArgs e)
        {
            var resp = await CorreiosRestAPI.GetCEP(inptCEP.Text);
            rTBJson.Text = CorreiosRestAPI.BeautifyJson(resp);
            var stats = await GetStatusCEP(inptCEP.Text);
            rTBStatusCode.Text = stats;

            string tipoServ = "CEP Consulta";
            string username = Dns.GetHostEntry(Environment.MachineName).HostName;

            //string hora = DateTime.Now.ToShortTimeString();
            //string hora = DateTime.Now.ToString("pt-BR");
            //string dataHora = data+hora;
            DateTime data = DateTime.Now;
            string dataHora = data.ToString("G", CultureInfo.GetCultureInfo("pt-BR"));



            SqlConnection con = new SqlConnection($"Data Source={datasource};Initial Catalog={nomebanco};Integrated Security=True");
            string sql = "INSERT INTO dados(nomeUsuario, cep, tipo_serv, dataModf, feedback) VALUES (@nomeUsuario, @cep, @tipo_serv, @dataModf, @feedback)";

            try
            {
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.Add(new SqlParameter("@nomeUsuario", username));
                com.Parameters.Add(new SqlParameter("@cep", this.inptCEP.Text));
                com.Parameters.Add(new SqlParameter("@tipo_serv", tipoServ));
                com.Parameters.Add(new SqlParameter("@dataModf", dataHora));
                com.Parameters.Add(new SqlParameter("@feedback", stats));

                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Valores atribuídos à tabela.");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private async void btnGetGEO_Click(object sender, EventArgs e)
        {
            var resp = await GeoLocAPI.GetGeoLoc(txtBLat1.Text, txtBLong1.Text);
            rTBGeoLocJson.Text = GeoLocAPI.BeautifyJson(resp);
            var stats = await GetStatusGEO(txtBLat1.Text, txtBLong1.Text);
            rTBGeoStats.Text = stats;

            string tipoServ = "GEOLoc Coordenada";
            string username = Dns.GetHostEntry(Environment.MachineName).HostName;

            DateTime data = DateTime.Now;
            string dataHora = data.ToString("G", CultureInfo.GetCultureInfo("pt-BR"));

            SqlConnection con = new SqlConnection($"Data Source={datasource};Initial Catalog={nomebanco};Integrated Security=True");
            string sql = "INSERT INTO dados(nomeUsuario, latitude, longitude, tipo_serv, dataModf, feedback) VALUES (@nomeUsuario, @latitude, @longitude, @tipo_serv, @dataModf, @feedback)";

            try
             {
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.Add(new SqlParameter("@nomeUsuario", username));
                com.Parameters.Add(new SqlParameter("@latitude", this.txtBLat1.Text));
                com.Parameters.Add(new SqlParameter("@longitude", this.txtBLong1.Text));
                com.Parameters.Add(new SqlParameter("@tipo_serv", tipoServ));
                com.Parameters.Add(new SqlParameter("@dataModf", dataHora));
                com.Parameters.Add(new SqlParameter("@feedback", stats));

                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Valores atribuídos à tabela.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private async void btnGetGeoEnd_Click(object sender, EventArgs e)
        {
            var resp = await GeoLocAPI.GetGeoLocEnd(txtBGeoEndereco.Text);
            rTBGeoLocJson.Text = GeoLocAPI.BeautifyJson(resp); 
            var stats = await GetStatusGEOEnd(txtBGeoEndereco.Text);
            rTBGeoStats.Text = stats;

            string tipoServ = "GEOLoc Endereço";
            string username = Dns.GetHostEntry(Environment.MachineName).HostName;

            DateTime data = DateTime.Now;
            string dataHora = data.ToString("G", CultureInfo.GetCultureInfo("pt-BR"));

            SqlConnection con = new SqlConnection($"Data Source={datasource};Initial Catalog={nomebanco};Integrated Security=True");
            string sql = "INSERT INTO dados(nomeUsuario, endereco, tipo_serv, dataModf, feedback) VALUES (@nomeUsuario, @endereco, @tipo_serv, @dataModf, @feedback)";

            try
            {
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.Add(new SqlParameter("@nomeUsuario", username));
                com.Parameters.Add(new SqlParameter("@endereco", this.txtBGeoEndereco.Text));
                com.Parameters.Add(new SqlParameter("@tipo_serv", tipoServ));
                com.Parameters.Add(new SqlParameter("@dataModf", dataHora));
                com.Parameters.Add(new SqlParameter("@feedback", stats));

                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Valores atribuídos à tabela.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private async void btnGetClimaCoord_Click(object sender, EventArgs e)
        {
            var resp = await ClimaAPI.GetClima(txtBLat2.Text, txtBLong2.Text);
            rTBClimaLocJson.Text = ClimaAPI.BeautifyJson(resp);
            var stats = await GetStatusClima(txtBLat2.Text, txtBLong2.Text);
            rTBClimaStats.Text = stats;

            string tipoServ = "CLIMA Coordenada";
            string username = Dns.GetHostEntry(Environment.MachineName).HostName;

            DateTime data = DateTime.Now;
            string dataHora = data.ToString("G", CultureInfo.GetCultureInfo("pt-BR"));

            SqlConnection con = new SqlConnection($"Data Source={datasource};Initial Catalog={nomebanco};Integrated Security=True");
            string sql = "INSERT INTO dados(nomeUsuario, latitude, longitude, tipo_serv, dataModf, feedback) VALUES (@nomeUsuario, @latitude, @longitude, @tipo_serv, @dataModf, @feedback)";

            try
            {
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.Add(new SqlParameter("@nomeUsuario", username));
                com.Parameters.Add(new SqlParameter("@latitude", this.txtBLat2.Text));
                com.Parameters.Add(new SqlParameter("@longitude", this.txtBLong2.Text));
                com.Parameters.Add(new SqlParameter("@tipo_serv", tipoServ));
                com.Parameters.Add(new SqlParameter("@dataModf", dataHora));
                com.Parameters.Add(new SqlParameter("@feedback", stats));

                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Valores atribuídos à tabela.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private async void btnGetClimaEnd_Click(object sender, EventArgs e)
        {
            var resp = await ClimaAPI.GetClimaEnd(txtBClimaEndereco.Text);
            rTBClimaLocJson.Text = ClimaAPI.BeautifyJson(resp);
            var stats = await GetStatusClimaEnd(txtBClimaEndereco.Text);
            rTBClimaStats.Text = stats;

            string tipoServ = "CLIMA Endereço";
            string username = Dns.GetHostEntry(Environment.MachineName).HostName;

            DateTime data = DateTime.Now;
            string dataHora = data.ToString("G", CultureInfo.GetCultureInfo("pt-BR"));

            SqlConnection con = new SqlConnection($"Data Source={datasource};Initial Catalog={nomebanco};Integrated Security=True");
            string sql = "INSERT INTO dados(nomeUsuario, endereco, tipo_serv, dataModf, feedback) VALUES (@nomeUsuario, @endereco, @tipo_serv, @dataModf, @feedback)";

            try
            {
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.Add(new SqlParameter("@nomeUsuario", username));
                com.Parameters.Add(new SqlParameter("@endereco", this.txtBClimaEndereco.Text));
                com.Parameters.Add(new SqlParameter("@tipo_serv", tipoServ));
                com.Parameters.Add(new SqlParameter("@dataModf", dataHora));
                com.Parameters.Add(new SqlParameter("@feedback", stats));

                con.Open();
                com.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Valores atribuídos à tabela.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnClearGeo_Click(object sender, EventArgs e)
        {
            rTBGeoLocJson.Clear();
            rTBGeoStats.Clear();
            txtBGeoEndereco.Clear();
            txtBLat1.Clear();
            txtBLong1.Clear();
        }

        private void btnClimaClear_Click(object sender, EventArgs e)
        {
            rTBClimaLocJson.Clear();
            rTBClimaStats.Clear();
            txtBClimaEndereco.Clear();
            txtBLat2.Clear();
            txtBLong2.Clear();
        }

        private void tabAPIControl_Click(object sender, EventArgs e)
        {
            inptCEP.Clear();
            rTBStatusCode.Clear();
            rTBJson.Clear();
            txtBLat1.Clear();
            txtBLong1.Clear();
            txtBGeoEndereco.Clear();
            rTBGeoLocJson.Clear();
            rTBGeoStats.Clear();
            txtBLat2.Clear();
            txtBLong2.Clear();
            txtBClimaEndereco.Clear();
            rTBClimaLocJson.Clear();
            rTBClimaStats.Clear();
        }

        
    }
}
