using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Og_Guild_Bank.Models.Logging;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Models
{
    public class BlizzardApi
    {
        public string Token { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public BlizzardApi(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            Token = GetAccessToken();
        }

        public string GetAccessToken()
        {
            try
            {
                var client = new RestClient("https://us.battle.net/oauth/token");
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddParameter("application/x-www-form-urlencoded", $"grant_type=client_credentials&client_id={ClientId}&client_secret={ClientSecret}", ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                var tokenResponse = JsonConvert.DeserializeObject<AccessTokenResponse>(response.Content);

                return tokenResponse.access_token;
            }
            catch (Exception ex)
            {
                ErrorLog error = new ErrorLog { ErrorMessage = ex.Message };
                error.InsertToLog(null);
                return null;
            }
        }

        public string GetItemImage(int itemId)
        {
            var client = new RestClient(string.Format("https://us.api.blizzard.com/data/wow/media/item/{0}?namespace=static-classic-us&locale=en_US&access_token={1}", itemId, Token));
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            ItemMedia itemMedia = JsonConvert.DeserializeObject<ItemMedia>(response.Content);
            return (itemMedia.Assets == null) ? "https://render-classic-us.worldofwarcraft.com/icons/56/inv_misc_questionmark.jpg" : itemMedia.Assets[0].Value;
        }
    }

    public class AccessTokenResponse
    {
        public string access_token { get; set; }
    }

    public class ItemMedia
    {
        public dynamic _links { get; set; }
        public List<KeyValuePair> Assets { get; set; }
    }
    public class KeyValuePair
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

}
