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
            while (true)
            {
                Console.WriteLine("\tMENU");
                Console.WriteLine("1.Add productrecords.");
                Console.WriteLine("2.Display productrecords.");
                Console.WriteLine("3.Delete productby Id.");
                Console.WriteLine("4.Exit.");
                Console.WriteLine("Choose a number from 1 to 4");
                int key = Convert.ToInt32(Console.ReadLine());
                Manager mn = new Manager();
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
                        Console.WriteLine("Delete productby Id");
                        int del = Convert.ToInt32(Console.ReadLine());
                        foreach(Product product in mn.getListSP())
                        {
                            if(product.ID == del)
                            {
                                mn.getListSP().Remove(product);
                                Console.WriteLine("successful delete!");
                            }
                        }
                        Console.WriteLine("not ID in List!");
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
