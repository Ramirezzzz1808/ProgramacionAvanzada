using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APi_Consumo.Datos

{
    public class CountryAPI
    {
        private readonly HttpClient _http;

        public CountryAPI()
        {
            _http = new HttpClient();
        }

        public async Task<List<Country>> GetAllCountriesAsync()
        {
            string url = "https://restcountries.com/v3.1/all";
            var response = await _http.GetAsync(url);
            if (!response.IsSuccessStatusCode) return new List<Country>();

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Country>>(json);
        }
    }

    public class Country
    {
        public Name name { get; set; }
        public List<string> capital { get; set; }
        public string region { get; set; }
        public int population { get; set; }
        public Flags flags { get; set; }
        public override string ToString()
        {
            return name?.common ?? "Sin nombre";
        }
    }

    public class Name
    {
        public string common { get; set; }
    }

    public class Flags
    {
        public string png { get; set; }
    }

}

