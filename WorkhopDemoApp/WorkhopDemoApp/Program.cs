using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkhopDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String computerNameInAppConfig = ConfigurationManager.AppSettings["ComputerName"] ?? string.Empty;

            if (computerNameInAppConfig.ToUpper() == Environment.MachineName.ToUpper())
            {
                
            }
            else
            {
                Console.WriteLine("Please Adjust the Computer Name in the App.Config File for this example to work.");
                Console.WriteLine("Press any Key to Continue....");
                Console.ReadKey();
            }

        }
    }
}
