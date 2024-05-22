using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Mage : Hero
    {
        //-Can do fireball attack, which causes 150% of his Strength as damage. Which is 25% chanse to happen.
        //- taking 10% more damage from all sources.
        public Mage() : this("Gandalf")
        {

        }
        public Mage(string name) : base(name)
        {

        }
        public override int Attack()
        {
            int coef = Random.Shared.Next(80, 121);
            int dice = Random.Shared.Next(0, 100);
            if (dice <= 25)
            {
                return (150 * Strength) / 100;
            }
            else
            {
                return Strength;
            }
        }
        public override void TakeDamage(int incomingDamage)
        {
            incomingDamage = incomingDamage + (10 * incomingDamage) / 100;
            base.TakeDamage(incomingDamage);
        }
    }
}
