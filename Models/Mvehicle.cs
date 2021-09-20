using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Mvehicle
    {
        public Mvehicle()
        {
            MvehicleAssent = new HashSet<MvehicleAssent>();
            MvehicleAttachment = new HashSet<MvehicleAttachment>();
            MvehicleCard = new HashSet<MvehicleCard>();
            MvehicleTripAssent = new HashSet<MvehicleTripAssent>();
        }

        public long VehicleId { get; set; }
        public int VehicleTypeId { get; set; }
        public string PlateChar { get; set; }
        public int PlateNumber { get; set; }
        public int MarkId { get; set; }
        public int ModelId { get; set; }
        public int CountryId { get; set; }
        public string ManufaDate { get; set; }
        public string ChassisNum { get; set; }
        public string EngineNum { get; set; }
        public decimal EngineCc { get; set; }
        public int FuelId { get; set; }
        public int? FuelTypeId { get; set; }
        public decimal TankCapacity { get; set; }
        public decimal ExtraTankCapacity { get; set; }
        public long ProfileId { get; set; }
        public int StatusId { get; set; }
        public Guid QrCode { get; set; }
        public string Rfid { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserAdded { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserModified { get; set; }

        public virtual Scountry Country { get; set; }
        public virtual Nfuel Fuel { get; set; }
        public virtual SfuelType FuelType { get; set; }
        public virtual SvehicleMark Mark { get; set; }
        public virtual SvehicleModel Model { get; set; }
        public virtual Mprofile Profile { get; set; }
        public virtual Sstatus Status { get; set; }
        public virtual SvehicleType VehicleType { get; set; }
        public virtual ICollection<MvehicleAssent> MvehicleAssent { get; set; }
        public virtual ICollection<MvehicleAttachment> MvehicleAttachment { get; set; }
        public virtual ICollection<MvehicleCard> MvehicleCard { get; set; }
        public virtual ICollection<MvehicleTripAssent> MvehicleTripAssent { get; set; }
    }
}
