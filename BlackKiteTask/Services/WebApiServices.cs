using BlackKiteTask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlackKiteTask
{
    static class WebApiServices
    {
        static string url = "https://seam.riskscore.cards/";
        static string serviceUrl = "";
        static HttpClient client = new HttpClient();

        static public Token SetToken
        {
            set
            {
                if (value != null)
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + value.access_token);
            }
        }
        public static async Task<string> GetEcosystems()
        {
            serviceUrl = $"{url}api/v2/ecosystems";
            using (HttpResponseMessage response = await client.GetAsync(serviceUrl))
                return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> GetAll()
        {
            serviceUrl = $"{url}api/v2/companies";
            using (HttpResponseMessage response = await client.GetAsync(serviceUrl))
                return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> GetOne(int id)
        {
            serviceUrl = $"{url}api/v2/companies/{id}";
            using (HttpResponseMessage response = await client.GetAsync(serviceUrl))
                return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> GetSummary(int id)
        {
            serviceUrl = $"{url}api/v2/companies/{id}/summary";
            using (HttpResponseMessage response = await client.GetAsync(serviceUrl))
                return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> Post<T>(T instance) where T : class, new()
        {
            serviceUrl = $"{url}api/v2/companies";
            StringContent httpContent = new StringContent(JsonConvert.SerializeObject(instance), Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await client.PostAsync(serviceUrl, httpContent))
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

        public static async Task<string> Search<T>(T instance) where T : class, new()
        {
            serviceUrl = $"{url}api/v2/companies/search";
            StringContent httpContent = new StringContent(JsonConvert.SerializeObject(instance), Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await client.PostAsync(serviceUrl, httpContent))
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

        public static async Task<string> Delete(int id)
        {
            serviceUrl = $"{url}api/personel/delete/{id}";
            using (HttpResponseMessage response = await client.DeleteAsync(serviceUrl))
                return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> GetToken(string clientId, string clientSecret)
        {
            using (var client = new HttpClient())
            {
                String serviceUrl = "https://seam.riskscore.cards//api/v2/oauth/token";
                List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", "clientCredentials" ),
                new KeyValuePair<string, string>("client_id", clientId ),
                new KeyValuePair<string, string> ("client_secret", clientSecret )
            };
                HttpContent content = new FormUrlEncodedContent(pairs);
                using (HttpResponseMessage response = await client.PostAsync(serviceUrl, content))
                    return await response.Content.ReadAsStringAsync();
            }
        }
    }

}
