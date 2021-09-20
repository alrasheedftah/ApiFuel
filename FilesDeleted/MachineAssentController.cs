// using System;
// using System.Linq;
// using System.Threading.Tasks;
// using ApiAppPetrol.Domain.Response;
// using ApiAppPetrol.Exceptions;
// using ApiAppPetrol.Extention;
// using ApiAppPetrol.Services;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;
// using ApiAppPetrol.Policies;

// namespace ApiAppPetrol.Controllers
// { 
//     //[Authorize]        
//     [Authorize(AuthenticationSchemes = "Bearer")]
//     [Authorize(Roles = PoliciesCustom.SecurityAgent+","+PoliciesCustom.Station)]
//     // [Authorize(Policy = )]
//     [ApiController]
//     [Produces("application/json")]   
//     public class MachineAssentController : ControllerBase
//     {
//         IMachineAssentServices _machineAssentServices;
//         // int StationID=0;
//         public MachineAssentController(IMachineAssentServices machineAssentServices){
//             _machineAssentServices = machineAssentServices;
            
//         }

//         [HttpGet(ApiRoutes.MachineRoute.getAll)]
//         public async Task<IActionResult> getAll()
//         {
//             // return Ok(HttpContext.GetIMEI());
//             var StationID = HttpContext.GetStationID();
 
//             int stID = 0,FuelType=0,StatusID=0;
//             string FullName= Request.Query["fullName"].ToString();
//             int.TryParse(Request.Query["fuelType"].ToString(),out FuelType);
//             int.TryParse(StationID, out stID);
//             var strDate=Request.Query["strDate"];
//             var endDate=Request.Query["endDate"];
//             var page=1;
//             int.TryParse(Request.Query["page"],out page);
//             int.TryParse(Request.Query["StatusID"],out StatusID);

//             // return Ok(DateTime.Parse(strDate).Date>=DateTime.Parse("2020-07-08T00:00:00"));//DateTime.Now.Date.AddDays(2));

//             page=page ==0?1:page;
//             //  First Get StationID from Current user Then Pass To The Method 
//             var mAssent = await _machineAssentServices.GetMachineAssents(stID,strDate,endDate,FuelType,FullName,StatusID);
//             return Ok(mAssent.AsQueryable().GetPaged2(page,15));//.GetSum());
            
//         }
//         [HttpGet(ApiRoutes.MachineRoute.getMachineID)]
//         public async Task<IActionResult> Get([FromRoute] long AssentID){

//             var machineAssent=await  _machineAssentServices.GetMachineAssentById(AssentID);
//             if(machineAssent == null)
//             throw new HttpResponseException(){ Status = 404 ,Value = new ErrorsResponse{
//             Errors = new[] { "The Specific Id Not Found " },
//             Success = false
//         }};
 
//                 return Ok(machineAssent);

//         }

//         [HttpPut(ApiRoutes.MachineRoute.UpdateWithdraw)]
//         public async Task<IActionResult> UpdateWithdraw([FromRoute] long AssentID){
//            var ValidStation= await _machineAssentServices.ValidStationAssent(AssentID,HttpContext.GetStationID(),HttpContext.GetIMEI());
//             if(!ValidStation){
//                 return BadRequest(new {error = "Sorry The AssentId Not Agree To Make opertaion "});
//             }
 
//             return Ok(new {message="Success Withdrowed ",success=true});

//         }
//     }
// }