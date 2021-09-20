using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SprofileFacilityAttachmentTypes
    {
        public SprofileFacilityAttachmentTypes()
        {
            MprofileFacilityAttachment = new HashSet<MprofileFacilityAttachment>();
        }

        public int AttachmentTypeId { get; set; }
        public string AttachmentTypeName { get; set; }
        public int SectionId { get; set; }
        public bool? Active { get; set; }

        public virtual Nsection Section { get; set; }
        public virtual ICollection<MprofileFacilityAttachment> MprofileFacilityAttachment { get; set; }
    }
}
