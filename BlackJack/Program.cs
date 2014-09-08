using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            GameTable game1 = new GameTable(4);
            game1.AddPlayer(new Player());
            game1.StartGame();
            Console.ReadLine();
        }
    }
}
