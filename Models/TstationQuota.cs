using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class TstationQuota
    {
        public int StationId { get; set; }
        public int FuelId { get; set; }
        public int FuelTypeId { get; set; }
        public DateTime Date { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalAssent { get; set; }
        public decimal TotalWithdraw { get; set; }
        public decimal RemQuantity { get; set; }
        public decimal RemWithdraw { get; set; }
        public string UserAdded { get; set; }

        public virtual Nfuel Fuel { get; set; }
        public virtual SfuelType FuelType { get; set; }
        public virtual Sstation Station { get; set; }
    }
}
