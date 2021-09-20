using System;

using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using ApiAppPetrol.Exceptions;
using ApiAppPetrol.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


namespace ApiAppPetrol.Services
{
    public class ProfileFacilityAssentService : IProfileFacilityAssentService
    {
        private readonly PetrolSDContext _context;

        public ProfileFacilityAssentService(PetrolSDContext context)
        {
            _context = context;
        }

        public async Task<AssentResponse> GetProfileFacilityAssentByQR(Guid id)
        {
            var AssentDetails = await _context.MprofileFacilityAssent
            .Where(assent => assent.Qrcode == id)
            .Select(assent => new AssentResponse
            {
                AssentId = assent.AssentId,
                FacilityName = assent.ProfileFacility.ProfileFacilityName,
                FacilityTypeName = assent.Facility.FacilityName,
                ProfileName = assent.Profile.ProfileName,
                SectionName = assent.Section.SectionName,
                StateName = assent.State.StateName,
                LocalityName = assent.Locality.LocalityName,
                OfficeName = assent.Office.OfficeName,
                CompanyName = assent.Company.CompanyName,
                StationName = assent.Station.StationName,
                StationID = assent.StationId,
                FuelName = assent.Fuel.FuelName,
                FuelTypeName = assent.FuelType.FuelTypeName,
                StatusId = assent.ExpDate.Date < DateTime.Now.Date ? 3 : assent.StatusId,
                StatusName = (assent.StatusId == 1 ? (assent.ExpDate.Date < DateTime.Now.Date ? "منتهي الصلاحية" : "ساري") : (assent.StatusId == 4 ? "التصديق ملغي" : "غير ساري")),
                ApprovedLiter = assent.ApprovedLiter,
                startDate = assent.StartDate,
                ExpDate = assent.ExpDate,
                DateDispose = assent.DateDispose,
                AgentFacilityName = assent.FacilityAgentId != null ? assent.FacilityAgent.FacilityAgentName : assent.Profile.ProfileName,
                AgentIDNumber = assent.FacilityAgentId != null ? assent.FacilityAgent.Idnumber : assent.Profile.Idnumber,
                AgentPhone = assent.FacilityAgentId != null ? assent.FacilityAgent.Phone : assent.Profile.Phone1,
                // MachineCount = assent
                // Gender = assent.FacilityAgentId!=null?assent.FacilityAgent.Gander:assent.Profile.,
            }
            ).SingleOrDefaultAsync();
            // var strinJson= JsonConvert.SerializeObject(AssentDetails);
            //  var MAssentRespone= JsonConvert.DeserializeObject<MachineAssentResponse>(strinJson);
            return AssentDetails;

        }

        public async Task<List<AssentReportResponse>> GetProfileFacilityAssents(int StationID, string startDate, string endDate, int FuelTypeParam, string FullName, int StatusID)
        {
            var strDate = startDate != null && startDate != "" ? DateTime.Parse(startDate) : DateTime.Now.Date;//new DateTime(2020, 8, 9);//DateTime;//.UtcNow; 
            var enddDate = endDate != null && endDate != "" ? DateTime.Parse(endDate) : DateTime.Now.Date;// : strDate.AddDays(1);// DateTime.UtcNow.AddDays(1);//.ToShortDateString();

            var AssentsReports = await _context.MprofileFacilityAssent
               .Where(assent => assent.StartDate.Date <= strDate.Date && assent.ExpDate.Date >= enddDate.Date)

               .Where(assent => assent.StationId == StationID)
               // //   .Include(assent => assent.FuelType.FuelTypeId)
               .Where(assent => (FuelTypeParam == 0 || assent.FuelType.FuelTypeId == FuelTypeParam))

               .Where(assent => (StatusID == 0 || assent.StatusId == StatusID))

               .Where(assent => (FullName == null || FullName == "" || assent.Profile.ProfileName.Contains(FullName)))

               .Select(assent => new AssentReportResponse
               {

                   AssentId = assent.AssentId,

                   FacilityName = assent.ProfileFacility.ProfileFacilityName,

                   ProfileName = assent.Profile.ProfileName,

                   FacilityTypeName = assent.Facility.FacilityName,

                   SectionName = assent.Section.SectionName,

                   AgentFacilityName = assent.FacilityAgentId != null ? assent.FacilityAgent.FacilityAgentName : assent.Profile.ProfileName,

                   AgentIDNumber = assent.FacilityAgentId != null ? assent.FacilityAgent.Idnumber : assent.Profile.Idnumber,

                   AgentPhone = assent.FacilityAgentId != null ? assent.FacilityAgent.Phone : assent.Profile.Phone1,

                  // details = new {MarkName = assent.Machine.Mark.MarkName, ModelName= assent.Machine.Model.ModelName},

                  fuelInfo = new FuelInfoAssent { FuelName = assent.Fuel.FuelName, FuelTypeName = assent.FuelType.FuelTypeName, fuelID = assent.FuelId },



                   ExpDate = assent.ExpDate,

                   startDate = assent.StartDate,

                   StatusID = assent.ExpDate.Date < DateTime.Now.Date ? 3 : (assent.StartDate > DateTime.Now.Date ? 6 : assent.StatusId),

                   StatusName = (assent.StatusId == 1 ? (assent.ExpDate.Date < DateTime.Now.Date ? "منتهي الصلاحية" : (assent.StartDate > DateTime.Now.Date ? "تاريخ الصرف ليس الان " : "ساري")) : "غير ساري"),



                   ApprovedLiter = assent.ApprovedLiter,

               })
                .OrderBy(i => i.ExpDate)
                  .ToListAsync();

            return AssentsReports;

        }

        public PagedList<ReportsResponse> GetTest(int StationID, string strDate, string endSate, int FuelTypeParam, string FullName)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateProfileFacilityAssents(long AssentID)
        {
            throw new System.NotImplementedException();
        }

        [Obsolete]
        public async Task<bool> ValidStationProfileFacilityAssent(Guid assentID, string StationID, string UserName)
        {
            //var Assent = await _context.MprofileFacilityAssent.AsNoTracking().SingleOrDefaultAsync(assent => assent.Qrcode == assentID);
            //if (Assent == null)
            //{
            //    throw new HttpResponseException()
            //    {
            //        Status = 403,
            //        Value = new ErrorsResponse
            //        {
            //            Errors = new[] { "Sory This Assent ID  INvalid " },
            //            Success = false
            //        }
            //    };
            //}
            //              // Check Station 
            //            if(Assent.StationId != int.Parse(StationID))
            //                 throw new HttpResponseException(){ Status = 403 ,Value = new ErrorsResponse{
            //             Errors = new[] { "Sory This Station   INvalid " },
            //             Success = false
            //         }};

            //                 // Check Expir Date 
            //             if(Assent.ExpDate < DateTime.Now.Date )
            //                 throw new HttpResponseException(){ Status = 403 ,Value = new ErrorsResponse{
            //             Errors = new[] { " Sory The Assent Id Is ExpireDate " },
            //             Success = false
            //         }};

            //             // check Status to agree 
            //             if(Assent.StatusId != 1)
            //             throw new HttpResponseException(){ Status = 403 ,Value = new ErrorsResponse{
            //             Errors = new[] { " Sory The Assent is Withdrawed " },
            //             Success = false
            //         }};

            //    // int id=AssentID;
            //                 // TODO Call Procedure UpdateMachineAssentsToMachineAssents 
            //             //  var  machineAssent= await _context.MprofileFacilityAssent.FirstOrDefaultAsync(m => m.AssentId == AssentID);

            //              // Change StatuId To Done Complate Operation
            //              Assent.StatusId=IMachineAssentServices.StatuseComplated;
            //             // _context.MmachineAssent.Attach(machineAssent);
            //             // Save Change To DB         
            //             _context.Entry(Assent).Property(Uassents => Uassents.StatusId).IsModified = true;
            //            var Updated = await _context.SaveChangesAsync();
            //             // _context.MmachineAssent.Attach()
            //             return Updated > 0;
            //         //  var tsStationQuota=_context.TstationQuota.SingleOrDefault(ts=> ts.StationId== Assent.StationId 
            //         //  && ts.Date==DateTime.Now.Date && ts.FuelId== Assent.FuelId && ts.FuelTypeId == Assent.FuelTypeId);

            //         //    tsStationQuota.TotalWithdraw+=Assent.TotalLiter;
            //         //     // _context.MmachineAssent.Attach(machineAssent);
            //         //     // Save Change To DB         
            //         //     _context.Entry(tsStationQuota).Property(tsStationQuota => tsStationQuota.TotalWithdraw).IsModified = true;
            //         //    var Updated = await _context.SaveChangesAsync();
            var AssentIDP = new SqlParameter("@AssentID", assentID);
            var StationIDP = new SqlParameter("@UserStationID", StationID);
            var UserNameP = new SqlParameter("@UserName", UserName);
            var reternP = new SqlParameter() { ParameterName = "@retVal", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output, Value = -1 };
            _ = await _context.Database.ExecuteSqlCommandAsync("EXEC @retVal = [dbo].[AssentWithdraw] @AssentID,@UserStationID,@UserName", reternP, AssentIDP, StationIDP, UserNameP);
            int res = (int)reternP.Value;
            if (res == -1)
            {
                throw new HttpResponseException()
                {
                    Status = 403,

                    Value = new ErrorsResponse
                    {

                        Errors = new[] { "Sory This Assent ID  INvalid " },
                        Success = false,
                        Code = res,
                    }
                };
            }
            // Check Station 
            if (res == -2)
                throw new HttpResponseException()
                {
                    Status = 403,
                    Value = new ErrorsResponse
                    {
                        Errors = new[] { "Sory This Station   INvalid " },
                        Success = false,
                        Code = res,

                    }
                };

            // Check Expir Date 
            if (res == -3)
                throw new HttpResponseException()
                {
                    Status = 403,
                    Value = new ErrorsResponse
                    {
                        Errors = new[] { " Sory The Assent Id Is Withdrowed " },
                        Success = false,
                        Code = res,

                    }
                };

            // check Status to agree 
            if (res == -4)
                throw new HttpResponseException()
                {
                    Status = 403,
                    Value = new ErrorsResponse
                    {
                        Errors = new[] { " Sorry The Assent is Expaired " },
                        Success = false,
                        Code = res,

                    }
                };


            //         //   var tsStationQuota =_context.TStationQuota.SingleOrDefault(ts=> ts.StationID== Assent.StationId 
            //         //&& ts.Date==DateTime.Now.Date && ts.FuelID== Assent.FuelId && ts.FuelTypeID == Assent.FuelTypeId);

            //         //  tsStationQuota.TotalWithdraw+=Assent.ApprovedLiter;
            //         //   // _context.MmachineAssent.Attach(machineAssent);
            //         //   // Save Change To DB         
            //         //   _context.Entry(tsStationQuota).Property(tsStationQuota => tsStationQuota.TotalWithdraw).IsModified = true;
            //         //  var Updated = await _context.SaveChangesAsync();

            return true;

        }
    }
}