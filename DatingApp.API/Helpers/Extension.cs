using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    //is static so we do not need to create a new instance of this class
    public static class Extension
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}