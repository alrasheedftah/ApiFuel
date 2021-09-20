using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class Sreject
    {
        public Sreject()
        {
            Mprofile = new HashSet<Mprofile>();
            NsiteSurvey = new HashSet<NsiteSurvey>();
        }

        public int RejectId { get; set; }
        public string RejectName { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Mprofile> Mprofile { get; set; }
        public virtual ICollection<NsiteSurvey> NsiteSurvey { get; set; }
    }
}
