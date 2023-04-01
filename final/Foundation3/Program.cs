using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Please give the following info: ");
        Console.Write("What is the title of the event: ");
        string title = Console.ReadLine();
        Console.Write("What is the date of the event: ");
        string date = Console.ReadLine();
        Console.Write("What is the address: ");
        string address = Console.ReadLine();

        Address address1 = new Address(address);

        Event event1 = new Event(title, date);
        
        do
        {
            Console.WriteLine("1. Standard");
            Console.WriteLine("2. Full");
            Console.WriteLine("3. Short");
            Console.WriteLine("3. Quit");
            Console.Write("How much detail do you want in your post? ");
            string detail = Console.ReadLine();
            
            if (detail == "1")
            {
                Console.Write("What is the description: ");
                string description = Console.ReadLine();
                Console.Write("What is the time: ");
                string time = Console.ReadLine();
                string a1 = address1.getAddress();
                string t1 = event1.getTitle();
                string d1 = event1.getDate();
                
                Standard s1 = new Standard(t1, description, d1, time, a1);
                s1.standardMessage(t1,d1);
            }
            else if (detail == "2")
            {
                Console.Write("What is the description: ");
                string description = Console.ReadLine();
                Console.Write("What is the time: ");
                string time = Console.ReadLine();

                Console.WriteLine("1. Lecture");
                Console.WriteLine("2. Reception");
                Console.WriteLine("3. Outdoor Gathering");
                Console.Write("What type: ");
                string type = Console.ReadLine();

                string a1 = address1.getAddress();
                string t1 = event1.getTitle();
                string d1 = event1.getDate();

                Full f1 = new Full(t1, description, d1, type, time, a1);
                f1.fullMessage(t1, d1);
                if (type ==  "1")
                {
                    Console.Write("Name of speaker: ");
                    string name = Console.ReadLine();
                    Console.Write("Capacity: ");
                    string cap = Console.ReadLine();
                    f1.returnLecture(name, cap);
                }
                else if (type ==  "2")
                {
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    f1.returnReception(email);
                }
                else if (type == "3")
                {
                    Console.Write("Weather Description: ");
                    string weather = Console.ReadLine();
                    f1.returnWeather(weather);
                }
            }
            else if (detail == "3")
            {
                Console.WriteLine("1. Lecture");
                Console.WriteLine("2. Reception");
                Console.WriteLine("3. Outdoor Gathering");
                Console.Write("What type: ");
                string type = Console.ReadLine();

                if (type ==  "1")
                {
                    type = "Lecture";
                }
                else if (type ==  "2")
                {
                    type = "Reception";
                }
                else if (type == "3")
                {
                    type = "Outdoor Gathering";
                }

                string t1 = event1.getTitle();
                string d1 = event1.getDate();

                Short short1 = new Short(t1, d1, type);
                short1.shortMessage(t1, d1);
            }
            else if (detail == "4")
            {
                break;
            }
        }while (true);
    }
}