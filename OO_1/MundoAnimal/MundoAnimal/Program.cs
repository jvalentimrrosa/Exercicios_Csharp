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
            aa();
            /*
            Animal bicho = new Gato();
            bicho.Voz(Console.ReadLine());
            bicho.Raca(Console.ReadLine());
            bicho.Dono(Console.ReadLine());
            bicho = new Cachorro();
            bicho.Voz(Console.ReadLine());
            bicho.Raca(Console.ReadLine());
            bicho.Dono(Console.ReadLine());
            Console.Read();*/
        }
        static void aa()
        {

            Animal bicho = new Gato();
            bicho.Voz(Console.ReadLine());
            bicho.Raca(Console.ReadLine());
            
            ((Pet)bicho ).Dono(Console.ReadLine());
            if(bicho is Pet) (bicho as Pet).Dono(Console.ReadLine());

            bicho = new Cachorro();
            bicho.Voz(Console.ReadLine());
            bicho.Raca(Console.ReadLine());
            if (bicho is Pet)
                (bicho as Pet).Dono(Console.ReadLine());
            

            Console.Read();
        }

    }
}
