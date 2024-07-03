﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }

    internal class Customer
    {
        public DateTime BillDate { get; set; } = DateTime.Now;
        private List<Product> products = new List<Product>();
        public int CustomerID { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerAddress { get; set; } = string.Empty;
        public int BillAmount { get; set; }

        private void GenerateBill()
        {
            var amount = 0;
            foreach (var item in products)
            {
                amount += item.Price * item.Quantity;
            }
            BillAmount= amount;
        }
        public void AddToCart(Product product)
        {
            if (product == null)
            {
                throw new Exception("Product Details are not set");
            }
            products.Add(product);
            GenerateBill();
        }

        public void RemoveFromCart(Product product)
        {
            if (products.Remove(product))
            {
                GenerateBill();
            }
            else
                throw new Exception("Product not found to remove");
        }
        public override string ToString()
        {
            return $"{BillDate.ToString("dd/MM/yyyy")},{CustomerID},{CustomerName},{CustomerAddress},{BillAmount}\n";
            //return $"Name: {CustomerName}\nCustomer Address: {CustomerAddress}\nBillDate: {BillDate}\nBillAmount:{BillAmount}\n\n";
        }
    }
}
