using System;

namespace PlayerPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                return;

            Perks perks = 0;

            foreach (char c in args[0])
            {
                switch (c)
                {
                    case 'w':
                        perks ^= Perks.WaterBreathing;
                        break;
                    case 'a':
                        perks ^= Perks.AutoHeal;
                        break;
                    case 's':
                        perks ^= Perks.Stealth;
                        break;
                    case 'd':
                        perks ^= Perks.DoubleJump;
                        break;
                    default:
                        Console.WriteLine("Unknown perk!");
                        return;
                }
            }

            if (perks == 0)
            {
                Console.WriteLine("No perks at all!");
                return;
            }

            Console.WriteLine(perks);

            if ((perks & (Perks.Stealth | Perks.DoubleJump)) == (Perks.Stealth | Perks.DoubleJump))
                Console.WriteLine("Silent jumper!");

            if ((perks & Perks.AutoHeal) != Perks.AutoHeal)
                Console.WriteLine("Not gonna make it!");
        }
    }
}
