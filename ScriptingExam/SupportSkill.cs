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

        public SupportSkill(string name, Affinities affinity, SupSkillType suppSkill)
        {
            supportSkill = suppSkill;
            Power = 0;
        }

        public override void UseSkill()
        {
            if(critt.attackCounter < 3)
            {
                if (supportSkill == SupSkillType.atkUp)
                {
                    realAttack = ((critt.BaseAttack * 20) / 100) + critt.BaseAttack;
                }
                critt.attackCounter++;
            }
            if(critt.defenseCounter < 3)
            {
                if (supportSkill == SupSkillType.defUp)
                {
                    realDefense = ((critt.BaseDefense * 20) / 100) - critt.BaseDefense;
                }
                critt.defenseCounter++;
            }
            if(critt.speedCounter < 3)
            {
                if (supportSkill == SupSkillType.spdDown)
                {
                    realSpeed = critt.BaseSpeed - ((critt.BaseSpeed * 30) / 100);
                }
                critt.speedCounter++;
            }
        }
    }
}
