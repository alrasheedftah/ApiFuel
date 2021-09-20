using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SstationType
    {
        public SstationType()
        {
            TstationType = new HashSet<TstationType>();
        }

        public int StationTypeId { get; set; }
        public string StationTypeName { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<TstationType> TstationType { get; set; }
    }
}
