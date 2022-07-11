using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class Manager
    {
        private List<Product> Listsp = null;
        Product sp = new Product();

        public Manager()
        {
            Listsp = new List<Product>();
        }

        public int QuantitySP()
        {
            int Count = 0;
            if (Listsp != null)
            {
                Count = Listsp.Count;
            }
            return Count;
        }

        public void EnterSP()
        {
            Console.Write("Enter ID: ");
            sp.ID = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Name: ");
            sp.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Price ");
            sp.Price = Convert.ToString(Console.ReadLine());

            Listsp.Add(sp);

        }
        public void ShowSP(List<Product> listSP)
        {
            Console.WriteLine("{0, -5} {1, -20} {2, -5} ",
                  "ID", "Name", "Price");
            if (listSP != null && listSP.Count > 0)
            {
                foreach (Product x in listSP)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} ",
                                      x.ID, x.Name, x.Price);
                }
            }
            Console.WriteLine();
        }

        public void DeleteSP()
        {
            Console.WriteLine(" Delete Id");
            sp.ID = Convert.ToString(Console.ReadLine());
            Listsp.Remove(sp);
        }
        public List<Product> getListSP()
        {
            return Listsp;
        }
    }
}
