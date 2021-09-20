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
    public class TripAuthProviderService : ITripAuthProviderService
    {
        private readonly PetrolSDContext _context;

         public TripAuthProviderService(PetrolSDContext context){
            _context = context;
        }

        public async Task<List<TripAuthResponse>> GetAllTripsAuthProvider(int StateID)
        {
            var tripsAuth= await _context.StripAuthProvider
            .Where(tripProvider  => tripProvider.StateId == StateID)
            .Select(trip => new TripAuthResponse{
                TripAuthName = trip.TripAuthProviderName,
                TripAuthID = trip.TripAuthProviderId,
                Active = trip.Active
            })
            .ToListAsync();
            
            return tripsAuth;
        }
        
    }
}