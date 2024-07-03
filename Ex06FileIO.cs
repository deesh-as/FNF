using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// "?" : value of object can be set to Null
namespace ConsoleApp1
{
    internal class Ex06FileIO
    {
        const string fileName = "TestCode.txt";
        static void WriteToFile(string content)
        {
            if (Configuration != null)
            {
                string? fileName = Configuration["FileOptions:FilePath"];
                Console.WriteLine(fileName);
                if (fileName != null)
                {
                    File.WriteAllText(fileName, content);
                }
                else
                {
                    Console.WriteLine("Path is not set, cannot write to file");
                }
            }

        }

       
         public static IConfigurationRoot? Configuration { get; set; }
         public static void Initialize()
         {
             var config = new ConfigurationBuilder().SetBasePath("C:\\MyTrainings\\ConsoleApp1").AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();
            if (Configuration == null)
            {
                 Configuration = config;
            }
         }
        static void Main(string[] args)
        {
            Initialize();
            WriteToFile("Sample Content for the File");
        }
        
    }
}
