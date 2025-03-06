using System;
using HeroPerks;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string Perks = args[0].Trim().ToLower();

            Perks PlayerPerk = 0;

            int countWarp = 0;
            int countStealth = 0;
            int countHeal = 0;
            int countJump = 0;

            foreach (char c in Perks)
            {
                if (c != 'w' && c != 's' && c != 'a' && c != 'd')
                {
                    Console.WriteLine("! Unknown perk!");
                    return;
                }
                switch (c)
                {
                    case 'w': countWarp++; break;
                    case 'a': countHeal++; break;
                    case 's': countStealth++; break;
                    case 'd': countJump++; break;
                }
            }
            if (countWarp % 2 != 0) PlayerPerk |= HeroPerks.Perks.WarpShift;
            if (countStealth % 2 != 0) PlayerPerk |= HeroPerks.Perks.Stealth;
            if (countHeal % 2 != 0) PlayerPerk |= HeroPerks.Perks.AutoHeal;
            if (countJump % 2 != 0) PlayerPerk |= HeroPerks.Perks.DoubleJump;

            if (PlayerPerk != 0)
            {
                Console.WriteLine(PlayerPerk);

                if ((PlayerPerk & HeroPerks.Perks.Stealth) != 0 && (PlayerPerk & HeroPerks.Perks.DoubleJump) != 0)
                {
                    Console.WriteLine("!Silent Jumper!");
                }

                if ((PlayerPerk & HeroPerks.Perks.AutoHeal) == 0)
                {
                    Console.WriteLine("!Not gonna make it!");
                }
            }
            else
            {
                Console.WriteLine("!No perks at all!");
                Console.WriteLine("!Not gonna make it!");
            }







        }
    }
}
