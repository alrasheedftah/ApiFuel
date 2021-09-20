using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class MprofileFacility
    {
        public MprofileFacility()
        {
            Mmachine = new HashSet<Mmachine>();
            MprofileFacilityAssent = new HashSet<MprofileFacilityAssent>();
            MprofileFacilityAttachment = new HashSet<MprofileFacilityAttachment>();
        }

        public long ProfileFacilityId { get; set; }
        public string ProfileFacilityName { get; set; }
        public int SectionId { get; set; }
        public int FacilityId { get; set; }
        public int StateId { get; set; }
        public int LocalityId { get; set; }
        public string Address { get; set; }
        public string GeoCode { get; set; }
        public bool Electricity { get; set; }
        public string ElectricityNumber { get; set; }
        public int? FuelTypeId { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Long { get; set; }
        public int StatusId { get; set; }
        public decimal TotalArea { get; set; }
        public long ProfileId { get; set; }
        public int? FacilityAgentId { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserAdded { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserModified { get; set; }

        public virtual Nfacility Facility { get; set; }
        public virtual NfacilityAgent FacilityAgent { get; set; }
        public virtual SfuelType FuelType { get; set; }
        public virtual Slocality Locality { get; set; }
        public virtual Mprofile Profile { get; set; }
        public virtual Nsection Section { get; set; }
        public virtual Nstate State { get; set; }
        public virtual Sstatus Status { get; set; }
        public virtual ICollection<Mmachine> Mmachine { get; set; }
        public virtual ICollection<MprofileFacilityAssent> MprofileFacilityAssent { get; set; }
        public virtual ICollection<MprofileFacilityAttachment> MprofileFacilityAttachment { get; set; }
    }
}
