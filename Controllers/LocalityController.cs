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
    public class LocalityController : ControllerBase
    {
       private ILocalityServices _localityService;
        public LocalityController(ILocalityServices localityService){
            _localityService = localityService;

        }

        [HttpGet(ApiRoutes.LocalityRoute.getAll)]
        public async Task<IActionResult> index(){
                var UserName=HttpContext.GetUserName();
                var localityDetails= await _localityService.GetLocalityUser(UserName);
                if(localityDetails ==null)
                     throw new HttpResponseException(){ Status = 404 ,Value = new ErrorsResponse{
                Errors = new[] { "The Company Id Not Found " },
                Success = false
                  }};
                return Ok(localityDetails);

        } 

        // [HttpGet(ApiRoutes.CompanyRoute.getAll)]
        // public async Task<IActionResult> getAllInCompany([FromRoute]int stateID){

        //         var stationsCompany= await _localityService.GetCompanys();
        //         return Ok(stationsCompany);


        // }


    }


}