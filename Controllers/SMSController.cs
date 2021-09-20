using System.Reflection;
using System.Net;
using System;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using ApiAppPetrol.Domain.SMSContent;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace ApiAppPetrol.Controllers
{
    // [Authorize]
    [ApiController]
    [Produces("application/json")]
    [Route("sms")]
    public class SMSController : ControllerBase
    {

        // [AllowAnonymous]
        [HttpGet("SendSMS")]
    public  IActionResult SendSMS(){

        ///   TODO Check Data Agree False Or True To determine Which Response SMS to Use   

        bool agrre=true;
        var  smsMessage=new SmsContent();
      
        if(!agrre){
             smsMessage=new SmsContent{
                Title = "  رفض ",
                Order ="  الالية مولد ديزل 14040 كيلوواط ",
                CustmorName = " الرشيد فتح الرحمن ",
                Agreedate = " "+ DateTime.Now,
                Note = "هناك بعض المستندات الناقصة الرجاء متابعة المكتب",
                };
              //  sms=" تمت الموافقة علي  "+"%0a"+" الاليه او المكتبة " +"%0a"+" باسم الشخص الفلاني" +"%0a"+" بتاريخ " + DateTime.Now +"%0a"+" لملاحظة ان وجدت" +"%0a";
        }
        else{
                smsMessage=new SmsContent{
                Title = "  الموافقة ",
                Order ="  الالية : مولد ديزل  ش :12346 "+"%0a"+" م : 123460 ",
                CustmorName = " : الرشيد فتح الرحمن محمد",
                Agreedate = " : "+ DateTime.UtcNow.ToShortDateString(),//ToString("dd/mm/yyy"),
                Note = " يمكنك الان ان تستخرج نصديق السحب من المحلية التابعة ",
                };

                // sms =" تمت الموافقة علي  "+"%0a"+" الاليه او المكتبة " +"%0a"+" باسم الشخص الفلاني" +"%0a"+" بتاريخ " + DateTime.Now +"%0a"+" لملاحظة ان وجدت" +"%0a";
            // };

        }
        
        ///   TODO phone Number Get From DB
        string PhoneNumber="249929121264";

        ///   TODO Base URL Move To AppSettin
        string url="http://sms.matger-tutia.com/app/gateway";

        var client = new RestClient(url);
        // client.Authenticator = new HttpBasicAuthenticator("username", "password");

        var request = new RestRequest("gateway.php?"+"sendmessage=1&"+"username="+SettingSMS.UserName+"&password="+SettingSMS.Password+"&"+"text="+smsMessage.getAsString()+"&numbers="+PhoneNumber+"&sender=SPC",DataFormat.Json);//gateway/gateway.php?sendmessage=1&username=SPC&password=SPC@2020&text=hi&numbers=249929121264&sender=SPC", DataFormat.Json);

        ///   TODO Call Url SMSGetaway By Async         
        var response=  client.Get(request);
        // var response = client.GetAsync<>(request);

        ///   TODO Check Response    then Return Ur Specific View    
        if(response.IsSuccessful)
            return Ok(response.Content);

        ///   TODO Internal Server Error Handle By Custom Ur Error Response                 
        return new BadRequestResult(){};//Ok(response.ErrorMessage);
       }
  
  }

}