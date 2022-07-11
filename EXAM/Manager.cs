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
            Product sp = new Product();
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

        public bool DeleteSP(string ID)
        {
            bool IsDeleted = false;
            Product sv = FindByID(ID);
            if (sv != null)
            {
                IsDeleted = Listsp.Remove(sv);
            }
            else
            {
                Console.WriteLine("Product ID with = {0} does not exist.", ID);
            }
            return IsDeleted;
        }
        public Product FindByID(string ID)
        {
            Product searchResult = null;
            if (Listsp != null && Listsp.Count > 0)
            {
                foreach (Product p in Listsp)
                {
                    if (p.ID == ID)
                    {
                        searchResult = p;
                    }
                }
            }
            return searchResult;
        }
        public List<Product> getListSP()
        {
            return Listsp;
        }
    }
}
