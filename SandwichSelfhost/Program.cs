using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

//Developed by Lisa Fowler using code originally developed by Matthias Otto

namespace SandwichSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //set up server configuration
            Uri _baseAddress = new Uri("http://localhost:60064/");
            HttpSelfHostConfiguration config = new HttpSelfHostConfiguration(_baseAddress);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            //Create Server
            HttpSelfHostServer server = new HttpSelfHostServer(config);

            //Start Listening
            server.OpenAsync().Wait();
            Console.WriteLine("Sandwich Web-API Self hosted on " + _baseAddress);
            Console.WriteLine("Hit ENTER to exit...");
            Console.ReadLine();
            server.CloseAsync().Wait();
        }
    }
}
