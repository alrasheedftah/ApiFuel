using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SstatusAssent
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public int StatusType { get; set; }
        public string StatusDescription { get; set; }
        public bool? Active { get; set; }
    }
}
