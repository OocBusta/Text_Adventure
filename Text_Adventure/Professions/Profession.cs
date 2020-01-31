namespace Text_Adventure
{
    abstract class Profession
    {
        public string ProfessionName { get; set; }

        public void setProfession(Character inChar)
        {
            inChar.charProfession = ProfessionName;
        }
    }
}