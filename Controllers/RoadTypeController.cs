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
    public class RoadTypeController : ControllerBase
    {
       private IRoadTypeService _roadTypeService;
        public RoadTypeController(IRoadTypeService roadTypeService){
            _roadTypeService = roadTypeService;

        }

     [HttpGet(ApiRoutes.RoadTypeRoute.getAllTypeRoute)]
        public async Task<IActionResult> Get(){

            var tripsAuth=await  _roadTypeService.GetAllRoadTypes();
            if(tripsAuth == null)
                throw new HttpResponseException(){ Status = 401 ,Value = new ErrorsResponse{
            Errors = new[] { "No Data In RoadType Table " },
            Success = false
        }};
        
                return Ok(tripsAuth);

        }
    }
}