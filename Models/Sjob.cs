using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Sjob
    {
        public Sjob()
        {
            Mprofile = new HashSet<Mprofile>();
        }

        public int JobId { get; set; }
        public string JobName { get; set; }
        public int ProfileTypeId { get; set; }
        public bool? Active { get; set; }

        public virtual SprofileType ProfileType { get; set; }
        public virtual ICollection<Mprofile> Mprofile { get; set; }
    }
}
