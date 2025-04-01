using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Skills
    {
        private SPECIAL special;
        // 0 Barter, EnegryWeapons, Expolosives, Guns, Lockpick, Medicine,
        // 6 MeleeWeapons, Repair, Science, Sneak, Speech, Survial,Unarmed
        private int[] stats = new int[13];

        /* private int barter;
        public int Barter { get; set; }

        private int enegryWeapons;
        public int EnegryWeapons { get; set; }

        private int expolosives;
        public int Expolosives { get; set; }

        private int guns;
        public int Guns { get; set; }

        private int lockpick;
        public int Lockpick { get; set; }

        private int medicine;
        public int Medicine { get; set; }

        private int meleeWeapons;
        public int MeleeWeapons { get; set; }

        private int repair;
        public int Repair { get; set; }

        private int science;
        public int Science { get; set; }

        private int sneak;
        public int Sneak { get; set; }

        private int speech;
        public int Speech { get; set; }

        private int survival;
        public int Survival { get; set; }

        private int unarmed;
        public int Unarmed { get; set; }
        */

        public void SetSkills(SPECIAL special)
        {
            stats[0] = 2 + special.stats[3] * 2 + (int)(Math.Ceiling(((double)special.stats[6] / 2)));
            stats[1] = 2 + special.stats[1] * 2 + (int)(Math.Ceiling(((double)special.stats[6] / 2)));
            stats[2] = 2 + special.stats[1] * 2 + (int)(Math.Ceiling(((double)special.stats[6] / 2)));
            stats[3] = 2 + special.stats[5] * 2 + (int)(Math.Ceiling(((double)special.stats[6] / 2)));
            stats[4] = 2 + special.stats[1] * 2 + (int)(Math.Ceiling(((double)special.stats[6] / 2)));
            stats[5] = 2 + special.stats[4] * 2 + (int)(Math.Ceiling(((double)special.stats[6] / 2)));
            stats[6] = 2 + special.stats[0] * 2 + (int)(Math.Ceiling(((double)special.stats[6] / 2)));
            stats[7] = 2 + special.stats[4] * 2 + (int)(Math.Ceiling(((double)special.stats[6] / 2)));
            stats[8] = 2 + special.stats[4] * 2 + (int)(Math.Ceiling(((double)special.stats[6] / 2)));
            stats[9] = 2 + special.stats[5] * 2 + (int)(Math.Ceiling(((double)special.stats[6] / 2)));
            stats[10] = 2 + special.stats[3] * 2 + (int)(Math.Ceiling(((double)special.stats[6] / 2)));
            stats[11] = 2 + special.stats[2] * 2 + (int)(Math.Ceiling(((double)special.stats[6] / 2)));
            stats[12] = 2 + special.stats[2] * 2 + (int)(Math.Ceiling(((double)special.stats[6] / 2)));
        }

        public void PrintSkills()
        {
            Console.WriteLine("현재 기술 상태");
            Console.WriteLine($"Barter         : {stats[0]}");
            Console.WriteLine($"Enegry Weapons : {stats[1]}");
            Console.WriteLine($"Expolosives    : {stats[2]}");
            Console.WriteLine($"Guns           : {stats[3]}");
            Console.WriteLine($"Lockpick       : {stats[4]}");
            Console.WriteLine($"Medicine       : {stats[5]}");
            Console.WriteLine($"Melee Weapons  : {stats[6]}");
            Console.WriteLine($"Repair         : {stats[7]}");
            Console.WriteLine($"Science        : {stats[8]}");
            Console.WriteLine($"Sneak          : {stats[9]}");
            Console.WriteLine($"Speech         : {stats[10]}");
            Console.WriteLine($"Survival       : {stats[11]}");
            Console.WriteLine($"Unarmed        : {stats[12]}");
        }
    }
}
