using System.Collections.Generic;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;

namespace ApiAppPetrol.Services
{

    public  interface IStationService
    {
       

        Task<StationResponse> GetStationById(int id);
        Task<List<StationResponse>> GetStationsCompanyById(int Compid,List<int> localID);

        Task<List<OnRoadQuotaResponse>> GetOnRoadQuota(int stationID);

        Task<bool> PutOnRoadQuota(int stationID,int onRoadID,string UserName);

        Task<List<StationResponse>> getStationsList(string roleName,string UserName,int LocalityID,int fuelID,int duelTypeID);

        // string GetStationById();  
        
    }
}