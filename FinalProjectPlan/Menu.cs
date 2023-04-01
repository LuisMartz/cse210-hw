 using System;
using System.Collections.Generic;
using YouTubeVideos;

namespace MyMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            List<Event> events = new List<Event>();
            BillingAddress billingAddress = new BillingAddress("84 Railroad St", "Nanuet", "NY", "USA"); /*Bill Address, switch in case to not be from USA*/
            Customer customer = new Customer("Peter Williams", billingAddress);
            Order order = new Order(1, customer, products);
            Address address = new Address("", "", "", "");

            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Video");
                Console.WriteLine("2. Activities");
                Console.WriteLine("3. Order");
                Console.WriteLine("4. Event");
                Console.WriteLine("5. List");
                Console.WriteLine("6. Quit");
                string input = Console.ReadLine() ?? "";

                switch (input)
                {
                    case "1":
                         List<Video> videos = new List<Video>();
                        Video video1 = new ConcreteVideo("Makeup Tutorial", "Sarah Thomas", 420);
                        video1.AddComment("Marta", "Thanks for sharing!");
                        video1.AddComment("Maria", "Thanks for your makeup tutorials.");
                        videos.Add(video1);
                        /*-----*/
                        Video video2 = new ConcreteVideo("Web development", "CSScoder_23", 1800);
                        video2.AddComment("Bill", "Great tutorial! Can't wait to start making my own webpage.");
                        video2.AddComment("Sarah", "Thanks for explaining everything so clearly.");
                        video2.AddComment("Thomas", "I found this very helpful, thanks!");
                        videos.Add(video2);
                        /*-----*/
                        Video video3 = new ConcreteVideo("Yoga Training", "ConfidenceUp", 600);
                        video3.AddComment("Emily", "I started to practice my yoga. Thank you!");
                        video3.AddComment("Mark", "I was looking for something like this, thank you.");
                        videos.Add(video3);
                        foreach (Video video in videos)
                        {
                            video.Display();
                        }
                             Console.ReadLine();
                        break;
                        
                        
                    case "2":
                        Console.WriteLine("Select an activity:");
                        Console.WriteLine("1. Running");
                        Console.WriteLine("2. Cycling");
                        Console.WriteLine("3. Hiking");
                        string activityType = Console.ReadLine() ?? "";

                        Console.WriteLine("Enter the name:");
                        string name = Console.ReadLine() ?? "";

                        Console.WriteLine("Enter the distance:");
                        double distance = double.Parse(Console.ReadLine() ?? "");

                        Console.WriteLine("Enter the start time (YYYY-MM-DD):");
                        DateTime startTime = DateTime.Parse(Console.ReadLine() ?? "");

                        switch (activityType)
                            {
                                case "1":
                                    Console.WriteLine("Enter the elevation gain:");
                                    double elevationGain = double.Parse(Console.ReadLine() ?? "");
                                    RunningActivity runningActivity = new RunningActivity(name, distance, startTime, elevationGain);
                                    Console.WriteLine(runningActivity.GetSummary());
                                    break;

                                case "2":
                                    Console.WriteLine("Enter the max speed:");
                                    double maxSpeed = double.Parse(Console.ReadLine() ?? "");
                                    CyclingActivity cyclingActivity = new CyclingActivity(name, distance, startTime, maxSpeed);
                                    Console.WriteLine(cyclingActivity.GetSummary());
                                    break;

                                case "3":
                                    Console.WriteLine("Enter the number of rest stops:");
                                    int numRestStops = int.Parse(Console.ReadLine() ?? "");
                                    HikingActivity hikingActivity = new HikingActivity(name, distance, startTime, numRestStops);
                                    Console.WriteLine(hikingActivity.GetSummary());
                                    break;

                                default:
                                    Console.WriteLine("Invalid activity type.");
                                    break;
                            }

                                     break;
                    case "3":
                        Console.WriteLine("Enter the product ID:");
                        int productId = int.Parse(Console.ReadLine() ?? "");

                        Console.WriteLine("Enter the product name:");
                        string productName = Console.ReadLine() ?? "";

                        Console.WriteLine("Enter the price:");
                        double price = double.Parse(Console.ReadLine() ?? "");

                        Console.WriteLine("Enter the quantity:");
                        int quantity = int.Parse(Console.ReadLine() ?? "");

                        Product product = new Product(productId, productName, price, quantity);
                        products.Add(product);

                        double totalCost = order.GetTotalCost();
                        Console.WriteLine("Total cost: " + totalCost);
                        break;
                    case "4":
                        Console.WriteLine("Select an event type:");
                        Console.WriteLine("1. Lecture");
                        Console.WriteLine("2. Reception");
                        Console.WriteLine("3. Outdoor Gathering");
                        string eventType = Console.ReadLine() ?? "";

                        Console.WriteLine("Enter the event name:");
                        string eventName = Console.ReadLine() ?? "";

                        Console.WriteLine("Enter the maximum number of attendees:");
                        int maxAttendees = int.Parse(Console.ReadLine() ?? "");

                    switch (eventType) {
                        case "1":
                            Console.WriteLine("Enter the name of the lecture:");
                            string lectureName = Console.ReadLine() ?? "";

                            Console.WriteLine("Enter the name of the speaker:");
                            string speakerName = Console.ReadLine() ?? "";

                            Console.WriteLine("Enter the start time of the lecture (YYYY-MM-DD)");
                            DateTime lectureStartTime = DateTime.Parse(Console.ReadLine() ?? "");

                            Console.WriteLine("Enter the end time of the lecture (YYYY-MM-DD)");
                            DateTime lectureEndTime = DateTime.Parse(Console.ReadLine() ?? "");

                            Console.WriteLine("Enter the location of the lecture: (Street-City-State-Zip)");
                            string location = Console.ReadLine() ?? "";
                            Address lectureAddress = new Address(location.Split('-')[0], location.Split('-')[1], location.Split('-')[2], location.Split('-')[3]);

                            Lecture lecture = new Lecture(lectureName, lectureStartTime, lectureEndTime, lectureAddress, speakerName, maxAttendees);
                            events.Add(lecture);

                            Console.WriteLine("Added a new lecture: " + lecture.GetMarketingMessage("Standard details"));
                            break;
                        case "2":
                            Console.WriteLine("Enter the name of the reception:");
                            string receptionName = Console.ReadLine() ?? "";

                            Console.WriteLine("Enter the start date of the reception (YYYY-MM-DD):");
                            DateTime receptionDate = DateTime.Parse(Console.ReadLine() ?? "");

                            Console.WriteLine("Enter the start time of the reception (HH:mm):");
                            DateTime receptionStartTime = DateTime.Parse(Console.ReadLine() ?? "");


                            Console.WriteLine("Enter the location of the reception: (Street-City-State-Zip)");
                            string lecturelocation = Console.ReadLine() ?? "";
                            Address receptionAddress = new Address(lecturelocation.Split('-')[0], lecturelocation.Split('-')[1], lecturelocation.Split('-')[2], lecturelocation.Split('-')[3]);

                            
                            Console.WriteLine("Enter the RSVP email for the reception:");
                            string rsvpEmail = Console.ReadLine() ?? "";

                            Reception reception = new Reception(receptionName, receptionDate, receptionStartTime, receptionAddress, rsvpEmail);
                            events.Add(reception);

                            Console.WriteLine("Added a new reception: " + reception.GetMarketingMessage("Full details"));
                            break;
                        case "3":
                            Console.WriteLine("Enter the name of the gathering:");
                            string gatheringName = Console.ReadLine() ?? "";

                            Console.WriteLine("Enter the start time of the gathering (YYYY-MM-DD)");
                            DateTime gatheringStartTime = DateTime.Parse(Console.ReadLine() ?? "");

                            Console.WriteLine("Enter the end time of the gathering (YYYY-MM-DD)");
                            DateTime gatheringEndTime = DateTime.Parse(Console.ReadLine() ?? "");

                            Console.WriteLine("Enter the location of the gathering: (Street-City-State-Zip)");
                            location = Console.ReadLine() ?? "";
                            Address gatheringAddress = new Address(location.Split('-')[0], location.Split('-')[1], location.Split('-')[2], location.Split('-')[3]);
                            Console.WriteLine("Enter the weather statement");
                            string weatherStatement = Console.ReadLine() ?? "";

                            OutdoorGathering gathering = new OutdoorGathering(gatheringName, gatheringStartTime, gatheringEndTime, gatheringAddress, weatherStatement);
                            events.Add(gathering);

                            Console.WriteLine("Added a new outdoor gathering: " + gathering.GetMarketingMessage("Full details"));
                            break;
                        default:
                            Console.WriteLine("Invalid event type.");
                            break;
                    }
                            break;
                            
                    case "5":
                    Console.WriteLine("Select a list to display:");
                    Console.WriteLine("1. Products");
                    Console.WriteLine("2. Events");
                    string listType = Console.ReadLine() ?? "";
                    switch (listType)
                    {
                        case "1":
                            Console.WriteLine("Products:");
                            foreach (Product product2 in order.Products)
                            {
                                Console.WriteLine(product2.GetSummary());
                            }
                            break;

                        case "2":
                            Console.WriteLine("Events:");
                            foreach (Event e in events)
                            {
                                Console.WriteLine(e.GetSummary());
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid list type.");
                            break;
                    }
                    break;
                    case "6":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

