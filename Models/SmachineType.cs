using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SmachineType
    {
        public SmachineType()
        {
            Mmachine = new HashSet<Mmachine>();
            TfacilityMachineUse = new HashSet<TfacilityMachineUse>();
        }

        public int MachineTypeId { get; set; }
        public string MachineTypeName { get; set; }
        public int SectionId { get; set; }
        public bool? Active { get; set; }

        public virtual Nsection Section { get; set; }
        public virtual ICollection<Mmachine> Mmachine { get; set; }
        public virtual ICollection<TfacilityMachineUse> TfacilityMachineUse { get; set; }
    }
}
