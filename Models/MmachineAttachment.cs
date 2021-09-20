using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class MmachineAttachment
    {
        public long AttachmentId { get; set; }
        public string AttachmentPath { get; set; }
        public int AttachmentTypeId { get; set; }
        public long MachineId { get; set; }

        public virtual SmachineAttachmentType AttachmentType { get; set; }
        public virtual Mmachine Machine { get; set; }
    }
}
