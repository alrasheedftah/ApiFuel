using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Ncompany
    {
        public Ncompany()
        {
            MprofileFacilityAssent = new HashSet<MprofileFacilityAssent>();
            MvehicleTripAssent = new HashSet<MvehicleTripAssent>();
            Sstation = new HashSet<Sstation>();
            TquotaCompany = new HashSet<TquotaCompany>();
            TquotaStation = new HashSet<TquotaStation>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<MprofileFacilityAssent> MprofileFacilityAssent { get; set; }
        public virtual ICollection<MvehicleTripAssent> MvehicleTripAssent { get; set; }
        public virtual ICollection<Sstation> Sstation { get; set; }
        public virtual ICollection<TquotaCompany> TquotaCompany { get; set; }
        public virtual ICollection<TquotaStation> TquotaStation { get; set; }
    }
}
