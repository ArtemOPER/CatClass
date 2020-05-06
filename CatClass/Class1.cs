using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatClass
{
    public class Cat
    {
        public string Name { get ; set: }
        public int Age { get ; set: }
        protected int Price { get; set }
        public Cat()
        {
            Price = 0;
        }
        public virtual string GetPrica()
        {
            return " Кошку можно получить бесплатно";
        }
    }


    public class PurebredCat : Cat
    {
        public string NamePurebred { get; set; }

        public string PassportID { get; set; }

        public string[] Graft { get; set; }

        public override string GetPrica()
        {
            return "Это пародистая кошка  - ее можно приобрести за" + base.GetPrica();
        }
    }
    
    public class thoroughbredcat : Cat


        