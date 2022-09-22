using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Augest_2022
{
    internal class Product
    {
        public String number { get; set; }
        public String id { get; set; }
        public String name { get; set; }
        public String manu_Date { get; set; }
        public String exp_date { get; set; }
        public int quantity { get; set; }

        public int price { get; set; }



        static List<Product> p = new List<Product>();

        public void save()
        {



        }

        public static List<Product> getAllProduct()
        {
            return p;
        }

        public static Product findOne(String ID)
        {
            return p.Find(c => c.id == ID);
        }
    }
}

   

