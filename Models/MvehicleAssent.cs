using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class MvehicleAssent
    {
        public long ProfileFacilityAssentId { get; set; }
        public long VehicleId { get; set; }
        public int? ConsumptionId { get; set; }
        public int MonthlyUse { get; set; }
        public decimal TotalLiter { get; set; }

        public virtual Mvehicle Vehicle { get; set; }
    }
}
