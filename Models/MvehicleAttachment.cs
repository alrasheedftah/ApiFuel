using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class MvehicleAttachment
    {
        public long AttachmentId { get; set; }
        public string AttachmentPath { get; set; }
        public int AttachmentTypeId { get; set; }
        public long VehicleId { get; set; }

        public virtual SvehicleAttachmentType AttachmentType { get; set; }
        public virtual Mvehicle Vehicle { get; set; }
    }
}
