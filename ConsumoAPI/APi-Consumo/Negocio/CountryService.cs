using APi_Consumo.Datos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APi_Consumo.Negocio
{
    public class CountryService
    {
        private readonly CountryAPI _api;

        public CountryService()
        {
            _api = new CountryAPI();
        }

        public async Task<List<Country>> ObtenerPaisesAsync()
        {
            return await _api.GetAllCountriesAsync();
        }
    }
}
