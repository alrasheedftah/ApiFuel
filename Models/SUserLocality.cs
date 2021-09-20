using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SuserLocality
    {
        public string UserName { get; set; }
        public int LocalityId { get; set; }

        public virtual Slocality Locality { get; set; }
    }
}
