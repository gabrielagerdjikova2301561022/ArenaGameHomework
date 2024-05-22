using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Assasin : Hero
    {
        //-Can do backstab attack, which causes 200% of his Strength as damage. Which is 10% chanse to happen.
        //-Have 10% chance to dodge incoming damage.
        public Assasin() : this("Dark Power")
        {

        }
        public Assasin(string name) : base(name)
        {

        }
        public override int Attack()
        {
            int dice = Random.Shared.Next(0, 100);
            if (dice <= 10)
            {
                return (200 * Strength) / 100;
            }
            else
            {
                return Strength;
            }
        }
        public override void TakeDamage(int incomingDamage)
        {
            int luck = Random.Shared.Next(0, 100);
            if (luck <= 10)
            {
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
