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
        public SupSkillType SuppSkill { get; protected set; }      

        public SupportSkill(string name, SupSkillType suppSkill) : base(name, suppSkill)
        {
            Name = name; 
            SuppSkill = suppSkill;
            Power = 0;
        }

        public override void UseSkill(Critter ally, Critter enemy)
        {
            if(ally.attackCounter < 3)
            {
                if (SuppSkill == SupSkillType.atkUp)
                {
                    ally.realAttack = ((ally.BaseAttack * 20) / 100) + ally.BaseAttack;
                    Console.WriteLine(ally.Name + " has increased its attack value."); //Ver como poner el nombre xd
                    Console.WriteLine(ally.Name + "'s current HP is " + ally.HP);
                }
                ally.attackCounter++;
            }
            if(ally.defenseCounter < 3)
            {
                if (SuppSkill == SupSkillType.defUp)
                {
                    ally.realDefense = ((ally.BaseDefense * 20) / 100) + ally.BaseDefense;
                    Console.WriteLine(ally.Name + " has increased its defense value.");
                    Console.WriteLine(ally.Name + "'s current HP is " + ally.HP);

                }
                ally.defenseCounter++;
            }
            if(enemy.speedCounter < 3)
            {
                if (SuppSkill == SupSkillType.spdDown)
                {
                    enemy.realSpeed = enemy.BaseSpeed - ((enemy.BaseSpeed * 30) / 100);
                    Console.WriteLine(enemy.Name + "'s speed has been decreased. D:D");
                    Console.WriteLine(enemy.Name + "'s current HP is " + enemy.HP);
                } 
                enemy.speedCounter++;
            }
        }
    }
}
