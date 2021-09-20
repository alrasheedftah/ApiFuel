using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Scountry
    {
        public Scountry()
        {
            Mmachine = new HashSet<Mmachine>();
            Mvehicle = new HashSet<Mvehicle>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Mmachine> Mmachine { get; set; }
        public virtual ICollection<Mvehicle> Mvehicle { get; set; }
    }
}
