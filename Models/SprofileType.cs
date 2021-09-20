using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SprofileType
    {
        public SprofileType()
        {
            Mconfig = new HashSet<Mconfig>();
            Mprofile = new HashSet<Mprofile>();
            MprofileFacilityAssent = new HashSet<MprofileFacilityAssent>();
            MvehicleTripAssent = new HashSet<MvehicleTripAssent>();
            Sidtype = new HashSet<Sidtype>();
            Sjob = new HashSet<Sjob>();
            SprofileAttachmentType = new HashSet<SprofileAttachmentType>();
            SvehicleAttachmentType = new HashSet<SvehicleAttachmentType>();
        }

        public int ProfileTypeId { get; set; }
        public string ProfileTypeName { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Mconfig> Mconfig { get; set; }
        public virtual ICollection<Mprofile> Mprofile { get; set; }
        public virtual ICollection<MprofileFacilityAssent> MprofileFacilityAssent { get; set; }
        public virtual ICollection<MvehicleTripAssent> MvehicleTripAssent { get; set; }
        public virtual ICollection<Sidtype> Sidtype { get; set; }
        public virtual ICollection<Sjob> Sjob { get; set; }
        public virtual ICollection<SprofileAttachmentType> SprofileAttachmentType { get; set; }
        public virtual ICollection<SvehicleAttachmentType> SvehicleAttachmentType { get; set; }
    }
}
