using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class TfuelTypeWareHouse
    {
        public int WareHouseId { get; set; }
        public int FuelTypeId { get; set; }
        public int NumberOfNozzle { get; set; }
        public decimal TankCapacity { get; set; }

        public virtual Nfuel FuelType { get; set; }
        public virtual NwareHouse WareHouse { get; set; }
    }
}
