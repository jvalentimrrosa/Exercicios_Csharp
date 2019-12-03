using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {          
            while (true)
            {
                var num = int.Parse(Console.ReadLine());
                if (num != 0)
                {
                    if (num % 2 == 0)
                    {
                        MusicPlayer musicPlayer = new MP3Player();
                    }
                    else
                    {
                        MusicPlayer musicPlayer = new CDPlayer();
                    }
                    var player = new Player(musicPlayer);
                    player.play();
                }
                else
                {
                    break;
                }
            }
            
        }
    }
}
