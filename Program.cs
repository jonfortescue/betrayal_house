using System.Reflection.PortableExecutable;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System;

namespace Betrayal_House
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();
            characters.Add(new Character("Ox Bellows",
                new double[Character.StatNotches] { 2, 2, 2, 3, 4, 5, 5, 6 },
                new double[Character.StatNotches] { 2, 2, 2, 3, 4, 5, 5, 6 },
                new double[Character.StatNotches] { 2, 2, 2, 3, 4, 5, 5, 6 },
                new double[Character.StatNotches] { 2, 2, 2, 3, 4, 5, 5, 6 }));
        }
    }

    public class Character
    {
        public const int StatNotches = 8;

        public string Name { get; set; }
        public double[] Speed { get; set; }
        public int SpeedStartNotch { get; set; }
        public double[] Might { get; set; }
        public double[] Sanity { get; set; }
        public double[] Knowledge { get; set; }

        public Character(string name, double[] speed, double[] might, double[] sanity, double[] knowledge)
        {
            if (speed.Length != StatNotches || might.Length != StatNotches || sanity.Length != StatNotches || knowledge.Length != StatNotches)
            {
                throw new InvalidDataException();
            }

            Name = name;
            Speed = speed;
            Might = might;
            Sanity = sanity;
            Knowledge = knowledge;
        }


    }
}
