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
    // [Authorize(Policy = PoliciesCustom.Station)]
    [Authorize(Roles = PoliciesCustom.SecurityAgent)]

    [ApiController]
    public class CompanyController : ControllerBase
    {
       private ICompanyService _companyService;
        public CompanyController(ICompanyService companyService){
            _companyService = companyService;

        }

        [HttpGet(ApiRoutes.CompanyRoute.show)]
        public async Task<IActionResult> show([FromRoute]int companyID){

                var stationDetails= await _companyService.GetCompanyById(companyID);
                if(stationDetails ==null)
                     throw new HttpResponseException(){ Status = 404 ,Value = new ErrorsResponse{
                Errors = new[] { "The Company Id Not Found " },
                Success = false
                  }};
                return Ok(stationDetails);

        } 

        [HttpGet(ApiRoutes.CompanyRoute.getAll)]
        public async Task<IActionResult> getAllInCompany([FromRoute]int CompanyId){
 
                var stationsCompany= await _companyService.GetCompanys(new List<int>{1,2,3,4,5});
                return Ok(stationsCompany);


        }


    }


}