using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com_Polimorfismo
{
    class CDPlayer : MusicPlayer
    {
       public override void Play()
        {
            Console.WriteLine("Ouvindo CD Player!");
        }
    }
}
