using System;
using System.Collections.Generic;
using System.Linq;

namespace Betrayal_House
{
    public class GameConstants
    {
        public static Random RNG = new Random();

        public static readonly List<Character> Characters = new List<Character>
        {
            new Character
            {
                Name = "Darrin \"Flash\" Williams",
                Age = 20,
                Color = ConsoleColor.Red,
                Speed = new Characteristic
                {
                    Values = new double[] { 4, 4, 4, 5, 6, 7, 7, 8 },
                    StartingNotch = 4,
                },
                Might = new Characteristic
                {
                    Values = new double[] { 2, 3, 3, 4, 5, 6, 6, 7 },
                    StartingNotch = 2,
                },
                Sanity = new Characteristic
                {
                    Values = new double[] { 1, 2, 3, 4, 5, 5, 5, 7 },
                    StartingNotch = 2,
                },
                Knowledge = new Characteristic
                {
                    Values = new double[] { 2, 3, 3, 4, 5, 5, 5, 7, },
                    StartingNotch = 2,
                },
            },
            new Character
            {
                Name = "Ox Bellows",
                Age = 23,
                Color = ConsoleColor.Red,
                Speed = new Characteristic
                {
                    Values = new double[] { 2, 2, 2, 3, 4, 5, 5, 6 },
                    StartingNotch = 4,
                },
                Might = new Characteristic
                {
                    Values = new double[] { 2, 3, 3, 4, 5, 6, 6, 7 },
                    StartingNotch = 2,
                },
                Sanity = new Characteristic
                {
                    Values = new double[] { 2, 2, 3, 4, 5, 5, 6, 7 },
                    StartingNotch = 2,
                },
                Knowledge = new Characteristic
                {
                    Values = new double[] { 2, 2, 3, 3, 5, 5, 6, 6 },
                    StartingNotch = 2,
                },
            },
            new Character
            {
                Name = "Brandon Jaspers",
                Age = 12,
                Color = ConsoleColor.Green,
                Speed = new Characteristic
                {
                    Values = new double[] { 3, 4, 4, 4, 5, 6, 7, 8 },
                    StartingNotch = 2,
                },
                Might = new Characteristic
                {
                    Values = new double[] { 2, 3, 3, 4, 5, 6, 6, 7 },
                    StartingNotch = 3,
                },
                Sanity = new Characteristic
                {
                    Values = new double[] { 3, 3, 3, 4, 5, 6, 7, 8 },
                    StartingNotch = 3,
                },
                Knowledge = new Characteristic
                {
                    Values = new double[] { 1, 3, 3, 5, 5, 6, 6, 7 },
                    StartingNotch = 2,
                },
            },
            new Character
            {
                Name = "Peter Akimoto",
                Age = 13,
                Color = ConsoleColor.Green,
                Speed = new Characteristic
                {
                    Values = new double[] { 3, 3, 3, 4, 6, 6, 7, 7, },
                    StartingNotch = 3,
                },
                Might = new Characteristic
                {
                    Values = new double[] { 2, 3, 3, 4, 5, 5, 6, 8 },
                    StartingNotch = 2,
                },
                Sanity = new Characteristic
                {
                    Values = new double[] { 3, 4, 4, 4, 5, 6, 6, 7 },
                    StartingNotch = 3,
                },
                Knowledge = new Characteristic
                {
                    Values = new double[] { 3, 4, 4, 5, 6, 7, 7, 8 },
                    StartingNotch = 2,
                },
            },
            new Character
            {
                Name = "Zoe Ingstrom",
                Age = 8,
                Color = ConsoleColor.Yellow,
                Speed = new Characteristic
                {
                    Values = new double[] { 4, 4, 4, 4, 5, 6, 8, 8 },
                    StartingNotch = 3,
                },
                Might = new Characteristic
                {
                    Values = new double[] { 2, 2, 3, 3, 4, 4, 6, 7 },
                    StartingNotch = 3,
                },
                Sanity = new Characteristic
                {
                    Values = new double[] { 3, 4, 5, 5, 6, 6, 7, 8 },
                    StartingNotch = 3,
                },
                Knowledge = new Characteristic
                {
                    Values = new double[] { 1, 2, 3, 4, 4, 5, 5, 5 },
                    StartingNotch = 2,
                },
            },
            new Character
            {
                Name = "Missy Dubourde",
                Age = 9,
                Color = ConsoleColor.Yellow,
                Speed = new Characteristic
                {
                    Values = new double[] { 3, 4, 5, 6, 6, 6, 7, 7 },
                    StartingNotch = 2,
                },
                Might = new Characteristic
                {
                    Values = new double[] { 2, 3, 3, 3, 4, 5, 6, 7 },
                    StartingNotch = 3,
                },
                Sanity = new Characteristic
                {
                    Values = new double[] { 1, 2, 3, 4, 5, 5, 6, 7 },
                    StartingNotch = 2,
                },
                Knowledge = new Characteristic
                {
                    Values = new double[] { 2, 3, 4, 4, 5, 6, 6, 6 },
                    StartingNotch = 3,
                },
            },
            new Character
            {
                Name = "Jenny LeClerc",
                Age = 21,
                Color = ConsoleColor.DarkMagenta,
                Speed = new Characteristic
                {
                    Values = new double[] { 2, 3, 4, 4, 4, 5, 6, 8 },
                    StartingNotch = 3,
                },
                Might = new Characteristic
                {
                    Values = new double[] { 3, 4, 4, 4, 4, 5, 6, 8 },
                    StartingNotch = 2,
                },
                Sanity = new Characteristic
                {
                    Values = new double[] { 1, 1, 2, 4, 4, 4, 5, 6 },
                    StartingNotch = 4,
                },
                Knowledge = new Characteristic
                {
                    Values = new double[] { 2, 3, 3, 4, 4, 5, 6, 8 },
                    StartingNotch = 2,
                },
            },
            new Character
            {
                Name = "Heather Granville",
                Age = 18,
                Color = ConsoleColor.DarkMagenta,
                Speed = new Characteristic
                {
                    Values = new double[] { 3, 3, 4, 5, 6, 6, 7, 8 },
                    StartingNotch = 2,
                },
                Might = new Characteristic
                {
                    Values = new double[] { 3, 3, 3, 4, 5, 6, 7, 8 },
                    StartingNotch = 2,
                },
                Sanity = new Characteristic
                {
                    Values = new double[] { 3, 3, 3, 4, 5, 6, 6, 6 },
                    StartingNotch = 2,
                },
                Knowledge = new Characteristic
                {
                    Values = new double[] { 2, 3, 3, 4, 5, 6, 7, 8 },
                    StartingNotch = 4,
                },
            },
            new Character
            {
                Name = "Madame Zostra",
                Age = 37,
                Color = ConsoleColor.Blue,
                Speed = new Characteristic
                {
                    Values = new double[] { 2, 3, 3, 5, 5, 6, 6, 7 },
                    StartingNotch = 2,
                },
                Might = new Characteristic
                {
                    Values = new double[] { 2, 3, 3, 4, 5, 5, 5, 6 },
                    StartingNotch = 3,
                },
                Sanity = new Characteristic
                {
                    Values = new double[] { 4, 4, 4, 5, 6, 7, 8, 8 },
                    StartingNotch = 2,
                },
                Knowledge = new Characteristic
                {
                    Values = new double[] { 1, 3, 4, 4, 4, 5, 6, 6 },
                    StartingNotch = 3,
                },
            },
            new Character
            {
                Name = "Vivian Lopez",
                Age = 42,
                Color = ConsoleColor.Blue,
                Speed = new Characteristic
                {
                    Values = new double[] { 3, 4, 4, 4, 4, 6, 7, 8 },
                    StartingNotch = 3,
                },
                Might = new Characteristic
                {
                    Values = new double[] { 2, 2, 2, 4, 4, 5, 6, 6 },
                    StartingNotch = 2,
                },
                Sanity = new Characteristic
                {
                    Values = new double[] { 4, 4, 4, 5, 6, 7, 8, 8 },
                    StartingNotch = 2,
                },
                Knowledge = new Characteristic
                {
                    Values = new double[] { 4, 5, 5, 5, 5, 6, 6, 7 },
                    StartingNotch = 3,
                },
            },
            new Character
            {
                Name = "Father Reinhardt",
                Age = 62,
                Color = ConsoleColor.White,
                Speed = new Characteristic
                {
                    Values = new double[] { 2, 3, 3, 4, 5, 6, 7, 7 },
                    StartingNotch = 2,
                },
                Might = new Characteristic
                {
                    Values = new double[] { 1, 2, 2, 4, 4, 5, 5, 7 },
                    StartingNotch = 2,
                },
                Sanity = new Characteristic
                {
                    Values = new double[] { 3, 4, 5, 5, 6, 7, 7, 8 },
                    StartingNotch = 4,
                },
                Knowledge = new Characteristic
                {
                    Values = new double[] { 1, 3, 3, 4, 5, 6, 6, 8 },
                    StartingNotch = 3,
                },
            },
            new Character
            {
                Name = "Professor Longfellow",
                Age = 57,
                Color = ConsoleColor.White,
                Speed = new Characteristic
                {
                    Values = new double[] { 2, 2, 4, 4, 5, 5, 6, 6 },
                    StartingNotch = 3,
                },
                Might = new Characteristic
                {
                    Values = new double[] { 1, 2, 3, 4, 5, 5, 6, 6 },
                    StartingNotch = 2,
                },
                Sanity = new Characteristic
                {
                    Values = new double[] { 1, 3, 3, 4, 5, 5, 6, 7 },
                    StartingNotch = 2,
                },
                Knowledge = new Characteristic
                {
                    Values = new double[] { 4, 5, 5, 5, 5, 6, 7, 8 },
                    StartingNotch = 4,
                },
            },
        };

        public static readonly List<Haunt> Haunts = new List<Haunt>
        {
            new Haunt
            {
                ScenarioNumber = 1,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.HauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.HauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 2,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.HauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.HauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 3,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.LowestTraitDescription("Knowledge", false),
                DetermineTraitor = Haunt.TraitorFromTraitExceptHauntRevealer(
                    (c, l) => c.Knowledge == l.Min(ch => ch.Knowledge),
                    Haunt.LowestTraitDescription("Knowledge"))
            },
            new Haunt
            {
                ScenarioNumber = 4,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.HighestTraitDescription("Might", false),
                DetermineTraitor = Haunt.TraitorFromTraitExceptHauntRevealer(
                    (c, l) => c.Might == l.Max(ch => ch.Might),
                    Haunt.HighestTraitDescription("Might"))
            },
            new Haunt
            {
                ScenarioNumber = 5,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.HauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.HauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 6,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.LowestTraitDescription("Sanity"),
                DetermineTraitor = l => new Traitor
                {
                    Character = l.FindAll(c => c.Sanity == l.Min(ch => ch.Sanity)).RandomElement(RNG),
                    Reason = Haunt.LowestTraitDescription("Sanity")
                }
            },
            new Haunt
            {
                ScenarioNumber = 7,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.NameDescription("Father Reinhardt", Haunt.HighestTraitDescription("Sanity")),
                DetermineTraitor = Haunt.TraitorOfName("Father Reinhardt",
                    l => new Traitor
                    {
                        Character = l.FindAll(c => c.Sanity == l.Max(ch => ch.Sanity)).RandomElement(RNG),
                        Reason = Haunt.HighestTraitDescription("Sanity")
                    }
                )
            },
            new Haunt
            {
                ScenarioNumber = 8,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.HauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.HauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 9,
                NumberOfOccurences = 3,
                RuleDescription = "None (at first)",
                DetermineTraitor = l => new Traitor
                {
                    Character = CharacterInstance.NullCharacter,
                    Reason = "None"
                }
            },
            new Haunt
            {
                ScenarioNumber = 10,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.HauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.HauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 11,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.HauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.HauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 12,
                NumberOfOccurences = 3,
                RuleDescription = "None",
                DetermineTraitor = l => new Traitor
                {
                    Character = CharacterInstance.NullCharacter,
                    Reason = "None"
                }
            },
            new Haunt
            {
                ScenarioNumber = 13,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.LowestTraitDescription("Sanity", false),
                DetermineTraitor = Haunt.TraitorFromTraitExceptHauntRevealer(
                    (c, l) => c.Sanity == l.Min(ch => ch.Sanity),
                    Haunt.LowestTraitDescription("Sanity"))
            },
            new Haunt
            {
                ScenarioNumber = 14,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.HauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.HauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 15,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.LowestTraitDescription("Sanity", false),
                DetermineTraitor = Haunt.TraitorFromTraitExceptHauntRevealer(
                    (c, l) => c.Speed == l.Min(ch => ch.Speed),
                    Haunt.LowestTraitDescription("Sanity"))
            },
            new Haunt
            {
                ScenarioNumber = 16,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.LeftHauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.LeftHauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 17,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.LeftHauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.LeftHauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 18,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.HauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.HauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 19,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.LeftHauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.LeftHauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 20,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.NameDescription("Vivian Lopez", Haunt.LeftHauntRevealerDescription),
                DetermineTraitor = Haunt.TraitorOfName("Vivian Lopez", Haunt.RandomTraitor(Haunt.LeftHauntRevealerDescription))
            },
            new Haunt
            {
                ScenarioNumber = 21,
                NumberOfOccurences = 3,
                RuleDescription = "Oldest explorer (except for haunt revealer)",
                DetermineTraitor = Haunt.TraitorFromTraitExceptHauntRevealer(
                    (c, l) => c.Age == l.Max(ch => ch.Age),
                    "Oldest explorer")
            },
            new Haunt
            {
                ScenarioNumber = 22,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.LeftHauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.LeftHauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 23,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.LeftHauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.LeftHauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 24,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.NameDescription("Brandon Jaspers", Haunt.LowestTraitDescription("Speed")),
                DetermineTraitor = Haunt.TraitorOfName("Brandon Jaspers",
                    l => new Traitor
                    {
                        Character = l.FindAll(c => c.Speed == l.Min(ch => ch.Speed)).RandomElement(),
                        Reason = Haunt.LowestTraitDescription("Speed")
                    }
                )
            },
            new Haunt
            {
                ScenarioNumber = 25,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.NameDescription("Zoe Ingstrom", Haunt.HighestTraitDescription("Knowledge")),
                DetermineTraitor = Haunt.TraitorOfName("Zoe Ingstrom",
                    l => new Traitor
                    {
                        Character = l.FindAll(c => c.Knowledge == l.Max(ch => ch.Knowledge)).RandomElement(),
                        Reason = Haunt.HighestTraitDescription("Knowledge")
                    }
                )
            },
            new Haunt
            {
                ScenarioNumber = 26,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.LeftHauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.LeftHauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 27,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.HighestTraitDescription("Knowledge", false),
                DetermineTraitor = Haunt.TraitorFromTraitExceptHauntRevealer(
                    (c, l) => c.Knowledge == l.Max(ch => ch.Knowledge),
                    Haunt.HighestTraitDescription("Knowledge"))
            },
            new Haunt
            {
                ScenarioNumber = 28,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.HighestTraitDescription("Knowledge", false),
                DetermineTraitor = Haunt.TraitorFromTraitExceptHauntRevealer(
                    (c, l) => c.Knowledge == l.Max(ch => ch.Knowledge),
                    Haunt.HighestTraitDescription("Knowledge"))
            },
            new Haunt
            {
                ScenarioNumber = 29,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.HauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.HauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 30,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.HauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.HauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 31,
                NumberOfOccurences = 3,
                RuleDescription = "None",
                DetermineTraitor = l => new Traitor
                {
                    Character = CharacterInstance.NullCharacter,
                    Reason = "None"
                }
            },
            new Haunt
            {
                ScenarioNumber = 32,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.HighestTraitDescription("Sanity"),
                DetermineTraitor = l => new Traitor
                {
                    Character = l.FindAll(c => c.Sanity == l.Max(ch => ch.Sanity)).RandomElement(),
                    Reason = Haunt.HighestTraitDescription("Sanity")
                }
            },
            new Haunt
            {
                ScenarioNumber = 33,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.HauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.HauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 34,
                NumberOfOccurences = 3,
                RuleDescription = "Hidden traitor",
                DetermineTraitor = Haunt.RandomTraitor("Hidden traitor"),
            },
            new Haunt
            {
                ScenarioNumber = 35,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.HighestTraitDescription("Knowledge"),
                DetermineTraitor = l => new Traitor
                {
                    Character = l.FindAll(c => c.Knowledge == l.Max(ch => ch.Knowledge)).RandomElement(),
                    Reason = Haunt.HighestTraitDescription("Knowledge")
                }
            },
            new Haunt
            {
                ScenarioNumber = 36,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.NameDescription("Missy Dubourde", Haunt.HighestTraitDescription("Speed")),
                DetermineTraitor = Haunt.TraitorOfName("Missy Dubourde",
                    l => new Traitor
                    {
                        Character = l.FindAll(c => c.Speed == l.Max(ch => ch.Speed)).RandomElement(),
                        Reason = Haunt.HighestTraitDescription("Speed")
                    }
                )
            },
            new Haunt
            {
                ScenarioNumber = 37,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.LowestTraitDescription("Might"),
                DetermineTraitor = l => new Traitor
                {
                    Character = l.FindAll(c => c.Might == l.Min(ch => ch.Might)).RandomElement(),
                    Reason = Haunt.LowestTraitDescription("Might")
                }
            },
            new Haunt
            {
                ScenarioNumber = 38,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.LowestTraitDescription("Knowledge"),
                DetermineTraitor = l => new Traitor
                {
                    Character = l.FindAll(c => c.Knowledge == l.Min(ch => ch.Knowledge)).RandomElement(),
                    Reason = Haunt.LowestTraitDescription("Knowledge")
                }
            },
            new Haunt
            {
                ScenarioNumber = 39,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.HighestTraitDescription("Speed", false),
                DetermineTraitor = Haunt.TraitorFromTraitExceptHauntRevealer(
                    (c, l) => c.Speed == l.Max(ch => ch.Speed),
                    Haunt.HighestTraitDescription("Speed"))
            },
            new Haunt
            {
                ScenarioNumber = 40,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.LeftHauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.LeftHauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 41,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.HauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.HauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 42,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.HighestTraitDescription("Might"),
                DetermineTraitor = l => new Traitor
                {
                    Character = l.FindAll(c => c.Might == l.Max(ch => ch.Might)).RandomElement(),
                    Reason = Haunt.HighestTraitDescription("Might")
                }
            },
            new Haunt
            {
                ScenarioNumber = 43,
                NumberOfOccurences = 4,
                RuleDescription = "Hidden traitor",
                DetermineTraitor = Haunt.RandomTraitor("Hidden traitor"),
            },
            new Haunt
            {
                ScenarioNumber = 44,
                NumberOfOccurences = 3,
                RuleDescription = "Youngest explorer",
                DetermineTraitor = l => new Traitor
                {
                    Character = l.FindAll(c => c.Age == l.Min(ch => ch.Age)).RandomElement(),
                    Reason = "Youngest explorer"
                }
            },
            new Haunt
            {
                ScenarioNumber = 45,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.HighestTraitDescription("Knowledge"),
                DetermineTraitor = l => new Traitor
                {
                    Character = l.FindAll(c => c.Knowledge == l.Max(ch => ch.Knowledge)).RandomElement(),
                    Reason = Haunt.HighestTraitDescription("Knowledge")
                }
            },
            new Haunt
            {
                ScenarioNumber = 46,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.NameDescription("Madame Zostra", Haunt.LowestTraitDescription("Speed")),
                DetermineTraitor = Haunt.TraitorOfName("Madame Zostra",
                    l => new Traitor {
                        Character = l.FindAll(c => c.Speed == l.Min(ch => ch.Speed)).RandomElement(),
                        Reason = Haunt.LowestTraitDescription("Speed")
                    }
                )
            },
            new Haunt
            {
                ScenarioNumber = 47,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.HauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.HauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 48,
                NumberOfOccurences = 4,
                RuleDescription = Haunt.LeftHauntRevealerDescription,
                DetermineTraitor = Haunt.RandomTraitor(Haunt.LeftHauntRevealerDescription),
            },
            new Haunt
            {
                ScenarioNumber = 49,
                NumberOfOccurences = 3,
                RuleDescription = Haunt.NameDescription("Heather Granville", Haunt.HighestTraitDescription("Knowledge")),
                DetermineTraitor = Haunt.TraitorOfName("Heather Granville",
                    l => new Traitor
                    {
                        Character = l.FindAll(c => c.Knowledge == l.Max(ch => ch.Knowledge)).RandomElement(RNG),
                        Reason = Haunt.HighestTraitDescription("Knowledge")
                    }
                )
            },
            new Haunt
            {
                ScenarioNumber = 50,
                NumberOfOccurences = 3,
                RuleDescription = "None",
                DetermineTraitor = l => new Traitor
                {
                    Character = CharacterInstance.NullCharacter,
                    Reason = "None"
                }
            },
        };

        public static List<Haunt> HauntTable
        {
            get
            {
                var hauntTable = new List<Haunt>();
                foreach (var haunt in Haunts)
                {
                    for (int i = 0; i < haunt.NumberOfOccurences; i++)
                    {
                        hauntTable.Add(haunt);
                    }
                }
                return hauntTable;
            }
        }
    }
}
