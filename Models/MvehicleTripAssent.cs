using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class MvehicleTripAssent
    {
        public long AssentId { get; set; }
        public long VehicleId { get; set; }
        public long ProfileId { get; set; }
        public int ProfileTypeId { get; set; }
        public int? VehicleAgentId { get; set; }
        public int StateId { get; set; }
        public int LocalityId { get; set; }
        public int OfficeId { get; set; }
        public int CompanyId { get; set; }
        public int StationId { get; set; }
        public int TripId { get; set; }
        public int TripType { get; set; }
        public int? TripAuthId { get; set; }
        public int? TripAuthProviderId { get; set; }
        public string TripAuthNumber { get; set; }
        public int FuelId { get; set; }
        public int FuelTypeId { get; set; }
        public int StatusId { get; set; }
        public decimal ApprovedLiter { get; set; }
        public decimal RemLiter { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpDate { get; set; }
        public string UserAdded { get; set; }
        public string UserDispose { get; set; }
        public DateTime? DateDispose { get; set; }
        public Guid Qrcode { get; set; }

        public virtual Ncompany Company { get; set; }
        public virtual Nfuel Fuel { get; set; }
        public virtual SfuelType FuelType { get; set; }
        public virtual Slocality Locality { get; set; }
        public virtual Soffice Office { get; set; }
        public virtual Mprofile Profile { get; set; }
        public virtual SprofileType ProfileType { get; set; }
        public virtual Nstate State { get; set; }
        public virtual Sstation Station { get; set; }
        public virtual Sstatus Status { get; set; }
        public virtual Mvehicle Vehicle { get; set; }
        public virtual NfacilityAgent VehicleAgent { get; set; }
    }
}
