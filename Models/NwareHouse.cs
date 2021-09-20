using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class NwareHouse
    {
        public NwareHouse()
        {
            TfuelTypeWareHouse = new HashSet<TfuelTypeWareHouse>();
            TquotaCompany = new HashSet<TquotaCompany>();
            TquotaState = new HashSet<TquotaState>();
            TquotaStation = new HashSet<TquotaStation>();
            TquotaWareHouse = new HashSet<TquotaWareHouse>();
        }

        public int WareHouseId { get; set; }
        public string WareHouseName { get; set; }
        public int StateId { get; set; }
        public int LocalityId { get; set; }

        public virtual Slocality Locality { get; set; }
        public virtual Nstate State { get; set; }
        public virtual ICollection<TfuelTypeWareHouse> TfuelTypeWareHouse { get; set; }
        public virtual ICollection<TquotaCompany> TquotaCompany { get; set; }
        public virtual ICollection<TquotaState> TquotaState { get; set; }
        public virtual ICollection<TquotaStation> TquotaStation { get; set; }
        public virtual ICollection<TquotaWareHouse> TquotaWareHouse { get; set; }
    }
}
