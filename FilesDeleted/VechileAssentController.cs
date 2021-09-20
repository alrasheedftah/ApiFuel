using System.Linq;
using System.Threading.Tasks;
using ApiAppPetrol.Extention;
using ApiAppPetrol.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiAppPetrol.Controllers
{
    //    [Authorize]    
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Produces("application/json")]
    // [Route("[controller]")]
    public class VechileAssentController : ControllerBase
    {
        IVehicleAssentServices _vehicleAssentServices;

        public VechileAssentController(IVehicleAssentServices vehicleAssentServices){
            _vehicleAssentServices = vehicleAssentServices;
        }

        [HttpGet(ApiRoutes.VechileRoute.getAll)]
        public async Task<IActionResult> getAll(){


            var StationID = HttpContext.GetStationID();
            int stID = 0,FuelType=0,StatusID=0;
            string FullName= Request.Query["fullName"].ToString();
            // return Ok(FullName);
            int.TryParse(Request.Query["fuelType"].ToString(),out FuelType);
            int.TryParse(StationID, out stID);
            var strDate=Request.Query["strDate"];
            var endDate=Request.Query["endDate"];
            int.TryParse(Request.Query["StatusID"],out StatusID);
            var page=1;
            int.TryParse(Request.Query["page"],out page);

            var VAssent =await _vehicleAssentServices.GetVehicleAssents(stID,strDate,endDate,FuelType,FullName,StatusID);
            return Ok(VAssent.AsQueryable().GetPaged(page,15));
            
        }

        [HttpGet(ApiRoutes.VechileRoute.getVechile)]
        public async Task<IActionResult> Get([FromRoute] long AssentID){


            var vechileAssent=await  _vehicleAssentServices.GetVehicleAssentById(AssentID);
            if(vechileAssent == null)
                return NotFound(" Sory This AssentID not Exisit ");

                return Ok(vechileAssent);

        }

        [HttpPut(ApiRoutes.VechileRoute.UpdateWithdraw)]
        public async Task<IActionResult> UpdateWithdraw([FromRoute] long AssentID){
            var ValidStation= await _vehicleAssentServices.ValidStationAssent(AssentID,HttpContext.GetStationID());
            if(!ValidStation){
                return BadRequest(new {error = "Sory The AssentId Not Agree To Make opertaion "});
            }

            // var updatedAssent= await _vehicleAssentServices.UpdateVehicleAssent(AssentID);
            // if()
            return Ok("Withdrawed");

        }
    
    }


}