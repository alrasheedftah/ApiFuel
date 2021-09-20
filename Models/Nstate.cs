using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Nstate
    {
        public Nstate()
        {
            Mconfig = new HashSet<Mconfig>();
            Mprofile = new HashSet<Mprofile>();
            MprofileFacility = new HashSet<MprofileFacility>();
            MprofileFacilityAssent = new HashSet<MprofileFacilityAssent>();
            MvehicleTripAssent = new HashSet<MvehicleTripAssent>();
            NwareHouse = new HashSet<NwareHouse>();
            ScarLetter = new HashSet<ScarLetter>();
            Slocality = new HashSet<Slocality>();
            Soffice = new HashSet<Soffice>();
            TquotaState = new HashSet<TquotaState>();
        }

        public int StateId { get; set; }
        public string StateName { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Mconfig> Mconfig { get; set; }
        public virtual ICollection<Mprofile> Mprofile { get; set; }
        public virtual ICollection<MprofileFacility> MprofileFacility { get; set; }
        public virtual ICollection<MprofileFacilityAssent> MprofileFacilityAssent { get; set; }
        public virtual ICollection<MvehicleTripAssent> MvehicleTripAssent { get; set; }
        public virtual ICollection<NwareHouse> NwareHouse { get; set; }
        public virtual ICollection<ScarLetter> ScarLetter { get; set; }
        public virtual ICollection<Slocality> Slocality { get; set; }
        public virtual ICollection<Soffice> Soffice { get; set; }
        public virtual ICollection<TquotaState> TquotaState { get; set; }
    }
}
