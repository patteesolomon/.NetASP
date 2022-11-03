using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameName {
    class ItemConfig {

        private int taintPoint;

        struct MysticPwr {
        string name = "";
        int manap = 0;
        int hpp = 0;

        };

        private HashSet<MysticPwr> MysticPwrs = new HashSet<MysticPwr> { };
        public HashSet<MysticPwr> MysPListUp { get => MysticPwrs; set => MysticPwrs = value; }
        

        struct Item {
            string name;

            // weapon mana stats
            int wisp;
            int shade;
            int dryad;
            int aura;
            int salamander;
            int gnome;
            int jinn;
            int undine;
        };

        public HashSet<Item> Items = new HashSet<object> { };
        public HashSet<Item> ItemListUp { get => Items; set => Items = value; }

        struct Weapon {
            // weapon base stats
            string name;
            int HPRgrade; // Hp plus and poison resistance
            int Powgrade; // Power : Raw strength level 
            int Chagrade; // Charm: Successfullness of status magic
            int Spigrade; // spirit : defence against status magic and other alignment boosts.
            int Skigrade; // Skill: Technical attack level
            int Luckgrade; // Luck: frequency of finding treasure and other things
            int Offgrade; // Overall offencive power --> base attack power
            int Deffgrade; // Defence: defence level against physical attacks
            int Mdefgrade; // Magic Def: defence against magic

            // weapon mana stats
            int wisp; // light
            int shade; // darkness
            int dryad; // life 
            int aura; // resonance 
            int salamander; // fire
            int gnome; // earth
            int jinn; // air
            int undine; // water

            [Range(0, 3)]
            MysticPwr[] manstuc;


        };

        public HashSet<Weapon> Weapons = new HashSet<object> {  };
        public HashSet<Weapon> WepListUp { get => Weapons; set => Weapons = value; }

        struct Armor
        {
            string ArmorType;
            //  base stats
            string name;
            int HPRgrade; // Hp plus and poison resistance
            int Powgrade; // Power : Raw strength level 
            int Chagrade; // Charm: Successfullness of status magic
            int Spigrade; // spirit : defence against status magic and other alignment boosts.
            int Skigrade; // Skill: Technical attack level
            int Luckgrade; // Luck: frequency of finding treasure and other things
            int Deffgrade; // Defence: defence level against physical attacks
            int Mdefgrade; // Magic Def: defence against magic

            // stopping pwer
            int DefStrike;
            int DefSlash;
            int DefThrust;
            int DefMagic;

            //  mana stats
            int wisp;
            int shade;
            int dryad;
            int aura;
            int salamander;
            int gnome;
            int jinn;
            int undine;

            [Range(0, 3)]
            MysticPwr[] manstuc;

        };

        public HashSet<Armor> Armors = new HashSet<object> {};
        public HashSet<Armor> ArmListUp { get => Armors; set => Armors = value; }

    }
}