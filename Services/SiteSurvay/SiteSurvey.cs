using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
//
using Microsoft.EntityFrameworkCore;
using ApiAppPetrol.Models;

namespace ApiAppPetrol.Services
{
    class SiteSurvey : ISiteSurvey
    {
        private readonly PetrolSDContext _context;

        public SiteSurvey(PetrolSDContext context){
            _context = context;
        }

        public async Task<List<SiteSurveyResponse>> GetAllSurvey(string UserName)
        {
           // SiteSurveyResponse AllSites=null;
             var  AllSites = await _context.NsiteSurvey
               .Where(siteSurvey => siteSurvey.UserName == UserName)
               .Where(siteSurvey => siteSurvey.SurveyDate >= DateTime.Now )
               .Select(siteSurvey => new SiteSurveyResponse{
                   UserName = siteSurvey.UserName, 

                   ProfileFacilityID = siteSurvey.Machine.ProfileFacilityId,

                   FacilityName = siteSurvey.Machine.ProfileFacility.ProfileFacilityName,

                   ProfileName = siteSurvey.Machine.Profile.ProfileName,

                   SectionName =siteSurvey.Machine.ProfileFacility.Section.SectionName,

                   MachineCount =siteSurvey.Machine.ProfileFacility.Mmachine.Count(),
                   
                   StatusName = siteSurvey.Machine.Status.StatusName,

                   MachineID = siteSurvey.MachineId,

                   SurveyDate = siteSurvey.SurveyDate,

                   Accptence = siteSurvey.Accptence,

                   RejectID = siteSurvey.RejectId,

                   Note = siteSurvey.Note,

                   Date = siteSurvey.Date

               })
               .ToListAsync();
              
           return AllSites;
        }
    }
}