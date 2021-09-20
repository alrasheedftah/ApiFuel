using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class NsiteSurvey
    {
        public string UserName { get; set; }
        public long MachineId { get; set; }
        public DateTime SurveyDate { get; set; }
        public long? ProfileFacilityId { get; set; }
        public bool? Accptence { get; set; }
        public int? RejectId { get; set; }
        public string Note { get; set; }
        public DateTime? Date { get; set; }

        public virtual Mmachine Machine { get; set; }
        public virtual Sreject Reject { get; set; }
    }
}
