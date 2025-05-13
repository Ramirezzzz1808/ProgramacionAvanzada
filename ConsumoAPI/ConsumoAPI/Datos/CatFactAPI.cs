using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace COnsumoAPI.Datos
{
    public class CatFactAPI
    {
        private readonly HttpClient _httpClient;

        public CatFactAPI()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> ObtenerDatoGatoAsync()
        {
            var respuesta = await _httpClient.GetAsync("https://catfact.ninja/fact");
            if (respuesta.IsSuccessStatusCode)
            {
                var json = await respuesta.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<CatFactResponse>(json);
                return resultado.fact;
            }
            return "Error al obtener el dato.";
        }
    }

    public class CatFactResponse
    {
        public string fact { get; set; }
        public int length { get; set; }
    }
}
