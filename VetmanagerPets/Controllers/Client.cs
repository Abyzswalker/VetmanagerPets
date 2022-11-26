using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace VetmanagerPets.Controllers
{
    public class Client
    {
        private VMSettings vmSettings;
        private const string URL = "/rest/api/client";

        public Client()
        {
            vmSettings = new VMSettings();
            vmSettings.Load();
        }

        private string GetUrl()
        {
             return VetmanagerUrl.GetValidUrl(vmSettings.GetDomain()) + URL;
        }

        private List<ClientModel> GetData(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-USER-TOKEN", vmSettings.GetToken());
                    client.DefaultRequestHeaders.Add("X-MOBILE-APP", vmSettings.GetAppName());

                    var response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
                    var parseJson = JObject.Parse(response.ToString());
                    var data = parseJson["data"]["client"];

                    return data.ToObject<List<ClientModel>>();
                }
            }
            catch { return null; }
        }

        public List<ClientModel> GetAll()
        {
            List<ClientModel> clientModel = GetData(GetUrl());

            return GetClientsFullName(clientModel);
        }

        private List<ClientModel> GetClientsFullName(List<ClientModel> clientList)
        {
            for (int i = 0; i < clientList.Count; i++)
            {
                if (clientList[i] != null)
                {
                    clientList[i].full_name = clientList[i].last_name + " " + clientList[i].first_name;
                }
            }
            return clientList;
        }
    }
}
