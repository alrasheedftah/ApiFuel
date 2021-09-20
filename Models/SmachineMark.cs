using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SmachineMark
    {
        public SmachineMark()
        {
            Mmachine = new HashSet<Mmachine>();
            SmachineModel = new HashSet<SmachineModel>();
        }

        public int MarkId { get; set; }
        public string MarkName { get; set; }
        public string MarkNameEn { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Mmachine> Mmachine { get; set; }
        public virtual ICollection<SmachineModel> SmachineModel { get; set; }
    }
}
