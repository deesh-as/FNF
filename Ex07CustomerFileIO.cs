using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex07CustomerFileIO
    {
        static void WriteCustomerInfo(Customer cst)
        {
            try
            {
                var fileName = Ex06FileIO.Configuration["FileOptions:FilePath"];
                File.AppendAllText(fileName, cst.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Ex06FileIO.Initialize();
            Customer cst = new Customer
            {
                CustomerAddress = "Bangalore",
                CustomerID = 1,
                CustomerName = "Phaniraj"
            };
            cst.AddToCart(new Product
            {
                ID = 1,
                Name = "Nokia Phone",
                Price = 1300,
                Quantity = 1
            });
            cst.AddToCart(new Product
            {
                ID = 2,
                Name = "IPhone 15 Pro",
                Price = 111300,
                Quantity = 1
            });
            cst.AddToCart(new Product
            {
                ID = 3,
                Name = "Biscuits Pack",
                Price = 13,
                Quantity = 4
            });
            WriteCustomerInfo(cst);
        }
    }   

}
