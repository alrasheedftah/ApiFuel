using System.Collections.Generic;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;

namespace ApiAppPetrol.Services
{

    public  interface IFuelTypeServices
    {
       
        Task<List<FuelResponse>> GetFuelTypes();
        // string GetStationById();     
    }
}