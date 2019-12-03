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
            var bicho = new Pet(new Gato());
            bicho.Voz(Console.ReadLine());
            bicho.Raca(Console.ReadLine());
            bicho.Dono(Console.ReadLine());
            bicho.setPet(new Cachorro());
            bicho.Voz(Console.ReadLine());
            bicho.Raca(Console.ReadLine());
            bicho.Dono(Console.ReadLine());
            Console.Read();
        }

    }
}
