using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SvehicleModel
    {
        public SvehicleModel()
        {
            Mvehicle = new HashSet<Mvehicle>();
        }

        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int MarkId { get; set; }
        public bool? Active { get; set; }

        public virtual SvehicleMark Mark { get; set; }
        public virtual ICollection<Mvehicle> Mvehicle { get; set; }
    }
}
