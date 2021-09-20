using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Slocality
    {
        public Slocality()
        {
            Mprofile = new HashSet<Mprofile>();
            MprofileFacility = new HashSet<MprofileFacility>();
            MprofileFacilityAssent = new HashSet<MprofileFacilityAssent>();
            MvehicleTripAssent = new HashSet<MvehicleTripAssent>();
            NwareHouse = new HashSet<NwareHouse>();
            Soffice = new HashSet<Soffice>();
            Sstation = new HashSet<Sstation>();
            SuserLocality = new HashSet<SuserLocality>();
        }

        public int LocalityId { get; set; }
        public string LocalityName { get; set; }
        public int StateId { get; set; }
        public bool? Active { get; set; }

        public virtual Nstate State { get; set; }
        public virtual ICollection<Mprofile> Mprofile { get; set; }
        public virtual ICollection<MprofileFacility> MprofileFacility { get; set; }
        public virtual ICollection<MprofileFacilityAssent> MprofileFacilityAssent { get; set; }
        public virtual ICollection<MvehicleTripAssent> MvehicleTripAssent { get; set; }
        public virtual ICollection<NwareHouse> NwareHouse { get; set; }
        public virtual ICollection<Soffice> Soffice { get; set; }
        public virtual ICollection<Sstation> Sstation { get; set; }
        public virtual ICollection<SuserLocality> SuserLocality { get; set; }
    }
}
