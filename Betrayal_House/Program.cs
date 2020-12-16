using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Betrayal_House
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string[] characterNames = new string[] { "Madame Zostra", "Missy Dubourde", "Vivian Lopez", "Father Reinhardt" };
            TestAllCharacterCombinations(4, 10000.0);
        }

        public static void TestAllCharacterCombinations(int numPlayers, double instances)
        {
            var characterCombinations = new List<List<Character>>();

            while (characterCombinations.Count < Combinatorics.Combinations(GameConstants.Characters.Count, numPlayers))
            {
                var combo = GameConstants.Characters.SelectCombination(numPlayers, GameConstants.RNG);

                if (!characterCombinations.Contains(combo))
                {
                    characterCombinations.Add(combo.ToList());
                }
            }

            List<Game> games = new List<Game>();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < characterCombinations.LongCount(); i++)
            {
                if (i % (characterCombinations.LongCount() / 100) == 0)
                {
                    Console.WriteLine($"{(double)i / characterCombinations.LongCount():p0}: {stopwatch.Elapsed}");
                }

                var characters = characterCombinations[i];
                for (int j = 0; j < (int)instances; j++)
                {
                    games.Add(new Game(characters));
                }
            }
            stopwatch.Stop();

            foreach (Character character in GameConstants.Characters)
            {
                ConsoleColor currentColor = Console.ForegroundColor;
                Console.ForegroundColor = character.Color;
                Console.WriteLine($"{character.Name}: " +
                    $"{games.FindAll(g => g.Traitor.Character.Name == character.Name).Count / (double)games.Count:p2}");
                Console.ForegroundColor = currentColor;

                Console.WriteLine("\tTop Five Reasons for Traitor:");
                var traitorGames = games.FindAll(g => g.Traitor.Character.Name == character.Name);
                var reasons = traitorGames.GroupBy(g => g.Traitor.Reason).OrderByDescending(g => g.Count()).ToList();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"\t{reasons[i].Key}: {(double)reasons[i].Count() / traitorGames.Count:p2}");
                }
            }
        }

        public static void TestSetOfCharacters(string[] characterNames)
        {
            var characters = characterNames.Select(n => GameConstants.Characters.Find(c => c.Name == n)).ToList();

            double instances = 100000.0;

            List<Game> games = new List<Game>();
            for (int i = 0; i < (int)instances; i++)
            {
                games.Add(new Game(characters));
            }

            foreach (Character character in characters)
            {
                ConsoleColor currentColor = Console.ForegroundColor;
                Console.ForegroundColor = character.Color;
                Console.WriteLine($"{character.Name}: " +
                    $"{games.FindAll(g => g.Traitor.Character.Name == character.Name).Count / instances:p2}");
                Console.ForegroundColor = currentColor;

                Console.WriteLine("\tTop Five Reasons for Traitor:");
                var traitorGames = games.FindAll(g => g.Traitor.Character.Name == character.Name);
                var reasons = traitorGames.GroupBy(g => g.Traitor.Reason).OrderByDescending(g => g.Count()).ToList();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"\t{reasons[i].Key}: {(double)reasons[i].Count() / traitorGames.Count:p2}");
                }
            }
            Console.WriteLine($"No Traitor: {games.FindAll(g => g.Traitor.Character.Name == "No Traitor").Count / instances:p2}");

            Console.WriteLine("\nReasons for traitor selections:\n");
            Console.WriteLine(string.Join('\n', games.GroupBy(g => g.Traitor.Reason)
                .OrderByDescending(c => c.Count())
                .Select(l => $"{l.Key}: {l.Count() / instances:p2}")));
        }

        public static void TestIndividualGame(string[] characterNames)
        {
            Game game = new Game(characterNames);

            string traitorInfo = game.Traitor.Character.Name == "No Traitor"
                ? "No traitor."
                : $"Traitor is {game.Traitor.Character.Summary}";
            Console.WriteLine($"Haunt #{game.Haunt.ScenarioNumber}: {traitorInfo}\nRule: {game.Haunt.RuleDescription}\n\n" +
                $"{string.Join('\n', game.CharacterInstances.Select(c => c.Summary))}");
        }
    }

}
