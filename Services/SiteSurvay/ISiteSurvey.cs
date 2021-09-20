using System.Threading.Tasks;
using System.Collections.Generic;
using ApiAppPetrol.Domain.Response;

namespace ApiAppPetrol.Services
{
    public interface ISiteSurvey
    {
        Task<List<SiteSurveyResponse>> GetAllSurvey(string UserName);
    }
}