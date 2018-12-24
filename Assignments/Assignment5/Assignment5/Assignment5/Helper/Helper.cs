using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Assignment5.Helper
{
    public class ProductAPI
    {
        public HttpClient Initial()
        {
            var Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:52363");
            return Client;
        }
    }
}
