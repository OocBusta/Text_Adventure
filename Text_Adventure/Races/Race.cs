namespace Text_Adventure
{
    abstract class Race
    {
        public string raceName { get; set; }
        public int raceStrength { get; set; }
        public int raceDexterity { get; set; }
        public int raceAgility { get; set; }
        public int raceWisdom { get; set; }
        public int raceIntelligence{ get; set; }
        public int raceCharisma { get; set; }

        public void setRace(Character inChar)
        {
            inChar.charRace = raceName;
            inChar.raceStrMod = raceStrength;
            inChar.raceDexMod = raceDexterity;
            inChar.raceAgiMod = raceAgility;
            inChar.raceWisMod = raceWisdom;
            inChar.raceIntMod = raceIntelligence;
            inChar.raceChaMod = raceCharisma;
        }
    }
}