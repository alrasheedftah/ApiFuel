using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class TfuelTypeStation
    {
        public int StationId { get; set; }
        public int FuelId { get; set; }
        public int FuelTypeId { get; set; }
        public int NumberOfNozzle { get; set; }
        public decimal TankCapacity { get; set; }

        public virtual Nfuel Fuel { get; set; }
        public virtual SfuelType FuelType { get; set; }
        public virtual Sstation Station { get; set; }
    }
}
