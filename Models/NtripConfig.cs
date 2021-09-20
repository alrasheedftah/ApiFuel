using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class NtripConfig
    {
        public int TripId { get; set; }
        public int TripLfrom { get; set; }
        public int TripLto { get; set; }
        public int RoadTypeId { get; set; }
        public int VehicleTypeId { get; set; }
        public int Distance { get; set; }
        public decimal ApprovedFuel { get; set; }
        public bool? Active { get; set; }

        public virtual SroadType RoadType { get; set; }
        public virtual SvehicleType VehicleType { get; set; }
    }
}
