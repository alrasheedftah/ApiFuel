using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class MmachineAssent
    {
        public long ProfileFacilityAssentId { get; set; }
        public long MachineId { get; set; }
        public int? ConsumptionId { get; set; }
        public int MonthlyUse { get; set; }
        public decimal TotalLiter { get; set; }

        public virtual Mmachine Machine { get; set; }
    }
}
