using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SmachineAttachmentType
    {
        public SmachineAttachmentType()
        {
            MmachineAttachment = new HashSet<MmachineAttachment>();
        }

        public int AttachmentTypeId { get; set; }
        public string AttachmentTypeName { get; set; }
        public int FacilityId { get; set; }
        public bool? Active { get; set; }

        public virtual Nfacility Facility { get; set; }
        public virtual ICollection<MmachineAttachment> MmachineAttachment { get; set; }
    }
}
