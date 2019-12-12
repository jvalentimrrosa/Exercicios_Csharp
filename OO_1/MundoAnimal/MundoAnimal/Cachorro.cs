using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal
{
    class Cachorro : Animal
    {
        public override void Voz(string animal)
        {
            Console.WriteLine(animal + " late!");
        }

        public override string Raca(string raca)
        {
            return raca;
        }
    }
}
