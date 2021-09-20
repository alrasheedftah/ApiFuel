using System.Collections.Generic;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using WebApplication1.Models;

namespace ApiAppPetrol.Services
{   

    public  interface IMachineAssentServices
    {
        public  const int StatuseAgree = 1;
        public  const int StatuseComplated = 2;


        // Task<List<MachineAssentResponse>> GetMachineAssents(int StationID);

        Task<List<ReportsResponse>> GetMachineAssents(int StationID,string strDate,string endSate, int FuelTypeParam,string FullName,int StatusID);

        PagedList<ReportsResponse> GetTest(int StationID,string strDate,string endSate, int FuelTypeParam,string FullName);

        Task<MachineAssentResponse> GetMachineAssentById(long id);

        Task<bool> UpdateMachineAssents(long AssentID);

       public  Task<bool> ValidStationAssent(long assentID,string StationID,string IMEI);//StationID

        // Withdraw
        
    }
}