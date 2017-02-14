using System;
using System.ServiceModel.Web;

namespace ConsoleApplication1
{
    public class Program
    {
        private static void Main()
        {
            var DemoServices = new RestDemo();
            var _serviceHost = new WebServiceHost(DemoServices, new Uri("http://localhost:8000/DEMOService"));
            _serviceHost.Open();
            Console.ReadKey();
            _serviceHost.Close();
        }
    }
}
