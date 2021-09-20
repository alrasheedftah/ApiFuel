using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;
// using WebApplication1.Models;

namespace ApiAppPetrol.Domain.Response
{
    public class OnRoadQuotaResponse
    {
    
        public int ID { get; set; }

        public int StationId { get; set; }
        // public int LocalityId { get; set; }

        // public string StationName { get; set; }
        // public string LocalityName { get; set; }

        // public string Address { get; set; }
        // public string Phone { get; set; }
        // public bool? Active { get; set; }
        // public string CompanyName { get; set; }

         public int FuelID { get; set; }
         public int FuelTypeID { get; set; }
         public string FuelName { get; set; }
         public string FuelTypeName { get; set; }
         public decimal Quantity { get; set; }

        public DateTime DateMove { get; set; }


       
    }

  
    

}