using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public class UserView
    {
        public virtual string FullName { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Roles { get; set; }
        public virtual int? StationID { get; set; }
        public virtual string StationName { get; set; }
        public virtual string LocalityName { get; set; }

        public bool IsActive { get; set; }
        public int CompanyID { get; set; }//
        public string CompanyName { get; set; }
    }
}