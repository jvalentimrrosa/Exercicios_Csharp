using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player audio1 = new Player();
            audio1.playCD();
            Player audio2 = new Player();
            audio2.playMP3();
            Console.Read();
         
        }
    }
}
