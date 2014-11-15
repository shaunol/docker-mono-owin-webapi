using System;
using System.Net.Http;
using System.Threading;
using Microsoft.Owin.Hosting;

namespace OwinMonoSelfHostTest
{
    class Program
    {
        private static readonly ManualResetEvent _ExitEvent = new ManualResetEvent(false);

        static void Main()
        {
            Console.CancelKeyPress += (sender, eventArgs) =>
            {
                eventArgs.Cancel = true;
                _ExitEvent.Set();
            };

            // Start OWIN host 
            // This requires administrative rights to bind on all interfaces like this.
            using (WebApp.Start<Startup>("http://+:9100"))
            {
                // Create HttpCient and make a request to api/values 
                var client = new HttpClient();

                var response = client.GetAsync("http://localhost:9100/values").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);

                _ExitEvent.WaitOne();
            }
        }
    }
}
