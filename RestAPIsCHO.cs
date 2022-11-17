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
        public static async Task<string> GetStatus(string cepnum)
        {
            using (HttpClient client = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                using (HttpResponseMessage res = await client.GetAsync("https://viacep.com.br/ws/" + cepnum + "/json/"))
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
        private async void btnGetCEP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i > 0; i++) {
                var resp = await CorreiosRestAPI.GetCEP(inptCEP.Text);
                rTBJson.Text = CorreiosRestAPI.BeautifyJson(resp);
                var stats = await GetStatus(inptCEP.Text);
                rTBStatusCode.Text = stats;

                string username = Dns.GetHostEntry(Environment.MachineName).HostName;

                DateTime date = DateTime.Today;
                string dataHora = date.ToString("G");

                int contador = i+1;

                SqlConnection con = new SqlConnection("Data Source= DESKTOP-DUDU-ROG6KEL;Initial Catalog= CEP;Integrated Security=True");
                string sql = "INSERT INTO dados(id, nomeUsuario, cep, dataModf ) VALUES (@id, @nomeUsuario, @cep, @dataModf)";

                try
                {
                    SqlCommand com = new SqlCommand(sql, con);
                    com.Parameters.Add(new SqlParameter("@id", contador));
                    com.Parameters.Add(new SqlParameter("@nomeUsuario", username));
                    com.Parameters.Add(new SqlParameter("@cep", this.inptCEP.Text));
                    com.Parameters.Add(new SqlParameter("@dataModf", dataHora));

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Valores atribuídos à tabela.");

                } catch (SqlException ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex);
                }
                finally { con.Close(); }
        }
        }
    }
}
