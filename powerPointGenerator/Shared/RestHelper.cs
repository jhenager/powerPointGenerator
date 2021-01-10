using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace powerPointGenerator.Shared
{
    public static class RestHelper
    {
        private static readonly string baseURL = "https://googleapis.com/customsearch/v1?";
        public static async Task<string> Get()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "AIzaSyCf7k2WdDDl8RPKpl5M3VmVct1RkeSXEE4&cx=7e04aeedfc86094c4"))
                {
                    using (HttpContent content =res.Content)
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
