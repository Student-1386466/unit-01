using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_01_09_01_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator App\n");

            while(true)
            {
                Console.WriteLine("Enter your first number and press 'Enter':");
                decimal a = Convert.ToDecimal(Console.ReadLine());// this will help you enter a number onvert it into decimal and store it in variable//

                Console.WriteLine("Enter your second number and Press 'Enter':");
                decimal b = Convert.ToDecimal(Console.ReadLine());// this will help you enter a number onvert it into decimal and store it in variable//

                Console.WriteLine("\n Press 1 for Addition and press'Enter'");
                Console.WriteLine("\n Press 2 for Subtraction and press'Enter'");
                Console.WriteLine("\n Press 3 for Multiplication and press'Enter'");
                Console.WriteLine("\n Press 4 for Division and press'Enter'");
                Console.WriteLine("");

                int z = Convert.ToInt32(Console.ReadLine());//it will read the number and convert it into int and store into variable//
                switch(z)
                {
                    case 1:
                        Console.WriteLine("\nAnswer:");
                        Console.WriteLine(a + b);
                        break;//if cnodition true it will go out of switch and process other statements//
                    case 2:
                        Console.WriteLine("\nAnswer:");
                        Console.WriteLine(a - b);
                        break;
                    case 3:
                        Console.WriteLine("\nAnswer:");
                        Console.WriteLine(a * b);
                        break;
                    case 4:
                        Console.WriteLine("\nAnswer:");
                        Console.WriteLine(a / b);
                        break;
                  
                }
                Console.WriteLine("\nPress any key to Restart....\n");
                Console.ReadKey();//this will restart the program//
            }
        }
    }
}
