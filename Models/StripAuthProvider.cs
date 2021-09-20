using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class StripAuthProvider
    {
        public int TripAuthProviderId { get; set; }
        public string TripAuthProviderName { get; set; }
        public int StateId { get; set; }
        public bool Active { get; set; }
    }
}
