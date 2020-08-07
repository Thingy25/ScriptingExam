using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingExam
{
    public  enum SupSkillType { atkUp, defUp, spdDown }

    class SupportSkill : Skill
    {
        public SupSkillType supportSkill;
        public float realAttack;
        public float realDefense;
        public float realSpeed;

        public SupportSkill(string name, SupSkillType suppSkill)
        {
            supportSkill = suppSkill;
            Power = 0;
        }

        public override void UseSkill(Critter ally, Critter enemy)
        {
            if(ally.attackCounter < 3)
            {
                if (supportSkill == SupSkillType.atkUp)
                {
                    realAttack = ((ally.BaseAttack * 20) / 100) + ally.BaseAttack;
                }
                ally.attackCounter++;
            }
            if(ally.defenseCounter < 3)
            {
                if (supportSkill == SupSkillType.defUp)
                {
                    realDefense = ((ally.BaseDefense * 20) / 100) - ally.BaseDefense;
                }
               ally.defenseCounter++;
            }
            if(enemy.speedCounter < 3)
            {
                if (supportSkill == SupSkillType.spdDown)
                {
                    realSpeed = enemy.BaseSpeed - ((enemy.BaseSpeed * 30) / 100);
                }
                enemy.speedCounter++;
            }
        }
    }
}
