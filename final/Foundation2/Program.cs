using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        
        Console.Clear();

        Console.Write("Name: ");
        string customerName = Console.ReadLine();

        Console.Write("Street Address: ");
        string streetAdd = Console.ReadLine();

        Console.Write("City: ");
        string city = Console.ReadLine();

        Console.Write("State or Province: ");
        string stateorprov = Console.ReadLine();

        Console.Write("Country: ");
        string country = Console.ReadLine();

        Customer customer = new Customer(customerName);
        Address address = new Address(streetAdd, city, stateorprov, country);


        do
        {
            Console.Clear();

            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Create Order");
            Console.WriteLine(" 2. Save Order");
            Console.WriteLine(" 3. Print Order");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine(" 5. show customer info");
            Console.Write("Select a choice from the menu: ");
            string menuInput = Console.ReadLine();
                
            if(menuInput == "1")
            {
                Console.Write("What is the product: ");
                string productName = Console.ReadLine();

                Console.Write("What is the ID: ");
                string id = Console.ReadLine();

                Console.Write("What is the price: ");
                string price = Console.ReadLine();

                Console.Write("What is the quantity: ");
                string quantity = Console.ReadLine();

                Product product1 = new Product(productName, id, price, quantity);
                string product = product1.productstring();
                order1.addProduct(product);
            }
            else if(menuInput == "2")
            {
                order1.saveShoppingList();
            }
            else if(menuInput == "3")
            {
                Console.Clear();
                order1.packingOrder();
                Console.WriteLine();
                address.shippingLabel();
                Console.WriteLine();
                
                int shippingCost = 0;
                if(address.country() == true)
                {
                    shippingCost += 5;
                }
                else
                {
                    shippingCost += 35;
                }

                int cost = order1.getItemPrices();
                int totalCost = cost + shippingCost;
                Console.WriteLine();
                Console.WriteLine($"Total Cost: ${totalCost}");
                Console.WriteLine();
            }
            else if(menuInput == "4")
            {
                break;
            }
        }while (true);
    }
}