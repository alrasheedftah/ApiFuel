using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class NfacilityAgent
    {
        public NfacilityAgent()
        {
            MprofileFacility = new HashSet<MprofileFacility>();
            MprofileFacilityAssent = new HashSet<MprofileFacilityAssent>();
            MvehicleTripAssent = new HashSet<MvehicleTripAssent>();
        }

        public int FacilityAgentId { get; set; }
        public string FacilityAgentName { get; set; }
        public string Phone { get; set; }
        public int IdtypeId { get; set; }
        public string Idnumber { get; set; }
        public DateTime IdissueDate { get; set; }
        public bool Gander { get; set; }
        public string Address { get; set; }
        public bool? Active { get; set; }

        public virtual Sidtype Idtype { get; set; }
        public virtual ICollection<MprofileFacility> MprofileFacility { get; set; }
        public virtual ICollection<MprofileFacilityAssent> MprofileFacilityAssent { get; set; }
        public virtual ICollection<MvehicleTripAssent> MvehicleTripAssent { get; set; }
    }
}
