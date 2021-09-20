
using System.Threading.Tasks;
using ApiAppPetrol.Extention;
using ApiAppPetrol.Policies;
using ApiAppPetrol.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiAppPetrol.Controllers
{
    
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(Policy = PoliciesCustom.Engineer)]
    [ApiController]
    public class SiteSurveyController : ControllerBase  {
       private ISiteSurvey _siteSurvey;
       public  SiteSurveyController(ISiteSurvey siteSurvey){
           _siteSurvey = siteSurvey;
        }


        [HttpGet(ApiRoutes.Enginner.getSiteSurvey)]
        public async Task<IActionResult> index(){
            var UserName = HttpContext.GetUserName()??null;
            var sitesSurvey= await _siteSurvey.GetAllSurvey(UserName);
            return Ok(sitesSurvey);
        }
    }
}