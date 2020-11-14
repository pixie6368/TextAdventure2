using System;

namespace TextAdventure2
{
    
    
        class Program
    {
        static void Main()
        {

            //declare variables
            string Lives;
            string Begin;
            string Silent;
            string Things;
            string Free;
            string Free1;
            string Almighty;
            string Free2;
            string Dream;
            string Colorful;
            string State;
            string Gender1;
            string Gender2;
            string Sit;
            string Brotherhood;
            string Quote1;
            string Quote2;
            string Quote3;

            //write header and instructions
            Console.WriteLine("-------");
            Console.WriteLine("Madlib!");
            Console.WriteLine("-------");
            // instructions
            Console.WriteLine("Research quotes from I have a Dream Speech by Martin Luther King.");
            Console.WriteLine("Fill in blanks with a noun, verb, adjective or adverb. Input a synonym of each word!");


            //ask player to enter words
            Console.WriteLine("Please enter a noun: ");
            Lives = Console.ReadLine();

            Console.WriteLine("Please enter an verb: ");
            Begin = Console.ReadLine();

            Console.WriteLine("Please enter an adjective: ");
            Silent = Console.ReadLine();

            Console.WriteLine("Please enter a noun: ");
            Things = Console.ReadLine();

            Console.WriteLine("Please enter an adjective: ");
            Free = Console.ReadLine();

            Console.WriteLine("Please enter an adjective: ");
            Free1 = Console.ReadLine();

            Console.WriteLine("Please enter an adjective: ");
            Almighty = Console.ReadLine();

            Console.WriteLine("Please enter an adjective: ");
            Free2 = Console.ReadLine();

            Console.WriteLine("Please enter a noun: ");
            Dream = Console.ReadLine();

            Console.WriteLine("Please enter a colorful adjective: ");
            Colorful = Console.ReadLine();

            Console.WriteLine("Please enter a noun: ");
            State = Console.ReadLine();

            Console.WriteLine("Please enter a gender: ");
            Gender1 = Console.ReadLine();

            Console.WriteLine("Please enter another gender: ");
            Gender2 = Console.ReadLine();

            Console.WriteLine("Please enter an verb: ");
            Sit = Console.ReadLine();

            Console.WriteLine("Please enter an noun: ");
            Brotherhood = Console.ReadLine();



            //write out Quotes and fill in blanks with synonyms
            Quote1 = "Our " + Lives + " " + Begin + " to end the day we become " + Silent + " about " + Things + " that matter.";
            Console.WriteLine(Quote1);

            Quote2 = Free + "  at last," + Free1 + " at last, " + "Thank God    " + Almighty + " we are " + Free2 + " at last";
            Console.WriteLine(Quote2);

            Quote3 = "I have a " + Dream + " that one day on the " + Colorful + " hills of " + State + ", the " + Gender1 + " of former slaves and the  " + Gender2 + " of former slave owners will be able to " + Sit + " down together at the table of " + Brotherhood + ".";
            Console.WriteLine(Quote3);

            //keep window open and prompt for exit
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
    }
}

