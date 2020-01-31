using System;

namespace Text_Adventure
{
    class Program
    {
        static void Main(string[] args)

        {
            Races.Elf race1 = new Races.Elf();
            Races.Orc race2 = new Races.Orc();
            Races.Human race3 = new Races.Human();
            Characters.Player test = new Characters.Player();
            string a = test.DisplayText();
            Console.WriteLine(a);
            Console.ReadLine();
            Console.Clear();

            race1.setRace(test);
            a = test.DisplayText();
            Console.WriteLine(a);
            Console.ReadLine();
            Console.Clear();

            race2.setRace(test);
            a = test.DisplayText();
            Console.WriteLine(a);
            Console.ReadLine();
            Console.Clear();

            race3.setRace(test);
            a = test.DisplayText();
            Console.WriteLine(a);
            Console.ReadLine();
            Console.Clear();

        }
    }
}
