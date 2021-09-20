using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using ApiAppPetrol.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
//

namespace ApiAppPetrol.Services
{
    public class TripAuthService : ITripAuthService
    {
        private readonly PetrolSDContext _context;

         public TripAuthService(PetrolSDContext context){
            _context = context;
        }

        public async Task<List<TripAuthResponse>> GetAllTripsAuth()
        {
            var tripsAuth= await _context.StripAuth
            .Select(trip => new TripAuthResponse{
                TripAuthName = trip.TripAuthName,
                TripAuthID = trip.TripAuthId,
                Active = trip.Active
            })
            .ToListAsync();
            
            return tripsAuth;
        }
        
    }
}