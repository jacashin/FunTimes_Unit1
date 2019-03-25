using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunTimes_Unit1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            Console.WriteLine("Hello! What are you in the mood of?");
            Console.WriteLine("Here are your options:");
            Console.WriteLine("1) Action");
            Console.WriteLine("2) Chilling");
            Console.WriteLine("3) Danger");
            Console.WriteLine("4) Great Food");

            string userInput1 = Console.ReadLine();
            int.TryParse(userInput1, out x);
            
            

            if (x<1 || x>4)
            {
                Console.WriteLine("Sorry that is not a valid option");
            }
            
            else if (x == 1)
            {
                Console.WriteLine("How many people will be in your party?");
                string userInput2 = Console.ReadLine();
                int.TryParse(userInput2, out y);

                Console.Write("Try stock car racing, ");
                
                if (y == 0)
                {
                    Console.WriteLine("you can use sneakers to walk to your destination.");
                }
                else if (y > 1 && y < 5)
                {
                    Console.WriteLine("I think you should go together in a sedan.");
                }
                else if (y > 4 && y < 11)
                {
                    Console.WriteLine("you're going to need a VW Bus to get there.");
                }
                else
                {
                    Console.WriteLine("you should look to get an airplane as your mode of transportation.");
                }
            }
            else if (x == 2)
            {
                Console.WriteLine("How many people will be in your party?");
                string userInput2 = Console.ReadLine();
                int.TryParse(userInput2, out y);

                Console.Write("Try hiking, ");
                
                if (y == 0)
                {
                    Console.WriteLine("you can use sneakers to walk to your destination.");
                }
                else if (y > 1 && y < 5)
                {
                    Console.WriteLine("I think you should go together in a sedan.");
                }
                else if (y > 4 && y < 11)
                {
                    Console.WriteLine("you're going to need a VW Bus to get there.");
                }
                else
                {
                    Console.WriteLine("you should look to get an airplane as your mode of transportation.");
                }
            }
            else if (x == 3)
            {
                Console.WriteLine("How many people will be in your party?");
                string userInput2 = Console.ReadLine();
                int.TryParse(userInput2, out y);

                Console.Write("You might be interested in skydiving, ");
                
                if (y == 0)
                {
                    Console.WriteLine("you can use sneakers to walk to your destination.");
                }
                else if (y > 1 && y < 5)
                {
                    Console.WriteLine("I think you should go together in a sedan.");
                }
                else if (y > 4 && y < 11)
                {
                    Console.WriteLine("you're going to need a VW Bus to get there.");
                }
                else
                {
                    Console.WriteLine("you should look to get an airplane as your mode of transportation.");
                }
            }
            else if (x == 4)
            {
                Console.WriteLine("How many people will be in your party?");
                string userInput2 = Console.ReadLine();
                int.TryParse(userInput2, out y);

                Console.Write("Why don't you head on over to Taco Bell? ");
                
                if (y == 0)
                {
                    Console.WriteLine("you can use sneakers to walk to your destination.");
                }
                else if (y > 1 && y < 5)
                {
                    Console.WriteLine("I think you should go together in a sedan.");
                }
                else if (y > 4 && y < 11)
                {
                    Console.WriteLine("you're going to need a VW Bus to get there.");
                }
                else
                {
                    Console.WriteLine("you should look to get an airplane as your mode of transportation.");
                }
            }
            Console.ReadLine();
            Console.WriteLine("Goodbye");
            Console.ReadLine();
        }
    }
}

