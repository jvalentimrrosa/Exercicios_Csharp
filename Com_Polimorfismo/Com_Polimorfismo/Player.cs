using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com_Polimorfismo
{
    class Player
    {
        MP3Player mp3 = new MP3Player();
        CDPlayer cd = new CDPlayer();

        public void Playing(int num)
        {
            if (num%2 == 0)
            {
                mp3.Play();
            }
            else
            {
                cd.Play();
            }
        }
    }
}
