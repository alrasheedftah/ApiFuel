using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class TfacilityVehicleUse
    {
        public int FacilityId { get; set; }
        public int VehicleTypeId { get; set; }
        public decimal MonthlyUse { get; set; }

        public virtual Nfacility Facility { get; set; }
        public virtual SvehicleType VehicleType { get; set; }
    }
}
