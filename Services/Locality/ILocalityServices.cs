using System.Collections.Generic;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;

using WebApplication1.Models;

namespace ApiAppPetrol.Services
{

    public  interface ILocalityServices
    {
       
        Task<List<LocalityResponse>> GetLocalityUser(string UserName);
    }
}