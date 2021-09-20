using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Domain.Response
{


    public class FuelResponse
    {

        public int FuelTyeID { get; set; }
        public string FuelTypeName { get; set; }
       
        public bool? Active { get; set; }
      

    }

}