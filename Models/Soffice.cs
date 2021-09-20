using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Soffice
    {
        public Soffice()
        {
            MprofileFacilityAssent = new HashSet<MprofileFacilityAssent>();
            MvehicleTripAssent = new HashSet<MvehicleTripAssent>();
        }

        public int OfficeId { get; set; }
        public string OfficeName { get; set; }
        public int StateId { get; set; }
        public int LocalityId { get; set; }
        public bool? Active { get; set; }

        public virtual Slocality Locality { get; set; }
        public virtual Nstate State { get; set; }
        public virtual ICollection<MprofileFacilityAssent> MprofileFacilityAssent { get; set; }
        public virtual ICollection<MvehicleTripAssent> MvehicleTripAssent { get; set; }
    }
}
