using ConsoleApp1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using the File IO, we shall store the data of the Customer in the form of CSV.

namespace ConsoleApp1
{
    internal class Ex08CsvFileIO
    {
        static void Main(string[] args)
        {
            testforReadingRecords();
            //testForAddingRecord();

        }

        private static void testforReadingRecords()
        {
            ICustomerRepo repo = new CsvCustomerRepo();
            var records = repo.GetAllCustomers();
            foreach (var record in records)
            {
                Console.WriteLine($"Mr/Ms.{record.CustomerName} purchased products with us for an amount of Rs.{record.BillAmount} on {record.BillDate} and the delivery was made to {record.CustomerAddress}");
            }
        }

        private static void testForAddingRecord()
        {
            ICustomerRepo repo = new CsvCustomerRepo();
            var cst = new Customer { CustomerID = 111, CustomerAddress = "Bangalore", CustomerName = "Deesha" };
            cst.AddToCart(new Product { ID = 01, Name = "Toor Dhal", Price = 200, Quantity = 5 });
            cst.AddToCart(new Product { ID = 02, Name = "Chips", Price = 20, Quantity = 2 });

            repo.AddNewCustomer(cst);
        }
    }
}
