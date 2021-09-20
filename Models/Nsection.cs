using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Nsection
    {
        public Nsection()
        {
            Mconfig = new HashSet<Mconfig>();
            MprofileFacility = new HashSet<MprofileFacility>();
            MprofileFacilityAssent = new HashSet<MprofileFacilityAssent>();
            Nfacility = new HashSet<Nfacility>();
            SmachineType = new HashSet<SmachineType>();
            SprofileFacilityAttachmentTypes = new HashSet<SprofileFacilityAttachmentTypes>();
        }

        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public string Prefix { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Mconfig> Mconfig { get; set; }
        public virtual ICollection<MprofileFacility> MprofileFacility { get; set; }
        public virtual ICollection<MprofileFacilityAssent> MprofileFacilityAssent { get; set; }
        public virtual ICollection<Nfacility> Nfacility { get; set; }
        public virtual ICollection<SmachineType> SmachineType { get; set; }
        public virtual ICollection<SprofileFacilityAttachmentTypes> SprofileFacilityAttachmentTypes { get; set; }
    }
}
