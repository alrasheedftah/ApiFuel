using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;

namespace ApiAppPetrol.Services
{   

    public  interface IVehicleService
    {
        Task<VechileResponse> GetVehicleData(Guid QRcode);

    }
}