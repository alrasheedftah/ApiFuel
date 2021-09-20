using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SroadType
    {
        public SroadType()
        {
            NtripConfig = new HashSet<NtripConfig>();
        }

        public int RoadTypeId { get; set; }
        public string RoadTypeName { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<NtripConfig> NtripConfig { get; set; }
    }
}
