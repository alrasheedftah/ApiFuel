using System;
using System.Collections.Generic;
// using WebApplication1.Models;

namespace ApiAppPetrol.Domain.Response
{

        public class ReportsResponse{
        public long AssentId { get; set; }
        public Details details { get; set; }
        // public string ModelName { get; set; }

        public FuelInfo fuelInfo { get; set; }
        // public string FuelTypeName { get; set; }

        
        public decimal TotalLiter { get; set; }
        public decimal ApprovedLiter { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime ExpDate { get; set; } 

        public DateTime startDate { get; set; }


        public int StatusID { get; set; }

        public string StatusName { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }


        // public int CountFuelType { get; set; }
        
        
    }

    public class Details{

        public string MarkName { get; set; }

        public string ModelName { get; set; }
    }

    public class FuelInfo{
        //FuelName   //FuelTypeName

        public string FuelName { get; set; }
        public int fuelID{get ; set;}
        public string FuelTypeName { get; set; }

    }

}