using System.Collections.Generic;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;


namespace ApiAppPetrol.Services
{

    public  interface IRoadTypeService
    {
        Task<List<RoadTypeResponse>> GetAllRoadTypes();

    }
}