using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TaskRadacode
{   
    class ListMaker
    {         
        public async Task<List<Country>> GetCountryListAsync()
        {
            var result = new List<Country>();
            var task =
                await GetRequestAsync(@"http://api.vk.com/method/database.getCountries?need_all=1&count=230&v=5.60");

            var vk = JObject.Parse(task);

            foreach (var jsonCountry in vk["response"]["items"])
            {
                result.Add(JsonConvert.DeserializeObject<Country>(jsonCountry.ToString()));
            }
            return result;
        }
        public async Task<List<City>> GetCityListAsync(int idCountry, string q)
        {
            var result = new List<City>();
            var task =
                await GetRequestAsync(@"http://api.vk.com/method/database.getCities?need_all=1&count=100&country_id=" + idCountry+"&q="+q+"&v=5.60");

            var vk = JObject.Parse(task);

            foreach (var jsonCountry in vk["response"]["items"])
                result.Add(JsonConvert.DeserializeObject<City>(jsonCountry.ToString()));
            return result;
        }
        public async Task<List<University>> GetUnivListAsync(int idCountry, int idCity, string q)
        {
            var result = new List<University>();
            var task =
                await GetRequestAsync(@"http://api.vk.com/method/database.getUniversities?count=100&country_id=" + idCountry+ "&city_id="+idCity+ "&q=" +q+"&v=5.60");

            var vk = JObject.Parse(task);

            foreach (var jsonCountry in vk["response"]["items"])
                result.Add(JsonConvert.DeserializeObject<University>(jsonCountry.ToString()));
            return result;
        }

        private async Task<string> GetRequestAsync(string url)
        {
            using (var httpClient = new HttpClient())
                return await httpClient.GetStringAsync(url);
        }
      
    }
}
