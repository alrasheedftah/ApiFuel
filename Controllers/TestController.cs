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
    // [Authorize(AuthenticationSchemes = "Bearer")]  
    [ApiController]
    public class TestController : ControllerBase
    {
     
     [HttpGet("ApiTest")]
        public IActionResult Get(){
                // await;
                return  Ok("Documentaion Api");

        }
    }


}