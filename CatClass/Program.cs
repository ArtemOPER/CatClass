using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Шотландская_вислоухая cat = new Шотландская_вислоухая();
            cat.name = "Шотландская вислоухая";
            cat.price = 6000;
            cat.age = 2;
            cat.place = "Китай";

            cat.GetCatInfo();

            Русская_голубая cat1 = new Русская_голубая();
            cat1.type = "Семейство кошачих";
            cat1.name = "Русская голубая";
            cat1.place = "Россия";
            cat1.price = 100;
            cat1.age = 5;


            cat1.GetCat1Info();

            Console.ReadLine();
        }
    }
}
