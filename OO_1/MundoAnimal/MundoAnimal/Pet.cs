using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal
{
    class Pet
    {
        Animal pet;
        //string animal, raca, dono;

        public Pet(Animal pet)
        {
            this.pet = pet;
        }

        public void setPet(Animal pet)
        {
            this.pet = pet;
        }

        public void Voz(string animal)
        {
            pet.Voz(animal);
        }

        public void Raca(string raca)
        {
            pet.Raca(raca);
        }

        public void Dono(string dono)
        {
            pet.Dono(dono);
            
        }
    }
}
