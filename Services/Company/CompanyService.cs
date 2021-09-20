using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using ApiAppPetrol.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
//

namespace ApiAppPetrol.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly PetrolSDContext _context;

         public CompanyService(PetrolSDContext context){
            _context = context;
        }

        public async Task<CompanyResponse> GetCompanyById(int Compid)
        {
            var companyDetails= await _context.Ncompany
            .Select(company => new CompanyResponse{
                CompanyID =company.CompanyId,
                CompanyName = company.CompanyName,
                Phone = company.Phone,
                Active =company.Active,
                StationCount = company.Sstation.Count(st => st.MprofileFacilityAssent.Count() > 0)
            }
            )
            .FirstOrDefaultAsync(company=>company.CompanyID==Compid);

            return companyDetails;
            
        }

    public async  Task<List<CompanyResponse>> GetCompanys(List<int> localityID)
        {
            var companys= await _context.Ncompany
            .Select(company => new CompanyResponse {
                 CompanyID= company.CompanyId,
                CompanyName = company.CompanyName,
                Phone = company.Phone,
                Active =company.Active,
                StationCount = company.Sstation.Count(st => st.MprofileFacilityAssent.Count()>0)
                })
                .OrderByDescending(c => c.StationCount)
            .ToListAsync();

            return companys; 
        }
    }
}