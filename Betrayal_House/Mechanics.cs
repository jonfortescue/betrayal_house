using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Betrayal_House
{
    public class Character
    {
        public static int NumNotches = 8;
        public static double StandardDeviation = 1.5;

        public string Name { get; set; }
        public int Age { get; set; }
        public ConsoleColor Color { get; set; }
        public Characteristic Speed { get; set; }
        public Characteristic Might { get; set; }
        public Characteristic Sanity { get; set; }
        public Characteristic Knowledge { get; set; }
    }

    public struct Characteristic
    {
        public double[] Values;
        public int StartingNotch;
    }

    public struct Traitor
    {
        public CharacterInstance Character;
        public string Reason;
    }

    public class CharacterInstance
    {
        private Character _character;
        public string Name => _character.Name;
        public int Age => _character.Age;
        public ConsoleColor Color => _character.Color;
        public double Speed { get; }
        public double Might { get; }
        public double Sanity { get; }
        public double Knowledge { get; }

        public string Summary
        {
            get
            {
                return $"{Name} (Age {Age}):\tSp {Speed}, Mi {Might}, Sa {Sanity}, Kn {Knowledge}";
            }
        }

        public CharacterInstance(Character character)
        {
            _character = character;

            int speedNotch = (int)Math.Round(Math.Min(Character.NumNotches - 1, Math.Max(0,
                Normal.Sample(GameConstants.RNG, character.Speed.StartingNotch + 0.5, Character.StandardDeviation))));
            int mightNotch = (int)Math.Round(Math.Min(Character.NumNotches - 1, Math.Max(0,
                Normal.Sample(GameConstants.RNG, character.Might.StartingNotch + 0.5, Character.StandardDeviation))));
            int sanityNotch = (int)Math.Round(Math.Min(Character.NumNotches - 1, Math.Max(0,
                Normal.Sample(GameConstants.RNG, character.Sanity.StartingNotch + 0.5, Character.StandardDeviation))));
            int knowledgeNotch = (int)Math.Round(Math.Min(Character.NumNotches - 1, Math.Max(0,
                Normal.Sample(GameConstants.RNG, character.Knowledge.StartingNotch + 0.5, Character.StandardDeviation))));

            Speed = character.Speed.Values[speedNotch];
            Might = character.Might.Values[mightNotch];
            Sanity = character.Sanity.Values[sanityNotch];
            Knowledge = character.Knowledge.Values[knowledgeNotch];
        }

        private static Character _nullCharacter = new Character
        {
            Name = "No Traitor",
            Age = 0,
            Color = ConsoleColor.Gray,
            Speed = new Characteristic
            {
                Values = new double[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                StartingNotch = 0,
            },
            Might = new Characteristic
            {
                Values = new double[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                StartingNotch = 0,
            },
            Sanity = new Characteristic
            {
                Values = new double[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                StartingNotch = 0,
            },
            Knowledge = new Characteristic
            {
                Values = new double[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                StartingNotch = 0,
            },
        };

        public static CharacterInstance NullCharacter = new CharacterInstance(_nullCharacter);
    }

    public class Haunt
    {
        public int ScenarioNumber { get; set; }
        public int NumberOfOccurences { get; set; }
        public string RuleDescription { get; set; }
        public Func<List<CharacterInstance>, Traitor> DetermineTraitor { get; set; }

        public static string HauntRevealerDescription = "Haunt revealer";
        public static string LeftHauntRevealerDescription = "Left of the haunt revealer";
        public static string LowestTraitDescription(string trait, bool includeHauntRevealer = true) => $"Lowest {trait}" +
            $"{(includeHauntRevealer ? "" : " except for haunt revealer")}";
        public static string HighestTraitDescription(string trait, bool includeHauntRevealer = true) => $"Highest {trait}" +
            $"{(includeHauntRevealer ? "" : " except for haunt revealer")}";
        public static string NameDescription(string name, string backupStr) => $"{name} or {backupStr}";

        public static Func<List<CharacterInstance>, Traitor> RandomTraitor(string desc)
        {
            return l => new Traitor
            {
                Character = l[GameConstants.RNG.Next(l.Count)],
                Reason = desc
            };
        }

        public static Func<List<CharacterInstance>, Traitor> TraitorOfName(string name,
            Func<List<CharacterInstance>, Traitor> backupFunction)
        {
            return l =>
            {
                if (l.Any(c => c.Name == name))
                {
                    return new Traitor
                    {
                        Character = l.Find(c => c.Name == name),
                        Reason = name
                    };

                }
                else
                {
                    return backupFunction(l);
                }
            };
        }

        public static Func<List<CharacterInstance>, Traitor> TraitorFromTraitExceptHauntRevealer(
            Func<CharacterInstance, List<CharacterInstance>, bool> match, string reason)
        {
            return l =>
            {
                var potentialTraitors = l.FindAll(c => match(c, l));
                if (GameConstants.RNG.Next(l.Count) == 0)
                {
                    if (potentialTraitors.Count == 1)
                    {
                        var newTraitorSet = l.FindAll(c => c.Name != potentialTraitors.Single().Name);
                        potentialTraitors = newTraitorSet.FindAll(c => match(c, newTraitorSet));
                    }
                    else
                    {
                        potentialTraitors.Remove(potentialTraitors.First());
                    }
                }

                return new Traitor
                {
                    Character = potentialTraitors.RandomElement(GameConstants.RNG),
                    Reason = reason
                };
            };
        }
    }

    public class Game
    {
        public List<Character> Characters { get; set; }
        public List<CharacterInstance> CharacterInstances { get; set; }
        public Haunt Haunt { get; set; }

        public Traitor Traitor { get; }

        public Game(string[] characters) : this(characters.Select(n => GameConstants.Characters.Find(c => c.Name == n)).ToList())
        {
        }

        public Game(List<Character> characters)
        {
            Characters = characters;
            if (Characters.Any(c => c == null))
            {
                throw new ArgumentException("One or more characters were invalid");
            }
            CharacterInstances = Characters.Select(c => new CharacterInstance(c)).ToList();
            Haunt = GameConstants.HauntTable[GameConstants.RNG.Next(GameConstants.HauntTable.Count)];
            Traitor = Haunt.DetermineTraitor(CharacterInstances);
        }
    }
}
