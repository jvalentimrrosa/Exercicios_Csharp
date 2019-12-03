using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal
{
    class Gato : Animal
    {
        public override void Voz(string animal)
        {
            Console.WriteLine(animal + " mia!");
            //return animal + " mia!"
        }

        public override string Raca(string raca)
        {
            return raca;
        }

        public override string Dono(string dono)
        {
            Console.WriteLine(dono + " é o dono do!");
            return dono;
        }
    }
}
