using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal
{
    abstract class Pet : Animal
    {
        /*Animal pet;
        
        public Pet(Animal pet)
        {
            this.pet = pet;
        }

        public void setPet(Animal pet)
        {
            this.pet = pet;
        }*/

        public override string Raca(string raca)
        {
            return raca;
        }
        public abstract string Dono(string dono);
    }
}
