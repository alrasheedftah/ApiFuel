using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class ZcheckPoint
    {
        public long AssentId { get; set; }
        public long VehicleId { get; set; }
        public int StopStationId { get; set; }
        public DateTime CheckDate { get; set; }
    }
}
