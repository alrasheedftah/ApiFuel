using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Mconfig
    {
        public int ConfigId { get; set; }
        public int StateId { get; set; }
        public int SectionId { get; set; }
        public int FacilityId { get; set; }
        public int ProfileTypeId { get; set; }
        public int FuelId { get; set; }
        public int FuelTypeId { get; set; }
        public int ApprovedFuelHours { get; set; }

        public virtual Nfacility Facility { get; set; }
        public virtual Nfuel Fuel { get; set; }
        public virtual SfuelType FuelType { get; set; }
        public virtual SprofileType ProfileType { get; set; }
        public virtual Nsection Section { get; set; }
        public virtual Nstate State { get; set; }
    }
}
