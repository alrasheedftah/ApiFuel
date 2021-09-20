using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class TquotaStation
    {
        public int StationId { get; set; }
        public int WareHouseId { get; set; }
        public int FuelTypeId { get; set; }
        public DateTime Date { get; set; }
        public decimal Quantity { get; set; }
        public int CompanyId { get; set; }
        public int Status { get; set; }
        public string UserAdded { get; set; }

        public virtual Ncompany Company { get; set; }
        public virtual Nfuel FuelType { get; set; }
        public virtual Sstation Station { get; set; }
        public virtual NwareHouse WareHouse { get; set; }
    }
}
