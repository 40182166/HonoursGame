using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /*abstract */class Stats
    {
        private int str = 0;
        private int agi = 0;
        private int intell = 0;
        private int vit = 0;

        public enum mainStat
        {
            STR_MAIN,
            INT_MAIN,
            AGI_MAIN
        };

        private float _phys_dmg;
        private float _base_phys_dmg;
        private float _magic_dmg;
        private float _base_magic_dmg;
        private float _phys_def;
        private float _base_phys_def;
        private float _magic_def;
        private float _base_magic_def;
        private float _crit_dmg;
        private float _base_crit_dmg;
        private float _crit_chance;
        private float _base_crit_chance;
        private float _dodge_chance;
        private float _base_dodge_chance;
        private float _stun_chance;
        private float _base_stun_chance;
        private float _stun_resist;
        private float _base_stun_resist;
        private float _hp;
        private float _base_hp;

        private mainStat thisMain;

        public Stats(mainStat _main)
        {
            thisMain = _main;
        }

        public int STR
        {
            get { return str; }
            set {
                str = value;
                if (thisMain == mainStat.STR_MAIN)
                {
                    Phys_dmg = str * 1.0f;
                }

                if (thisMain != mainStat.INT_MAIN)
                {
                    Crit_dmg = str * 10.0f;
                }
                Stun_chance = str * 4.0f;
            }
        }
        public int AGI
        {
            get { return agi; }
            set
            {
                agi = value;
                if (thisMain == mainStat.AGI_MAIN)
                {
                    Phys_dmg = agi * 1.0f;
                }

                Crit_chance = agi * 3.0f;
                Dodge_chance = agi * 2.5f;
            }
        }

        public int INT
        {
            get { return intell; }
            set
            {
                intell = value;
                if (thisMain == mainStat.INT_MAIN)
                {
                    Magic_dmg = intell * 1.0f;
                    Crit_dmg = intell * 10.0f;
                }
            }
        }

        public int VIT
        {
            get { return vit; }
            set
            {
                vit = value;
                HP = VIT * 10.0f;
                Phys_def = VIT * 0.30f;
                Stun_resist = VIT * 2.0f;
            }
        }

        public float Phys_dmg
        {
            get => _phys_dmg;
            set => _phys_dmg = value;
        }

        public float Base_phys_dmg
        {
            get => _base_phys_dmg;
            set => _base_phys_dmg = value;
        }

        public float Stun_chance
        {
            get => _stun_chance;
            set => _stun_chance = value;
        }

        public float Crit_dmg
        {
            get => _crit_dmg;
            set => _crit_dmg = value;
        }
        public float HP
        {
            get => _hp;
            set => _hp = value;
        }

        public float Phys_def
        {
            get => _phys_def;
            set => _phys_def = value;
        }

        public float Stun_resist
        {
            get => _stun_resist;
            set => _stun_resist = value;
        }

        public float Crit_chance
        {
            get => _crit_chance;
            set => _crit_chance = value;
        }

        public float Dodge_chance
        {
            get => _dodge_chance;
            set => _dodge_chance = value;
        }

        public float Magic_dmg
        {
            get => _magic_dmg;
            set => _magic_dmg = value;
        }

        public float Base_magic_dmg
        {
            get => _base_magic_dmg;
            set => _base_magic_dmg = value;
        }

        public float Magic_def
        {
            get => _magic_def;
            set => _magic_def = value;
        }

        public void performCritical()
        {
            switch (thisMain)
            {
                case mainStat.STR_MAIN:
                    Base_phys_dmg = Phys_dmg;
                    Phys_dmg = Phys_dmg + ((Phys_dmg * Crit_dmg) / 100.0f);
                    Console.WriteLine("STR is: " + STR + " Physical damage with crit is: " + Phys_dmg);
                    break;
                case mainStat.AGI_MAIN:
                    Base_phys_dmg = Phys_dmg;
                    Phys_dmg = Phys_dmg + ((Phys_dmg * Crit_dmg) / 100.0f);
                    Console.WriteLine("AGI is: " + AGI + " Physical damage with crit is: " + Phys_dmg);
                    break;
                case mainStat.INT_MAIN:
                    Base_magic_dmg = Magic_dmg;
                    Magic_dmg = Magic_dmg + ((Magic_dmg * Crit_dmg) / 100.0f);
                    Console.WriteLine("INT is: " + INT + " Magical damage with crit is: " + Magic_dmg);
                    break;
            }
        }

        public void endCritical()
        {
            switch (thisMain)
            {
                case mainStat.STR_MAIN:
                    Phys_dmg = Base_phys_dmg;
                    Console.WriteLine("STR is: " + STR + " Physical damage without is: " + Phys_dmg);
                    break;
                case mainStat.AGI_MAIN:
                    Phys_dmg = Base_phys_dmg;
                    Console.WriteLine("AGI is: " + AGI + " Physical damage without is: " + Phys_dmg);
                    break;
                case mainStat.INT_MAIN:
                    Magic_dmg = Base_magic_dmg;
                    Console.WriteLine("INT is: " + INT + " Magical damage without is: " + Magic_dmg);
                    break;
            }
        }


        public void getHit()
        {
            if (Phys_dmg != 0)
            {
                HP = HP - (Phys_dmg - Phys_def);
            }
        }

        public void setMainStat(mainStat newMain)
        {
            thisMain = newMain;
        }

    }
}
