using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class MvehicleCard
    {
        public long VehicleCardId { get; set; }
        public long VehicleId { get; set; }
        public long ProfileId { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserAdded { get; set; }
        public DateTime ExpDate { get; set; }

        public virtual Mvehicle Vehicle { get; set; }
        public virtual Mprofile VehicleCard { get; set; }
    }
}
