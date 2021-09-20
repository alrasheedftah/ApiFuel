using System;
using System.Collections.Generic;
using System.Globalization;
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
    [Authorize(Roles = PoliciesCustom.BusAssent+","+PoliciesCustom.TruckAssent)]    
    [ApiController]
    public class TripsAuthController : ControllerBase
    {
       private ITripAuthService _tripAuthService;
        public TripsAuthController(ITripAuthService tripAuthService){
            _tripAuthService = tripAuthService;

        }

     [HttpGet(ApiRoutes.TripsAuthRoute.getAllTripsAuth)]
        public async Task<IActionResult> Get(){

            var tripsAuth=await  _tripAuthService.GetAllTripsAuth();
            if(tripsAuth == null)
                throw new HttpResponseException(){ Status = 401 ,Value = new ErrorsResponse{
            Errors = new[] { "No Data In TripAuth Table " },
            Success = false
        }};
        
                return Ok(tripsAuth);

        }
    }
}