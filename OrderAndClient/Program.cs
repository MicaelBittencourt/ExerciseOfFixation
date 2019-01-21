using System;
using OrderAndClient.Entities;
using OrderAndClient.Entities.Enums;

namespace OrderAndClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string cliName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus),Console.ReadLine());

            Client cli = new Client(cliName, email, birthDate);
            Order order = new Order(DateTime.Now, status, cli);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for(int i =1; i <=n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product Name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product Price: ");
                double prodPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int qtt = int.Parse(Console.ReadLine());

                Product prod = new Product(prodName, prodPrice);
                OrderItem item = new OrderItem(qtt, prodPrice, prod);
                order.AddItem(item);

            }
            

            Console.WriteLine(order);
            


        }
    }
}
