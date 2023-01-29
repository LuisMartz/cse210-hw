using System;
 class Program{
    string[] quotes = {"Who was the most interesting person I interacted with today?",
    "What was the best part of my day?","What was the strongest emotion I felt today?"};
    static Random rnd = new Random();
    int random = Random.next(quotes.Count);
    /*Tried to use the random class to get different quotes [Online] */
    static void Main(string[] args){

    int leave = 5;
    while (leave !=5){
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        int options = Convert.ToInt32(Console.ReadLine());
        /*I had to change parts of the code from my concept and tried to find other pieces of code online.
        Also trying to apply "switch" */
    switch (options){
        case 1:
            Console.WriteLine((quotes[rnd]));
            string answer = Console.ReadLine();
            Console.WriteLine("Entry added to the journal");
            break;
        case 2:

        case 3:

        break;
        case 4:

        break;
    /*Still need to figure out the use of Journals. */
        case 5:
        Console.WriteLine("Leaving...");
        leave = 5;
        break;
    }
    }

 }
 }   