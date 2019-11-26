using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet bicho1 = new Pet();
            bicho1.VozCachorro();
            bicho1.Dono(Console.ReadLine());
            Pet bicho2 = new Pet();
            bicho2.VozGato();
            bicho2.Dono(Console.ReadLine());
            Console.Read();
        }

    }
}
