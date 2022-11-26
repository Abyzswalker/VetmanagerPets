using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace VetmanagerPets
{
    internal static class VetmanagerUrl
    {
        private const string URL = "https://billing-api.vetmanager.cloud/host/";

        public static string GetValidUrl(string domain)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync(URL + domain).Result.Content.ReadAsStringAsync().Result;
                    var parseJson = JObject.Parse(response.ToString());

                    return "https://" + parseJson["url"];
                };
            }
            catch (Exception) { return null; }            
        }
    }
}
