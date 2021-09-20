using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SfuelType
    {
        public SfuelType()
        {
            Mconfig = new HashSet<Mconfig>();
            MprofileFacility = new HashSet<MprofileFacility>();
            MprofileFacilityAssent = new HashSet<MprofileFacilityAssent>();
            Mvehicle = new HashSet<Mvehicle>();
            MvehicleTripAssent = new HashSet<MvehicleTripAssent>();
            TfuelTypeStation = new HashSet<TfuelTypeStation>();
            TquotaState = new HashSet<TquotaState>();
            TstationQuota = new HashSet<TstationQuota>();
        }

        public int FuelTypeId { get; set; }
        public string FuelTypeName { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Mconfig> Mconfig { get; set; }
        public virtual ICollection<MprofileFacility> MprofileFacility { get; set; }
        public virtual ICollection<MprofileFacilityAssent> MprofileFacilityAssent { get; set; }
        public virtual ICollection<Mvehicle> Mvehicle { get; set; }
        public virtual ICollection<MvehicleTripAssent> MvehicleTripAssent { get; set; }
        public virtual ICollection<TfuelTypeStation> TfuelTypeStation { get; set; }
        public virtual ICollection<TquotaState> TquotaState { get; set; }
        public virtual ICollection<TstationQuota> TstationQuota { get; set; }
    }
}
