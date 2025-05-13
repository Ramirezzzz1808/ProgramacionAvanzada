using COnsumoAPI.Datos;
using System.Threading.Tasks;

namespace ConsumoAPI.Negocio
{
    public class CatFactService
    {
        private readonly CatFactAPI _api;

        public CatFactService()
        {
            _api = new CatFactAPI();
        }

        public async Task<string> ObtenerDatoCurioso()
        {
            return await _api.ObtenerDatoGatoAsync();
        }
    }
}
