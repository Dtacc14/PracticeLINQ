using System;
using System.Collections.Generic;
using System.Linq;

namespace PraticeLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() { "NCAA", "Madden", "Call of Duty", "Rocket League", "Fortnite", "Legend of Zelda", "Left 4 Dead" };

            Console.WriteLine("Here is a list of the games I play:");
            videoGames.OrderBy(x => x.Length).ToList().ForEach(Console.WriteLine);      
        }
    }
}