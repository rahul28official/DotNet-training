using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleApp3
{
    internal class IDisposable
    {
        static class Program
        {
            static void Main()
            {
                using var serviceProxy = new ServiceProxy(null);
                serviceProxy.Get();
                serviceProxy.Post("");
                Console.ReadLine();

            }
        }
        public class ServiceProxy:System.IDisposable
        {
            private readonly HttpClient httpClient;
            private bool disposed;
            public ServiceProxy(IHttpClientFactory httpClientFactory)
            {
                httpClient = httpClientFactory.CreateClient();
            }
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            protected virtual void Dispose(bool disposing)
            {

                if (!disposed)
                {
                    return;
                }
                if(disposing)
                {
                    httpClient.Dispose();
                }
                disposed= true;
            }
            public void Get()
            {
                var response = httpClient.GetAsync("");

            }
            public void Post(string request)
            {
                var response=httpClient.PostAsync("",new StringContent(request));
            }
        }
    }
}
