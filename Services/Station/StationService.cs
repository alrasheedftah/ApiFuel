using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using ApiAppPetrol.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ApiAppPetrol.Services
{
    public class StationService : IStationService
    {
        private readonly PetrolSDContext _context;

         public StationService(PetrolSDContext context){
            _context = context;
        }

 public async Task<StationResponse> GetStationById(int id)
        {
            // TODO Call Procedure Get GetMachineAssentById 
            var StationResult = await _context.Sstation
            .Where(s => s.StationId == id)
            .Select(s => new StationResponse
            {

                StationName = s.StationName,
                LocalityName = s.Locality.LocalityName,
                Address = s.Address,
                Phone = s.Phone,
                Active = s.Active,
                CompanyName = s.Company.CompanyName,
                // ts =s.TStationQuota.TakeLast(4)
                TstationQuota = s.TstationQuota.Where(ts => ts.Date == DateTime.Now.Date)
                                .Select(ts => new TsResponse
                                {
                                    FuelName = ts.Fuel.FuelName,
                                    FuelTypeName = ts.FuelType.FuelTypeName,
                                    Quantity = ts.Quantity,
                                    TotalAssent = ts.Station.MprofileFacilityAssent.Where(m => m.FuelId == ts.FuelId && m.FuelTypeId == ts.FuelTypeId && m.StartDate <= DateTime.Now.Date && m.ExpDate >= DateTime.Now.Date && m.StatusId == 1).Sum(m => m.ApprovedLiter),
                                    TotalWithdraw = ts.Station.MprofileFacilityAssent.Where(m => m.FuelId == ts.FuelId && m.FuelTypeId == ts.FuelTypeId && m.StartDate <= DateTime.Now.Date && m.ExpDate >= DateTime.Now.Date && m.StatusId == 2).Sum(m => m.ApprovedLiter),
                                    FuelTypeID = ts.FuelTypeId,
                                    FuelID = ts.FuelId,

                                    RemQuantity = ts.Quantity + ts.RemQuantity - ts.TotalAssent,
                                    RemWithdraw = ts.Quantity + ts.RemWithdraw - ts.TotalWithdraw,

                                    AssentCount = ts.Station.MprofileFacilityAssent.Count(m => m.FuelId == ts.FuelId && m.FuelTypeId == ts.FuelTypeId && m.StartDate <= DateTime.Now.Date && m.ExpDate >= DateTime.Now.Date),

                                    AssentWithdrawCount = ts.Station.MprofileFacilityAssent.Count(m => m.StatusId == 2 && m.FuelId == ts.FuelId && m.FuelTypeId == ts.FuelTypeId && m.StartDate <= DateTime.Now.Date && m.ExpDate >= DateTime.Now.Date),

                                    AssentActiveCount = ts.Station.MprofileFacilityAssent.Count(m => m.StatusId == 1 && m.FuelId == ts.FuelId && m.FuelTypeId == ts.FuelTypeId && m.FuelId == ts.FuelId && m.FuelTypeId == ts.FuelTypeId && m.StartDate <= DateTime.Now.Date && m.ExpDate >= DateTime.Now.Date),

                                }).ToList()//.AsQueryable().Take(1).ToList()//.GroupBy(ts => new {ts.FuelID,ts.FuelTypeID}).ToList()//.AsQueryable().Take(1).ToList()
            })

            .SingleOrDefaultAsync();

            return StationResult;

        }

        public async Task<List<StationResponse>> GetStationsCompanyById(int CompanyID, List<int> localID)
        {
            var stations = await _context.Sstation
            .Where(station => station.CompanyId == CompanyID)
            // .Where(station => localID.Contains(station.LocalityId))
            .Where(station => station.MprofileFacilityAssent.Count() > 0)
            .Where(station => station.Active == true)
            .Select(s => new StationResponse
            {
                StationId = s.StationId,
                StationName = s.StationName,
                LocalityName = s.Locality.LocalityName,
                LocalityId = s.LocalityId,
                Address = s.Address,
                Phone = s.Phone,
                Active = s.Active,
                CompanyName = s.Company.CompanyName,
                // SumQuantity = s.TstationQuota.Where(ts => ts.Date.Month == DateTime.Now.Month && ts.Date.Year == DateTime.Now.Year).Sum(ts => ts.Quantity),
                // TstationQuota = s.TstationQuota.Where(ts =>ts.Date == DateTime.Today.Date)
                // .Select(ts => new TsResponse
                // {
                //     FuelName = ts.Fuel.FuelName,
                //     FuelTypeName = ts.FuelType.FuelTypeName,
                //     Quantity = ts.Quantity,
                //     TotalAssent = ts.TotalAssent,
                //     TotalWithdraw = ts.TotalWithdraw,
                //     FuelTypeID = ts.FuelTypeId,
                //     FuelID = ts.FuelId,
                //     RemWithdraw = ts.RemWithdraw,

                //                     AssentCount = ts.Station.MprofileFacilityAssent.Count(m => m.FuelId == ts.FuelId && m.FuelTypeId == ts.FuelTypeId && m.StartDate <= DateTime.Now.Date && m.ExpDate >= DateTime.Now.Date),

                //                     AssentWithdrawCount = ts.Station.MprofileFacilityAssent.Count(m => m.StatusId == 2 && m.FuelId == ts.FuelId && m.FuelTypeId == ts.FuelTypeId && m.StartDate <= DateTime.Now.Date && m.ExpDate >= DateTime.Now.Date),

                //                     AssentActiveCount = ts.Station.MprofileFacilityAssent.Count(m => m.StatusId == 1 && m.FuelId == ts.FuelId && m.FuelTypeId == ts.FuelTypeId && m.FuelId == ts.FuelId && m.FuelTypeId == ts.FuelTypeId && m.StartDate <= DateTime.Now.Date && m.ExpDate >= DateTime.Now.Date),
                // }).ToList()//.TakeLast(4).ToList()
            })
            .OrderBy(st => st.LocalityId)
            .ToListAsync();

            // RemWithdraw     RemAssent

            return stations;
        }

     public async Task<List<OnRoadQuotaResponse>> GetOnRoadQuota(int stationID)
        {
             var OnRoadQuota= await _context.TonRoadQuota
             .Where(road => road.StationId == stationID )
             .Select(roadQountity => new OnRoadQuotaResponse{
                ID = roadQountity.Id,
                StationId = roadQountity.StationId,
                FuelID = roadQountity.FuelId,
                FuelTypeID = roadQountity.FuelTypeId,
                // FuelName = roadQountity.Fuel.FuelName,
                // FuelTypeName = roadQountity.FuelType.FuelTypeName, // TODO 

                Quantity = roadQountity.Quantity,
                DateMove =roadQountity.Date,

             }).OrderBy(rq => rq.Quantity).ToListAsync();

             return OnRoadQuota;
            
        }

        public async Task<bool> PutOnRoadQuota(int stationID,int onRoadID,string UserName)
        {
          
           var OnRoadQuota= await _context.TonRoadQuota.SingleOrDefaultAsync(rq => rq.Id == onRoadID ); 
        //    if(OnRoadQuota == null)
           var tstationQuota=  _context.TstationQuota
           .LastOrDefault(ts => ts.StationId ==stationID );
        //    .ToList().AsQueryable().LastOrDefault();
         
            
            tstationQuota.FuelId=OnRoadQuota.FuelId;
            tstationQuota.FuelTypeId=OnRoadQuota.FuelTypeId;
            tstationQuota.Quantity=OnRoadQuota.Quantity;
            tstationQuota.Date=DateTime.Now.Date;
            var tsStationQuotaNew = _context.TstationQuota.Add(
            tstationQuota
            );

            _context.TonRoadQuota.Remove(OnRoadQuota);               
            var Updated=await _context.SaveChangesAsync();
            return true;


            // TODO Call Procedure Replaced Above Code by Under 
            //  var StationIdP = new SqlParameter("@StationId", stationID);
            //  var onRoadIDP = new SqlParameter("@onRoadID", onRoadID);

            // var UserNameP = new SqlParameter("@UserName", UserName);
            // var reternP = new SqlParameter() { ParameterName = "@retVal", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output, Value = -1 };
            // await _context.Database.ExecuteSqlCommandAsync("EXEC @retVal = [dbo].[OnRoadQuota] @id", reternP,onRoadIDP);
            // int res = (int)reternP.Value;
            // if(res > 0)
            // return true;

            // return false;
           
        }

        public async Task<List<StationResponse>> getStationsList(string roleName,string UserName,int LocalityID,int fuelID,int fuelTypeID)
        {
                var stationType= await _context.TstationType
                .Where(stype => stype.RoleName == roleName)
                .Select(stype => new StationResponse{
                    StationId = stype.Station.StationId,
                    StationName = stype.Station.StationName,
                    CompanyName = stype.Station.Company.CompanyName,
                    SumQuantity =stype.Station.TstationQuota
                    .Where(ts => ts.Date.Date == DateTime.Now.Date)
                    .Where(ts => ts.FuelTypeId == fuelTypeID)
                    .SingleOrDefault(ts => ts.FuelId == fuelID ).RemWithdraw
                    // .Where(ts => ts.Date.Date == DateTime.Now.Date)
                    // .Select(ts => new TsResponse{
                    //     RemWithdraw = ts.RemWithdraw,

                    // }).Last().RemWithdraw

                })
                .ToListAsync();

                // var stationList= await _context.Sstation
                // .Where(stations => stations.LocalityId == LocalityID)
                // .Where(station => station.Active == true)
                // .Where(station => station.Assent == false )
                // .Select(station => new StationResponse{

                // }).ToListAsync();
                
               return stationType;
        }



    }
}