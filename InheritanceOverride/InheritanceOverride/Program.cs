using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            CityDerivedClass cdc = new CityDerivedClass();
            cdc.showCityName();
        }
    }
    public class CityBaseClass
    {
        public virtual void showCityName()
        {
            Console.WriteLine("New York City");
            Console.ReadLine();
        }
    }
    public class CityDerivedClass : CityBaseClass
    {
        public override void showCityName()
        {
            Console.WriteLine("New Jersey");
            Console.ReadLine();
        }
    }
}
