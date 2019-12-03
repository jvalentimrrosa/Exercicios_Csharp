using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal
{
    class Animal
    {
        public string Voz(string animal, string voz)
        {
            Console.WriteLine(voz + " é a voz do " + animal);
            return animal;
        }

        public string Raca (string raca)
        {
            return raca;
        }
    }

}
