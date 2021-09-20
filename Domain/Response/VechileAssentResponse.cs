using System;
using System.Collections.Generic;
// using WebApplication1.Models;

namespace ApiAppPetrol.Domain.Response
{

        public class VechileAssentResponse{
        public long AssentId { get; set; }
        public long VehicleId { get; set; }
        public string    ProfileName { get; set; }
        public string    StateName { get; set; }
        public string    OfficeName { get; set; }
        public string    CompanyName { get; set; }
        public string    StationName { get; set; }

        public int    StationID { get; set; }

        public string    FuelName { get; set; }
        public string    FuelTypeName { get; set; }
        
        public int    StatusId { get; set; }        
        public string    StatusName { get; set; }
        public string    TripAuthName { get; set; }
        public string    TripAuthProviderName { get; set; }
        public string TripAuthNumber { get; set; }
        public decimal TotalLiter { get; set; }
        public decimal ApprovedLiter { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpDate { get; set; }
      
      
        
    }


}