using System;
using System.Collections.Generic;
// using WebApplication1.Models;

namespace ApiAppPetrol.Domain.Response
{

        public class AssentReportResponse{ 
        public long AssentId { get; set; }

        public string FacilityName { get; set; }

        public string ProfileName { get; set; }

        public string FacilityTypeName { get; set; }

        public string AgentFacilityName { get; set; }

        public string AgentIDNumber { get; set; }
        public string AgentPhone { get; set; }

        public Details details { get; set; }
        // public string ModelName { get; set; }

        public FuelInfoAssent fuelInfo { get; set; }
        // public string FuelTypeName { get; set; }

        
        public decimal TotalLiter { get; set; }
        public decimal ApprovedLiter { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime ExpDate { get; set; } 

        public DateTime startDate { get; set; }


        public int StatusID { get; set; }

        public string StatusName { get; set; }

        public string FullName { get; set; }

        public string SectionName { get; set; }


        public string PhoneNumber { get; set; }


        // public int CountFuelType { get; set; }
        
        
    }


    public class FuelInfoAssent{
        //FuelName   //FuelTypeName

        public string FuelName { get; set; }
        public int fuelID{get ; set;}
        public string FuelTypeName { get; set; }

    }

}