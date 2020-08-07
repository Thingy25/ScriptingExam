using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingExam
{
    class AttackSkill : Skill
    {
        public AttackSkill(string name, Affinities affinity, float power)
        {
            if (power >= 1 && power <= 10) Power = power;
            else Power = 1;
        }

        public override void UseSkill(Critter ally, Critter enemy)
        {
            //Utilities.Compare(playerCrit.affin, enemyCrit.affin);
        }

        
    }
}
