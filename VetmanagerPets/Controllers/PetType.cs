using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace VetmanagerPets.Controllers
{
    internal class PetType
    {
        private VMSettings vmSettings;
        private const string URL = "/rest/api/PetType";

        public PetType()
        {
            vmSettings = new VMSettings();
            vmSettings.Load();
        }
        private string GetUrl()
        {
            return VetmanagerUrl.GetValidUrl(vmSettings.GetDomain()) + URL;
        }
        private string GetUrl(string filter)
        {
            return VetmanagerUrl.GetValidUrl(vmSettings.GetDomain()) + URL + filter;
        }
        private List<PetTypeModel> GetData(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-USER-TOKEN", vmSettings.GetToken());
                    client.DefaultRequestHeaders.Add("X-MOBILE-APP", vmSettings.GetAppName());

                    var response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;

                    var parseJson = JObject.Parse(response.ToString());
                    var data = parseJson["data"]["petType"];

                    return data.ToObject<List<PetTypeModel>>();
                }
            }
            catch { return null; }
        }
        public string Get(uint petTypeId)
        {
            List<PetTypeModel> petType = GetData(GetUrl(Filter.Get("id", petTypeId)));

            for (int i = 0; i < petType.Count; i++)
            {
                if (petType[i].id == petTypeId)
                {
                    return petType[i].title;
                }
            }
            return "Неизвестно";
        }
        public List<PetTypeModel> GetAll()
        {
            return GetData(GetUrl());
        }
    }
}
