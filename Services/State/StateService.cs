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
    public class StateService : IStateService
    {
        private readonly PetrolSDContext _context;

         public StateService(PetrolSDContext context){
            _context = context;
        }

        public  Task<List<StateResponse>> GetAllStates()
        {
            var states=  _context.Nstate
            .Select(state => new StateResponse{
                StateName = state.StateName,
                StateID = state.StateId
            }).ToListAsync(); 

            return states;
        }

      

        public async Task<StateResponse> GetStateUser(int StateID)
        {
            var StatesResponse= await _context.Nstate
            .Select( State => new StateResponse{
                StateID = State.StateId ,
                StateName = State.StateName
            })
            .SingleOrDefaultAsync(state => state.StateID == StateID );

            return StatesResponse;
             
        }

         public async Task<List<LocalityResponse>> GetStateLocality(int StateID)
        {
            var localityResponse= await _context.Slocality
            .Where(local => local.StateId == StateID)
            .Select( locality => new LocalityResponse{
                localityId = locality.LocalityId ,
                localityName = locality.LocalityName
            })
           .ToListAsync();

            return localityResponse;
             
        }
    }
}