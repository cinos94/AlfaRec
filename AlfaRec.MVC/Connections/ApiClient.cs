using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AlfaRec.MVC.Connections
{
    public partial class ApiClient
    {
        private readonly HttpClient httpClient;
        public ApiClient(HttpClient client)
        {
            httpClient = client;
        }
    }
}
