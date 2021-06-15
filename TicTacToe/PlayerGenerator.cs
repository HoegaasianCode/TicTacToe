using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class PlayerGenerator
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public void ReadPlayerNames()
        {
            Console.WriteLine("Enter 1st player's name: ");
            string userName1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd player's name: ");
            string userName2 = Console.ReadLine();
            CreatePlayers(userName1, userName2);
        }
        private void CreatePlayers(string userName1, string userName2)
        {
            Player1 = new(1, userName1);
            Player2 = new(2, userName2);
        }
    }
}
