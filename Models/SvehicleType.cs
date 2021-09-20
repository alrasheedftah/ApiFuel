using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SvehicleType
    {
        public SvehicleType()
        {
            Mvehicle = new HashSet<Mvehicle>();
            NtripConfig = new HashSet<NtripConfig>();
            TfacilityVehicleUse = new HashSet<TfacilityVehicleUse>();
        }

        public int VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Mvehicle> Mvehicle { get; set; }
        public virtual ICollection<NtripConfig> NtripConfig { get; set; }
        public virtual ICollection<TfacilityVehicleUse> TfacilityVehicleUse { get; set; }
    }
}
