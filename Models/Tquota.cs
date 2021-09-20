using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Tquota
    {
        public int FuelTypeId { get; set; }
        public DateTime Date { get; set; }
        public decimal Quantity { get; set; }
        public string UserAdded { get; set; }

        public virtual Nfuel FuelType { get; set; }
    }
}
