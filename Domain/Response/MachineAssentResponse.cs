using System;
using System.Collections.Generic;
// using WebApplication1.Models;

namespace ApiAppPetrol.Domain.Response
{

        public class MachineAssentResponse{
        // public long AssentId { get; set; }
        public string MachineName { get; set; }
        public string ProfileName { get; set; }
        public string SectionName { get; set; }
        public string FacilityName { get; set; }
        public string StateName { get; set; }
        public string LocalityName { get; set; }
        public string OfficeName { get; set; }
        public string CompanyName { get; set; }
        public string StationName { get; set; }

        public int StationID { get; set; }

        public string FuelName { get; set; }
        public string FuelTypeName { get; set; }

         public int FuelID { get; set; }
         public int FuelTypeID { get; set; }

        public int StatusId { get; set; }

        public string StatusName { get; set; }
        public decimal TotalLiter { get; set; }
        public decimal ApprovedLiter { get; set; }


        public DateTime startDate { get; set; }

        public DateTime ExpDate { get; set; }
    

        
        
    }


// public class StationInfoAssent{
//  public int FuelID { get; set; }
//   public int FuelTypeID { get; set; }
// }

}