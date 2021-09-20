using System;
using System.Collections.Generic;
using System.Linq;
using ApiAppPetrol.Domain.Response;
using Microsoft.AspNetCore.Http;

namespace ApiAppPetrol.Extention
{
    public static class GenralExtenion
    {
        public static string GetUserId(this HttpContext httpContext)
        {
            if(httpContext.User == null){
                return string.Empty;
            }

            return httpContext.User.Claims.Single(claim=> claim.Type == "id").Value;
        }

    public static string GetUserName(this HttpContext httpContext)
        {
            if(httpContext.User == null){
                return string.Empty;
            }

            return httpContext.User.Claims.Single(claim=> claim.Type == "UserName").Value;
        }

        public static string GetStationID(this HttpContext httpContext)
        {
            if(httpContext.User == null){
                return string.Empty;
            }

            return httpContext.User.Claims.Single(claim=> claim.Type == "GetStationID").Value;
        }


         public static string GetIMEI(this HttpContext httpContext)
        {
            if(httpContext.User == null){
                return string.Empty;
            }

            return httpContext.User.Claims.Single(claim=> claim.Type == "IMEI").Value;
        }


        public static string GetLocalityID(this HttpContext httpContext)
        {
            if(httpContext.User == null){
                return string.Empty;
            }

            return httpContext.User.Claims.Single(claim=> claim.Type == "LocalityID").Value;
        }

        public static string GetStateID(this HttpContext httpContext)
        {
            if(httpContext.User == null){
                return string.Empty;
            }

            return httpContext.User.Claims.Single(claim=> claim.Type == "StateID").Value;
        }

        public static string GetRoleName(this HttpContext httpContext)
        {
            if(httpContext.User == null){
                return string.Empty;
            }

            return httpContext.User.Claims.Single(claim=> claim.Type == "RoleName").Value;
        }



public static PagedResult<T> GetPaged<T>(this IQueryable<T> query,int page, int pageSize) where T : class
   {
     var result = new PagedResult<T>();
     result.CurrentPage = page;
     result.PageSize = pageSize;
     result.RowCount = query.Count();


     var pageCount = (double)result.RowCount / pageSize;
     result.PageCount = (int)Math.Ceiling(pageCount);
 
     var skip = (page - 1) * pageSize;     
     result.Results = query.Skip(skip).Take(pageSize).ToList();
 
     return result;
}


public static PagedResult<AssentReportResponse> GetPaged2(this IQueryable<AssentReportResponse> query,int page, int pageSize) 
   {
     var result = new PagedResult<AssentReportResponse>();
     result.CurrentPage = page;
     result.PageSize = pageSize;
     result.RowCount = query.Count();


     var pageCount = (double)result.RowCount / pageSize;
     result.PageCount = (int)Math.Ceiling(pageCount);
 
     var skip = (page - 1) * pageSize;     
     result.Results = query.Skip(skip).Take(pageSize).ToList();
 
    result.PenzSum=query.ToList().Where(r=>r.fuelInfo.fuelID == 1).Sum(r =>
     {
         return r.ApprovedLiter;
     });
     result.GazzSum=query.ToList().Where(r=>r.fuelInfo.fuelID == 2).Sum(r=>r.ApprovedLiter);

     return result;
}


public static PagedResult<AssentReportResponse> GetSum(this PagedResult<AssentReportResponse> query) 
   {
       
     
     query.PenzSum=query.Results.Where(r=>r.fuelInfo.fuelID == 1).Sum(r =>
     {
         return r.ApprovedLiter;
     });
     query.GazzSum=query.Results.Where(r=>r.fuelInfo.fuelID == 2).Sum(r=>r.ApprovedLiter);

     return query;

     
}
    }



}