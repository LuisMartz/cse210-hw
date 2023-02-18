using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string scripture = "Worship God, for him only shalt thou serve. (Moses 1:15)";

            while (scripture.ToLower() != "quit")
            {
                Console.WriteLine(scripture);
                Console.WriteLine("Type 'quit' to leave or else press Enter to delete characters");
               string input = Console.ReadLine();

                if (input == "quit"){
                    break;
                }

                
                if (scripture.ToLower() != "quit")
                {
                    string originalString = scripture;
                    Console.WriteLine("Original string: " + originalString);

                    Random random = new Random();
                    int stringLength = originalString.Length;
                    string input_2 = " ";

                    while (stringLength > 0 & input_2 != "quit")
                    {
                        
                        int deleteIndex = random.Next(0, stringLength);
                        string deletedString = originalString.Remove(deleteIndex, 1);
                        originalString = deletedString;
                        stringLength = originalString.Length;

                        Console.WriteLine("Character removed: " + deletedString);
                        Console.WriteLine("Press enter to continue deleting or else type 'quit' to leave");
                        input_2 = Console.ReadLine();
                        Console.Clear();
                        
                    }

                    Console.WriteLine("The string has been completely deleted, exiting program...");
                    break;
                }
                
            }

            Console.WriteLine("Exiting program...");
        }
    }
}
