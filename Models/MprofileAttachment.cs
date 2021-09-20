using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class MprofileAttachment
    {
        public long AttachmentId { get; set; }
        public string AttachmentPath { get; set; }
        public int AttachmentTypeId { get; set; }
        public long ProfileId { get; set; }

        public virtual SprofileAttachmentType AttachmentType { get; set; }
        public virtual Mprofile Profile { get; set; }
    }
}
