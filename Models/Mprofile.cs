using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Mprofile
    {
        public Mprofile()
        {
            Mmachine = new HashSet<Mmachine>();
            MprofileAttachment = new HashSet<MprofileAttachment>();
            MprofileFacility = new HashSet<MprofileFacility>();
            MprofileFacilityAssent = new HashSet<MprofileFacilityAssent>();
            Mvehicle = new HashSet<Mvehicle>();
            MvehicleTripAssent = new HashSet<MvehicleTripAssent>();
        }

        public long ProfileId { get; set; }
        public int ProfileTypeId { get; set; }
        public string ProfileName { get; set; }
        public int StateId { get; set; }
        public int LocalityId { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public int JobId { get; set; }
        public string JobAddress { get; set; }
        public int? IdtypeId { get; set; }
        public string Idnumber { get; set; }
        public DateTime? IdissueDate { get; set; }
        public int ProfileStatusId { get; set; }
        public int? RejectId { get; set; }
        public string Note { get; set; }
        public string TransportMember { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserAdded { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserModified { get; set; }

        public virtual Sidtype Idtype { get; set; }
        public virtual Sjob Job { get; set; }
        public virtual Slocality Locality { get; set; }
        public virtual Sstatus ProfileStatus { get; set; }
        public virtual SprofileType ProfileType { get; set; }
        public virtual Sreject Reject { get; set; }
        public virtual Nstate State { get; set; }
        public virtual MvehicleCard MvehicleCard { get; set; }
        public virtual ICollection<Mmachine> Mmachine { get; set; }
        public virtual ICollection<MprofileAttachment> MprofileAttachment { get; set; }
        public virtual ICollection<MprofileFacility> MprofileFacility { get; set; }
        public virtual ICollection<MprofileFacilityAssent> MprofileFacilityAssent { get; set; }
        public virtual ICollection<Mvehicle> Mvehicle { get; set; }
        public virtual ICollection<MvehicleTripAssent> MvehicleTripAssent { get; set; }
    }
}
