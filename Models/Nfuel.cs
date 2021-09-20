using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Nfuel
    {
        public Nfuel()
        {
            Mconfig = new HashSet<Mconfig>();
            Mmachine = new HashSet<Mmachine>();
            MprofileFacilityAssent = new HashSet<MprofileFacilityAssent>();
            Mvehicle = new HashSet<Mvehicle>();
            MvehicleTripAssent = new HashSet<MvehicleTripAssent>();
            TfuelTypeStation = new HashSet<TfuelTypeStation>();
            TfuelTypeWareHouse = new HashSet<TfuelTypeWareHouse>();
            Tquota = new HashSet<Tquota>();
            TquotaCompany = new HashSet<TquotaCompany>();
            TquotaState = new HashSet<TquotaState>();
            TquotaStation = new HashSet<TquotaStation>();
            TquotaWareHouse = new HashSet<TquotaWareHouse>();
            TstationQuota = new HashSet<TstationQuota>();
        }

        public int FuelId { get; set; }
        public string FuelName { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Mconfig> Mconfig { get; set; }
        public virtual ICollection<Mmachine> Mmachine { get; set; }
        public virtual ICollection<MprofileFacilityAssent> MprofileFacilityAssent { get; set; }
        public virtual ICollection<Mvehicle> Mvehicle { get; set; }
        public virtual ICollection<MvehicleTripAssent> MvehicleTripAssent { get; set; }
        public virtual ICollection<TfuelTypeStation> TfuelTypeStation { get; set; }
        public virtual ICollection<TfuelTypeWareHouse> TfuelTypeWareHouse { get; set; }
        public virtual ICollection<Tquota> Tquota { get; set; }
        public virtual ICollection<TquotaCompany> TquotaCompany { get; set; }
        public virtual ICollection<TquotaState> TquotaState { get; set; }
        public virtual ICollection<TquotaStation> TquotaStation { get; set; }
        public virtual ICollection<TquotaWareHouse> TquotaWareHouse { get; set; }
        public virtual ICollection<TstationQuota> TstationQuota { get; set; }
    }
}
