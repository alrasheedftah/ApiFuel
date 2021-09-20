using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using ApiAppPetrol.Exceptions;
using ApiAppPetrol.Extention;
using ApiAppPetrol.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiAppPetrol.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]  
    [ApiController]
    public class FuelTypeController : ControllerBase
    {
       private IFuelTypeServices _fuelTypeServices;
        public FuelTypeController(IFuelTypeServices fuelTypeServices){
            _fuelTypeServices = fuelTypeServices;

        }

     [HttpGet(ApiRoutes.FuelTypeRoute.getFuelType)]
        public async Task<IActionResult> Get(){

         
            var fuelType=await  _fuelTypeServices.GetFuelTypes();
            if(fuelType == null)
                throw new HttpResponseException(){ Status = 401 ,Value = new ErrorsResponse{
            Errors = new[] { "No Data In FuelType Table " },
            Success = false
        }};
        
                return Ok(fuelType);

        }
    }
}