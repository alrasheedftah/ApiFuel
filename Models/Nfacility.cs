using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Nfacility
    {
        public Nfacility()
        {
            Mconfig = new HashSet<Mconfig>();
            MprofileFacility = new HashSet<MprofileFacility>();
            MprofileFacilityAssent = new HashSet<MprofileFacilityAssent>();
            SmachineAttachmentType = new HashSet<SmachineAttachmentType>();
            TfacilityMachineUse = new HashSet<TfacilityMachineUse>();
            TfacilityVehicleUse = new HashSet<TfacilityVehicleUse>();
        }

        public int FacilityId { get; set; }
        public string FacilityName { get; set; }
        public string Prefix { get; set; }
        public int ActivityWeighte { get; set; }
        public int SectionId { get; set; }
        public bool? Active { get; set; }

        public virtual Nsection Section { get; set; }
        public virtual ICollection<Mconfig> Mconfig { get; set; }
        public virtual ICollection<MprofileFacility> MprofileFacility { get; set; }
        public virtual ICollection<MprofileFacilityAssent> MprofileFacilityAssent { get; set; }
        public virtual ICollection<SmachineAttachmentType> SmachineAttachmentType { get; set; }
        public virtual ICollection<TfacilityMachineUse> TfacilityMachineUse { get; set; }
        public virtual ICollection<TfacilityVehicleUse> TfacilityVehicleUse { get; set; }
    }
}
