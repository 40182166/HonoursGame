using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class CharClass
    {
        private Stats _theseStats;

        public enum characterClass
        {
            WARRIOR,
            MAGE,
            ARCHER
        };

        public CharClass(characterClass thisClassIdentifier)
        {
            switch (thisClassIdentifier)
            {
                case characterClass.WARRIOR:
                    Statistics = new Stats(Stats.mainStat.STR_MAIN);
                    break;
                case characterClass.MAGE:
                    Statistics = new Stats(Stats.mainStat.INT_MAIN);
                    break;
                case characterClass.ARCHER:
                    Statistics = new Stats(Stats.mainStat.AGI_MAIN);
                    break;
                default:
                    break;
            }
        }

        public Stats Statistics
        {
            get { return _theseStats; }
            set
            {
                _theseStats = value;
            }
        }

    }
}
