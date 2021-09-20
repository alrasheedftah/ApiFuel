using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SvehicleMark
    {
        public SvehicleMark()
        {
            Mvehicle = new HashSet<Mvehicle>();
            SvehicleModel = new HashSet<SvehicleModel>();
        }

        public int MarkId { get; set; }
        public string MarkName { get; set; }
        public string MarkNameEn { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Mvehicle> Mvehicle { get; set; }
        public virtual ICollection<SvehicleModel> SvehicleModel { get; set; }
    }
}
