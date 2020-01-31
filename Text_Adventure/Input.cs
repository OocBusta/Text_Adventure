using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Adventure
{
    class Input
    {
        string userInput = "";


        private void AskNewChar()
        {
            bool answer = false;
            while(answer == false){
                Console.WriteLine("Would you like to create a new character?" + "\n" + "(Y)es or (N)o");
                userInput = Console.ReadLine();
                userInput = userInput.ToUpper();
                if(userInput == "Y" | userInput == "YES")
                {
                    answer = true;
                } else if (userInput == "N" | userInput == "NO")
                {
                    Console.WriteLine("Well, then. Get the fuck out of here.");
                    Console.ReadLine();
                    Environment.Exit(0);
                } else
                {
                    Console.WriteLine("Please input either (Y)es or (N)o." + "\n" + "Please hit enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        private Character CreateCharacter()
        {
            bool isGood = false;

            Character newChar = new Characters.NPC();

            Console.Clear();
            Console.WriteLine("Will this character be a NPC or a Player?");
            userInput = Console.ReadLine();
            userInput = userInput.ToUpper();

            do
            {
                if (userInput == "NPC")
                {
                    newChar = new Characters.NPC();
                    isGood = true;
                }
                else if (userInput == "PLAYER")
                {
                    newChar = new Characters.Player();
                    isGood = true;
                }
                else
                {
                    Console.WriteLine("Please type in either NPC or Player" + "\n" + "Please hit enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    isGood = false;
                }
            } while (isGood == false);
            
            return newChar;
            
        }
        
        private Race[] InstantiateRaces()
        {
            Races.Elf raceElf = new Races.Elf();
            Races.Orc raceOrc = new Races.Orc();
            Races.Human raceHuman = new Races.Human;

            Race[] races = new Race[] { raceElf, raceOrc, raceHuman };
            return races;
        }

        private Profession[] InstantiaeProfessions()
        {
            Professions.Thief profThief = new Professions.Thief();
            Professions.Warrior profWarrior = new Professions.Warrior();

            Profession[] professions = new Profession[] { profThief, profWarrior };
            return professions;
        }
    }
}
