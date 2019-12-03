using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal
{
    abstract class Animal
    {
        public abstract void Voz(string animal);

        public abstract string Raca(string raca);

        public abstract string Dono(string dono);
       
    }

}
