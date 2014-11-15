using System;
using System.Net.Http;
using System.Threading;
using Microsoft.Owin.Hosting;

namespace OwinMonoSelfHostTest
{
    class Program
    {
        private static readonly WaitHandle _WaitHandle = new ManualResetEvent(false);

        static void Main()
        {
            // Start OWIN host 
            using (WebApp.Start<Startup>("http://+:9100"))
            {
                // Create HttpCient and make a request to api/values 
                var client = new HttpClient();

                var response = client.GetAsync("http://localhost:9100/values").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);

                while (_WaitHandle.WaitOne())
                {
                    //
                }
            }
        }
    }
}
