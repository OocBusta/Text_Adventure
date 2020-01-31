using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Adventure.Races
{
    class Elf : Race
    {
        public Elf()
        {
            raceName = "Elf";
            raceStrength = -2;
            raceDexterity = -2;
            raceAgility = 1;
            raceWisdom = 1;
            raceIntelligence = 1;
            raceCharisma = 1;
        }
    }
}
