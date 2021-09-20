// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using ApiAppPetrol.Domain.Response;
// using ApiAppPetrol.Exceptions;
// using Microsoft.EntityFrameworkCore;
// using Newtonsoft.Json;
// 
// using WebApplication1.Models;

// namespace ApiAppPetrol.Services
// {
//     public class VehicleAssentServices : IVehicleAssentServices
//     {
//         private readonly PetrolSDContext _context;

//         public VehicleAssentServices(PetrolSDContext context){
//             _context = context;
//         }


//         // Get All Machine Assent Data By ID 
//         public async Task<VechileAssentResponse> GetVehicleAssentById(long id)
//         {
//                 // TODO Call Procedure Get GetMachineAssentById 
//                var mVechileString= await _context.MvehicleAssent
//                     .Select(v => new {

//                     // ProfileName = v.Profile.ProfileName ,
                    
//                     // MachineName = v.Vehicle.VechileType.VehicleTypeName,
                    
//                     // SectionName = v.Section.SectionName,
                    
//                     // FacilityName=v.Facility.FacilityName,

//                     // StateName = v.State.StateName ,

//                     // LocalityName = v.Locality.LocalityName,

//                     // OfficeName = v.Office.OfficeName ,

//                     // CompanyName = v.Company.CompanyName ,

//                     // StationName = v.Station.StationName ,

//                     // FuelName = v.Fuel.FuelName,

//                     // FuelTypeName = v.FuelType.FuelTypeName,
                    
//                     // StatusName = (v.StatusId ==1?(v.ExpDate.Date<DateTime.Now.Date?"منتهي الصلاحية":"ساري") :"غير ساري"),
                   
                    
//                     // TotalLiter =  v.TotalLiter ,

//                     // ApprovedLiter = v.ApprovedLiter,

//                     // ExpDate = v.ExpDate,

//                     // startDate = v.DateAdded,

//                     // TripAuthProviderName = v.TripAuthProvider.TripAuthProviderName,

//                     // TripAuthNumber = v.TripAuthNumber,

//                     // TripAuthName = v.TripAuth.TripAuthName,
                   
//                     // StatusId = v.ExpDate.Date<DateTime.Now.Date?3:v.StatusId,



//                })
//                .SingleOrDefaultAsync();

//              var strinJson= JsonConvert.SerializeObject(mVechileString);
//              var VAssentRespone= JsonConvert.DeserializeObject<VechileAssentResponse>(strinJson);
              
//                return VAssentRespone;         
//         }

//        public async Task<bool> ValidStationAssent(long assentID,string StationID){//StationID
//         //    var Assent = await _context.MvehicleAssent.SingleOrDefaultAsync(assent => assent.AssentId == 1);
//         //    if(Assent == null){
//         //       throw new HttpResponseException(){ Status = 403 ,Value = new ErrorsResponse{
//         //     Errors = new[] { "Sory This Assent ID  INvalid " },
//         //     Success = false

//         // }};
//         //    }
//              // Check Station 
//         //    if(Assent.StationId != int.Parse(StationID))
//         //            throw new HttpResponseException(){ Status = 403 ,Value = new ErrorsResponse{
//         //     Errors = new[] { "Sory This Station   INvalid " },
//         //     Success = false
//         // }};


//         //         // Check Expir Date 
//         //     if(DateTime.Compare(Assent.ExpDate,DateTime.Now) > 0)
//         //            throw new HttpResponseException(){ Status = 403 ,Value = new ErrorsResponse{
//         //     Errors = new[] { " Sory The Assent Id Is ExpireDate " },
//         //     Success = false
//         // }};
            
//         //     // check Status to agree 
//         //     if(Assent.StatusId != 2)
//         //      throw new HttpResponseException(){ Status = 403 ,Value = new ErrorsResponse{
//         //     Errors = new[] { " Sory The Assent is Withdrawed " },
//         //     Success = false
//         // }};


//       //  var tsStationQuota=_context.TStationQuota.SingleOrDefault(ts=> ts.StationID== Assent.StationId 
//       //    && ts.Date==DateTime.Now.Date && ts.FuelID== Assent.FuelId && ts.FuelTypeID == Assent.FuelTypeId);
          
//       //      tsStationQuota.TotalWithdraw+=Assent.TotalLiter;
//       //       // _context.MmachineAssent.Attach(machineAssent);
//       //       // Save Change To DB         
//       //       _context.Entry(tsStationQuota).Property(tsStationQuota => tsStationQuota.TotalWithdraw).IsModified = true;
//       //      var Updated = await _context.SaveChangesAsync();


// // var  machineAssent= await _context.MvehicleAssent.FirstOrDefaultAsync(v => v.AssentId == Assent.);

//              // Change StatuId To Done Complate Operation
//             //  Assent.StatusId=IMachineAssentServices.StatuseComplated;
//             // _context.MmachineAssent.Attach(machineAssent);
//             // Save Change To DB         
//           //   _context.Entry(Assent).Property(Uassents => Uassents.StatusId).IsModified = true;
//           //  var UpdatedAssent = await _context.SaveChangesAsync();
//             // _context.MmachineAssent.Attach()
//             return 1 > 0;
//                 // return true;


//        }

//         public async Task<List<ReportsResponse>> GetVehicleAssents(int StationID,string startDate,string endDate, int FuelTypeParam,string FullName,int StatusID)
//         {

//             var strDate = startDate!=null && startDate!= ""? DateTime.Parse(startDate) : DateTime.UtcNow.Date;//new DateTime(2020, 8, 9);//DateTime;//.UtcNow; 
//             var enddDate = endDate!=null && endDate!= "" ? DateTime.Parse(endDate)   : DateTime.UtcNow.Date.AddDays(2) ;// : strDate.AddDays(1);// DateTime.UtcNow.AddDays(1);//.ToShortDateString();

//                 // TODO Call Procedure Get GetMachineAssent For Station ID 
//            var mvecihleString= await _context.MvehicleAssent
//           //  .Where(m => m.ExpDate.Date >= strDate.Date && m.ExpDate <= enddDate.Date )
            
//               // .Where(m => m.StationId == StationID)
//             //   .Include(m => m.FuelType.FuelTypeId)
//               // .Where(m => ( FuelTypeParam == 0 ||m.FuelType.FuelTypeId == FuelTypeParam ) )

//               // .Where(m => ( StatusID == 0 ||m.StatusId == StatusID ) )

//               // .Where(m => (FullName == null  || m.Profile.ProfileName.Contains(FullName)) )

//             .Select(v => new {

// //                     AssentId = v.AssentId ,
// // // 
// //                     MachineName = v.Vehicle.VechileType.VehicleTypeName,
                    
                    
// //                     details = new {MarkName = v.Vehicle.Mark.MarkName, ModelName= v.Vehicle.Model.ModelName},

// //                     // ModelName= m.Machine.Model.ModelName,
// //                     fuelInfo = new {FuelName = v.Fuel.FuelName ,FuelTypeName = v.FuelType.FuelTypeName},

// //                     TotalLiter = v.TotalLiter,

// //                     // FuelName = m.Fuel.FuelName ,
// //                     // FuelTypeName = m.FuelType.FuelTypeName,

// //                     LocalityName = v.Locality.LocalityName,

// //                     DateAdded = v.DateAdded,

                   
// //                     expDate = v.ExpDate,

// //                     startDate = v.DateAdded,

// //                     StatusID = v.ExpDate.Date<DateTime.Now.Date?3:v.StatusId,

// //                     StatusName = (v.StatusId ==1?(v.ExpDate.Date<DateTime.Now.Date?"منتهي الصلاحية":"ساري") :"غير ساري"),
                    
// //                     FullName = v.Profile.ProfileName,

// //                     PhoneNumber = v.Profile.Phone1,

//                })
//             // .OrderBy(i => i.DateAdded)
           
//            .ToListAsync();//Where(ve=> ve.StationId == StationID).ToList();

//              var strinJson= JsonConvert.SerializeObject(mvecihleString);
//              var VAssentRespone= JsonConvert.DeserializeObject<List<ReportsResponse>>(strinJson);
              
//             return VAssentRespone;  
            
//  }

//         public async Task<bool> UpdateVehicleAssent(long AssentID)
//         {
//                 // TODO Call Procedure UpdateMachineAssentsToMachineAssents 
//              var  vechileAssent= await GetVehicleAssentById(AssentID);
               
//              // Change StatuId To Done Complate Operation
//              vechileAssent.StatusId=IVehicleAssentServices.StatuseComplated;

//             // Save Change To DB         
//             _context.Entry(vechileAssent).Property(Uassents => Uassents.StatusId).IsModified = true;
//            var Updated = await _context.SaveChangesAsync();
//             // _context.MmachineAssent.Attach()
//             return Updated > 0;
                 
//             // throw new System.NotImplementedException();
//         }
//     }
// }