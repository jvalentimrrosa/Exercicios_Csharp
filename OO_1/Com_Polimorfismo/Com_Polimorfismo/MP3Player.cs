using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com_Polimorfismo
{
    class MP3Player : MusicPlayer
    {
        public override void Play()
        {
            Console.WriteLine("Ouvindo MP3 Player!");
        }
    }
}
