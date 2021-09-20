using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Domain.Response
{


    public class SiteSurveyResponse
    {

        public string UserName { get; set; }
        public long? MachineID { get; set; }

        public DateTime SurveyDate { get; set; }
        public string FacilityName { get; set; }

        public long? ProfileFacilityID { get; set; }


        public string ProfileName { get; set; }
        
        public string SectionName { get; set; }

        public int MachineCount { get; set; }

        public string StatusName { get; set; }

        // public decimal TotalLiter { get; set; }

        public bool? Accptence { get; set; }
        public int? RejectID { get; set; }//  

        public string Note { get; set; }

       
        public DateTime? Date { get; set; }
      

    }

}