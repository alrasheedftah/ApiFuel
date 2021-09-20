using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;
// using WebApplication1.Models;

namespace ApiAppPetrol.Domain.Response
{


    public class CompanyResponse
    {
    

        public int CompanyID { get; set; }
        public string Phone { get; set; }
        public bool? Active { get; set; }
        public string CompanyName { get; set; }

        public int StationCount { get; set; }

    }

    

}