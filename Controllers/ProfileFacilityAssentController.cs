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
    [Authorize(Roles = PoliciesCustom.SecurityAgent+","+PoliciesCustom.Station)] 
    [ApiController]
    [Produces("application/json")]   
    public class ProfileFacilityAssentController : ControllerBase
    {
        IProfileFacilityAssentService _profileFacilityAssentService;
        // int StationID=0;
        public ProfileFacilityAssentController(IProfileFacilityAssentService profileFacilityAssentService){
            _profileFacilityAssentService = profileFacilityAssentService;
            
        }

        [Authorize(Policy = PoliciesCustom.Station)]
        [HttpGet(ApiRoutes.MachineRoute.getAll)]
        public async Task<IActionResult> getAll()
        {

            var StationID = HttpContext.GetStationID();
 
            int stID = 0,FuelType=0,StatusID=0;
            string FullName= Request.Query["fullName"].ToString();
            int.TryParse(Request.Query["fuelType"].ToString(),out FuelType);
            int.TryParse(StationID, out stID);
            var strDate=Request.Query["strDate"];
            var endDate=Request.Query["endDate"];
            var page=1;
            int.TryParse(Request.Query["page"],out page);
            int.TryParse(Request.Query["StatusID"],out StatusID);

            // return Ok(DateTime.Parse(strDate).Date>=DateTime.Parse("2020-07-08T00:00:00"));//DateTime.Now.Date.AddDays(2));


            //  First Get StationID from Current user Then Pass To The Method 
            var mAssent = await _profileFacilityAssentService.GetProfileFacilityAssents(stID,strDate,endDate,FuelType,FullName,StatusID);
        //   return Ok("ana");
            return Ok(mAssent.AsQueryable().GetPaged2(page,15));//.GetSum());
            
        }
        [HttpGet(ApiRoutes.MachineRoute.getMachineID)]
        public async Task<IActionResult> Get([FromRoute] string AssentQR){
            // return Ok(Guid.NewGuid());
            var machineAssent=await  _profileFacilityAssentService.GetProfileFacilityAssentByQR(Guid.Parse(AssentQR));
            if(machineAssent == null)
            throw new HttpResponseException(){ Status = 404 ,Value = new ErrorsResponse{
            Errors = new[] { "The Specific Id Not Found " },
            Success = false
        }};
 
                return Ok(machineAssent);

        }

        [Authorize(Policy = PoliciesCustom.Station)]        
        [HttpPut(ApiRoutes.MachineRoute.UpdateWithdraw)]
        public async Task<IActionResult> UpdateWithdraw([FromRoute] string AssentQR){

            var ValidStation= await _profileFacilityAssentService.ValidStationProfileFacilityAssent(Guid.Parse(AssentQR),HttpContext.GetStationID(),HttpContext.GetIMEI());
            if(!ValidStation){
                return BadRequest(new {error = "Sory The AssentId Not Agree To Make opertaion "});
            }
 
            
            return Ok(new {message="Success Withdrowed ",success=true});

        }
    }
}