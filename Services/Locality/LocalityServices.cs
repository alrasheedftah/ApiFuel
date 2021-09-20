using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using ApiAppPetrol.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

using WebApplication1.Models;

namespace ApiAppPetrol.Services
{
    public class LocalityServices : ILocalityServices
    {
        private readonly PetrolSDContext _context;

         public LocalityServices(PetrolSDContext context){
            _context = context;
        }

        public async Task<List<LocalityResponse>> GetLocalityUser(string UserName)
        {
            var locality= await _context.SuserLocality
            .Where(ul=> ul.UserName == UserName )
            .Select(ul => new LocalityResponse{
                localityName = ul.Locality.LocalityName,
                localityId = ul.LocalityId,
            })
            .ToListAsync();
            
            return locality;
        }
    }
}