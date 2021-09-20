using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using ApiAppPetrol.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ApiAppPetrol.Services
{
    public class FuelTypeServices : IFuelTypeServices
    {
        private readonly PetrolSDContext _context;

         public FuelTypeServices(PetrolSDContext context){
            _context = context;
        }

         public async Task<List<FuelResponse>> GetFuelTypes()
        {
                // TODO Call Procedure Get GetMachineAssentById 
               var stString= await _context.SfuelType
               .Select( ftype => new {

                  FuelTyeID = ftype.FuelTypeId ,

                  FuelTypeName = ftype.FuelTypeName,

                  Active = ftype.Active,
                  
               })
               .ToListAsync();

             var strinJson= JsonConvert.SerializeObject(stString);
             var StationRespone= JsonConvert.DeserializeObject<List<FuelResponse>>(strinJson);

             return StationRespone;
            
        }

    }
}