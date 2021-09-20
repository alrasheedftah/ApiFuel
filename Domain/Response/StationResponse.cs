using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;
// using WebApplication1.Models;

namespace ApiAppPetrol.Domain.Response
{


    public class StationResponse
    {
    
        public int StationId { get; set; }
        public int LocalityId { get; set; }

        public string StationName { get; set; }
        public string LocalityName { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }
        public bool? Active { get; set; }
        public string CompanyName { get; set; }

        public decimal SumQuantity { get; set; }

       
        public decimal totAssent(){
            
            return (decimal)TstationQuota.LastOrDefault().TotalAssent;
        }
       
        public ICollection<TsResponse> TstationQuota { get; set; }
                
    }

   public class TsResponse{

         public int FuelID { get; set; }
         public int FuelTypeID { get; set; }
         public string FuelName { get; set; }
         public string FuelTypeName { get; set; }
         public decimal Quantity { get; set; }
         public decimal TotalAssent { get; set; }

         public decimal  TotalWithdraw { get; set; }

         public int AssentCount { get; set; }

        public int AssentWithdrawCount { get; set; }

        public int AssentActiveCount { get; set; }
        public decimal RemWithdraw { get; set; }
        public decimal RemQuantity { get; set; }

        

// RemWithdraw     RemAssent

   }

    

}