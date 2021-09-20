using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class TquotaState
    {
        public int StateId { get; set; }
        public int WareHouseId { get; set; }
        public int FuelId { get; set; }
        public int FuelTypeId { get; set; }
        public DateTime Date { get; set; }
        public decimal Quantity { get; set; }
        public string UserAdded { get; set; }

        public virtual Nfuel Fuel { get; set; }
        public virtual SfuelType FuelType { get; set; }
        public virtual Nstate State { get; set; }
        public virtual NwareHouse WareHouse { get; set; }
    }
}
