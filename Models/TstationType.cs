using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class TstationType
    {
        public int StationId { get; set; }
        public int StationTypeId { get; set; }
        public string RoleName { get; set; }
        public bool Active { get; set; }

        public virtual Sstation Station { get; set; }
        public virtual SstationType StationType { get; set; }
    }
}
