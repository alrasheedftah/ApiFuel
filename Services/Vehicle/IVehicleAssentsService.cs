using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;

namespace ApiAppPetrol.Services
{   

    public  interface IVehicleAssentService
    {
        public  const int StatuseAgree = 1;
        public  const int StatuseComplated = 2;
//  
//631       15 
        // Task<List<MachineAssentResponse>> GetMachineAssents(int StationID);

        Task<List<AssentReportResponse>> GetVehicleAssents(int StationID,string strDate,string endSate, int FuelTypeParam,string FullName,int StatusID);

        Task<VechileAssentResponse> PostVehicleAssents(Guid QrCode,int StationID,string RoleName,string UserName, int TripAuthProviderID,int TripAuthID,int FromLocalityID,int ToLocalityID);

        Task<VechileAssentResponse> GetVehicleAssentByQR(Guid id);


       public  Task<bool> ValidStationVehicleAssent(Guid assentID,string StationID,string IMEI);//StationID
 
        // Withdraw
        
    }
}