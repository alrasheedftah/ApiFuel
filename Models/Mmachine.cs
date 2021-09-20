using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Mmachine
    {
        public Mmachine()
        {
            MmachineAssent = new HashSet<MmachineAssent>();
            MmachineAttachment = new HashSet<MmachineAttachment>();
            NsiteSurvey = new HashSet<NsiteSurvey>();
        }

        public long MachineId { get; set; }
        public int MachineTypeId { get; set; }
        public int MarkId { get; set; }
        public int ModelId { get; set; }
        public int CountryId { get; set; }
        public string ChassisNum { get; set; }
        public string EngineNum { get; set; }
        public decimal EngineCc { get; set; }
        public int FuelId { get; set; }
        public decimal TankCapacity { get; set; }
        public string ManufaDate { get; set; }
        public int ConsumptionId { get; set; }
        public long ProfileId { get; set; }
        public long? ProfileFacilityId { get; set; }
        public int StatusId { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserAdded { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserModified { get; set; }

        public virtual Sconsumption Consumption { get; set; }
        public virtual Scountry Country { get; set; }
        public virtual Nfuel Fuel { get; set; }
        public virtual SmachineType MachineType { get; set; }
        public virtual SmachineMark Mark { get; set; }
        public virtual SmachineModel Model { get; set; }
        public virtual Mprofile Profile { get; set; }
        public virtual MprofileFacility ProfileFacility { get; set; }
        public virtual Sstatus Status { get; set; }
        public virtual ICollection<MmachineAssent> MmachineAssent { get; set; }
        public virtual ICollection<MmachineAttachment> MmachineAttachment { get; set; }
        public virtual ICollection<NsiteSurvey> NsiteSurvey { get; set; }
    }
}
