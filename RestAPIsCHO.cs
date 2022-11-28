using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHO
{
    public partial class RestAPIsCHO : Form
    {
        public RestAPIsCHO()
        {
            InitializeComponent();
        }

        private readonly static string baseURL = "https://viacep.com.br/ws/";
        
        public static async Task<string> GetStatus(string cepnum)
        {
            using (HttpClient client = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                using (HttpResponseMessage res = await client.GetAsync(baseURL + cepnum + "/json/"))
                // using (HttpResponseMessage res = await client.GetAsync(baseURL))
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

        public static async Task<string> GetStatusCode(string cepnum)
        {
            using (HttpClient client = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                using (HttpResponseMessage res = await client.GetAsync(baseURL + cepnum + "/json/"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string result = ((int)res.StatusCode).ToString();
                        return result;
                    }
                }
            }
        }

        private void MensagemConfirmacao()
        {
            Timer timer = new Timer();
            timer.Interval = 5000;
            MessageBox.Show("Valores atribuídos à tabela.");
            timer.Start();
            
        }
        private void MensagemErro()
        {
            Timer timer = new Timer();
            timer.Interval = 5000;
            MessageBox.Show("Ocorreu um erro.");
            timer.Start();

        }


        private async void btnGetCEP_Click(object sender, EventArgs e)
        {
            var resp = await CorreiosRestAPI.GetCEP(inptCEP.Text);
            var statsCode = await GetStatusCode(inptCEP.Text);
            rTBJson.Text = statsCode;

            if (statsCode == "200")
            {    
                rTBJson.Text = CorreiosRestAPI.BeautifyJson(resp);
            }
            else if (statsCode == "400")
            {
                rTBJson.Text = "Link invalido!";
            }

            var stats = await GetStatus(inptCEP.Text);
            rTBStatusCode.Text = stats;

            string username = Dns.GetHostEntry(Environment.MachineName).HostName;

            DateTime date = DateTime.Today;
            string dataHora = date.ToString("G");

            SqlConnection con = new SqlConnection("Data Source=KAYDEN7-PC;Initial Catalog=CEP;Integrated Security=True");
            string sql = "INSERT INTO dados(id, nomeUsuario, cep, dataModf, feedback ) VALUES (@id, @nomeUsuario, @cep, @dataModf, @feedback)";

            Random contador = new Random();

            try
                {
                // for (int i = 0; i > 0; i++) {
                // contador++;

                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.Add(new SqlParameter("@id", contador.Next()));
                com.Parameters.Add(new SqlParameter("@nomeUsuario", username));
                com.Parameters.Add(new SqlParameter("@cep", this.inptCEP.Text));
                com.Parameters.Add(new SqlParameter("@dataModf", dataHora));
                com.Parameters.Add(new SqlParameter("@feedback", stats));

                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                MensagemConfirmacao();
                // }
                }

            catch (SqlException ex)
                {

                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.Add(new SqlParameter("@id", contador.Next()));
                com.Parameters.Add(new SqlParameter("@nomeUsuario", username));
                com.Parameters.Add(new SqlParameter("@cep", this.inptCEP.Text));
                com.Parameters.Add(new SqlParameter("@dataModf", dataHora));
                com.Parameters.Add(new SqlParameter("@feedback", stats));

                com.ExecuteNonQuery();
                con.Close();

                MensagemErro();
                MessageBox.Show(ex.Message);
                

            }
            finally { con.Close(); }
        }
    }
}
