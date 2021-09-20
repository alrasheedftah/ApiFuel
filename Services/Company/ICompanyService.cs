using System.Collections.Generic;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;

namespace ApiAppPetrol.Services
{

    public  interface ICompanyService
    {
       

        Task<List<CompanyResponse>> GetCompanys(List<int> localityID);
        Task<CompanyResponse> GetCompanyById(int Compid);
        
        // string GetStationById();  
        
    }
}