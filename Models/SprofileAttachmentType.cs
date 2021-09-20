using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SprofileAttachmentType
    {
        public SprofileAttachmentType()
        {
            MprofileAttachment = new HashSet<MprofileAttachment>();
        }

        public int AttachmentTypeId { get; set; }
        public string AttachmentTypeName { get; set; }
        public int ProfileTypeId { get; set; }
        public bool? Active { get; set; }

        public virtual SprofileType ProfileType { get; set; }
        public virtual ICollection<MprofileAttachment> MprofileAttachment { get; set; }
    }
}
