// using System.Runtime.Serialization;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using ApiAppPetrol.Domain.Response;
// using Microsoft.EntityFrameworkCore;
// using WebApplication1.Models;
// using Newtonsoft.Json;
// using ApiAppPetrol.Extention;
// using ApiAppPetrol.Exceptions;
// 

// namespace ApiAppPetrol.Services
// {
//     public class MachineAssentServices : IMachineAssentServices
//     {
//         private readonly PetrolSDContext _context;

//         public MachineAssentServices(PetrolSDContext context){
//             _context = context;
//         }


//         // Get All Machine Assent Data By ID 
//         public async Task<MachineAssentResponse> GetMachineAssentById(long id)
//         {
//                 // TODO Call Procedure Get GetMachineAssentById
//                 var MAssent= await _context.MmachineAssent
//                .Where(m => m.ProfileFacilityAssentId == id )
//              //    .Where(m => m.ExpDate < )  
//                .Select(m => new {

//                     // ProfileName = m.Profile.ProfileName ,

//                     MachineName = m.Machine.MachineType.MachineTypeName,
                    
//                     // SectionName = m.Section.SectionName,

//                     // FacilityName = m.Facility.FacilityName,

//                     // StateName = m.State.StateName ,

//                     // LocalityName = m.Locality.LocalityName,

//                     // OfficeName = m.Office.OfficeName ,

//                     // CompanyName = m.Company.CompanyName ,

//                     // StationName = m.Station.StationName ,

//                     // StationID = m.StationId,

//                     // FuelName = m.Fuel.FuelName,
//                     // FuelID = m.FuelId,
//                     // FuelTypeID=m.FuelTypeId,

//                     // FuelTypeName = m.FuelType.FuelTypeName,
                    
                    
//                     // StatusId=m.StatusId,
                    
//                     // TotalLiter =  m.TotalLiter ,

//                     // ApprovedLiter = m.ApprovedLiter,

//                     // ExpDate = m.ExpDate,
                    
//                     // startDate = m.StartDate,

//                     // startDate = m.,
//                     // startDate = m.,


//                     // StatusID = m.ExpDate.Date<DateTime.Now.Date?3:m.StatusId,

//                     // StatusName = (m.StatusId ==1?(m.ExpDate.Date<DateTime.Now.Date?"منتهي الصلاحية":"ساري") :(m.StatusId==4?"التصديق ملغي":"غير ساري")),

                    

//                })
//                .SingleOrDefaultAsync();
//              var strinJson= JsonConvert.SerializeObject(MAssent);
//              var MAssentRespone= JsonConvert.DeserializeObject<MachineAssentResponse>(strinJson);
              
//                return MAssentRespone;               
//         }

//        public async Task<bool> ValidStationAssent(long assentID,string StationID,string IMEI){//StationID
    
//         //    var Assent = await _context.MmachineAssent.AsNoTracking().SingleOrDefaultAsync(assent => assent.AssentId == assentID);
//         //    if(Assent == null){
//         //     throw new HttpResponseException(){ Status = 403 ,Value = new ErrorsResponse{
//         //     Errors = new[] { "Sory This Assent ID  INvalid " },
//         //     Success = false
//         // }};
//         //    }
//         //      // Check Station 
//         //    if(Assent.StationId != int.Parse(StationID))
//         //         throw new HttpResponseException(){ Status = 403 ,Value = new ErrorsResponse{
//         //     Errors = new[] { "Sory This Station   INvalid " },
//         //     Success = false
//         // }};

//         //         // Check Expir Date 
//         //     if(Assent.ExpDate < DateTime.Now.Date )
//         //         throw new HttpResponseException(){ Status = 403 ,Value = new ErrorsResponse{
//         //     Errors = new[] { " Sory The Assent Id Is ExpireDate " },
//         //     Success = false
//         // }};
            
//         //     // check Status to agree 
//         //     if(Assent.StatusId != 1)
//         //     throw new HttpResponseException(){ Status = 403 ,Value = new ErrorsResponse{
//         //     Errors = new[] { " Sory The Assent is Withdrawed " },
//         //     Success = false
//         // }};

//         // //  var tsStationQuota=_context.TStationQuota.SingleOrDefault(ts=> ts.StationID== Assent.StationId 
//         // //  && ts.Date==DateTime.Now.Date && ts.FuelID== Assent.FuelId && ts.FuelTypeID == Assent.FuelTypeId);
          
//         // //    tsStationQuota.TotalWithdraw+=Assent.TotalLiter;
//         //     // _context.MmachineAssent.Attach(machineAssent);
//         //     // Save Change To DB         
//         //     _context.Entry(tsStationQuota).Property(tsStationQuota => tsStationQuota.TotalWithdraw).IsModified = true;
//         //    var Updated = await _context.SaveChangesAsync();
        
//                 return true;

    
//     //  var AssentIDP = new SqlParameter("@AssentID", assentID);
//     //         var StationIDP = new SqlParameter("@UserStationID", StationID);
//     //         var reternP = new SqlParameter() { ParameterName = "@retVal", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output, Value = -1 };
//     //         await _context.Database.ExecuteSqlCommandAsync("EXEC @retVal = [dbo].[AssentWithdraw] @AssentID,@UserStationID", reternP, AssentIDP, StationIDP);
//     //         int res = (int)reternP.Value;
//     //         if (res == -1)
//     //         {
//     //             throw new HttpResponseException()
//     //             {
//     //                 Status = 403,
                    
//     //                 Value = new ErrorsResponse
//     //                 {

//     //                     Errors = new[] { "Sory This Assent ID  INvalid " },
//     //                     Success = false,
//     //                     Code = res,
//     //                 }
//     //             };
//     //         }
//     //         // Check Station 
//     //         if (res == -2)
//     //             throw new HttpResponseException()
//     //             {
//     //                 Status = 403,
//     //                 Value = new ErrorsResponse
//     //                 {
//     //                     Errors = new[] { "Sory This Station   INvalid " },
//     //                     Success = false,
//     //                     Code = res,

//     //                 }
//     //             };

//     //         // Check Expir Date 
//     //         if (res == -3)
//     //             throw new HttpResponseException()
//     //             {
//     //                 Status = 403,
//     //                 Value = new ErrorsResponse
//     //                 {
//     //                     Errors = new[] { " Sory The Assent Id Is Withdrowed " },
//     //                     Success = false,
//     //                     Code = res,

//     //                 }
//     //             };

//     //         // check Status to agree 
//     //         if (res == -4)
//     //             throw new HttpResponseException()
//     //             {
//     //                 Status = 403,
//     //                 Value = new ErrorsResponse
//     //                 {
//     //                     Errors = new[] { " Sorry The Assent is Expaired " },
//     //                     Success = false,
//     //                     Code = res,

//     //                 }
//     //             };


//     // //         //   var tsStationQuota =_context.TStationQuota.SingleOrDefault(ts=> ts.StationID== Assent.StationId 
//     // //         //&& ts.Date==DateTime.Now.Date && ts.FuelID== Assent.FuelId && ts.FuelTypeID == Assent.FuelTypeId);

//     // //         //  tsStationQuota.TotalWithdraw+=Assent.ApprovedLiter;
//     // //         //   // _context.MmachineAssent.Attach(machineAssent);
//     // //         //   // Save Change To DB         
//     // //         //   _context.Entry(tsStationQuota).Property(tsStationQuota => tsStationQuota.TotalWithdraw).IsModified = true;
//     // //         //  var Updated = await _context.SaveChangesAsync();

//     //         return true; 
//        }


// public async Task<List<ReportsResponse>> GetMachineAssents(int StationID,string startDate,string endDate, int FuelTypeParam,string FullName,int StatusID)
//         {
            
//             var strDate = startDate!=null && startDate!= ""? DateTime.Parse(startDate) : DateTime.UtcNow.Date;//new DateTime(2020, 8, 9);//DateTime;//.UtcNow; 
//             var enddDate = endDate!=null && endDate!= "" ? DateTime.Parse(endDate)   : DateTime.UtcNow.Date.AddDays(2) ;// : strDate.AddDays(1);// DateTime.UtcNow.AddDays(1);//.ToShortDateString();

//             //Where(c => c.DateCreated > DateTime.Now.AddDays(-2));
//                 // TODO Call Procedure Get GetMachineAssent For Station ID 
//            var machineAssents= await _context.MmachineAssent
              
//               // .Where(m => m.ExpDate.Date >= strDate.Date && m.ExpDate <= enddDate.Date )
            
//               // .Where(m => m.StationId == StationID)
//             //   .Include(m => m.FuelType.FuelTypeId)
//               // .Where(m => ( FuelTypeParam == 0 ||m.FuelType.FuelTypeId == FuelTypeParam ) )

//               // .Where(m => ( StatusID == 0 ||m.StatuId == StatusID ) )

//               // .Where(m => (FullName == null || FullName=="" || m.Profile.ProfileName.Contains(FullName)) )
//             //    .Where(m => m.ExpDate < )  
//               .Select(m => new { 

//                     // AssentId = m.AssentId ,

//                     // MachineName = m.Machine.MachineType.MachineTypeName,
                    
                    
//                     // details = new {MarkName = m.Machine.Mark.MarkName, ModelName= m.Machine.Model.ModelName},

//                     // // ModelName= m.Machine.Model.ModelName,
//                     // fuelInfo = new {FuelName = m.Fuel.FuelName ,FuelTypeName = m.FuelType.FuelTypeName , fuelID= m.FuelId},

//                     // TotalLiter = m.TotalLiter,

//                     // // FuelName = m.Fuel.FuelName ,
//                     // // FuelTypeName = m.FuelType.FuelTypeName,

//                     // LocalityName = m.Locality.LocalityName,

//                     // DateAdded = m.DateAdded,


//                     // expDate = m.ExpDate,

//                     // startDate = m.StartDate,

//                     // StatusID = m.ExpDate.Date<DateTime.Now.Date?3:m.StatusId,

//                     // StatusName = (m.StatusId ==1?(m.ExpDate.Date<DateTime.Now.Date?"منتهي الصلاحية":"ساري") :"غير ساري"),
                    
//                     // FullName = m.Profile.ProfileName,

//                     // PhoneNumber = m.Profile.Phone1,

//                     // ApprovedLiter =m.ApprovedLiter,
//                     // // fuelID=_context.MmachineAssent.Where(m=>m.FuelTypeId == 1 ).Count(),




//                })
//               //  .OrderBy(i => i.)
//                  .ToListAsync();
           
//         //    .Include(machineAssents=> machineAssents.Station)
//         //    .AsNoTracking()
//         //    .OrderBy(i => i.MachineId)
//         //    .ToListAsync();
           
//         //    .Where(ma=>ma.StationId == 1)
           
//         //    .ToListAsync();
//         var strinJson= JsonConvert.SerializeObject(machineAssents);
//         var MAssentRespone= JsonConvert.DeserializeObject<List<ReportsResponse>>(strinJson);
             
//            return  MAssentRespone;
//         }

//         public async Task<bool> UpdateMachineAssents(long AssentID)
//         {
//           // int id=AssentID;
//                 // TODO Call Procedure UpdateMachineAssentsToMachineAssents 
//             //  var  machineAssent= await _context.MmachineAssent.FirstOrDefaultAsync(m => m.AssentId == AssentID);

//              // Change StatuId To Done Complate Operation
//             //  machineAssent.StatusId=IMachineAssentServices.StatuseComplated;
//             // _context.MmachineAssent.Attach(machineAssent);
//             // Save Change To DB         
//             // _context.Entry(machineAssent).Property(Uassents => Uassents.StatusId).IsModified = true;
//            var Updated = await _context.SaveChangesAsync();
//             // _context.MmachineAssent.Attach()
//             return Updated > 0;
                 
//             // throw new System.NotImplementedException();
//         }

//         public PagedList<ReportsResponse> GetTest(int StationID, string strDate, string endSate, int FuelTypeParam, string FullName)
//         {
//             //var query = _context.AsQueryable();  
//             // return new PagedList<MmachineAssent>(  
//             //   _context.MmachineAssent.OrderBy(m =>m.AssentId),2,1);  
//             _context.MmachineAssent.GetPaged(1,1);
//             return null;
//         }
//     }
// }