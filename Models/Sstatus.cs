using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Sstatus
    {
        public Sstatus()
        {
            Mmachine = new HashSet<Mmachine>();
            Mprofile = new HashSet<Mprofile>();
            MprofileFacility = new HashSet<MprofileFacility>();
            MprofileFacilityAssent = new HashSet<MprofileFacilityAssent>();
            Mvehicle = new HashSet<Mvehicle>();
            MvehicleTripAssent = new HashSet<MvehicleTripAssent>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public int StatusType { get; set; }
        public string StatusDescription { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Mmachine> Mmachine { get; set; }
        public virtual ICollection<Mprofile> Mprofile { get; set; }
        public virtual ICollection<MprofileFacility> MprofileFacility { get; set; }
        public virtual ICollection<MprofileFacilityAssent> MprofileFacilityAssent { get; set; }
        public virtual ICollection<Mvehicle> Mvehicle { get; set; }
        public virtual ICollection<MvehicleTripAssent> MvehicleTripAssent { get; set; }
    }
}
