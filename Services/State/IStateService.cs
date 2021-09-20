using System.Collections.Generic;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;


namespace ApiAppPetrol.Services
{

    public  interface IStateService
    {
       
        Task<StateResponse> GetStateUser(int StateID);

        Task<List<StateResponse>> GetAllStates();
        Task<List<LocalityResponse>> GetStateLocality(int StateID);


    }
}