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
    public class RoadTypeService : IRoadTypeService
    {
        private readonly PetrolSDContext _context;

         public RoadTypeService(PetrolSDContext context){
            _context = context;
        }

        public  Task<List<RoadTypeResponse>> GetAllRoadTypes()
        {
            var roadTypes=  _context.SroadType
            .Select(roadTypes => new RoadTypeResponse{
                RoadTypeID = roadTypes.RoadTypeId,
                RoadTypeName = roadTypes.RoadTypeName
            }).ToListAsync(); 
            return roadTypes;
        }
      
    }
}