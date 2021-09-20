using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using WebApplication1.Models;

namespace ApiAppPetrol.Services
{   

    public  interface IProfileFacilityAssentService
    {
        public  const int StatuseAgree = 1;
        public  const int StatuseComplated = 2;


        // Task<List<MachineAssentResponse>> GetMachineAssents(int StationID);

        Task<List<AssentReportResponse>> GetProfileFacilityAssents(int StationID,string strDate,string endSate, int FuelTypeParam,string FullName,int StatusID);

        PagedList<ReportsResponse> GetTest(int StationID,string strDate,string endSate, int FuelTypeParam,string FullName);

        Task<AssentResponse> GetProfileFacilityAssentByQR(Guid id);

        Task<bool> UpdateProfileFacilityAssents(long AssentID);

       public  Task<bool> ValidStationProfileFacilityAssent(Guid assentID,string StationID,string IMEI);//StationID

        // Withdraw
        
    }
}