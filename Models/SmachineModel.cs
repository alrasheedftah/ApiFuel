using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SmachineModel
    {
        public SmachineModel()
        {
            Mmachine = new HashSet<Mmachine>();
        }

        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int MarkId { get; set; }
        public bool Prime { get; set; }
        public bool? Active { get; set; }

        public virtual SmachineMark Mark { get; set; }
        public virtual ICollection<Mmachine> Mmachine { get; set; }
    }
}
