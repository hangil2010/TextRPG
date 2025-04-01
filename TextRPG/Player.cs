namespace TextRPG
{
    public class Player
    {
        private SPECIAL special = new SPECIAL();
        private Skills skills = new Skills();

        public Player()
        {
            special.SetSpecial();
            skills.SetSkills(special);
            PrintStats();
        }
        
        private void PrintStats()
        {
            special.PrintSpecial();
            skills.PrintSkills();
        }
    }
}
