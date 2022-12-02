using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;

namespace CHO
{
    public static class GeoLocAPI
    {
        private static readonly string baseURL = "https://geocode.xyz/";

        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }

        public static async Task<string> GetGeoLoc(string latt, string longt)
        {
            using (HttpClient client = new HttpClient())
            {
                //decimal tempLat = decimal.Parse(latt);
                //decimal tempLong = decimal.Parse(longt);
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                //using (HttpResponseMessage res = await client.GetAsync(baseURL + tempLat + "," + tempLong + "geoit=JSONp&auth=797165037426226490234x100731"))
                using (HttpResponseMessage res = await client.GetAsync(baseURL + latt + "," + longt + "?geoit=json&auth=797165037426226490234x100731"))
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

        public static async Task<string> GetGeoLocEnd(string endereco)
        {
            using (HttpClient client = new HttpClient())
            {
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                //using (HttpResponseMessage res = await client.GetAsync(baseURL + tempLat + "," + tempLong + "geoit=JSONp&auth=797165037426226490234x100731"))
                //string enderecotratado = Uri.EscapeDataString(baseURL + endereco + "?json=1");
                string enderecopercent = endereco.Replace(' ', '%');
                System.Console.WriteLine(enderecopercent);
                using (HttpResponseMessage res = await client.GetAsync(baseURL + enderecopercent + "?json=1"))
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
