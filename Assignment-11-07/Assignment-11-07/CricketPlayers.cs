using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11_07
{
    internal class CricketPlayers
    {
        public void print()
        {
            IDictionary<string, int> Players = new Dictionary<string,int>();
            Players.Add("Rahul", 1);
            Players.Add("Rohit",45);
            Players.Add("Virat",18);
            Players.Add("Sky",63);
            Players.Add("Pant",17);
            Players.Add("Hardik",33);
            Players.Add("Jaddu",8);
            Players.Add("Yuzi",3);
            Players.Add("Bhuvi",15);
            Players.Add("Shami",11);
            Players.Add("Bhumrah",93);
            foreach(var player in Players)
            {
                Console.WriteLine("Player Name:{0} {1}",player.Key,player.Value);
            }
        }
    }
}
