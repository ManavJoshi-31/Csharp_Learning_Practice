using System;
using System.Collections.Generic;

namespace LINQLab
{
    class Customer
    {


        // Define CustomerId, Name and City Properties.
        public int CustomerId {  get; set; }
        public string Name { get; set; }

        public string City { get; set; }
    }

    class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double OrderAmount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer { CustomerId = 1, Name = "Virat", City = "Jaipur" },
                new Customer { CustomerId = 2, Name = "Rohit", City = "Lucknow" },
                new Customer { CustomerId = 3, Name = "Dhawan", City = "Bhopal" },
                new Customer { CustomerId = 4, Name = "Bhavin", City = "Gondal" },
                new Customer { CustomerId = 5, Name = "Raj", City = "Surat" },
                new Customer { CustomerId = 6, Name = "Anuj", City = "Nadiad" },
                new Customer { CustomerId = 7, Name = "Dale Steyn", City = "Pune" }
            };

        List<Order> orders = new List<Order>()
            {
                new Order { OrderId = 101, CustomerId = 1, ProductName = "Cricket Bat", Category = "Sports", OrderAmount = 4500 },
                new Order { OrderId = 102, CustomerId = 2, ProductName = "Sports Shoes", Category = "Sports", OrderAmount = 6200 },
                new Order { OrderId = 103, CustomerId = 3, ProductName = "Laptop", Category = "Electronics", OrderAmount = 65000 },
                new Order { OrderId = 104, CustomerId = 4, ProductName = "Wireless Mouse", Category = "Electronics", OrderAmount = 1200 },
                new Order { OrderId = 105, CustomerId = 5, ProductName = "Backpack", Category = "Accessories", OrderAmount = 1800 },
                new Order { OrderId = 106, CustomerId = 6, ProductName = "Bluetooth Speaker", Category = "Electronics", OrderAmount = 3500 },
                new Order { OrderId = 107, CustomerId = 7, ProductName = "Smart Watch", Category = "Electronics", OrderAmount = 8500 },
                new Order { OrderId = 108, CustomerId = 1, ProductName = "Headphones", Category = "Electronics", OrderAmount = 2500 },
                new Order { OrderId = 109, CustomerId = 2, ProductName = "Jersey", Category = "Sports", OrderAmount = 1500 },
                new Order { OrderId = 110, CustomerId = 5, ProductName = "Keyboard", Category = "Electronics", OrderAmount = 2200 }
            };

            // ==========================================================
            // Write LINQ queries below
            // ==========================================================

            // Query 1:
            // Display the names of all customers along with the products they have ordered.
            // (Use Join)
            var result = customers.Join(orders, customers => customers.CustomerId,
                                                orders => orders.CustomerId,
                                                (customers, orders) => new
                                                {
                                                    customers.Name,
                                                    orders.ProductName
                                                });
            Console.WriteLine("\nCustomers with their respective orders are :- \n");
            foreach(var item in result)
            {
                Console.WriteLine(item.Name + "  Has ordered  " + item.ProductName);
            }


            // Query 2:
            // Display the details of the first order whose amount is greater than ₹20,000.
            // (Use First() or FirstOrDefault())
            var firstOrder = orders.FirstOrDefault(order => order.OrderAmount > 20000);
            Console.WriteLine("\nThe first order with amount greater than 20,000 is:\n");
            Console.WriteLine($"Product Name      : {firstOrder.ProductName}");
            Console.WriteLine($"Order Amount      : {firstOrder.OrderAmount}");
            Console.WriteLine($"Order ID          : {firstOrder.OrderId}");
            Console.WriteLine($"Customer ID       : {firstOrder.CustomerId}");
            Console.WriteLine($"Product Category  : {firstOrder.Category}");
            // Query 3:
            // Display all customers from Ahmedabad along with the total amount they have spent on orders.
            // (Use Join, Where, GroupBy, and Sum)

            var ahmedabadCustomers = customers.Where(c => c.City == "Ahmedabad")
                                           .Join(orders, c => c.CustomerId, o => o.CustomerId, (c, o) => new { c.Name, o.OrderAmount })
                                           .GroupBy(x => x.Name)
                                           .Select(g => new { CustomerName = g.Key, TotalAmountSpent = g.Sum(x => x.OrderAmount) });
            foreach (var customer in ahmedabadCustomers)
            {
                Console.WriteLine($"Customer Name: {customer.CustomerName}, Total Amount Spent: {customer.TotalAmountSpent}");
            }
            // Query 4:
            // Display the customer who has placed the highest-value order,
            // along with the product name and order amount.
            // (Use Join and OrderByDescending())
            var highOrder = orders.OrderByDescending(o => o.OrderAmount)
                              .Join(customers, o => o.CustomerId, c => c.CustomerId, (o, c) => new { c.Name, o.ProductName, o.OrderAmount })
                              .FirstOrDefault();

            Console.WriteLine("\nHighest Value Order:\n");
            Console.WriteLine($"Customer Name : {highOrder.Name}");
            Console.WriteLine($"Product Name  : {highOrder.ProductName}");
            Console.WriteLine($"Order Amount  : ₹{highOrder.OrderAmount}");
            Console.ReadKey();
        }
    }
}