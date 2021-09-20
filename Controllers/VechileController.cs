using System;
using System.Linq;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using ApiAppPetrol.Exceptions;
using ApiAppPetrol.Extention;
using ApiAppPetrol.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ApiAppPetrol.Policies;

namespace ApiAppPetrol.Controllers
{ 
    [Authorize(AuthenticationSchemes = "Bearer")]
    // [Authorize(Roles = PoliciesCustom.SecurityAgent+","+PoliciesCustom.Station)] 
    [Authorize(Roles = PoliciesCustom.BusAssent+","+PoliciesCustom.TruckAssent)]
    [ApiController]
    [Produces("application/json")]   
    public class VechileController : ControllerBase
    {
        IVehicleService _VehicleService;
        // int StationID=0;
        public VechileController(IVehicleService vehicleService){
            _VehicleService = vehicleService;
        }

        // [Authorize(Policy = PoliciesCustom.Vechile)]
        [HttpGet(ApiRoutes.VechileRoute.getVechileQR)]
        public async Task <IActionResult> getVechileDataByQR([FromRoute]String QRCode){
            var VechileData= await _VehicleService.GetVehicleData(Guid.Parse(QRCode));
            return Ok(VechileData);
        }


    }
}