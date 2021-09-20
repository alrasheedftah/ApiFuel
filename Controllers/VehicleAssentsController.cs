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
    public class VehicleAssentsController : ControllerBase
    {
        IVehicleAssentService _VehicleAssentService;
        // int StationID=0;
        public VehicleAssentsController(IVehicleAssentService vehicleAssentService){
            _VehicleAssentService = vehicleAssentService;
            
        }


        [HttpGet(ApiRoutes.AssentVechileRoute.getVehicleAssentByQR)]
        public async Task<IActionResult> Get([FromRoute] string AssentQR){
            // return Ok(Guid.NewGuid());
            var VehicleAssent=await  _VehicleAssentService.GetVehicleAssentByQR(Guid.Parse(AssentQR));
            if(VehicleAssent == null)
            throw new HttpResponseException(){ Status = 404 ,Value = new ErrorsResponse{
            Errors = new[] { "The Specific Id Not Found " },
            Success = false
        }};
 
                return Ok(VehicleAssent);

        }

       
      [Authorize(Policy = PoliciesCustom.BusAssent)]        
        [HttpPut(ApiRoutes.AssentVechileRoute.PostVehicleAssent)]
        public async Task<IActionResult> PostVehicleAssent([FromForm] string AssentQR){

            var newAssent= await _VehicleAssentService.PostVehicleAssents(Guid.Parse(AssentQR),1,"BusAssent","ana",1,1,1,1);
            if(newAssent ==null){
                return BadRequest(new {error = "Sory The AssentId Not Agree To Make opertaion "});
            }
 
            
            return Ok(newAssent);

        }

        
    }
}