using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Modules
{
    public class ServiceProduct
    {
        private Random rnd = new Random();
        public void GenerateProduct(Grocery shop)
        {
            for (int i = 0; i < rnd.Next(5, 20); i++)
            {
                Product p = new Product();
                p.Barcode = rnd.Next(10000, 300000);
                p.Cur.CurCode = 398;
                p.Cur.CurName = "KZT";
                p.Cur = new Product.Currency() { CurCode = 398, CurName = "KZT" };
                p.DateOfProduction = DateTime.Now.AddDays(-rnd.Next(0, 1000));
                p.ExpiredDay = rnd.Next(1, 10);
                p.ExpiredTime = DateTime.Now.AddDays(rnd.Next(0, 20));
                p.Name = string.Format("Product #{0}", rnd.Next());
                p.Price = rnd.NextDouble();

                shop.Products.Add(p);
            }
        }
        public List<Grocery> GenerateShop()
        {
            List<Grocery> Shops = new List<Grocery>();
            for (int i = 0; i < rnd.Next(1, 10); i++)
            {
                Grocery g = new Grocery();
                g.Name = "Shop #" + rnd.Next();
                GenerateProduct(g);
                Shops.Add(g);
            }
            return Shops;
        }
    }
}

