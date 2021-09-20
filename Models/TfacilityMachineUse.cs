using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class TfacilityMachineUse
    {
        public int FacilityId { get; set; }
        public int MachineTypeId { get; set; }
        public decimal MonthlyUse { get; set; }

        public virtual Nfacility Facility { get; set; }
        public virtual SmachineType MachineType { get; set; }
    }
}
