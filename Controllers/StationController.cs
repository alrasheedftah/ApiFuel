using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using ApiAppPetrol.Exceptions;
using ApiAppPetrol.Extention;
using ApiAppPetrol.Policies;
using ApiAppPetrol.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
 
namespace ApiAppPetrol.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]  
    [Authorize(Roles = PoliciesCustom.SecurityAgent+","+PoliciesCustom.Station)]

    [ApiController]
    public class StationController : ControllerBase
    {
       private IStationService _stationService;
       ILocalityServices _localityServices;
        public StationController(IStationService stationService,ILocalityServices localityServices){
            _stationService = stationService;
            _localityServices=localityServices;

        }

 [HttpGet(ApiRoutes.StationsRoute.getStation)]
        public async Task<IActionResult> Get(){
            // return Ok(HttpContext.GetUserName());
            var StationID = HttpContext.GetStationID();
            int stID = 0;
            int.TryParse(StationID,out stID);
            
                //  First Get StationID from Current user Then Pass To The Method 
            var station=await  _stationService.GetStationById(stID);// ??null;
            if(station == null)
                throw new HttpResponseException(){ Status = 401 ,Value = new ErrorsResponse{
            Errors = new[] { "Not Register or Your Station  NOt  Activ " },
            Success = false
        }};

                return Ok(station);

        }
     
        [Authorize(Policy = PoliciesCustom.SecurityAgent)]
        [HttpGet(ApiRoutes.StationsRoute.show)]
        public async Task<IActionResult> show([FromRoute]int Stationid){

                var stationDetails= await _stationService.GetStationById(Stationid);
                    if(stationDetails == null)
                throw new HttpResponseException(){ Status = 404 ,Value = new ErrorsResponse{
            Errors = new[] { "Station Not Found   " },
            Success = false
        }};

                return Ok(stationDetails);

        } 

        // [Authorize(Policy = PoliciesCustom.SecurityAgent)]
        [HttpGet(ApiRoutes.CompanyRoute.getStationsCompany)]
        public async Task<IActionResult> getAllInCompany([FromRoute]int CompanyId){
                int localID=0;
                int.TryParse(Request.Query["localityID"].ToString(),out localID);
                var UserName=HttpContext.GetUserName();
                var localityIDs=await _localityServices.GetLocalityUser(UserName);
                var IDs=localityIDs.Select(l => l.localityId).ToList();
                 
                var stationsCompany= await _stationService.GetStationsCompanyById(CompanyId,IDs);
                if(stationsCompany == null)
                      throw new HttpResponseException(){ Status = 404 ,Value = new ErrorsResponse{
                Errors = new[] { "The Company Id Not Found " },
                Success = false
                  }};
                return Ok(stationsCompany);

        }

        [Authorize(Policy = PoliciesCustom.Station)]
        [HttpGet(ApiRoutes.StationsRoute.stationOnRoad)]
        public async Task<IActionResult> getAllOnRoad(){
            var StationID = HttpContext.GetStationID();
            int stID = 0;
            int.TryParse(StationID,out stID);
            // return Ok(stID+"");
            var OnRoadQuota = await _stationService.GetOnRoadQuota(stID);
            if(OnRoadQuota == null)
                      throw new HttpResponseException(){ Status = 404 ,Value = new ErrorsResponse{
                Errors = new[] { "Not Qouta Came On Road To U " },
                Success = false
                  }};
                return Ok(OnRoadQuota);
        }

    [Authorize(Policy = PoliciesCustom.Station)]
    [HttpPut(ApiRoutes.StationsRoute.putStationOnRoad)]
    public async Task<IActionResult> putOnRoadQuota(int onRoadID){
         var StationID = HttpContext.GetStationID();
            int stID = 0;
            int.TryParse(StationID,out stID);
            // return Ok(stID+"");
            var OnRoadQuotaUpdated = await _stationService.PutOnRoadQuota(stID,onRoadID,HttpContext.GetUserName());
            
            return Ok(OnRoadQuotaUpdated);

    }   
 
    [AllowAnonymous]
    [Authorize(Roles = PoliciesCustom.BusAssent+","+PoliciesCustom.TruckAssent)]
     [HttpGet(ApiRoutes.StationsRoute.getStationAssents)]
        public async Task<IActionResult> getStationVehicle(){
              
            var roleName= HttpContext.GetRoleName();
            var localID=int.Parse(HttpContext.GetLocalityID());
            var fuelID=int.Parse(Request.Query["fuelID"].ToString());
            var fuelTypeID=int.Parse(Request.Query["fuelTypeID"].ToString());

              //  First Get StationID from Current user Then Pass To The Method 
            var station=await  _stationService.getStationsList(roleName,roleName,localID,fuelID,fuelTypeID);// ??null;
            if(station == null)
                throw new HttpResponseException(){ Status = 401 ,Value = new ErrorsResponse{
            Errors = new[] { "Not Register or Your Station  NOt  Activ " },
            Success = false
        }};

                return Ok(station);

        }


    }
}