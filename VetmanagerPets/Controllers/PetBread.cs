using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace VetmanagerPets.Controllers
{
    internal class PetBread
    {
        private VMSettings vmSettings;
        private const string URL = "/rest/api/Breed";
        public PetBread()
        {
            vmSettings = new VMSettings();
            vmSettings.Load();
        }
        private string GetUrl(string filter)
        {
            return VetmanagerUrl.GetValidUrl(vmSettings.GetDomain()) + URL + filter;
        }
        private List<PetBreadModel> GetData(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-USER-TOKEN", vmSettings.GetToken());
                    client.DefaultRequestHeaders.Add("X-MOBILE-APP", vmSettings.GetAppName());

                    var response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;

                    var parseJson = JObject.Parse(response.ToString());
                    var data = parseJson["data"]["breed"];

                    return data.ToObject<List<PetBreadModel>>();
                }
            }
            catch { return null; }
        }
        public string Get(uint breedId)
        {
            List<PetBreadModel> petBreed = GetData(GetUrl(Filter.Get("id", breedId)));

            for (int i = 0; i < petBreed.Count; i++)
            {
                if (petBreed[i].id == breedId)
                {
                    return petBreed[i].title;
                }
            }
            return "Неизвестно";
        }
        public List<PetBreadModel> GetForType(uint typeId)
        {
            return GetData(GetUrl(Filter.Get("pet_type_id", typeId)));
        }
    }
}
