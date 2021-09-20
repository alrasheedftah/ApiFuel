using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class SvehicleAttachmentType
    {
        public SvehicleAttachmentType()
        {
            MvehicleAttachment = new HashSet<MvehicleAttachment>();
        }

        public int AttachmentTypeId { get; set; }
        public string AttachmentTypeName { get; set; }
        public int ProfileTypeId { get; set; }
        public bool? Active { get; set; }

        public virtual SprofileType ProfileType { get; set; }
        public virtual ICollection<MvehicleAttachment> MvehicleAttachment { get; set; }
    }
}
