using System;
using System.Collections.Generic;
// using WebApplication1.Models;

namespace ApiAppPetrol.Domain.Response
{

        public class VechileResponse{
        public long VehicleId { get; set; }
        public long ProfileId { get; set; }
        public string    ProfileName { get; set; }
        public int MarkId { get; set; }
        public string    MarkName { get; set; }
        public int ModelId { get; set; }
        public string    ModelName { get; set; }

        public string    PlateChar { get; set; }
        public int    PlateNumber { get; set; }
        public string    ManufaDate { get; set; }
        public string    ChassisNum { get; set; }
        public decimal    TankCapacity { get; set; }
        public string    FuelName { get; set; }
        public string    FuelTypeName { get; set; }
        
        public int    StatusId { get; set; }        
        public string    StatusName { get; set; }     
        public VehicleCard vehicleCard { get; set; }



      
        
    }

public class VehicleCard{
        public string UserAdded { get; set; }
        public DateTime ExpDate { get; set; }
        public DateTime DateAdded { get; set; }

}
}