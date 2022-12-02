using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;

namespace CHO
{
    public static class ClimaAPI
    {
        //private static readonly string baseURL = "https://api.openweathermap.org/data/3.0/onecall?";
        private static readonly string baseURL = "https://api.openweathermap.org/data/2.5/weather?";

        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }

        public static async Task<string> GetClima(string latt, string longt)
        {
            using (HttpClient client = new HttpClient())
            {
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "lat=" + latt + "&lon=" + longt + "&exclude=hourly,daily&lang=pt_br&appid=386c4fd2b0685a37ff131405fe7d5d39"))
                //using (HttpResponseMessage res = await client.GetAsync(baseURL + "lat=" + latt + "&lon=" + longt + "&lang=pt_br&appid=386c4fd2b0685a37ff131405fe7d5d39"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        //private static readonly string baseUrlEnd = "https://api.openweathermap.org/data/2.5/weather?";

        public static async Task<string> GetClimaEnd(string endereco)
        {
            using (HttpClient client = new HttpClient())
            {
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                //string enderecopercent = endereco.Replace(' ', '%');
                //using (HttpResponseMessage res = await client.GetAsync(baseUrlEnd + "q=" + endereco + "London,uk&appid=386c4fd2b0685a37ff131405fe7d5d39"))
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "q=" + endereco + "London,uk&appid=386c4fd2b0685a37ff131405fe7d5d39"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
    }
}

