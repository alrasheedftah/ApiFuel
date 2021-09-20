using System.Collections.Generic;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using WebApplication1.Models;
namespace ApiAppPetrol.Services
{
    public  interface IVehicleAssentServices
    {

        public  const int StatuseAgree = 2;
        public  const int StatuseComplated = 0;


        Task<List<ReportsResponse>> GetVehicleAssents(int StationID,string strDate,string endSate, int FuelTypeParam,string FullName,int StatusID);

        Task<VechileAssentResponse> GetVehicleAssentById(long id);

        Task<bool> UpdateVehicleAssent(long AssentID);

       public  Task<bool> ValidStationAssent(long assentID,string StationID);//StationID



        // Withdraw
        
    }
       
    }
