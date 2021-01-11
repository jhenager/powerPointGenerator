using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace powerPointGenerator.Shared
{
    public static class RestHelper
    {
        private static readonly string baseURL = "https://www.googleapis.com/customsearch/v1?";
        public static async Task<string> Get(string input)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "key=AIzaSyBFdu1N5-OHqtNDv3L8UMZRu3_gh0PC_mQ&cx=7e04aeedfc86094c4" + "&searchType=image" + "&imgSize=medium" + "&q=" + input))
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
        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Newtonsoft.Json.Formatting.Indented);
        }
    }
}
