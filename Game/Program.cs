using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Stats stat = new Stats(Stats.mainStat.INT_MAIN);
            stat.STR = 1;
            stat.VIT = 10;
            stat.AGI = 5;
            stat.INT = 3;
            Console.WriteLine("STR is: " + stat.STR + ", Physical damage is: " + stat.Phys_dmg + ", Critical damage is: " + stat.Crit_dmg + "%");

            stat.performCritical();

            //Console.WriteLine("STR is: " + stat.STR + ", Physical damage is: " + stat.Phys_dmg + ", Critical damage is: " + stat.Crit_dmg + "%");
            stat.endCritical();
            //Console.WriteLine("STR is: " + stat.STR + ", Physical damage is: " + stat.Phys_dmg + ", Critical damage is: " + stat.Crit_dmg + "%\n");

            Console.WriteLine("\nVIT is: " + stat.VIT + ", HP before attack is: " + stat.HP + ", Physical defence is: " + stat.Phys_def + "\n");
            stat.getHit();
            Console.WriteLine("VIT is: " + stat.VIT + ", HP after attack is: " + stat.HP + ", Physical defence is: " + stat.Phys_def + "\n");


            Console.ReadLine();
        }
    }
}
