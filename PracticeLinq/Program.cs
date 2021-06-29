using System;
using System.Collections.Generic;
using System.Linq;
namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var newList = new List<int>();
            var game1 = new Games("Call of Duty", 2003, "Activision");
            var game2 = new Games("Warhammer 40K", 1987, "Games Workshop");
            var game3 = new Games("Tie Fighter", 1994, "LucasArts");
            var game4 = new Games("X-Wing", 1993, "LucasArts");
            var game5 = new Games("Mario Bros.", 1983, "Nintendo");
            var game6 = new Games("Pong", 1972, "Atari");
            var game7 = new Games("Sonic the Hedgehog", 1991, "Sega");
            var games = new List<Games>() { game1, game2, game3, game4, game5, game6 };
            var oldest = games.Min(g => g.Date);
            var howLong = games.Select(g => 2021 - g.Date);
            foreach (var date in howLong)
            {
                newList.Add(date);
            }
            int x = 0;
            for (int i = 0; i < games.Count(); i++)
            {
                Console.WriteLine($"It has been {newList[x]} years since {games[i].Name} was released.");
                x++;
            }
            var ordered = games.OrderBy(g => g.Company).ThenBy(g => g.Name);
            foreach (Games game in ordered)
            {
                Console.WriteLine($"{game.Name} : {game.Company}" );
            }
            var avgAge = games.Average(g => g.Date);
            Console.WriteLine($"The average release date is {avgAge}");
            var youngest = games.Max(g => g.Date);
            Console.WriteLine($"Of the list of 6 games, the oldest was published in {oldest} and the newest in {youngest}.");
            var take = games.Where(g => g.Name.Contains(" ")).OrderByDescending(g => g.Date).Take(1);
            foreach (Games t in take)
            {
                Console.WriteLine($"Of the game titles containing a space, the youngest is {t.Name}.");
            }
            var sum = games.Sum(g => g.Date);
            Console.WriteLine($"Just for fun, if you added up all these games' release dates you would get {sum}.");
            var addGame = games.Append(game7).Count();
            Console.WriteLine($"After adding {game7.Name} to the list, there are {addGame} games in the list.");
           

            
           
        }
    }
}
