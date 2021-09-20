using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Sidtype
    {
        public Sidtype()
        {
            Mprofile = new HashSet<Mprofile>();
            NfacilityAgent = new HashSet<NfacilityAgent>();
        }

        public int IdtypeId { get; set; }
        public string IdtypeName { get; set; }
        public string Idmask { get; set; }
        public int ProfileTypeId { get; set; }
        public bool? Active { get; set; }

        public virtual SprofileType ProfileType { get; set; }
        public virtual ICollection<Mprofile> Mprofile { get; set; }
        public virtual ICollection<NfacilityAgent> NfacilityAgent { get; set; }
    }
}
