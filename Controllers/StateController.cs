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
    // [Authorize(Policy = PoliciesCustom.Station)]
    [Authorize(Roles = PoliciesCustom.SecurityAgent)]

    [ApiController]
    public class StateController : ControllerBase
    {
       private IStateService _stateService;
        public StateController(IStateService stateService){
            _stateService = stateService;

        }

        [HttpGet(ApiRoutes.LocalityRoute.getAll)]
        public async Task<IActionResult> show(int stateID){
                // var stateID=int.Parse(HttpContext.GetStateID());
                var stateDetails= await _stateService.GetStateUser(stateID);
                if(stateDetails ==null)
                     throw new HttpResponseException(){ Status = 404 ,Value = new ErrorsResponse{
                Errors = new[] { "The State Id Not Found " },
                Success = false
                  }};
                return Ok(stateDetails);

        } 

        [HttpGet(ApiRoutes.StateRoute.getAll)]
        public async Task<IActionResult> getAllState([FromRoute]int CompanyId){

                var states= await _stateService.GetAllStates();
                if(states == null )
                   throw new HttpResponseException(){ Status = 404 ,Value = new ErrorsResponse{
                Errors = new[] { "The List State Not Available   " },
                Success = false
                  }};
                return Ok(states);


        }
    [AllowAnonymous]
    [Authorize(Roles = PoliciesCustom.BusAssent+","+PoliciesCustom.TruckAssent)]
        [HttpGet(ApiRoutes.StateRoute.getstateLocality)]
        public async Task<IActionResult> getStateLocalities([FromRoute]int stateID){

                var states= await _stateService.GetStateLocality(stateID);
                if(states == null )
                   throw new HttpResponseException(){ Status = 404 ,Value = new ErrorsResponse{
                Errors = new[] { "The  State Not have Locality Available  " },
                Success = false
                  }};
                return Ok(states);

        }

    }

}