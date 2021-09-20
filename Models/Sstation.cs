using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Sstation
    {
        public Sstation()
        {
            MprofileFacilityAssent = new HashSet<MprofileFacilityAssent>();
            MvehicleTripAssent = new HashSet<MvehicleTripAssent>();
            TfuelTypeStation = new HashSet<TfuelTypeStation>();
            TquotaStation = new HashSet<TquotaStation>();
            TstationQuota = new HashSet<TstationQuota>();
            TstationType = new HashSet<TstationType>();
        }

        public int StationId { get; set; }
        public string StationName { get; set; }
        public int LocalityId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool? Active { get; set; }
        public int CompanyId { get; set; }
        public bool Assent { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserAdded { get; set; }
        public string UserUpdate { get; set; }

        public virtual Ncompany Company { get; set; }
        public virtual Slocality Locality { get; set; }
        public virtual ICollection<MprofileFacilityAssent> MprofileFacilityAssent { get; set; }
        public virtual ICollection<MvehicleTripAssent> MvehicleTripAssent { get; set; }
        public virtual ICollection<TfuelTypeStation> TfuelTypeStation { get; set; }
        public virtual ICollection<TquotaStation> TquotaStation { get; set; }
        public virtual ICollection<TstationQuota> TstationQuota { get; set; }
        public virtual ICollection<TstationType> TstationType { get; set; }
    }
}
