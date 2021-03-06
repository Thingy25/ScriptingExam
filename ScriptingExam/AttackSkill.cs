﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingExam
{
    class AttackSkill : Skill
    {
        public AttackSkill(string name, Affinities affinity, float power) : base(name, affinity, power)
        {
           
            if (power >= 1 && power <= 10) Power = power;
            else Power = 1;
        }

        public override void UseSkill(Critter ally, Critter enemy)
        {
            float affMultiplier, dmgValue;
            affMultiplier = Utilities.Compare(Affinity, enemy.Affin);
            dmgValue = (ally.BaseAttack + Power) * affMultiplier;

            Console.WriteLine(ally.Name + " has attacked: " + enemy.Name + "!");
            enemy.ReceiveDamage(dmgValue);
            if (enemy.HP > 0)
            {
                Console.WriteLine(enemy.Name + "'s health is: " + enemy.HP);
            }
        }
 
    }
}
