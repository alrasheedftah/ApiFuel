using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class StripAuth
    {
        public int TripAuthId { get; set; }
        public string TripAuthName { get; set; }
        public bool Active { get; set; }
    }
}
