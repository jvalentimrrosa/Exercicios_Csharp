using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal
{
    class Pet
    {
        Animal cao = new Cachorro();
        Animal cat = new Gato();
        string pet;

        public void VozCachorro()
        {
            pet = cao.Voz("cão","Latir");
        }

        public void VozGato()
        {
            pet = cat.Voz("gato", "Miar");
        }

        public void Dono(string fulano)
        {
            string pet1;
            if (pet == "cão")
            {
                pet1 = cao.Raca("dálmata");
            }
            else
            {
                pet1 = cat.Raca("persa");
            }
            Console.WriteLine(fulano + " é o dono do " + pet1);
        }
    }
}
