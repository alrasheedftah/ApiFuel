public static class ApiRoutes {

public  const string baseUrl="api";
    public static class MachineRoute{
    public  const string getAll =baseUrl+"/assents";
    public  const string getMachineID = baseUrl+"/assents/{AssentQR}";

    public  const string UpdateWithdraw = baseUrl+"/assents/{AssentQR}";


    }

    public static class VechileRoute{
    public  const string getAll =baseUrl+"/vechile";
    public  const string getVechileQR = baseUrl+"/vechile/{QRCode}";
    public  const string getVechile = baseUrl+"/vechile/{QRCode}";


    public  const string UpdateWithdraw = baseUrl+"/vechile/{QRCode}";


    }

    public static class AssentVechileRoute{
    public  const string getAll =baseUrl+"/vehicleAssent";
    public  const string getVehicleAssentByQR = baseUrl+"/vehicleAssent/{QRCode}";

    public  const string UpdateWithdraw = baseUrl+"/vehicleAssent/{AssentID}";
    public  const string PostVehicleAssent = baseUrl+"/vehicleAssent/{AssentID}";



    }


    public static class StationsRoute{
    public  const string getStation = baseUrl+"/station";
    public  const string getAll = baseUrl+"/station/{CompanyId}";

    public  const string show = baseUrl+"/stationDetails/{Stationid}";

    public  const string stationOnRoad = baseUrl+"/stationRoadQuota";

    public  const string putStationOnRoad = baseUrl+"/stationRoadQuota/{onRoadID}";

    public  const string getStationAssents = baseUrl+"/stationAssent";
    



    }


    public static class FuelTypeRoute{
    public  const string getFuelType = baseUrl+"/fueltype";

    }
      public static class UsersRoute{
    public  const string getProfile =baseUrl+"/profile";
    public  const string PostLogin = baseUrl+"/login";

    }

    public static class CompanyRoute{
    public  const string getAll =baseUrl+"/companys";
    public  const string show = baseUrl+"/company/{companyID}";

    public  const string getStationsCompany = baseUrl+"/company/{companyID}/station";


    }


    public static class LocalityRoute{
    public  const string getAll =baseUrl+"/locality";
    public  const string show = baseUrl+"/locality/{localityID}";

    public  const string getStationsCompany = baseUrl+"/locality/{localityID}/station";

    }


    public static class StateRoute{
    public  const string getAll =baseUrl+"/state";
    public  const string show = baseUrl+"/state/{stateID}";
    public  const string getstateLocality = baseUrl+"/state/{stateID}/locality";



    }
    public static class Enginner{
    public  const string getSiteSurvey = baseUrl+"/sitesurvey";

    }

    public static class TripsAuthRoute{
    public  const string getAllTripsAuth = baseUrl+"/trips";

    }

    public static class TripsAuthProviderRoute{
    public  const string getAllTripsAuthProvider = baseUrl+"/tripProviders";

    }

    public static class RoadTypeRoute{
    public  const string getAllTypeRoute = baseUrl+"/roadType";

    }
  
}
