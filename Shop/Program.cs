using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DAL;
using Shop.DAL.Modules;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProduct sp = new ServiceProduct();
            List<Grocery> gr = sp.GenerateShop();
            foreach (Grocery item in gr.OrderBy(o=>o.Products.Count()))
            {
                item.Info();
            }
           
            Console.WriteLine("Enter SHOP NAME");
            string terp = Console.ReadLine();
            Console.Clear();
            Grocery gro = gr.FirstOrDefault(o=>o.Name==terp);
            if(gro != null)
            {
                Console.WriteLine("Enter QR");
                int temp = Int32.Parse(Console.ReadLine());
                Product findProd = gro[temp];
                findProd.PrintInfo();
            }
        }
    }
}
