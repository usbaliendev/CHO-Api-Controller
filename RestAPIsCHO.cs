using System;
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
            var resp = await CorreiosRestAPI.GetCEP(inptCEP.Text);
            rTBJson.Text = CorreiosRestAPI.BeautifyJson(resp);
            var stats = await GetStatus(inptCEP.Text);
            rTBStatusCode.Text = stats;
        }
    }
}
