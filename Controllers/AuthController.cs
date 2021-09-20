
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Requsts;
using ApiAppPetrol.Domain.Response;
using ApiAppPetrol.Exceptions;
using ApiAppPetrol.Extention;
using ApiAppPetrol.Models;
using ApiAppPetrol.Policies;
using ApiAppPetrol.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace ApiAppPetrol.Controllers
{
    [Authorize]
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        private IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromForm]UserLoginRequest model)
        {
            if(!ModelState.IsValid)
                return Ok(new MyAutheResult
                {
                    Errors = new[] { " Validation Error  " }
                });
            var authResponse = await _userService.Authenticate(model.UserName,model.Password,model.IMEI);

            if(!authResponse.Success)  // spc  PWD: SPS@2020    ip:41.202.162.236
            {
                return Ok(authResponse);
            }  

            return Ok(authResponse);          
        }

        [AllowAnonymous]
        [HttpPost("logout")]
        // public IActionResult logout([FromForm]UserLoginRequest ana){
        
        // if(!ModelState.IsValid)
        // throw new HttpResponseException(){ Status = 404 ,Value = new ErrorsResponse{
        //     Errors = new[] { "The Specific Id Not Found " },
        //     Success = false
        // }};

        // throw new HttpResponseException(){ Status = 404 ,Value = new ErrorsResponse{
        //     Errors = new[] { " Data Success " },
        //     Success = false
        // }};
        // // return Ok(ana.UserName+""+ana.Password);
        // //  return Ok(Request.Query["page"]);
        //   var newUser= _userService.Create("ahmed@gmail.com","ahmed@gmail.com","ahmed@gmail.com","ahmed@gmail.com","ahmed123");

        //     return  Ok(newUser);

        // }

    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(Roles = PoliciesCustom.SecurityAgent+","+PoliciesCustom.Station+","+PoliciesCustom.Engineer)]
    [HttpGet("profile")]
        public async Task<IActionResult> GetProfileAsync()
        {
            
            var id = HttpContext.User.Claims.First().Value;//HttpContext.GetStationID();
            var userr =  _userService.Profile(id);
            var userRoles = await _userService.GetRoles(userr.Result);
            Sstation Station = null;
            string localName=null;
            // UserView CurrentUser=new UserView();
            if (userr.Result.StationID != null)
            {
                Station = _userService.getStation(userr.Result.StationID.Value);
            }
            if(userr.Result.LocalityID != null)
            {
               localName= _userService.getLocality(userr.Result.LocalityID.Value);
            }
            var  CurrentUser = new UserView()
            {
                FullName = userr.Result.FullName,
                UserName = userr.Result.UserName,
                Email = userr.Result.Email,
                PhoneNumber = userr.Result.PhoneNumber,
                StationID = userr.Result.StationID,
                StationName = Station == null ? "" : Station.StationName,
                CompanyID = Station == null ? -1 : Station.CompanyId,
                CompanyName = Station == null ? "" : Station.Company.CompanyName,
                LocalityName =localName ,
                IsActive = userr.Result.IsActive,
                Roles = userRoles.FirstOrDefault()
            };
            
          return Ok(CurrentUser);
           
        }

    }
}