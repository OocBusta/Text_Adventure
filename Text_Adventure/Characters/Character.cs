using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Adventure
{
    abstract class Character
    {
        public string charName { get; set; }
        public string charRace { get; set; }
        public string charProfession { get; set; }

        public int charStrength { get; set; }
        public int charDexterity { get; set; }
        public int charAgility { get; set; }
        public int charWisdom { get; set; }
        public int charIntelligence { get; set; }
        public int charCharisma { get; set; }

        public int raceStrMod { get; set; }
        public int raceDexMod { get; set; }
        public int raceAgiMod { get; set; }
        public int raceWisMod { get; set; }
        public int raceIntMod { get; set; }
        public int raceChaMod { get; set; }

        public bool isPlayer { get; set; }

        public Character()
        {
            charStrength = 10;
            charDexterity = 10;
            charAgility = 10;
            charWisdom = 10;
            charIntelligence = 10;
            charCharisma = 10;
        }
        public string DisplayText()
        {
            string display =
                "Name: " + this.charName + "\n" +
                "Race: " + this.charRace + "\n" +
                "Profession: " + this.charProfession + "\n\n" +
                "* * * * * * * * * * * *" + "\n\n" +
                "Strength:     " + this.charStrength + " | " + this.raceStrMod + " | " + (this.charStrength + this.raceStrMod) + "\n" +
                "Dexterity:    " + this.charDexterity + " | " + this.raceDexMod + " | " + (this.charDexterity + this.raceDexMod) + "\n" +
                "Agility:      " + this.charAgility + " | " + this.raceAgiMod + " | " + (this.charAgility + this.raceAgiMod) + "\n" +
                "Wisdom:       " + this.charWisdom + " | " + this.raceWisMod + " | " + (this.charWisdom + this.raceWisMod) + "\n" +
                "Intelligence: " + this.charIntelligence + " | " + this.raceIntMod + " | " + (this.charIntelligence + this.raceIntMod) + "\n" +
                "Charisma:     " + this.charCharisma + " | " + this.raceChaMod + " | " + (this.charCharisma + this.raceChaMod) + "\n";

            return display;
        }


    }
}
