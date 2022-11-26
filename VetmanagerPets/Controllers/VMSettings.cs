using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace VetmanagerPets.Controllers
{
    public class VMSettings
    {
        private VMSettingsModel vmSettingsModel;
        private const string URL = "/token_auth.php";

        private string GetUrl()
        {
            return VetmanagerUrl.GetValidUrl(vmSettingsModel.domain);
        }

        private string GetAuthToken()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.PostAsync(GetUrl() + URL, FormContent()).Result.Content.ReadAsStringAsync().Result;
                    var parseJson = JObject.Parse(response.ToString());
                    var data = parseJson["data"];

                    return (string)data["token"];
                }
            }
            catch (Exception) { return null; }
        }

        public bool Save(string domain, string login, string password)
        {
            vmSettingsModel = new VMSettingsModel()
            {
                domain = domain,
                login = login,
                password = password
            };
            vmSettingsModel.token = GetAuthToken();

            if (vmSettingsModel.token != null)
            {
                return new Xml().WriteXML(vmSettingsModel);
            } else { return false; }
        }

        public bool Load()
        {
            vmSettingsModel = new Xml().ReadXML();

            if (vmSettingsModel != null)
                return true;
            else 
                return false;            
        }

        private FormUrlEncodedContent FormContent()
        {
            return new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("login", vmSettingsModel.login),
                    new KeyValuePair<string, string>("password", vmSettingsModel.password),
                    new KeyValuePair<string, string>("app_name", vmSettingsModel.appName)
                });
        }

        public string GetDomain()
        {
            return vmSettingsModel.domain;
        }

        public string GetLogin()
        {
            return vmSettingsModel.login;
        }

        public string GetToken()
        {
            return vmSettingsModel.token;
        }

        public string GetPass()
        {
            return vmSettingsModel.password;
        }

        public string GetAppName()
        {
            return vmSettingsModel.appName;
        }
    }
}
