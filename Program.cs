using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62DersThisReadonlyCons
{
    class Program
    {   

        class Isci
        {
            public readonly double maas;
            public Isci(double maas)
            {
                this.maas = maas;
            }
        }
        // Readonly, constructors icerisinden degistirilebilir. Ancak Const hic bi sekilde degistirilemez.
        // Readonly'e sonradan deger atanabilir ancak Const'a o an deger atamak gerekir.
        static void Main(string[] args)
        {
            Isci i1 = new Isci(4250.5);
            Isci i2 = new Isci(8500.5);
            Console.WriteLine(i1.maas + " " + i2.maas);

        }
    }
}
