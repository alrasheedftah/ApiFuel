using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using ApiAppPetrol.Exceptions;
using ApiAppPetrol.Helpers;
using ApiAppPetrol.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;


namespace ApiAppPetrol.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppSettings _appSettings;
        private readonly PetrolSDContext _context;


        public UserService(IOptions<AppSettings> appSettings, UserManager<ApplicationUser> userManager,PetrolSDContext context)
        {
            _context = context;
            _userManager = userManager;
            _appSettings = appSettings.Value;
        }

        public async Task<MyAutheResult> Authenticate(string username, string password,string IMEI)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
            {
                throw new HttpResponseException(){ Status = 401 ,Value = new ErrorsResponse{
            Errors = new[] { " UserName Is Wrong " },
            Code=1
            },
            };
            
            }

           if(GetRoles(user).Result.FirstOrDefault()=="TruckStation"||GetRoles(user).Result.FirstOrDefault()=="BusStation"||GetRoles(user).Result.FirstOrDefault()=="Station"||GetRoles(user).Result.FirstOrDefault()=="Engineer" ||GetRoles(user).Result.FirstOrDefault()=="Security" ){ 
            var userHasValidPasswd = await _userManager.CheckPasswordAsync(user, password);
            if (!userHasValidPasswd)
            {
                throw new HttpResponseException(){ Status = 401 ,Value = new ErrorsResponse{
                Errors = new[] { " Passord  Is Wrong " },
                Code=2
                }
            };
            }

            if(user.IMEI == null || user.IMEI == String.Empty){
                user.IMEI=IMEI;
                await _userManager.UpdateAsync(user);
            }
            if(user.IMEI != IMEI){
                {
                throw new HttpResponseException(){ Status = 401 ,Value = new ErrorsResponse{
                Errors = new[] { " UnAuthorized IMEI  to Login  " },
                Code=3
                }
            };
            }
            }
           }else{
                   throw new HttpResponseException(){ Status = 401 ,Value = new ErrorsResponse{
                Errors = new[] { " UnAuthorized Roles To Login  " },
                Code=4
                }
            };
            
           }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub,username),
                    new Claim(ClaimTypes.Role, GetRoles(user).Result.FirstOrDefault()),//.Any(role=>role == "Station")?"Station":"Engineer"),

                    new Claim("id",user.Id),
                    new Claim("UserName",user.UserName),
                    new Claim("GetStationID" ,user.StationID.HasValue?user.StationID+"":""),
                    new Claim("IMEI" ,user.IMEI),
                    new Claim("LocalityID",user.LocalityID+""),
                    new Claim("StateID",user.StateID+""),
                    new Claim("RoleName",GetRoles(user).Result.FirstOrDefault()),

                }),
                Expires = DateTime.UtcNow.AddDays(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var Tokenusr = tokenHandler.WriteToken(token);



            return new MyAutheResult
            {
                Token = Tokenusr.ToString(),
                Success = true,

            };
        }

        public async Task<List<string>> GetRoles(ApplicationUser Currentuser)
        {
            var CurrentUserroles = await _userManager.GetRolesAsync(Currentuser);

            return CurrentUserroles.ToList();
        }

        public Sstation getStation(int StationID)
        {
            var Station = _context.Sstation.Include(s => s.Company).FirstOrDefault(s => s.StationId == StationID);
            return Station;
        }

         public  string getLocality(int LocalityID)
        {
            var Locality =  _context.Slocality.SingleOrDefault(Locality=> Locality.LocalityId == LocalityID);
            // if(Locality!=null)
            return Locality!=null?Locality.LocalityName:null;
        }


        public async Task<ApplicationUser> Profile(string id)
        {
            var data = await _userManager.FindByNameAsync(id);
            return data;
        }

 public async Task<ApplicationUser> Create(string firstName, string lastName, string email, string userName, string password)
{
   var appUser = new ApplicationUser {Email = email, UserName = userName};
   
   var identityResult = await _userManager.CreateAsync(appUser, password);

   if (!identityResult.Succeeded) return null;//= identityResult.Errors.Select(e  => new Error(e.Code, e.Description))};

        //  var newUser=new ApplicationUser{
        //   Email = "rasta@gmail.com" ,
        //   UserName = "rasta@gmail.com ",
        //   NormalizedEmail = "rasta@gmail.com ",
        //   EmailConfirmed = true,
          

           
        // };
       
        var CreateUser = await _userManager.CreateAsync(new ApplicationUser{
          Email = "rasta@gmail.com" ,
          UserName = "rasta@gmail.com",
          NormalizedEmail = "rasta@gmail.com ",
          EmailConfirmed = true,   
        },password);
     var addded= _context.SaveChanges();


        return null;        
        // var user = new IdentityUser(firstName, lastName, appUser.Id, appUser.UserName);
        
        
        // _context.Users.Add(user);


//    return new CreateUserResponse(appUser.Id, identityResult.Succeeded, identityResult.Succeeded ? null :  identityResult.Errors.Select(e => new Error(e.Code, e.Description)));
}
    }
}