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
            var player = new Player(new MP3Player());

            while (true)
            {
                var num = int.Parse(Console.ReadLine());
                if (num != 0)
                {
                    if (num % 2 == 0)
                    {
                        player.setPlayer(new MP3Player());
                    }
                    else
                    {
                        player.setPlayer(new CDPlayer());
                    }
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
