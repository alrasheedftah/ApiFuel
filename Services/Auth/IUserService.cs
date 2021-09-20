using System.Collections.Generic;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using ApiAppPetrol.Models;
using Microsoft.AspNetCore.Identity;


namespace ApiAppPetrol.Services
{
    public interface IUserService
    {
        Task<MyAutheResult> Authenticate(string username, string password,string IMEI);
        // IEnumerable<AspNetUsers> GetAll();
        // AspNetUsers GetById(int id);

        Task<ApplicationUser> Profile(string id);

        Task<List<string>> GetRoles(ApplicationUser Currentuser);
   
        Sstation getStation(int StationID);

       string getLocality(int LocalityID);



        public  Task<ApplicationUser> Create(string firstName, string lastName, string email, string userName, string password);


    }
}