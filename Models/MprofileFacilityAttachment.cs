using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class MprofileFacilityAttachment
    {
        public long AttachmentId { get; set; }
        public string AttachmentPath { get; set; }
        public int AttachmentTypeId { get; set; }
        public long ProfileFacilityId { get; set; }

        public virtual SprofileFacilityAttachmentTypes AttachmentType { get; set; }
        public virtual MprofileFacility ProfileFacility { get; set; }
    }
}
