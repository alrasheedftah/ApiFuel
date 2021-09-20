using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Sconsumption
    {
        public Sconsumption()
        {
            Mmachine = new HashSet<Mmachine>();
        }

        public int ConsumptionId { get; set; }
        public decimal ConsumptionKva { get; set; }
        public decimal ConsumptionKw { get; set; }
        public decimal ConsumptionHp { get; set; }
        public decimal ConsumptionGh { get; set; }
        public decimal ConsumptionLh { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Mmachine> Mmachine { get; set; }
    }
}
