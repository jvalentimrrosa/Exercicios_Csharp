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
            Player audio1 = new Player();

            while (true)
            {
                var aux = int.Parse(Console.ReadLine());
                audio1.Playing(aux);
                if (aux == 0)
                {
                    break;
                }
            }
            
        }
    }
}
