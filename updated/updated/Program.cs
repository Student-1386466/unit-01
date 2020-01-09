using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace updated
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator App");
            decimal Fnum = 0;
            decimal Snum = 0;

            bool exit = false;
            while (exit == false)
            {
                while (true)
                {
                    bool valid1 = false;
                    bool valid2 = false;

                    while (valid1 == false)
                    {
                        Console.WriteLine("Enter First Number:");
                        string string1 = Console.ReadLine();
                        bool parsed = decimal.TryParse(string1, out Fnum);
                        if (!parsed)
                            Console.WriteLine("'{0}' is not correct fromat.. Any digits", string1);
                        else
                            valid1 = true;
                    }
                    while (valid2 == false)
                    {
                        Console.WriteLine("Enter Second Number:");
                        string string2 = Console.ReadLine();
                        bool parsed2 = decimal.TryParse(string2, out Snum);
                        if (!parsed2)
                            Console.WriteLine("'{0}' is not correct format..Any Digit", string2);
                        else
                            valid2 = true;
                    }
                    Console.WriteLine("\n Press 1 for Addition\n Press 2 for Subtraction\n Press 3 for Multiplication\n Press 4 for Division");
                    int z = Convert.ToInt32(Console.ReadLine());//it will read the number and convert it into int and store into variable//
                    switch (z)
                    {
                        case 1:
                            Console.WriteLine("\nAnswer:");
                            Console.WriteLine(Fnum + Snum);
                            break;//if cnodition true it will go out of switch and process other statements//
                        case 2:
                            Console.WriteLine("\nAnswer:");
                            Console.WriteLine(Fnum - Snum);
                            break;
                        case 3:
                            Console.WriteLine("\nAnswer:");
                            Console.WriteLine(Fnum * Snum);
                            break;
                        case 4:
                            Console.WriteLine("\nAnswer:");
                            Console.WriteLine(Fnum / Snum);
                            break;

                    }
                    /*Console.WriteLine("\nPress any key to Restart....\n");
                    Console.ReadKey();//this will restart the program*/
                }
                Console.WriteLine("Press 'q'to quit and '1' for restart");
                string str = Console.ReadLine();
                decimal q = 0;
                if (str == q)
                    exit = true;



            }
        }
    }
}
