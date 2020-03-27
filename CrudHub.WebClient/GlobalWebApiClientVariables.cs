using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CrudHub.WebClient
{
    public static class GlobalWebApiClientVariables
    {
        public static HttpClient WebApiClient = new HttpClient();

        static GlobalWebApiClientVariables()
        {
            WebApiClient.BaseAddress = new Uri("https://localhost:44357/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
