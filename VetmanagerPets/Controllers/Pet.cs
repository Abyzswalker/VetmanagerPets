using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using VetmanagerPets.Models;

namespace VetmanagerPets.Controllers
{
    public class Pet
    {
        private VMSettings vmSettings;
        private const string URL = "/rest/api/pet/";

        public Pet()
        {
            vmSettings = new VMSettings();
            vmSettings.Load()
;       }

        private string GetUrl()
        {
            return VetmanagerUrl.GetValidUrl(vmSettings.GetDomain()) + URL;
        }

        private string GetUrl(string filter)
        {
            return VetmanagerUrl.GetValidUrl(vmSettings.GetDomain()) + URL + filter;
        }   
        
        private List<PetModel> GetData(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-USER-TOKEN", vmSettings.GetToken());
                    client.DefaultRequestHeaders.Add("X-MOBILE-APP", vmSettings.GetAppName());

                    var response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
                    var parseJson = JObject.Parse(response.ToString());
                    var data = parseJson["data"]["pet"];

                    return data.ToObject<List<PetModel>>();
                }
            }
            catch { return null; }
        }
   
        public List<ClientsPetModel> GetPetsForClient(uint clientId)
        {
            PetType petType = new PetType();
            PetBread petBread = new PetBread();
            PetGender petGender = new PetGender();
            List<ClientsPetModel> ListClientsPetModel = new List<ClientsPetModel>();

            List<PetModel> petsList = GetData(GetUrl(Filter.Get("owner_id", clientId)));

            if (petsList != null)
            {
                for (int i = 0; i < petsList.Count; i++)
                {
                    ListClientsPetModel.Add(new ClientsPetModel()
                    {
                        id = petsList[i].id,
                        owner_id = petsList[i].owner_id,
                        type = petType.Get(petsList[i].type_id),
                        alias = petsList[i].alias,
                        sex = petGender.Get(petsList[i].sex),
                        birthday = petsList[i].birthday == null || petsList[i].birthday == "0000-00-00" ? "" : petsList[i].birthday,
                        breed = petBread.Get(petsList[i].breed_id),
                    });
                }
            }

            return ListClientsPetModel;
        }

        public List<PetModel> GetById(uint petId)
        {
            return GetData(GetUrl(Filter.Get("id", petId)));
        }

        public bool Add(uint clientId, string petAlias, uint typeId, uint breadId, string petSex, string birthday)
        {
            try
            {
                FormUrlEncodedContent formContent = FormContentForAdd(clientId, petAlias, typeId, breadId, petSex, birthday);

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-USER-TOKEN", vmSettings.GetToken());
                    client.DefaultRequestHeaders.Add("X-MOBILE-APP", vmSettings.GetAppName());

                    var response = client.PostAsync(GetUrl(), formContent).Result.Content.ReadAsStringAsync().Result;
                }
                return true;
            }
            catch (Exception) { return false; } 
        }

        public bool Edit(uint petId, string petAlias, uint typeId, uint breadId, string petSex, string birthday)
        {
            try
            {
                FormUrlEncodedContent formContent = FormContentForEdit(petAlias, typeId, breadId, petSex, birthday);

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-USER-TOKEN", vmSettings.GetToken());
                    client.DefaultRequestHeaders.Add("X-MOBILE-APP", vmSettings.GetAppName());

                    client.BaseAddress = new Uri(GetUrl());

                    var response = client.PutAsync(petId.ToString(), formContent).Result.Content.ReadAsStringAsync().Result;
                }
                return true;
            }
            catch (Exception) { return false; }
        }

        public bool Delete(uint petId)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-USER-TOKEN", vmSettings.GetToken());
                    client.DefaultRequestHeaders.Add("X-MOBILE-APP", vmSettings.GetAppName());

                    client.BaseAddress = new Uri(GetUrl());

                    var response = client.DeleteAsync(petId.ToString()).Result;
                }
                return true;
            }
            catch (Exception) { return false; }
        }

        private FormUrlEncodedContent FormContentForAdd(uint ownerId, string alias, uint typeId, uint breadId, string sex, string birthday)
        {
            return new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("owner_id", ownerId.ToString()),
                    new KeyValuePair<string, string>("alias", alias),
                    new KeyValuePair<string, string>("type_id", typeId.ToString()),
                    new KeyValuePair<string, string>("breed_id", breadId.ToString()),
                    new KeyValuePair<string, string>("sex", sex),
                    new KeyValuePair<string, string>("birthday", birthday)
                });
        }

        private FormUrlEncodedContent FormContentForEdit(string alias, uint typeId, uint breadId, string sex, string birthday)
        {
            return new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("alias", alias),
                    new KeyValuePair<string, string>("type_id", typeId.ToString()),
                    new KeyValuePair<string, string>("breed_id", breadId.ToString()),
                    new KeyValuePair<string, string>("sex", sex),
                    new KeyValuePair<string, string>("birthday", birthday)
                });
        }
    }
}
