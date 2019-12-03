using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Polimorfismo
{
    class Player
    {
        MusicPlayer mp3 = new MP3Player();
        CDPlayer cd = new CDPlayer();

        public void playMP3()
        {
            mp3.Play("MP3");
        }

        public void playCD()
        {
            cd.Play("CD");
        }
    }
}
