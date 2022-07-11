using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager mn = new Manager();
            while (true)
            {
                Console.WriteLine("\tMENU");
                Console.WriteLine("1.Add productrecords.");
                Console.WriteLine("2.Display productrecords.");
                Console.WriteLine("3.Delete productby Id.");
                Console.WriteLine("4.Exit.");
                Console.WriteLine("Choose a number from 1 to 4");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("1. Add productrecords.");
                        mn.EnterSP();
                        Console.WriteLine("Add successful!");
                        break;
                    case 2:
                        if (mn.QuantitySP() > 0)
                        {
                            Console.WriteLine("Display productrecords");
                            mn.ShowSP(mn.getListSP());
                        }
                        else
                        {
                            Console.WriteLine("not product!");
                        }
                        break;
                    case 3:
                        if (mn.QuantitySP() > 0)
                        {
                            string ID;
                            Console.WriteLine("\n3. Delete product by ID.");
                            Console.Write("\nInput ID to delete: ");
                            ID = Console.ReadLine();
                            if (mn.DeleteSP(ID))
                            {
                                Console.WriteLine("\nProduct ID with = {0} has been removed!", ID);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nThere are no products in the list.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exit!");
                        return;
                    default:
                        Console.WriteLine("Choose a number from 1 to 4");
                        break;
                }

            }
        }
    }
}
